namespace TestingDocumentationTool
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ButtonSetupTestPlan = new System.Windows.Forms.Button();
            this.LabelAbout = new System.Windows.Forms.Label();
            this.ButtonLinkedIn = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.ButtonTestCases = new System.Windows.Forms.Button();
            this.ButtonSummary = new System.Windows.Forms.Button();
            this.ButtonResults = new System.Windows.Forms.Button();
            this.ButtonDownloadXLS = new System.Windows.Forms.Button();
            this.ButtonGitHub = new System.Windows.Forms.Button();
            this.LabelWindowLightMode = new System.Windows.Forms.Label();
            this.ButtonWModeBackground = new System.Windows.Forms.Button();
            this.ButtonWModeForeground = new System.Windows.Forms.Button();
            this.PanelSetupTestPlan = new System.Windows.Forms.Panel();
            this.PanelSetupTestPlanContinuation = new System.Windows.Forms.Panel();
            this.ComboBoxSetupTestPlanComponent = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LabelSetupTestPlanTestCaseName = new System.Windows.Forms.Label();
            this.LabelSetupTestPlanTestOutput = new System.Windows.Forms.Label();
            this.LabelSetupTestPlanComponent = new System.Windows.Forms.Label();
            this.LabelSetupTestPlanType = new System.Windows.Forms.Label();
            this.LabelSetupTestPlanTestArea = new System.Windows.Forms.Label();
            this.ButtonSetupTestPlanAddTestCase = new System.Windows.Forms.Button();
            this.ComboBoxSetupTestPlanType = new System.Windows.Forms.ComboBox();
            this.ComboBoxSetupTestPlanTestArea = new System.Windows.Forms.ComboBox();
            this.ButtonSetupTestPlanFinish = new System.Windows.Forms.Button();
            this.ButtonSetupTestPlanCancel = new System.Windows.Forms.Button();
            this.ButtonSetupTestPlanSave = new System.Windows.Forms.Button();
            this.RichTextBoxSetupTestPlanScope = new System.Windows.Forms.RichTextBox();
            this.LabelSetupTestPlanScope = new System.Windows.Forms.Label();
            this.RichTextBoxSetupTestPlanEnvironment = new System.Windows.Forms.RichTextBox();
            this.LabelSetupTestPlanEnvironment = new System.Windows.Forms.Label();
            this.RichTextBoxSetupTestPlanIntroduction = new System.Windows.Forms.RichTextBox();
            this.LabelSetupTestPlanIntroduction = new System.Windows.Forms.Label();
            this.LabelSetupTestPlanName = new System.Windows.Forms.Label();
            this.TextBoxSetupTestPlanName = new System.Windows.Forms.TextBox();
            this.PanelTestCases = new System.Windows.Forms.Panel();
            this.DataGridViewTestCases = new System.Windows.Forms.DataGridView();
            this.ButtonTestCasesSave = new System.Windows.Forms.Button();
            this.ButtonTestCasesRemove = new System.Windows.Forms.Button();
            this.TestArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Component = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestScenario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tag = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PreCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestSteps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpectedBehaviour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonTestCasesDetailedView = new System.Windows.Forms.Button();
            this.PanelSetupTestPlan.SuspendLayout();
            this.PanelSetupTestPlanContinuation.SuspendLayout();
            this.PanelTestCases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTestCases)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSetupTestPlan
            // 
            this.ButtonSetupTestPlan.FlatAppearance.BorderSize = 0;
            this.ButtonSetupTestPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSetupTestPlan.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSetupTestPlan.Image")));
            this.ButtonSetupTestPlan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonSetupTestPlan.Location = new System.Drawing.Point(80, 85);
            this.ButtonSetupTestPlan.Name = "ButtonSetupTestPlan";
            this.ButtonSetupTestPlan.Padding = new System.Windows.Forms.Padding(0, 10, 0, 20);
            this.ButtonSetupTestPlan.Size = new System.Drawing.Size(152, 161);
            this.ButtonSetupTestPlan.TabIndex = 0;
            this.ButtonSetupTestPlan.Text = "About Test Plan";
            this.ButtonSetupTestPlan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonSetupTestPlan.UseVisualStyleBackColor = true;
            this.ButtonSetupTestPlan.Click += new System.EventHandler(this.ButtonSetupTestPlan_Click);
            // 
            // LabelAbout
            // 
            this.LabelAbout.AutoSize = true;
            this.LabelAbout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAbout.Location = new System.Drawing.Point(151, 685);
            this.LabelAbout.Name = "LabelAbout";
            this.LabelAbout.Size = new System.Drawing.Size(130, 56);
            this.LabelAbout.TabIndex = 5;
            this.LabelAbout.Text = "ABOUT THE \r\nDEVELOPER";
            this.LabelAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonLinkedIn
            // 
            this.ButtonLinkedIn.FlatAppearance.BorderSize = 0;
            this.ButtonLinkedIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLinkedIn.Image = ((System.Drawing.Image)(resources.GetObject("ButtonLinkedIn.Image")));
            this.ButtonLinkedIn.Location = new System.Drawing.Point(274, 682);
            this.ButtonLinkedIn.Name = "ButtonLinkedIn";
            this.ButtonLinkedIn.Size = new System.Drawing.Size(42, 48);
            this.ButtonLinkedIn.TabIndex = 6;
            this.ButtonLinkedIn.UseVisualStyleBackColor = true;
            this.ButtonLinkedIn.Click += new System.EventHandler(this.ButtonLinkedIn_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("ButtonClose.Image")));
            this.ButtonClose.Location = new System.Drawing.Point(1183, 0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(37, 30);
            this.ButtonClose.TabIndex = 12;
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.FlatAppearance.BorderSize = 0;
            this.ButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("ButtonMinimize.Image")));
            this.ButtonMinimize.Location = new System.Drawing.Point(1146, -5);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(31, 33);
            this.ButtonMinimize.TabIndex = 14;
            this.ButtonMinimize.UseVisualStyleBackColor = true;
            this.ButtonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            // 
            // ButtonTestCases
            // 
            this.ButtonTestCases.FlatAppearance.BorderSize = 0;
            this.ButtonTestCases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTestCases.Image = ((System.Drawing.Image)(resources.GetObject("ButtonTestCases.Image")));
            this.ButtonTestCases.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonTestCases.Location = new System.Drawing.Point(274, 85);
            this.ButtonTestCases.Name = "ButtonTestCases";
            this.ButtonTestCases.Padding = new System.Windows.Forms.Padding(0, 10, 0, 20);
            this.ButtonTestCases.Size = new System.Drawing.Size(153, 161);
            this.ButtonTestCases.TabIndex = 15;
            this.ButtonTestCases.Text = "Test Cases";
            this.ButtonTestCases.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonTestCases.UseVisualStyleBackColor = true;
            this.ButtonTestCases.Click += new System.EventHandler(this.ButtonTestCases_Click);
            // 
            // ButtonSummary
            // 
            this.ButtonSummary.FlatAppearance.BorderSize = 0;
            this.ButtonSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSummary.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSummary.Image")));
            this.ButtonSummary.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonSummary.Location = new System.Drawing.Point(274, 284);
            this.ButtonSummary.Name = "ButtonSummary";
            this.ButtonSummary.Padding = new System.Windows.Forms.Padding(0, 10, 0, 20);
            this.ButtonSummary.Size = new System.Drawing.Size(153, 161);
            this.ButtonSummary.TabIndex = 17;
            this.ButtonSummary.Text = "Summary";
            this.ButtonSummary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonSummary.UseVisualStyleBackColor = true;
            this.ButtonSummary.Click += new System.EventHandler(this.ButtonSummary_Click);
            // 
            // ButtonResults
            // 
            this.ButtonResults.FlatAppearance.BorderSize = 0;
            this.ButtonResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonResults.Image = ((System.Drawing.Image)(resources.GetObject("ButtonResults.Image")));
            this.ButtonResults.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonResults.Location = new System.Drawing.Point(80, 284);
            this.ButtonResults.Name = "ButtonResults";
            this.ButtonResults.Padding = new System.Windows.Forms.Padding(0, 10, 0, 20);
            this.ButtonResults.Size = new System.Drawing.Size(152, 161);
            this.ButtonResults.TabIndex = 16;
            this.ButtonResults.Text = "Results";
            this.ButtonResults.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonResults.UseVisualStyleBackColor = true;
            this.ButtonResults.Click += new System.EventHandler(this.ButtonResults_Click);
            // 
            // ButtonDownloadXLS
            // 
            this.ButtonDownloadXLS.FlatAppearance.BorderSize = 0;
            this.ButtonDownloadXLS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDownloadXLS.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDownloadXLS.Image")));
            this.ButtonDownloadXLS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonDownloadXLS.Location = new System.Drawing.Point(80, 483);
            this.ButtonDownloadXLS.Name = "ButtonDownloadXLS";
            this.ButtonDownloadXLS.Padding = new System.Windows.Forms.Padding(0, 10, 0, 20);
            this.ButtonDownloadXLS.Size = new System.Drawing.Size(153, 161);
            this.ButtonDownloadXLS.TabIndex = 18;
            this.ButtonDownloadXLS.Text = "Download XLS FIle";
            this.ButtonDownloadXLS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonDownloadXLS.UseVisualStyleBackColor = true;
            this.ButtonDownloadXLS.Click += new System.EventHandler(this.ButtonDownloadXLS_Click);
            // 
            // ButtonGitHub
            // 
            this.ButtonGitHub.FlatAppearance.BorderSize = 0;
            this.ButtonGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGitHub.Image = ((System.Drawing.Image)(resources.GetObject("ButtonGitHub.Image")));
            this.ButtonGitHub.Location = new System.Drawing.Point(331, 683);
            this.ButtonGitHub.Name = "ButtonGitHub";
            this.ButtonGitHub.Size = new System.Drawing.Size(42, 48);
            this.ButtonGitHub.TabIndex = 19;
            this.ButtonGitHub.UseVisualStyleBackColor = true;
            this.ButtonGitHub.Click += new System.EventHandler(this.ButtonGitHub_Click);
            // 
            // LabelWindowLightMode
            // 
            this.LabelWindowLightMode.AutoSize = true;
            this.LabelWindowLightMode.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWindowLightMode.Location = new System.Drawing.Point(923, 701);
            this.LabelWindowLightMode.Name = "LabelWindowLightMode";
            this.LabelWindowLightMode.Size = new System.Drawing.Size(161, 32);
            this.LabelWindowLightMode.TabIndex = 20;
            this.LabelWindowLightMode.Text = "DARK MODE";
            // 
            // ButtonWModeBackground
            // 
            this.ButtonWModeBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonWModeBackground.FlatAppearance.BorderSize = 0;
            this.ButtonWModeBackground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonWModeBackground.Location = new System.Drawing.Point(1062, 697);
            this.ButtonWModeBackground.Name = "ButtonWModeBackground";
            this.ButtonWModeBackground.Size = new System.Drawing.Size(62, 32);
            this.ButtonWModeBackground.TabIndex = 21;
            this.ButtonWModeBackground.UseVisualStyleBackColor = false;
            this.ButtonWModeBackground.Click += new System.EventHandler(this.ButtonWModeBackground_Click);
            // 
            // ButtonWModeForeground
            // 
            this.ButtonWModeForeground.BackColor = System.Drawing.Color.White;
            this.ButtonWModeForeground.FlatAppearance.BorderSize = 0;
            this.ButtonWModeForeground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonWModeForeground.Location = new System.Drawing.Point(1063, 698);
            this.ButtonWModeForeground.Name = "ButtonWModeForeground";
            this.ButtonWModeForeground.Size = new System.Drawing.Size(30, 30);
            this.ButtonWModeForeground.TabIndex = 22;
            this.ButtonWModeForeground.UseVisualStyleBackColor = false;
            this.ButtonWModeForeground.Click += new System.EventHandler(this.ButtonWModeForeground_Click);
            // 
            // PanelSetupTestPlan
            // 
            this.PanelSetupTestPlan.Controls.Add(this.PanelSetupTestPlanContinuation);
            this.PanelSetupTestPlan.Controls.Add(this.ButtonSetupTestPlanCancel);
            this.PanelSetupTestPlan.Controls.Add(this.ButtonSetupTestPlanSave);
            this.PanelSetupTestPlan.Controls.Add(this.RichTextBoxSetupTestPlanScope);
            this.PanelSetupTestPlan.Controls.Add(this.LabelSetupTestPlanScope);
            this.PanelSetupTestPlan.Controls.Add(this.RichTextBoxSetupTestPlanEnvironment);
            this.PanelSetupTestPlan.Controls.Add(this.LabelSetupTestPlanEnvironment);
            this.PanelSetupTestPlan.Controls.Add(this.RichTextBoxSetupTestPlanIntroduction);
            this.PanelSetupTestPlan.Controls.Add(this.LabelSetupTestPlanIntroduction);
            this.PanelSetupTestPlan.Controls.Add(this.LabelSetupTestPlanName);
            this.PanelSetupTestPlan.Controls.Add(this.TextBoxSetupTestPlanName);
            this.PanelSetupTestPlan.Location = new System.Drawing.Point(485, 85);
            this.PanelSetupTestPlan.Name = "PanelSetupTestPlan";
            this.PanelSetupTestPlan.Size = new System.Drawing.Size(639, 570);
            this.PanelSetupTestPlan.TabIndex = 23;
            this.PanelSetupTestPlan.Visible = false;
            // 
            // PanelSetupTestPlanContinuation
            // 
            this.PanelSetupTestPlanContinuation.Controls.Add(this.ComboBoxSetupTestPlanComponent);
            this.PanelSetupTestPlanContinuation.Controls.Add(this.textBox1);
            this.PanelSetupTestPlanContinuation.Controls.Add(this.LabelSetupTestPlanTestCaseName);
            this.PanelSetupTestPlanContinuation.Controls.Add(this.LabelSetupTestPlanTestOutput);
            this.PanelSetupTestPlanContinuation.Controls.Add(this.LabelSetupTestPlanComponent);
            this.PanelSetupTestPlanContinuation.Controls.Add(this.LabelSetupTestPlanType);
            this.PanelSetupTestPlanContinuation.Controls.Add(this.LabelSetupTestPlanTestArea);
            this.PanelSetupTestPlanContinuation.Controls.Add(this.ButtonSetupTestPlanAddTestCase);
            this.PanelSetupTestPlanContinuation.Controls.Add(this.ComboBoxSetupTestPlanType);
            this.PanelSetupTestPlanContinuation.Controls.Add(this.ComboBoxSetupTestPlanTestArea);
            this.PanelSetupTestPlanContinuation.Controls.Add(this.ButtonSetupTestPlanFinish);
            this.PanelSetupTestPlanContinuation.Location = new System.Drawing.Point(0, 0);
            this.PanelSetupTestPlanContinuation.Name = "PanelSetupTestPlanContinuation";
            this.PanelSetupTestPlanContinuation.Size = new System.Drawing.Size(639, 570);
            this.PanelSetupTestPlanContinuation.TabIndex = 24;
            this.PanelSetupTestPlanContinuation.Visible = false;
            // 
            // ComboBoxSetupTestPlanComponent
            // 
            this.ComboBoxSetupTestPlanComponent.FormattingEnabled = true;
            this.ComboBoxSetupTestPlanComponent.Items.AddRange(new object[] {
            "Login",
            "Home",
            "Keyword",
            "Test Cases",
            "Test Suites",
            "Imported Scripts",
            "Collection",
            "Parameters",
            "Templates",
            "Profiles",
            "Commands",
            "Robot Framework",
            "Products",
            "Libraries",
            "Phases",
            "Users",
            "Tutorial"});
            this.ComboBoxSetupTestPlanComponent.Location = new System.Drawing.Point(217, 233);
            this.ComboBoxSetupTestPlanComponent.Name = "ComboBoxSetupTestPlanComponent";
            this.ComboBoxSetupTestPlanComponent.Size = new System.Drawing.Size(195, 36);
            this.ComboBoxSetupTestPlanComponent.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 292);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 34);
            this.textBox1.TabIndex = 11;
            // 
            // LabelSetupTestPlanTestCaseName
            // 
            this.LabelSetupTestPlanTestCaseName.AutoSize = true;
            this.LabelSetupTestPlanTestCaseName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSetupTestPlanTestCaseName.Location = new System.Drawing.Point(142, 295);
            this.LabelSetupTestPlanTestCaseName.Name = "LabelSetupTestPlanTestCaseName";
            this.LabelSetupTestPlanTestCaseName.Size = new System.Drawing.Size(79, 28);
            this.LabelSetupTestPlanTestCaseName.TabIndex = 10;
            this.LabelSetupTestPlanTestCaseName.Text = "Name :";
            // 
            // LabelSetupTestPlanTestOutput
            // 
            this.LabelSetupTestPlanTestOutput.AutoSize = true;
            this.LabelSetupTestPlanTestOutput.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSetupTestPlanTestOutput.Location = new System.Drawing.Point(213, 512);
            this.LabelSetupTestPlanTestOutput.Name = "LabelSetupTestPlanTestOutput";
            this.LabelSetupTestPlanTestOutput.Size = new System.Drawing.Size(0, 28);
            this.LabelSetupTestPlanTestOutput.TabIndex = 8;
            // 
            // LabelSetupTestPlanComponent
            // 
            this.LabelSetupTestPlanComponent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSetupTestPlanComponent.Location = new System.Drawing.Point(103, 236);
            this.LabelSetupTestPlanComponent.Name = "LabelSetupTestPlanComponent";
            this.LabelSetupTestPlanComponent.Size = new System.Drawing.Size(132, 28);
            this.LabelSetupTestPlanComponent.TabIndex = 7;
            this.LabelSetupTestPlanComponent.Text = "Component :";
            // 
            // LabelSetupTestPlanType
            // 
            this.LabelSetupTestPlanType.AutoSize = true;
            this.LabelSetupTestPlanType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSetupTestPlanType.Location = new System.Drawing.Point(155, 183);
            this.LabelSetupTestPlanType.Name = "LabelSetupTestPlanType";
            this.LabelSetupTestPlanType.Size = new System.Drawing.Size(68, 28);
            this.LabelSetupTestPlanType.TabIndex = 6;
            this.LabelSetupTestPlanType.Text = "Type :";
            // 
            // LabelSetupTestPlanTestArea
            // 
            this.LabelSetupTestPlanTestArea.AutoSize = true;
            this.LabelSetupTestPlanTestArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSetupTestPlanTestArea.Location = new System.Drawing.Point(123, 131);
            this.LabelSetupTestPlanTestArea.Name = "LabelSetupTestPlanTestArea";
            this.LabelSetupTestPlanTestArea.Size = new System.Drawing.Size(111, 28);
            this.LabelSetupTestPlanTestArea.TabIndex = 5;
            this.LabelSetupTestPlanTestArea.Text = "Test Area :";
            // 
            // ButtonSetupTestPlanAddTestCase
            // 
            this.ButtonSetupTestPlanAddTestCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSetupTestPlanAddTestCase.Location = new System.Drawing.Point(217, 343);
            this.ButtonSetupTestPlanAddTestCase.Name = "ButtonSetupTestPlanAddTestCase";
            this.ButtonSetupTestPlanAddTestCase.Size = new System.Drawing.Size(195, 42);
            this.ButtonSetupTestPlanAddTestCase.TabIndex = 4;
            this.ButtonSetupTestPlanAddTestCase.Text = "Add Test Case";
            this.ButtonSetupTestPlanAddTestCase.UseVisualStyleBackColor = true;
            this.ButtonSetupTestPlanAddTestCase.Click += new System.EventHandler(this.ButtonSetupTestPlanAddTestCase_Click);
            // 
            // ComboBoxSetupTestPlanType
            // 
            this.ComboBoxSetupTestPlanType.FormattingEnabled = true;
            this.ComboBoxSetupTestPlanType.Items.AddRange(new object[] {
            "Functional",
            "Non Functional"});
            this.ComboBoxSetupTestPlanType.Location = new System.Drawing.Point(217, 180);
            this.ComboBoxSetupTestPlanType.Name = "ComboBoxSetupTestPlanType";
            this.ComboBoxSetupTestPlanType.Size = new System.Drawing.Size(195, 36);
            this.ComboBoxSetupTestPlanType.TabIndex = 2;
            // 
            // ComboBoxSetupTestPlanTestArea
            // 
            this.ComboBoxSetupTestPlanTestArea.FormattingEnabled = true;
            this.ComboBoxSetupTestPlanTestArea.Items.AddRange(new object[] {
            "New Feature",
            "Enhacement"});
            this.ComboBoxSetupTestPlanTestArea.Location = new System.Drawing.Point(217, 128);
            this.ComboBoxSetupTestPlanTestArea.Name = "ComboBoxSetupTestPlanTestArea";
            this.ComboBoxSetupTestPlanTestArea.Size = new System.Drawing.Size(344, 36);
            this.ComboBoxSetupTestPlanTestArea.TabIndex = 1;
            // 
            // ButtonSetupTestPlanFinish
            // 
            this.ButtonSetupTestPlanFinish.BackColor = System.Drawing.Color.White;
            this.ButtonSetupTestPlanFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSetupTestPlanFinish.Location = new System.Drawing.Point(218, 409);
            this.ButtonSetupTestPlanFinish.Name = "ButtonSetupTestPlanFinish";
            this.ButtonSetupTestPlanFinish.Size = new System.Drawing.Size(195, 79);
            this.ButtonSetupTestPlanFinish.TabIndex = 0;
            this.ButtonSetupTestPlanFinish.Text = "Finish";
            this.ButtonSetupTestPlanFinish.UseVisualStyleBackColor = false;
            this.ButtonSetupTestPlanFinish.Click += new System.EventHandler(this.ButtonSetupTestPlanFinish_Click);
            // 
            // ButtonSetupTestPlanCancel
            // 
            this.ButtonSetupTestPlanCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSetupTestPlanCancel.Location = new System.Drawing.Point(367, 409);
            this.ButtonSetupTestPlanCancel.Name = "ButtonSetupTestPlanCancel";
            this.ButtonSetupTestPlanCancel.Size = new System.Drawing.Size(118, 43);
            this.ButtonSetupTestPlanCancel.TabIndex = 9;
            this.ButtonSetupTestPlanCancel.Text = "Cancel";
            this.ButtonSetupTestPlanCancel.UseVisualStyleBackColor = true;
            this.ButtonSetupTestPlanCancel.Click += new System.EventHandler(this.ButtonSetupTestPlanCancel_Click);
            // 
            // ButtonSetupTestPlanSave
            // 
            this.ButtonSetupTestPlanSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSetupTestPlanSave.Location = new System.Drawing.Point(491, 409);
            this.ButtonSetupTestPlanSave.Name = "ButtonSetupTestPlanSave";
            this.ButtonSetupTestPlanSave.Size = new System.Drawing.Size(118, 43);
            this.ButtonSetupTestPlanSave.TabIndex = 8;
            this.ButtonSetupTestPlanSave.Text = "Save";
            this.ButtonSetupTestPlanSave.UseVisualStyleBackColor = true;
            this.ButtonSetupTestPlanSave.Click += new System.EventHandler(this.ButtonSetupTestPlanSave_Click);
            // 
            // RichTextBoxSetupTestPlanScope
            // 
            this.RichTextBoxSetupTestPlanScope.Location = new System.Drawing.Point(218, 292);
            this.RichTextBoxSetupTestPlanScope.Name = "RichTextBoxSetupTestPlanScope";
            this.RichTextBoxSetupTestPlanScope.Size = new System.Drawing.Size(391, 93);
            this.RichTextBoxSetupTestPlanScope.TabIndex = 7;
            this.RichTextBoxSetupTestPlanScope.TabStop = false;
            this.RichTextBoxSetupTestPlanScope.Text = "";
            // 
            // LabelSetupTestPlanScope
            // 
            this.LabelSetupTestPlanScope.AutoSize = true;
            this.LabelSetupTestPlanScope.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSetupTestPlanScope.Location = new System.Drawing.Point(136, 327);
            this.LabelSetupTestPlanScope.Name = "LabelSetupTestPlanScope";
            this.LabelSetupTestPlanScope.Size = new System.Drawing.Size(85, 28);
            this.LabelSetupTestPlanScope.TabIndex = 6;
            this.LabelSetupTestPlanScope.Text = "Scope : ";
            // 
            // RichTextBoxSetupTestPlanEnvironment
            // 
            this.RichTextBoxSetupTestPlanEnvironment.Location = new System.Drawing.Point(217, 179);
            this.RichTextBoxSetupTestPlanEnvironment.Name = "RichTextBoxSetupTestPlanEnvironment";
            this.RichTextBoxSetupTestPlanEnvironment.Size = new System.Drawing.Size(391, 93);
            this.RichTextBoxSetupTestPlanEnvironment.TabIndex = 5;
            this.RichTextBoxSetupTestPlanEnvironment.Text = "";
            // 
            // LabelSetupTestPlanEnvironment
            // 
            this.LabelSetupTestPlanEnvironment.AutoSize = true;
            this.LabelSetupTestPlanEnvironment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSetupTestPlanEnvironment.Location = new System.Drawing.Point(43, 209);
            this.LabelSetupTestPlanEnvironment.Name = "LabelSetupTestPlanEnvironment";
            this.LabelSetupTestPlanEnvironment.Size = new System.Drawing.Size(210, 28);
            this.LabelSetupTestPlanEnvironment.TabIndex = 4;
            this.LabelSetupTestPlanEnvironment.Text = "Setup environment : ";
            this.LabelSetupTestPlanEnvironment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RichTextBoxSetupTestPlanIntroduction
            // 
            this.RichTextBoxSetupTestPlanIntroduction.Location = new System.Drawing.Point(218, 68);
            this.RichTextBoxSetupTestPlanIntroduction.Name = "RichTextBoxSetupTestPlanIntroduction";
            this.RichTextBoxSetupTestPlanIntroduction.Size = new System.Drawing.Size(391, 93);
            this.RichTextBoxSetupTestPlanIntroduction.TabIndex = 3;
            this.RichTextBoxSetupTestPlanIntroduction.Text = "";
            // 
            // LabelSetupTestPlanIntroduction
            // 
            this.LabelSetupTestPlanIntroduction.AutoSize = true;
            this.LabelSetupTestPlanIntroduction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSetupTestPlanIntroduction.Location = new System.Drawing.Point(93, 104);
            this.LabelSetupTestPlanIntroduction.Name = "LabelSetupTestPlanIntroduction";
            this.LabelSetupTestPlanIntroduction.Size = new System.Drawing.Size(147, 28);
            this.LabelSetupTestPlanIntroduction.TabIndex = 2;
            this.LabelSetupTestPlanIntroduction.Text = "Introduction : ";
            // 
            // LabelSetupTestPlanName
            // 
            this.LabelSetupTestPlanName.AutoSize = true;
            this.LabelSetupTestPlanName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSetupTestPlanName.Location = new System.Drawing.Point(144, 22);
            this.LabelSetupTestPlanName.Name = "LabelSetupTestPlanName";
            this.LabelSetupTestPlanName.Size = new System.Drawing.Size(85, 28);
            this.LabelSetupTestPlanName.TabIndex = 1;
            this.LabelSetupTestPlanName.Text = "Name : ";
            // 
            // TextBoxSetupTestPlanName
            // 
            this.TextBoxSetupTestPlanName.Location = new System.Drawing.Point(217, 19);
            this.TextBoxSetupTestPlanName.Name = "TextBoxSetupTestPlanName";
            this.TextBoxSetupTestPlanName.Size = new System.Drawing.Size(392, 34);
            this.TextBoxSetupTestPlanName.TabIndex = 0;
            // 
            // PanelTestCases
            // 
            this.PanelTestCases.Controls.Add(this.ButtonTestCasesDetailedView);
            this.PanelTestCases.Controls.Add(this.ButtonTestCasesRemove);
            this.PanelTestCases.Controls.Add(this.ButtonTestCasesSave);
            this.PanelTestCases.Controls.Add(this.DataGridViewTestCases);
            this.PanelTestCases.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelTestCases.Location = new System.Drawing.Point(485, 85);
            this.PanelTestCases.Name = "PanelTestCases";
            this.PanelTestCases.Size = new System.Drawing.Size(639, 570);
            this.PanelTestCases.TabIndex = 12;
            this.PanelTestCases.Visible = false;
            // 
            // DataGridViewTestCases
            // 
            this.DataGridViewTestCases.AllowUserToAddRows = false;
            this.DataGridViewTestCases.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTestCases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewTestCases.ColumnHeadersHeight = 29;
            this.DataGridViewTestCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewTestCases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestArea,
            this.Type,
            this.Component,
            this.ID,
            this.TestScenario,
            this.Description,
            this.Tag,
            this.PreCondition,
            this.TestSteps,
            this.ExpectedBehaviour});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewTestCases.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewTestCases.Location = new System.Drawing.Point(6, 4);
            this.DataGridViewTestCases.Name = "DataGridViewTestCases";
            this.DataGridViewTestCases.RowHeadersWidth = 51;
            this.DataGridViewTestCases.RowTemplate.Height = 24;
            this.DataGridViewTestCases.Size = new System.Drawing.Size(627, 506);
            this.DataGridViewTestCases.TabIndex = 0;
            // 
            // ButtonTestCasesSave
            // 
            this.ButtonTestCasesSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTestCasesSave.Location = new System.Drawing.Point(516, 516);
            this.ButtonTestCasesSave.Name = "ButtonTestCasesSave";
            this.ButtonTestCasesSave.Size = new System.Drawing.Size(118, 43);
            this.ButtonTestCasesSave.TabIndex = 9;
            this.ButtonTestCasesSave.Text = "Save";
            this.ButtonTestCasesSave.UseVisualStyleBackColor = true;
            this.ButtonTestCasesSave.Click += new System.EventHandler(this.ButtonTestCasesSave_Click);
            // 
            // ButtonTestCasesRemove
            // 
            this.ButtonTestCasesRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTestCasesRemove.Location = new System.Drawing.Point(392, 516);
            this.ButtonTestCasesRemove.Name = "ButtonTestCasesRemove";
            this.ButtonTestCasesRemove.Size = new System.Drawing.Size(118, 43);
            this.ButtonTestCasesRemove.TabIndex = 10;
            this.ButtonTestCasesRemove.Text = "Remove";
            this.ButtonTestCasesRemove.UseVisualStyleBackColor = true;
            this.ButtonTestCasesRemove.Click += new System.EventHandler(this.ButtonTestCasesRemove_Click);
            // 
            // TestArea
            // 
            this.TestArea.HeaderText = "Test Area";
            this.TestArea.MinimumWidth = 6;
            this.TestArea.Name = "TestArea";
            this.TestArea.ReadOnly = true;
            this.TestArea.Width = 125;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 125;
            // 
            // Component
            // 
            this.Component.HeaderText = "Component";
            this.Component.MinimumWidth = 6;
            this.Component.Name = "Component";
            this.Component.ReadOnly = true;
            this.Component.Width = 125;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // TestScenario
            // 
            this.TestScenario.HeaderText = "Test Scenario";
            this.TestScenario.MinimumWidth = 6;
            this.TestScenario.Name = "TestScenario";
            this.TestScenario.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 125;
            // 
            // Tag
            // 
            this.Tag.HeaderText = "Tag";
            this.Tag.Items.AddRange(new object[] {
            "UX",
            "Functionality",
            "Performance",
            "Integration",
            "Usability",
            "Security",
            "User Acceptance"});
            this.Tag.MinimumWidth = 6;
            this.Tag.Name = "Tag";
            this.Tag.Width = 125;
            // 
            // PreCondition
            // 
            this.PreCondition.HeaderText = "Pre-Condition";
            this.PreCondition.MinimumWidth = 6;
            this.PreCondition.Name = "PreCondition";
            this.PreCondition.Width = 125;
            // 
            // TestSteps
            // 
            this.TestSteps.HeaderText = "Test Steps";
            this.TestSteps.MinimumWidth = 6;
            this.TestSteps.Name = "TestSteps";
            this.TestSteps.Width = 125;
            // 
            // ExpectedBehaviour
            // 
            this.ExpectedBehaviour.HeaderText = "ExpectedBehaviour";
            this.ExpectedBehaviour.MinimumWidth = 6;
            this.ExpectedBehaviour.Name = "ExpectedBehaviour";
            this.ExpectedBehaviour.Width = 125;
            // 
            // ButtonTestCasesDetailedView
            // 
            this.ButtonTestCasesDetailedView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTestCasesDetailedView.Location = new System.Drawing.Point(202, 516);
            this.ButtonTestCasesDetailedView.Name = "ButtonTestCasesDetailedView";
            this.ButtonTestCasesDetailedView.Size = new System.Drawing.Size(184, 43);
            this.ButtonTestCasesDetailedView.TabIndex = 11;
            this.ButtonTestCasesDetailedView.Text = "Detailed View";
            this.ButtonTestCasesDetailedView.UseVisualStyleBackColor = true;
            this.ButtonTestCasesDetailedView.Click += new System.EventHandler(this.ButtonTestCasesDetailedView_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1220, 767);
            this.Controls.Add(this.PanelTestCases);
            this.Controls.Add(this.PanelSetupTestPlan);
            this.Controls.Add(this.ButtonWModeForeground);
            this.Controls.Add(this.ButtonWModeBackground);
            this.Controls.Add(this.LabelWindowLightMode);
            this.Controls.Add(this.ButtonGitHub);
            this.Controls.Add(this.ButtonDownloadXLS);
            this.Controls.Add(this.ButtonSummary);
            this.Controls.Add(this.ButtonResults);
            this.Controls.Add(this.ButtonTestCases);
            this.Controls.Add(this.ButtonMinimize);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonLinkedIn);
            this.Controls.Add(this.LabelAbout);
            this.Controls.Add(this.ButtonSetupTestPlan);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PanelSetupTestPlan.ResumeLayout(false);
            this.PanelSetupTestPlan.PerformLayout();
            this.PanelSetupTestPlanContinuation.ResumeLayout(false);
            this.PanelSetupTestPlanContinuation.PerformLayout();
            this.PanelTestCases.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTestCases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSetupTestPlan;
        private System.Windows.Forms.Label LabelAbout;
        private System.Windows.Forms.Button ButtonLinkedIn;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonMinimize;
        private System.Windows.Forms.Button ButtonTestCases;
        private System.Windows.Forms.Button ButtonSummary;
        private System.Windows.Forms.Button ButtonResults;
        private System.Windows.Forms.Button ButtonDownloadXLS;
        private System.Windows.Forms.Button ButtonGitHub;
        private System.Windows.Forms.Label LabelWindowLightMode;
        private System.Windows.Forms.Button ButtonWModeBackground;
        private System.Windows.Forms.Button ButtonWModeForeground;
        private System.Windows.Forms.Panel PanelSetupTestPlan;
        private System.Windows.Forms.Label LabelSetupTestPlanIntroduction;
        private System.Windows.Forms.Label LabelSetupTestPlanName;
        private System.Windows.Forms.TextBox TextBoxSetupTestPlanName;
        private System.Windows.Forms.RichTextBox RichTextBoxSetupTestPlanIntroduction;
        private System.Windows.Forms.RichTextBox RichTextBoxSetupTestPlanScope;
        private System.Windows.Forms.Label LabelSetupTestPlanScope;
        private System.Windows.Forms.RichTextBox RichTextBoxSetupTestPlanEnvironment;
        private System.Windows.Forms.Label LabelSetupTestPlanEnvironment;
        private System.Windows.Forms.Button ButtonSetupTestPlanSave;
        private System.Windows.Forms.Button ButtonSetupTestPlanCancel;
        private System.Windows.Forms.Panel PanelSetupTestPlanContinuation;
        private System.Windows.Forms.Button ButtonSetupTestPlanFinish;
        private System.Windows.Forms.Button ButtonSetupTestPlanAddTestCase;
        private System.Windows.Forms.ComboBox ComboBoxSetupTestPlanComponent;
        private System.Windows.Forms.ComboBox ComboBoxSetupTestPlanType;
        private System.Windows.Forms.ComboBox ComboBoxSetupTestPlanTestArea;
        private System.Windows.Forms.Label LabelSetupTestPlanComponent;
        private System.Windows.Forms.Label LabelSetupTestPlanType;
        private System.Windows.Forms.Label LabelSetupTestPlanTestArea;
        private System.Windows.Forms.Label LabelSetupTestPlanTestOutput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LabelSetupTestPlanTestCaseName;
        private System.Windows.Forms.Panel PanelTestCases;
        private System.Windows.Forms.DataGridView DataGridViewTestCases;
        private System.Windows.Forms.Button ButtonTestCasesRemove;
        private System.Windows.Forms.Button ButtonTestCasesSave;
        private System.Windows.Forms.Button ButtonTestCasesDetailedView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Component;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestScenario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestSteps;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpectedBehaviour;
    }
}

