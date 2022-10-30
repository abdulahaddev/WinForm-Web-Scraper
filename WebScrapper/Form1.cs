using Dasync.Collections;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebScrapper
{
    public partial class Form1 : Form
    {
        int currentPage = 1;
        public int parseCount { get; set; }
        public int TotalData { get; set; }
        public int TotalPage { get; set; }

        List<Applicant> ApplicantList = new List<Applicant>();
        public static DataSet Ds { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProgressBar.Value = 0;
            ProgressBar.TransitionValue(0);
        }
        private void btnStart_ClickAsync(object sender, EventArgs e)
        {
            _ = GetHtmlAsync();
        }

        private async Task GetHtmlAsync()
        {
            TotalData = await GetTotalData();
            TotalPage = await GetTotalPage();

            if (TotalData == 0)
            {
                MessageBox.Show("Data not found!");
                return;
            }

            ProgressBar.Minimum = 0;
            ProgressBar.Value = 0;

            var pageList = Enumerable.Range(1, 20);

            var limiter = new TaskLimiter(5, TimeSpan.FromSeconds(1));
            try
            {
                var tasks = pageList.Select(page => limiter.LimitAsync(async() => await ParseWebData(page))).ToArray();
                btnStart.Enabled = false;
                await Task.WhenAll(tasks).ConfigureAwait(false);

                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.Columns.Add("ApplicationNo", typeof(string));
                dt.Columns.Add("CompanyRegistration", typeof(string));
                dt.Columns.Add("ApplicantName", typeof(string));
                dt.Columns.Add("Document", typeof(string));
                dt.Columns.Add("Status", typeof(string));

                foreach (Applicant ap in ApplicantList)
                {
                    dt.Rows.Add(ap.ApplicationNo, ap.CompanyRegistration, ap.ApplicantName, ap.Document, ap.Status);
                }

                ds.Tables.Add(dt);
                Ds = ds;

                MessageBox.Show("Parse Completed !!\n\nPlease Check Report\n", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private async Task ParseWebData(int page)
        {
            try
            {
                var url = "https://eservices.imi.gov.my/myimms/PRAStatus?txnDetail=&SEARCH_IND=OLD&APPL_NO=&FIN_NO=&VSTR_TYP=M&CurrLang=en&MAD_ROC_NO=" + txtReg.Text + "&MAD_ROC_NO1=&MAD_ROC_NO2=" + txtReg.Text + "&MAD_APPL_NO=&agencyIndicator=1&searchStatusPRA=>>&currentPgNo=" + page + "";
                var httpClient = new HttpClient();

                var html = await httpClient.GetStringAsync(url);
                var htmlDocument = new HtmlAgilityPack.HtmlDocument();

                htmlDocument.LoadHtml(html);

                var parsedApplicationNos = htmlDocument.DocumentNode.SelectNodes("//*[@id='PRAStatus']/div[4]/table/tr/td[2]/div");
                var CompanyRegistrations = htmlDocument.DocumentNode.SelectNodes("//*[@id='PRAStatus']/div[4]/table/tr/td[3]/div");
                var Names = htmlDocument.DocumentNode.SelectNodes("//*[@id='PRAStatus']/div[4]/table/tr/td[4]/div");
                var Documents = htmlDocument.DocumentNode.SelectNodes("//*[@id='PRAStatus']/div[4]/table/tr/td[5]/div");
                var Statuss = htmlDocument.DocumentNode.SelectNodes("//*[@id='PRAStatus']/div[4]/table/tr/td[6]/div");

                if (parsedApplicationNos == null) return;

                if (parsedApplicationNos.Count > 0)
                {
                    for (int i = 0; i < parsedApplicationNos.Count; i++)
                    {
                        Applicant applicant = new Applicant()
                        {
                            ApplicationNo = parsedApplicationNos[i].InnerText,
                            CompanyRegistration = CompanyRegistrations[i].InnerText,
                            ApplicantName = Names[i].InnerText,
                            Document = Documents[i].InnerText,
                            Status = Statuss[i].InnerText
                        };
                        ApplicantList.Add(applicant);
                        parseCount++;
                        ProgressBar.TransitionValue(((parseCount * 100) / TotalData), 2000);
                        lblParsed.Text = parseCount.ToString();
                        DataGridView1.Rows.Add(applicant.ApplicationNo, applicant.CompanyRegistration, applicant.ApplicantName, applicant.Document, applicant.Status);
                        DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.RowCount - 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task<int> GetTotalPage()
        {
            try
            {
                var url = "https://eservices.imi.gov.my/myimms/PRAStatus?txnDetail=&SEARCH_IND=OLD&APPL_NO=&FIN_NO=&VSTR_TYP=M&CurrLang=en&MAD_ROC_NO=" + txtReg.Text + "&MAD_ROC_NO1=&MAD_ROC_NO2=" + txtReg.Text + "&MAD_APPL_NO=&agencyIndicator=1&searchStatusPRA=>>&currentPgNo=" + currentPage + "";
                var httpClient = new HttpClient();

                var html = await httpClient.GetStringAsync(url);
                var htmlDocument = new HtmlAgilityPack.HtmlDocument();
                htmlDocument.LoadHtml(html);

                string totalPage = htmlDocument.DocumentNode.SelectNodes("//*[@id='PRAStatus']/div[4]/table/tr[17]/td[2]/font")[0].InnerText;
                totalPage = totalPage.Split(' ').Last();
                totalPage = totalPage.Trim();
                return Convert.ToInt32(totalPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private async Task<int> GetTotalData()
        {
            try
            {
                var url = "https://eservices.imi.gov.my/myimms/PRAStatus?txnDetail=&SEARCH_IND=OLD&APPL_NO=&FIN_NO=&VSTR_TYP=M&CurrLang=en&MAD_ROC_NO=" + txtReg.Text + "&MAD_ROC_NO1=&MAD_ROC_NO2=" + txtReg.Text + "&MAD_APPL_NO=&agencyIndicator=1&searchStatusPRA=>>&currentPgNo=" + currentPage + "";
                var httpClient = new HttpClient();

                var html = await httpClient.GetStringAsync(url);
                var htmlDocument = new HtmlAgilityPack.HtmlDocument();
                htmlDocument.LoadHtml(html);

                string totalData = htmlDocument.DocumentNode.SelectNodes("//*[@id='PRAStatus']/div[4]/table/tr[17]/td[1]/font")[0].InnerText;
                totalData = totalData.Split(':').Last();
                totalData = totalData.Trim();
                lblTotal.Text = totalData;
                return Convert.ToInt32(totalData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (Form1.Ds == null)
            {
                MessageBox.Show("No report is available to show !");
            }
            else
            {
                FormReport fr = new FormReport();
                fr.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/abdulahaddev");
        }
    }
}
