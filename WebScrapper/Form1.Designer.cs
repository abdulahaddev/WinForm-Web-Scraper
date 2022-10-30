
namespace WebScrapper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnReport = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnDashboard = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.header = new System.Windows.Forms.Panel();
            this.btnMinimize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lblHeader = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblTotal = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblParsed = new Bunifu.UI.WinForms.BunifuLabel();
            this.DataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ApplicationNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyRegistration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Document = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ProgressBar = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.btnStart = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtReg = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panel1.SuspendLayout();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 478);
            this.panel1.TabIndex = 21;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabel1.Location = new System.Drawing.Point(22, 436);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(165, 15);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Developed by Abdul Ahad";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Silver;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnReport
            // 
            this.btnReport.AllowAnimations = true;
            this.btnReport.AllowMouseEffects = true;
            this.btnReport.AllowToggling = false;
            this.btnReport.AnimationSpeed = 200;
            this.btnReport.AutoGenerateColors = false;
            this.btnReport.AutoRoundBorders = false;
            this.btnReport.AutoSizeLeftIcon = true;
            this.btnReport.AutoSizeRightIcon = true;
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReport.BackgroundImage")));
            this.btnReport.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReport.ButtonText = "Report";
            this.btnReport.ButtonTextMarginLeft = 0;
            this.btnReport.ColorContrastOnClick = 45;
            this.btnReport.ColorContrastOnHover = 45;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.btnReport.CustomizableEdges = borderEdges7;
            this.btnReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReport.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReport.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnReport.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnReport.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnReport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.IconLeft = global::WebScrapper.Properties.Resources.report;
            this.btnReport.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnReport.IconLeftPadding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnReport.IconMarginLeft = 11;
            this.btnReport.IconPadding = 10;
            this.btnReport.IconRight = null;
            this.btnReport.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnReport.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnReport.IconSize = 20;
            this.btnReport.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnReport.IdleBorderRadius = 0;
            this.btnReport.IdleBorderThickness = 0;
            this.btnReport.IdleFillColor = System.Drawing.Color.Empty;
            this.btnReport.IdleIconLeftImage = global::WebScrapper.Properties.Resources.report;
            this.btnReport.IdleIconRightImage = null;
            this.btnReport.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.btnReport.IndicateFocus = false;
            this.btnReport.Location = new System.Drawing.Point(0, 57);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnReport.Name = "btnReport";
            this.btnReport.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReport.OnDisabledState.BorderRadius = 1;
            this.btnReport.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReport.OnDisabledState.BorderThickness = 1;
            this.btnReport.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReport.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReport.OnDisabledState.IconLeftImage = null;
            this.btnReport.OnDisabledState.IconRightImage = null;
            this.btnReport.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnReport.onHoverState.BorderRadius = 1;
            this.btnReport.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReport.onHoverState.BorderThickness = 1;
            this.btnReport.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnReport.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnReport.onHoverState.IconLeftImage = null;
            this.btnReport.onHoverState.IconRightImage = null;
            this.btnReport.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnReport.OnIdleState.BorderRadius = 1;
            this.btnReport.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReport.OnIdleState.BorderThickness = 1;
            this.btnReport.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnReport.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnReport.OnIdleState.IconLeftImage = global::WebScrapper.Properties.Resources.report;
            this.btnReport.OnIdleState.IconRightImage = null;
            this.btnReport.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnReport.OnPressedState.BorderRadius = 1;
            this.btnReport.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReport.OnPressedState.BorderThickness = 1;
            this.btnReport.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(230)))));
            this.btnReport.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnReport.OnPressedState.IconLeftImage = null;
            this.btnReport.OnPressedState.IconRightImage = null;
            this.btnReport.Size = new System.Drawing.Size(210, 54);
            this.btnReport.TabIndex = 1;
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReport.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReport.TextMarginLeft = 0;
            this.btnReport.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnReport.UseDefaultRadiusAndThickness = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.AllowAnimations = true;
            this.btnDashboard.AllowMouseEffects = true;
            this.btnDashboard.AllowToggling = false;
            this.btnDashboard.AnimationSpeed = 200;
            this.btnDashboard.AutoGenerateColors = false;
            this.btnDashboard.AutoRoundBorders = false;
            this.btnDashboard.AutoSizeLeftIcon = true;
            this.btnDashboard.AutoSizeRightIcon = true;
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnDashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.BackgroundImage")));
            this.btnDashboard.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.ButtonText = "Dashboard";
            this.btnDashboard.ButtonTextMarginLeft = 0;
            this.btnDashboard.ColorContrastOnClick = 45;
            this.btnDashboard.ColorContrastOnHover = 45;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.btnDashboard.CustomizableEdges = borderEdges8;
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDashboard.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnDashboard.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.IconLeft = global::WebScrapper.Properties.Resources.home;
            this.btnDashboard.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDashboard.IconLeftPadding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnDashboard.IconMarginLeft = 11;
            this.btnDashboard.IconPadding = 10;
            this.btnDashboard.IconRight = null;
            this.btnDashboard.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDashboard.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDashboard.IconSize = 20;
            this.btnDashboard.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnDashboard.IdleBorderRadius = 0;
            this.btnDashboard.IdleBorderThickness = 0;
            this.btnDashboard.IdleFillColor = System.Drawing.Color.Empty;
            this.btnDashboard.IdleIconLeftImage = global::WebScrapper.Properties.Resources.home;
            this.btnDashboard.IdleIconRightImage = null;
            this.btnDashboard.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.btnDashboard.IndicateFocus = false;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDashboard.OnDisabledState.BorderRadius = 1;
            this.btnDashboard.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.OnDisabledState.BorderThickness = 1;
            this.btnDashboard.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDashboard.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDashboard.OnDisabledState.IconLeftImage = null;
            this.btnDashboard.OnDisabledState.IconRightImage = null;
            this.btnDashboard.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnDashboard.onHoverState.BorderRadius = 1;
            this.btnDashboard.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.onHoverState.BorderThickness = 1;
            this.btnDashboard.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnDashboard.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.onHoverState.IconLeftImage = null;
            this.btnDashboard.onHoverState.IconRightImage = null;
            this.btnDashboard.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDashboard.OnIdleState.BorderRadius = 1;
            this.btnDashboard.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.OnIdleState.BorderThickness = 1;
            this.btnDashboard.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnDashboard.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.OnIdleState.IconLeftImage = global::WebScrapper.Properties.Resources.home;
            this.btnDashboard.OnIdleState.IconRightImage = null;
            this.btnDashboard.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDashboard.OnPressedState.BorderRadius = 1;
            this.btnDashboard.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDashboard.OnPressedState.BorderThickness = 1;
            this.btnDashboard.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(145)))), ((int)(((byte)(230)))));
            this.btnDashboard.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.OnPressedState.IconLeftImage = null;
            this.btnDashboard.OnPressedState.IconRightImage = null;
            this.btnDashboard.Size = new System.Drawing.Size(210, 54);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDashboard.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDashboard.TextMarginLeft = 0;
            this.btnDashboard.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDashboard.UseDefaultRadiusAndThickness = true;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.SteelBlue;
            this.header.Controls.Add(this.btnMinimize);
            this.header.Controls.Add(this.btnClose);
            this.header.Controls.Add(this.lblHeader);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(963, 41);
            this.header.TabIndex = 22;
            // 
            // btnMinimize
            // 
            this.btnMinimize.ActiveImage = null;
            this.btnMinimize.AllowAnimations = true;
            this.btnMinimize.AllowBuffering = false;
            this.btnMinimize.AllowToggling = false;
            this.btnMinimize.AllowZooming = false;
            this.btnMinimize.AllowZoomingOnFocus = false;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimize.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.ErrorImage")));
            this.btnMinimize.FadeWhenInactive = false;
            this.btnMinimize.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnMinimize.Image = global::WebScrapper.Properties.Resources.minimize;
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.ImageLocation = null;
            this.btnMinimize.ImageMargin = 0;
            this.btnMinimize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMinimize.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.btnMinimize.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.InitialImage")));
            this.btnMinimize.Location = new System.Drawing.Point(896, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Rotation = 0;
            this.btnMinimize.ShowActiveImage = true;
            this.btnMinimize.ShowCursorChanges = true;
            this.btnMinimize.ShowImageBorders = false;
            this.btnMinimize.ShowSizeMarkers = false;
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.ToolTipText = "Minimize";
            this.btnMinimize.WaitOnLoad = false;
            this.btnMinimize.Zoom = 0;
            this.btnMinimize.ZoomSpeed = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.ActiveImage = null;
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowBuffering = false;
            this.btnClose.AllowToggling = false;
            this.btnClose.AllowZooming = false;
            this.btnClose.AllowZoomingOnFocus = false;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.FadeWhenInactive = false;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.Image = global::WebScrapper.Properties.Resources.close;
            this.btnClose.ImageActive = null;
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 0;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(929, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = false;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.ToolTipText = "Exit";
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 0;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AllowParentOverrides = false;
            this.lblHeader.AutoEllipsis = false;
            this.lblHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblHeader.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblHeader.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(14, 8);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHeader.Size = new System.Drawing.Size(551, 23);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Web Scrapper Using C# WinForm with Rate Limiting Task";
            this.lblHeader.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblHeader.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel3.Location = new System.Drawing.Point(240, 75);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(112, 21);
            this.bunifuLabel3.TabIndex = 24;
            this.bunifuLabel3.Text = "Registration No.";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel4.Location = new System.Drawing.Point(240, 117);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(76, 21);
            this.bunifuLabel4.TabIndex = 24;
            this.bunifuLabel4.Text = "Total Item :";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblTotal
            // 
            this.lblTotal.AllowParentOverrides = false;
            this.lblTotal.AutoEllipsis = false;
            this.lblTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotal.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotal.Location = new System.Drawing.Point(372, 117);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotal.Size = new System.Drawing.Size(9, 21);
            this.lblTotal.TabIndex = 24;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotal.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel6.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel6.Location = new System.Drawing.Point(240, 159);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(89, 21);
            this.bunifuLabel6.TabIndex = 24;
            this.bunifuLabel6.Text = "Parsed Item :";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblParsed
            // 
            this.lblParsed.AllowParentOverrides = false;
            this.lblParsed.AutoEllipsis = false;
            this.lblParsed.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblParsed.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblParsed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblParsed.Location = new System.Drawing.Point(372, 159);
            this.lblParsed.Name = "lblParsed";
            this.lblParsed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblParsed.Size = new System.Drawing.Size(9, 21);
            this.lblParsed.TabIndex = 24;
            this.lblParsed.Text = "0";
            this.lblParsed.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblParsed.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowCustomTheming = false;
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridView1.ColumnHeadersHeight = 40;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApplicationNo,
            this.CompanyRegistration,
            this.ApplicantName,
            this.Document,
            this.Status});
            this.DataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.DataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.DataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.DataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.DataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridView1.CurrentTheme.Name = null;
            this.DataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.DataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.DataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.DataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataGridView1.Location = new System.Drawing.Point(216, 197);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowTemplate.Height = 40;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(743, 310);
            this.DataGridView1.TabIndex = 2;
            this.DataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // ApplicationNo
            // 
            this.ApplicationNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ApplicationNo.DataPropertyName = "ApplicationNo";
            this.ApplicationNo.FillWeight = 180F;
            this.ApplicationNo.HeaderText = "Application No";
            this.ApplicationNo.Name = "ApplicationNo";
            this.ApplicationNo.Width = 143;
            // 
            // CompanyRegistration
            // 
            this.CompanyRegistration.DataPropertyName = "CompanyRegistration";
            this.CompanyRegistration.HeaderText = "Company";
            this.CompanyRegistration.Name = "CompanyRegistration";
            // 
            // ApplicantName
            // 
            this.ApplicantName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ApplicantName.DataPropertyName = "ApplicantName";
            this.ApplicantName.FillWeight = 150F;
            this.ApplicantName.HeaderText = "Name";
            this.ApplicantName.Name = "ApplicantName";
            // 
            // Document
            // 
            this.Document.DataPropertyName = "Document";
            this.Document.HeaderText = "Document";
            this.Document.Name = "Document";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.lblHeader;
            this.bunifuDragControl3.Vertical = true;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Animated = true;
            this.ProgressBar.AnimationInterval = 1;
            this.ProgressBar.AnimationSpeed = 1;
            this.ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBar.CircleMargin = 10;
            this.ProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProgressBar.IsPercentage = true;
            this.ProgressBar.LineProgressThickness = 10;
            this.ProgressBar.LineThickness = 10;
            this.ProgressBar.Location = new System.Drawing.Point(757, 43);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressAnimationSpeed = 200;
            this.ProgressBar.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.ProgressBar.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.ProgressBar.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.ProgressBar.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.ProgressBar.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.ProgressBar.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.ProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ProgressBar.Size = new System.Drawing.Size(151, 151);
            this.ProgressBar.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgressBar.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.ProgressBar.SubScriptText = ".00";
            this.ProgressBar.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgressBar.SuperScriptMargin = new System.Windows.Forms.Padding(5, 50, 0, 0);
            this.ProgressBar.SuperScriptText = "%";
            this.ProgressBar.TabIndex = 16;
            this.ProgressBar.Text = "30";
            this.ProgressBar.TextMargin = new System.Windows.Forms.Padding(-5, 5, 0, 0);
            this.ProgressBar.Value = 30;
            this.ProgressBar.ValueByTransition = 30;
            this.ProgressBar.ValueMargin = new System.Windows.Forms.Padding(-5, 5, 0, 0);
            // 
            // btnStart
            // 
            this.btnStart.AllowAnimations = true;
            this.btnStart.AllowMouseEffects = true;
            this.btnStart.AllowToggling = false;
            this.btnStart.AnimationSpeed = 200;
            this.btnStart.AutoGenerateColors = false;
            this.btnStart.AutoRoundBorders = false;
            this.btnStart.AutoSizeLeftIcon = true;
            this.btnStart.AutoSizeRightIcon = true;
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStart.ButtonText = "Start";
            this.btnStart.ButtonTextMarginLeft = 0;
            this.btnStart.ColorContrastOnClick = 45;
            this.btnStart.ColorContrastOnHover = 45;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges9.BottomLeft = true;
            borderEdges9.BottomRight = true;
            borderEdges9.TopLeft = true;
            borderEdges9.TopRight = true;
            this.btnStart.CustomizableEdges = borderEdges9;
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStart.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnStart.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnStart.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnStart.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.IconLeft = null;
            this.btnStart.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnStart.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnStart.IconMarginLeft = 11;
            this.btnStart.IconPadding = 10;
            this.btnStart.IconRight = null;
            this.btnStart.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnStart.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnStart.IconSize = 25;
            this.btnStart.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnStart.IdleBorderRadius = 0;
            this.btnStart.IdleBorderThickness = 0;
            this.btnStart.IdleFillColor = System.Drawing.Color.Empty;
            this.btnStart.IdleIconLeftImage = null;
            this.btnStart.IdleIconRightImage = null;
            this.btnStart.IndicateFocus = false;
            this.btnStart.Location = new System.Drawing.Point(534, 66);
            this.btnStart.Name = "btnStart";
            this.btnStart.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnStart.OnDisabledState.BorderRadius = 38;
            this.btnStart.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStart.OnDisabledState.BorderThickness = 1;
            this.btnStart.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnStart.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnStart.OnDisabledState.IconLeftImage = null;
            this.btnStart.OnDisabledState.IconRightImage = null;
            this.btnStart.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnStart.onHoverState.BorderRadius = 38;
            this.btnStart.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStart.onHoverState.BorderThickness = 1;
            this.btnStart.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnStart.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnStart.onHoverState.IconLeftImage = null;
            this.btnStart.onHoverState.IconRightImage = null;
            this.btnStart.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnStart.OnIdleState.BorderRadius = 38;
            this.btnStart.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStart.OnIdleState.BorderThickness = 1;
            this.btnStart.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnStart.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnStart.OnIdleState.IconLeftImage = null;
            this.btnStart.OnIdleState.IconRightImage = null;
            this.btnStart.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnStart.OnPressedState.BorderRadius = 38;
            this.btnStart.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnStart.OnPressedState.BorderThickness = 1;
            this.btnStart.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnStart.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnStart.OnPressedState.IconLeftImage = null;
            this.btnStart.OnPressedState.IconRightImage = null;
            this.btnStart.Size = new System.Drawing.Size(85, 38);
            this.btnStart.TabIndex = 1;
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStart.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStart.TextMarginLeft = 0;
            this.btnStart.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnStart.UseDefaultRadiusAndThickness = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_ClickAsync);
            // 
            // txtReg
            // 
            this.txtReg.AcceptsReturn = false;
            this.txtReg.AcceptsTab = false;
            this.txtReg.AnimationSpeed = 200;
            this.txtReg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtReg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtReg.AutoSizeHeight = true;
            this.txtReg.BackColor = System.Drawing.Color.Transparent;
            this.txtReg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtReg.BackgroundImage")));
            this.txtReg.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtReg.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtReg.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtReg.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtReg.BorderRadius = 10;
            this.txtReg.BorderThickness = 1;
            this.txtReg.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtReg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReg.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtReg.DefaultText = "143800-K";
            this.txtReg.FillColor = System.Drawing.Color.White;
            this.txtReg.HideSelection = true;
            this.txtReg.IconLeft = null;
            this.txtReg.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReg.IconPadding = 10;
            this.txtReg.IconRight = null;
            this.txtReg.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReg.Lines = new string[] {
        "143800-K"};
            this.txtReg.Location = new System.Drawing.Point(364, 66);
            this.txtReg.MaxLength = 32767;
            this.txtReg.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtReg.Modified = false;
            this.txtReg.Multiline = false;
            this.txtReg.Name = "txtReg";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtReg.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtReg.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtReg.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtReg.OnIdleState = stateProperties12;
            this.txtReg.Padding = new System.Windows.Forms.Padding(3);
            this.txtReg.PasswordChar = '\0';
            this.txtReg.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtReg.PlaceholderText = "Enter text";
            this.txtReg.ReadOnly = false;
            this.txtReg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReg.SelectedText = "";
            this.txtReg.SelectionLength = 0;
            this.txtReg.SelectionStart = 8;
            this.txtReg.ShortcutsEnabled = true;
            this.txtReg.Size = new System.Drawing.Size(164, 39);
            this.txtReg.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtReg.TabIndex = 0;
            this.txtReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtReg.TextMarginBottom = 0;
            this.txtReg.TextMarginLeft = 3;
            this.txtReg.TextMarginTop = 1;
            this.txtReg.TextPlaceholder = "Enter text";
            this.txtReg.UseSystemPasswordChar = false;
            this.txtReg.WordWrap = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 519);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblParsed);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.bunifuLabel6);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.txtReg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReport;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDashboard;
        private System.Windows.Forms.Panel header;
        private Bunifu.UI.WinForms.BunifuImageButton btnMinimize;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private Bunifu.UI.WinForms.BunifuLabel lblHeader;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnStart;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuTextBox txtReg;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel lblTotal;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel lblParsed;
        private Bunifu.UI.WinForms.BunifuDataGridView DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyRegistration;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Document;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private Bunifu.UI.WinForms.BunifuCircleProgress ProgressBar;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

