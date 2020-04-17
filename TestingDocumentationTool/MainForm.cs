/// <summary>
/// 
/// @ author: Santiago Valle
/// 
/// @ project: testing-documentation-tool
/// 
/// @ description: Main Window definition and functions implementations.
/// 
/// <remarks>
/// 
/// @ classes:
///     MainWindow
/// 
/// @ fields:
///     System.String MainWindow.AvailableLightMode
///     System.Windows.Forms.Panel MainWindow.CurrentPanel
///     TestingDocumentation.Tool.TestPlan MainWindow.TestPlan
///     System.Boolean MainWindow.AvailableSummary
///     
/// @ functions:
///     private void MainWindow.buttonLoadFile_Click(object sender, EventArgs e)
///     private void MainWindow.ButtonSetupTestPlan_Click(object sender, EventArgs e)
///     private void MainWindow.ButtonTestCases_Click(object sender, EventArgs e)
///     private void MainWindow.ButtonResults_Click(object sender, EventArgs e)
///     private void MainWindow.ButtonSummary_Click(object sender, EventArgs e)
///     private void MainWindow.ButtonDownloadXLS_Click(object sender, EventArgs e)
///     private void MainWindow.ButtonGenerateHtmlFile_Click(object sender, EventArgs e)
///     private void MainWindow.ButtonLinkedIn_Click(object sender, EventArgs e)
///     private void MainWindow.ButtonGitHub_Click(object sender, EventArgs e)
///     private void MainWindow.ButtonWModeForeground_Click(object sender, EventArgs e)
///     private void MainWindow.ButtonWModeBackground_Click(object sender, EventArgs e)
///     private void MainWindow.WindowMode()
///     private void MainWindow.DarkMode()
///     private void MainWindow.LightMode()
///     private void MainWindow.ButtonSetupTestPlanCancel_Click(object sender, EventArgs e)
///     private void MainWindow.ButtonSetupTestPlanSave_Click(object sender, EventArgs e)
///     private void MainWindow.ButtonSetupTestPlanFinish_Click(object sender, EventArgs e)
///     private void MainWindow.ButtonSetupTestPlanAddTestCase_Click(object sender, EventArgs e)
///     private void MainWindow.ButtonTestCasesSave_Click(object sender, EventArgs e)
///     private void MainWindow.ButtonTestCasesRemove_Click(object sender, EventArgs e)
///     private void MainWindow.ButtonTestCasesDetailedView_Click(object sender, EventArgs e)
///     private void MainWindow.ButtonTestCasesDetailedExit_Click(object sender, EventArgs e)
///     private void MainWindow.FillDataGridViewTestCases()
///     private void MainWindow.ComboBoxSelectTestCase_SelectedIndexChanged(object sender, EventArgs e)
///     private void MainWindow.ButtonTestCasesDetailedViewExit_Click(object sender, EventArgs e)
///     private void MainWindow.ButtonTestCasesDetailedViewRemove_Click(object sender, EventArgs e)
///     private void MainWindow.ButtonResultSave_Click(object sender, EventArgs e)
///     private void MainWindow.ButtonResultCancel_Click(object sender, EventArgs e)
///     private void MainWindow.ButtonTestCasesDetailedViewSave_Click(object sender, EventArgs e)
///     private void MainWindow.ComboBoxResultSelectTestCase_SelectedIndexChanged(object sender, EventArgs e)
///     private void MainWindow.ButtonSummaryOk_Click(object sender, EventArgs e)
///     private void MainWindow.ButtonPanelHTMLOpenInBrowser_Click(object sender, EventArgs e)
///     private void MainWindow.OpenXlsxReport_Click(object sender, EventArgs e)
///     private void MainWindow.CreateReportHTML()
///     public void MainWindow.EditBarChartDatasets()
///     private void MainWindow.EditPieChartDatasets()
///     public void MainWindow.ButtonColorAnimation(Button button, Color color)
/// 
/// </remarks>
/// 
///     @ namespace: TestingDocumentationTool
/// 
/// </summary>


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace TestingDocumentationTool
{   
    public partial class MainWindow : Form
    {
        string AvailableLightMode;
        Panel CurrentPanel;
        TestPlan TestPlan;
        bool AvailableSummary;

        public MainWindow()
        {
            InitializeComponent();
            AvailableLightMode = "DARK MODE";
            LabelWindowLightMode.Text = AvailableLightMode;
            TestPlan = new TestPlan();
            AvailableSummary = false;
        }

        // App Functionality Buttons
        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            try
            {
                Excel excelFile = new Excel("report.xlsx", this.NotifyLoadFile);
                excelFile.LoadData(this.TestPlan);
                NotifyLoadFile.ShowBalloonTip(100, "Data Retrieved", "Data loaded from: report.xlsx successfully", ToolTipIcon.Info);
            }
            catch
            {
                NotifyLoadFile.ShowBalloonTip(100, "Error", "Error trying to retrieve data from: report.xlsx", ToolTipIcon.Error);
            }
        }

        private void ButtonSetupTestPlan_Click(object sender, EventArgs e)
        {
            TextBoxSetupTestPlanName.Text = TestPlan.Name;
            RichTextBoxSetupTestPlanIntroduction.Text = TestPlan.Introduction;
            RichTextBoxSetupTestPlanEnvironment.Text = TestPlan.SetupEnvironment;
            RichTextBoxSetupTestPlanScope.Text = TestPlan.Scope;

            if (CurrentPanel != null)
                CurrentPanel.Hide();

            PanelSetupTestPlan.Show();
            CurrentPanel = PanelSetupTestPlan;
        }

        private void ButtonTestCases_Click(object sender, EventArgs e)
        {
            PanelSetupTestPlan.Hide();

            if (CurrentPanel != null)
                CurrentPanel.Hide();

            PanelTestCases.Show();
            CurrentPanel = PanelTestCases;

            FillDataGridViewTestCases();
        }

        private void ButtonResults_Click(object sender, EventArgs e)
        {
            if (CurrentPanel != null)
                CurrentPanel.Hide();

            PanelResults.Show();
            CurrentPanel = PanelResults;

            ComboBoxResultSelectTestCase.BeginUpdate();
            ComboBoxResultSelectTestCase.DataSource = TestPlan.GetTestCases().ToList();
            ComboBoxResultSelectTestCase.EndUpdate();
            ComboBoxResultSelectTestCase.Refresh();

            TextBoxResultTestPlanFixes.Text = TestPlan.Fixes;
            TextBoxResultTestPlanRegression.Text = TestPlan.Regression;
        }

        private void ButtonSummary_Click(object sender, EventArgs e)
        {
            AvailableSummary = true;

            if (CurrentPanel != null)
                CurrentPanel.Hide();

            PanelSummary.Show();
            CurrentPanel = PanelSummary;
            CurrentPanel.Refresh();

            if (AvailableLightMode == "LIGHT MODE")
            {
                PictureBoxSummary.Image = Image.FromFile("..\\..\\..\\static\\availableSummary.png");
                PictureBoxSummary.Refresh();
                ButtonDownloadXLS.Image = Image.FromFile("..\\..\\..\\static\\downloadXlsDarkMode.png");
                ButtonGenerateHtmlFile.Image = Image.FromFile("..\\..\\..\\static\\generateHtmlFileDarkMode.png");
                ButtonGenerateHtmlFile.ForeColor = Color.White;
                ButtonDownloadXLS.ForeColor = Color.White;
            }
            else
            {
                PictureBoxSummary.Image = Image.FromFile("..\\..\\..\\static\\availableSummary.png");
                ButtonDownloadXLS.Image = Image.FromFile("..\\..\\..\\static\\downloadXls.png");
                ButtonGenerateHtmlFile.Image = Image.FromFile("..\\..\\..\\static\\generateHtmlFile.png");
                ButtonGenerateHtmlFile.ForeColor = Color.Black;
                ButtonDownloadXLS.ForeColor = Color.Black;
            }

            NotifyLoadFile.ShowBalloonTip(100, "Summary Created", "HTML and XLSX report creation enabled", ToolTipIcon.Info);
            Refresh();
        }

        private void ButtonDownloadXLS_Click(object sender, EventArgs e)
        {
            if (AvailableSummary)
            {
                if (CurrentPanel != null)
                    CurrentPanel.Hide();

                OpenXlsxReport.Visible = true;
                OpenXlsxReport.BringToFront();
                PanelReportCreated.Show();
                CurrentPanel = PanelReportCreated;
                CurrentPanel.Refresh();

                PictureBoxPanelHTML.Image = Image.FromFile("..\\..\\..\\static\\report-created.png");
                PictureBoxPanelHTML.Refresh();
                CurrentPanel.Refresh();

                Excel workbook = new Excel("report.xlsx", this.NotifyLoadFile);
                workbook.PerformChanges(this.TestPlan);
                NotifyLoadFile.ShowBalloonTip(100, "XLSX Report Available", "Path: " + workbook.GetFilePath(), ToolTipIcon.Info);
            }
        }

        private void ButtonGenerateHtmlFile_Click(object sender, EventArgs e)
        {
            if (AvailableSummary)
            {
                // Modify HTML template
                CreateReportHTML();

                // Modify Dataset in chart-bar.js
                EditBarChartDatasets();
                
                // Modify Dataset in chart-pie.js
                EditPieChartDatasets();

                if (CurrentPanel != null)
                    CurrentPanel.Hide();

                ButtonPanelHTMLOpenInBrowser.Visible = true;
                ButtonPanelHTMLOpenInBrowser.BringToFront();
                PanelReportCreated.Show();
                CurrentPanel = PanelReportCreated;
                CurrentPanel.Refresh();

                PictureBoxPanelHTML.Image = Image.FromFile("..\\..\\..\\static\\report-created.png");
                PictureBoxPanelHTML.Refresh();
                CurrentPanel.Refresh();

                string path = Path.GetFullPath(Directory.GetCurrentDirectory() + "\\..\\..\\..\\template\\report.html");
                NotifyLoadFile.ShowBalloonTip(100, "HTML Report Available", "Path: " + path, ToolTipIcon.Info);
                TestPlan.ClearResults();
            }
        }

        // Extra Buttons

        private void ButtonLinkedIn_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/santiago-valle-463130194/");
        }

        private void ButtonGitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/snvc00");
        }
    

        private void ButtonWModeForeground_Click(object sender, EventArgs e)
        {
            WindowMode();
        }

        private void ButtonWModeBackground_Click(object sender, EventArgs e)
        {
            WindowMode();
        }

        private void WindowMode()
        {
            if (AvailableLightMode == "DARK MODE")
            {
                // Dark Mode Setup
                DarkMode();
                ButtonWModeBackground.BackColor = Color.LightGreen;
                ButtonWModeForeground.Location = new Point(ButtonWModeForeground.Location.X + 30, ButtonWModeForeground.Location.Y);
                AvailableLightMode = "LIGHT MODE";
            }
            else
            {
                // Light Mode Setup
                LightMode();
                ButtonWModeBackground.BackColor = Color.LightGray;
                ButtonWModeForeground.Location = new Point(ButtonWModeForeground.Location.X - 30, ButtonWModeForeground.Location.Y);
                AvailableLightMode = "DARK MODE";
            }
        }

        private void DarkMode()
        {
            BackColor = Color.FromArgb(40, 40, 40);
            LabelAbout.ForeColor = Color.White;
            LabelWindowLightMode.ForeColor = Color.White;
            ButtonSetupTestPlan.ForeColor = Color.White;
            ButtonTestCases.ForeColor = Color.White;
            ButtonResults.ForeColor = Color.White;
            ButtonSummary.ForeColor = Color.White;
            ButtonDownloadXLS.ForeColor = Color.White;
            ButtonGenerateHtmlFile.ForeColor = Color.White;

            ButtonSetupTestPlan.Image = Image.FromFile("..\\..\\..\\static\\setupDarkMode.png");
            ButtonTestCases.Image = Image.FromFile("..\\..\\..\\static\\testDarkMode.png");
            ButtonResults.Image = Image.FromFile("..\\..\\..\\static\\resultsDarkMode.png");
            ButtonSummary.Image = Image.FromFile("..\\..\\..\\static\\summaryDarkMode.png");
            ButtonLoadFile.Image = Image.FromFile("..\\..\\..\\static\\folderDarkMode.png");

            if (AvailableSummary)
            {
                ButtonDownloadXLS.Image = Image.FromFile("..\\..\\..\\static\\downloadXlsDarkMode.png");
                ButtonGenerateHtmlFile.Image = Image.FromFile("..\\..\\..\\static\\generateHtmlFileDarkMode.png");
            }

            ButtonLinkedIn.Image = Image.FromFile("..\\..\\..\\static\\linkedinDarkMode.png");
            ButtonGitHub.Image = Image.FromFile("..\\..\\..\\static\\githubDarkMode.png");

            // Setup test plan panel
            TextBoxSetupTestPlanName.ForeColor = Color.White;
            RichTextBoxSetupTestPlanIntroduction.ForeColor = Color.White;
            RichTextBoxSetupTestPlanEnvironment.ForeColor = Color.White;
            RichTextBoxSetupTestPlanScope.ForeColor = Color.White;

            TextBoxSetupTestPlanName.BackColor = Color.FromArgb(40, 40, 40);
            RichTextBoxSetupTestPlanIntroduction.BackColor = Color.FromArgb(40, 40, 40);
            RichTextBoxSetupTestPlanEnvironment.BackColor = Color.FromArgb(40, 40, 40);
            RichTextBoxSetupTestPlanScope.BackColor = Color.FromArgb(40, 40, 40);

            LabelSetupTestPlanName.ForeColor = Color.White;
            LabelSetupTestPlanIntroduction.ForeColor = Color.White;
            LabelSetupTestPlanEnvironment.ForeColor = Color.White;
            LabelSetupTestPlanScope.ForeColor = Color.White;

            ButtonSetupTestPlanCancel.ForeColor = Color.White;
            ButtonSetupTestPlanSave.ForeColor = Color.White;
            ButtonSetupTestPlanSave.BackColor = Color.FromArgb(40, 40, 40);

            // Setup test panel continuation
            LabelSetupTestPlanTestArea.ForeColor = Color.White;
            LabelSetupTestPlanType.ForeColor = Color.White;
            LabelSetupTestPlanComponent.ForeColor = Color.White;
            LabelSetupTestPlanTestCaseName.ForeColor = Color.White;

            ButtonSetupTestPlanAddTestCase.ForeColor = Color.White;
            ButtonSetupTestPlanFinish.ForeColor = Color.White;
            ButtonSetupTestPlanFinish.BackColor = Color.FromArgb(40, 40, 40);

            // Test cases panel
            ButtonTestCasesDetailedView.ForeColor = Color.White;
            ButtonTestCasesRemove.ForeColor = Color.White;
            ButtonTestCasesSave.ForeColor = Color.White;
            ButtonTestCasesSave.BackColor = Color.FromArgb(40, 40, 40);
            ButtonTestCasesDetailedExit.ForeColor = Color.White;
            ButtonTestCasesDetailedExit.BackColor = Color.FromArgb(40, 40, 40);

            // Test cases panel detailed view
            LabelSelectTestCase.ForeColor = Color.White;
            ButtonTestCasesDetailedViewExit.BackColor = Color.FromArgb(40, 40, 40);
            ButtonTestCasesDetailedViewExit.ForeColor = Color.White;
            ButtonTestCasesDetailedViewSave.BackColor = Color.FromArgb(40, 40, 40);
            ButtonTestCasesDetailedViewSave.ForeColor = Color.White;
            ButtonTestCasesDetailedViewRemove.BackColor = Color.FromArgb(40, 40, 40);
            ButtonTestCasesDetailedViewRemove.ForeColor = Color.White;
            LabelTestCaseDetailedViewID.ForeColor = Color.White;
            LabelTestCaseDetailedViewTag.ForeColor = Color.White;
            LabelTestCaseDetailedViewDescription.ForeColor = Color.White;
            LabelTestCaseDetailedViewSteps.ForeColor = Color.White;
            LabelTestCaseDetailedViewExpectedBehavior.ForeColor = Color.White;
            LabelTestCaseDetailedViewScenario.ForeColor = Color.White;
            LabelTestCaseDetailedViewConditions.ForeColor = Color.White;
            /// ALL TEXTBOX COULD BE CHANGED

            // Results panel
            LabelResultSelectTestCase.ForeColor = Color.White;
            LabelResultNotes.ForeColor = Color.White;
            LabelResultsResult.ForeColor = Color.White;
            LabelResultStatus.ForeColor = Color.White;
            LabelResultTestPlanFixes.ForeColor = Color.White;
            LabelResultTestPlanRegression.ForeColor = Color.White;
            ButtonResultCancel.ForeColor = Color.White;
            ButtonResultCancel.BackColor = Color.FromArgb(40, 40, 40);
            ButtonResultSave.ForeColor = Color.White;
            ButtonResultSave.BackColor = Color.FromArgb(40, 40, 40);

            // Summary panel
            ButtonSummaryOk.ForeColor = Color.White;
            ButtonSummaryOk.BackColor = Color.FromArgb(40, 40, 40);

            // Report panel
            ButtonPanelHTMLOpenInBrowser.ForeColor = Color.White;
            ButtonPanelHTMLOpenInBrowser.BackColor = Color.FromArgb(40, 40, 40);
            OpenXlsxReport.ForeColor = Color.White;
            OpenXlsxReport.BackColor = Color.FromArgb(40, 40, 40);

            Refresh();
        }

        private void LightMode()
        {
            BackColor = Color.White;
            LabelAbout.ForeColor = Color.Black;
            LabelWindowLightMode.ForeColor = Color.Black;
            ButtonSetupTestPlan.ForeColor = Color.Black;
            ButtonTestCases.ForeColor = Color.Black;
            ButtonResults.ForeColor = Color.Black;
            ButtonSummary.ForeColor = Color.Black;
            ButtonDownloadXLS.ForeColor = Color.Black;
            ButtonGenerateHtmlFile.ForeColor = Color.Black;

            ButtonSetupTestPlan.Image = Image.FromFile("..\\..\\..\\static\\setup.png");
            ButtonTestCases.Image = Image.FromFile("..\\..\\..\\static\\test.png");
            ButtonResults.Image = Image.FromFile("..\\..\\..\\static\\results.png");
            ButtonSummary.Image = Image.FromFile("..\\..\\..\\static\\summary.png");
            ButtonLoadFile.Image = Image.FromFile("..\\..\\..\\static\\folder.png");

            if (AvailableSummary)
            {
                ButtonDownloadXLS.Image = Image.FromFile("..\\..\\..\\static\\downloadXls.png");
                ButtonGenerateHtmlFile.Image = Image.FromFile("..\\..\\..\\static\\generateHtmlFile.png");
            }

            ButtonLinkedIn.Image = Image.FromFile("..\\..\\..\\static\\linkedin.png");
            ButtonGitHub.Image = Image.FromFile("..\\..\\..\\static\\github.png");

            // Setup test plan panel
            TextBoxSetupTestPlanName.ForeColor = Color.Black;
            RichTextBoxSetupTestPlanIntroduction.ForeColor = Color.Black;
            RichTextBoxSetupTestPlanEnvironment.ForeColor = Color.Black;
            RichTextBoxSetupTestPlanScope.ForeColor = Color.Black;

            TextBoxSetupTestPlanName.BackColor = Color.White;
            RichTextBoxSetupTestPlanIntroduction.BackColor = Color.White;
            RichTextBoxSetupTestPlanEnvironment.BackColor = Color.White;
            RichTextBoxSetupTestPlanScope.BackColor = Color.White;

            LabelSetupTestPlanName.ForeColor = Color.Black;
            LabelSetupTestPlanIntroduction.ForeColor = Color.Black;
            LabelSetupTestPlanEnvironment.ForeColor = Color.Black;
            LabelSetupTestPlanScope.ForeColor = Color.Black;

            ButtonSetupTestPlanCancel.ForeColor = Color.Black;
            ButtonSetupTestPlanSave.ForeColor = Color.Black;
            ButtonSetupTestPlanSave.BackColor = Color.White;

            // Setup test panel continuation
            LabelSetupTestPlanTestArea.ForeColor = Color.Black;
            LabelSetupTestPlanType.ForeColor = Color.Black;
            LabelSetupTestPlanComponent.ForeColor = Color.Black;
            LabelSetupTestPlanTestCaseName.ForeColor = Color.Black;

            ButtonSetupTestPlanAddTestCase.ForeColor = Color.Black;
            ButtonSetupTestPlanFinish.ForeColor = Color.Black;
            ButtonSetupTestPlanFinish.BackColor = Color.White;

            // Test cases panel
            ButtonTestCasesDetailedView.ForeColor = Color.Black;
            ButtonTestCasesRemove.ForeColor = Color.Black;
            ButtonTestCasesSave.ForeColor = Color.Black;
            ButtonTestCasesSave.BackColor = Color.White;
            ButtonTestCasesDetailedExit.ForeColor = Color.Black;
            ButtonTestCasesDetailedExit.BackColor = Color.White;

            // Test cases panel detailed view
            LabelSelectTestCase.ForeColor = Color.Black;
            ButtonTestCasesDetailedViewExit.BackColor = Color.White;
            ButtonTestCasesDetailedViewExit.ForeColor = Color.Black;
            ButtonTestCasesDetailedViewSave.BackColor = Color.White;
            ButtonTestCasesDetailedViewSave.ForeColor = Color.Black;
            ButtonTestCasesDetailedViewRemove.BackColor = Color.White;
            ButtonTestCasesDetailedViewRemove.ForeColor = Color.Black;
            LabelTestCaseDetailedViewID.ForeColor = Color.Black;
            LabelTestCaseDetailedViewTag.ForeColor = Color.Black;
            LabelTestCaseDetailedViewDescription.ForeColor = Color.Black;
            LabelTestCaseDetailedViewSteps.ForeColor = Color.Black;
            LabelTestCaseDetailedViewExpectedBehavior.ForeColor = Color.Black;
            LabelTestCaseDetailedViewScenario.ForeColor = Color.Black;
            LabelTestCaseDetailedViewConditions.ForeColor = Color.Black;
            /// ALL TEXTBOX COULD BE CHANGED

            // Results panel
            LabelResultSelectTestCase.ForeColor = Color.Black;
            LabelResultNotes.ForeColor = Color.Black;
            LabelResultsResult.ForeColor = Color.Black;
            LabelResultStatus.ForeColor = Color.Black;
            LabelResultTestPlanFixes.ForeColor = Color.Black;
            LabelResultTestPlanRegression.ForeColor = Color.Black;
            ButtonResultCancel.ForeColor = Color.Black;
            ButtonResultCancel.BackColor = Color.White;
            ButtonResultSave.ForeColor = Color.Black;
            ButtonResultSave.BackColor = Color.White;

            // Summary panel
            ButtonSummaryOk.ForeColor = Color.Black;
            ButtonSummaryOk.BackColor = Color.White;

            // Report panel
            ButtonPanelHTMLOpenInBrowser.ForeColor = Color.Black;
            ButtonPanelHTMLOpenInBrowser.BackColor = Color.White;
            OpenXlsxReport.ForeColor = Color.Black;
            OpenXlsxReport.BackColor = Color.White;

            Refresh();
        }

        // Setup Test Plan Panel Functions
        private void ButtonSetupTestPlanCancel_Click(object sender, EventArgs e)
        {
            ButtonColorAnimation(ButtonSetupTestPlanCancel, Color.PaleVioletRed);

            CurrentPanel.Hide();
        }

        private void ButtonSetupTestPlanSave_Click(object sender, EventArgs e)
        {
            TestPlan.Name = TextBoxSetupTestPlanName.Text;
            TestPlan.Introduction = RichTextBoxSetupTestPlanIntroduction.Text;
            TestPlan.SetupEnvironment = RichTextBoxSetupTestPlanEnvironment.Text;
            TestPlan.Scope = RichTextBoxSetupTestPlanScope.Text;

            ButtonColorAnimation(ButtonSetupTestPlanSave, Color.LightGreen);

            CurrentPanel = PanelSetupTestPlanContinuation;
            CurrentPanel.Show();
            CurrentPanel.Refresh();
        }

        // Setup Test Plan Continuation Panel Functions
        private void ButtonSetupTestPlanFinish_Click(object sender, EventArgs e)
        {
            ButtonColorAnimation(ButtonSetupTestPlanFinish, Color.LightGreen);

            CurrentPanel.Hide();
            PanelSetupTestPlan.Hide();
        }

        private void ButtonSetupTestPlanAddTestCase_Click(object sender, EventArgs e)
        {
            if (ComboBoxSetupTestPlanTestArea.Text != "" && ComboBoxSetupTestPlanType.Text != "" && ComboBoxSetupTestPlanComponent.Text != "" && textBox1.Text != "")
            {
                TestPlan.AddTestCase(new TestCase(ComboBoxSetupTestPlanTestArea.Text, ComboBoxSetupTestPlanType.Text, ComboBoxSetupTestPlanComponent.Text, textBox1.Text));
                LabelSetupTestPlanTestOutput.ForeColor = Color.LightGreen;
                LabelSetupTestPlanTestOutput.Text = "Test case added successfully";
                CurrentPanel.Refresh();
                Thread.Sleep(2000);
                LabelSetupTestPlanTestOutput.Text = "";
                ComboBoxSetupTestPlanTestArea.Text = "";
                ComboBoxSetupTestPlanType.Text = "";
                ComboBoxSetupTestPlanComponent.Text = "";
                textBox1.Text = "";
            }
            else
            {
                LabelSetupTestPlanTestOutput.ForeColor = Color.PaleVioletRed;
                LabelSetupTestPlanTestOutput.Text = "Select an option for every field";
                CurrentPanel.Refresh();
                Thread.Sleep(2000);
                LabelSetupTestPlanTestOutput.Text = "";
            }



            CurrentPanel = PanelSetupTestPlanContinuation;
        }

        // Test Cases Functions
        private void ButtonTestCasesSave_Click(object sender, EventArgs e)
        {
            ButtonColorAnimation(ButtonTestCasesSave, Color.LightGreen);

            for (int i = 0; i < TestPlan.GetTestCases().Count; ++i)
            {
                TestPlan.GetTestCases()[i].TestScenario = (string)DataGridViewTestCases.Rows[i].Cells[4].Value;
                TestPlan.GetTestCases()[i].Description = (string)DataGridViewTestCases.Rows[i].Cells[5].Value;
                TestPlan.GetTestCases()[i].Tag = (string)DataGridViewTestCases.Rows[i].Cells[6].Value.ToString();
                TestPlan.GetTestCases()[i].PreConditions = (string)DataGridViewTestCases.Rows[i].Cells[7].Value;
                TestPlan.GetTestCases()[i].Steps = (string)DataGridViewTestCases.Rows[i].Cells[8].Value;
                TestPlan.GetTestCases()[i].ExpectedBehaviour = (string)DataGridViewTestCases.Rows[i].Cells[9].Value;
            }

        }

        private void ButtonTestCasesRemove_Click(object sender, EventArgs e)
        {
            ButtonTestCasesDetailedView_Click(sender, e);
        }

        private void ButtonTestCasesDetailedView_Click(object sender, EventArgs e)
        {
            CurrentPanel.Hide();
            CurrentPanel = PanelTestCasesDetailedView;
            CurrentPanel.Show();
            CurrentPanel.Refresh();

            ComboBoxSelectTestCase.BeginUpdate();
            ComboBoxSelectTestCase.DataSource = TestPlan.GetTestCases().ToList();
        }
        private void ButtonTestCasesDetailedExit_Click(object sender, EventArgs e)
        {
            ButtonColorAnimation(ButtonTestCasesDetailedExit, Color.PaleVioletRed);

            CurrentPanel.Hide();
            CurrentPanel.Refresh();
            CurrentPanel = null;
        }

        private void FillDataGridViewTestCases()
        {
            DataGridViewTestCases.Rows.Clear();

            if (TestPlan.GetTestCases() != null && TestPlan.GetTestCases().Count > 0)
            {
                TestCase tc;

                for (int i = DataGridViewTestCases.Rows.Count; i < TestPlan.GetTestCases().Count; ++i)
                {
                    tc = TestPlan.GetTestCases()[i];
                    DataGridViewTestCases.Rows.Add(tc.TestArea, tc.Type, tc.Component, tc.ID, tc.TestScenario, tc.Description,(object)tc.Tag, tc.PreConditions, tc.Steps, tc.ExpectedBehaviour);
                }
                
            }       
        }

        // Test cases detailed view functions
        private void ComboBoxSelectTestCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((TestCase)ComboBoxSelectTestCase.SelectedItem != null)
            {
                TestCase tc = (TestCase)ComboBoxSelectTestCase.SelectedItem;
                TextBoxTestCasesDetailedViewID.Text = tc.ID;
                ComboBoxTestCasesDetailedViewTag.Text = tc.Tag;
                TextBoxTestCasesDetailedViewDescription.Text = tc.Description;
                TextBoxTestCasesDetailedViewSteps.Text = tc.Steps;
                TextBoxTestCasesDetailedViewBehavior.Text = tc.ExpectedBehaviour;
                TextBoxTestCasesDetailedViewScenario.Text = tc.TestScenario;
                TextBoxTestCasesDetailedViewConditions.Text = tc.PreConditions;
            }
        }

        private void ButtonTestCasesDetailedViewExit_Click(object sender, EventArgs e)
        {
            CurrentPanel.Hide();
            CurrentPanel = PanelTestCases;
            PanelTestCases.Show();
            CurrentPanel.Refresh();
        }

        private void ButtonTestCasesDetailedViewRemove_Click(object sender, EventArgs e)
        {
            if (ComboBoxSelectTestCase.SelectedItem != null)
            {
                TestPlan.RemoveTestCase(ComboBoxSelectTestCase.SelectedIndex);
                FillDataGridViewTestCases();
                ComboBoxSelectTestCase.BeginUpdate();
                ComboBoxSelectTestCase.DataSource = TestPlan.GetTestCases().ToList();
                ComboBoxSelectTestCase.EndUpdate();
                ComboBoxSelectTestCase.Refresh();
                
                CurrentPanel.Refresh();
                ButtonColorAnimation(ButtonTestCasesDetailedViewRemove, Color.PaleVioletRed);
            }
        }

        // Results panel functions

        private void ButtonResultSave_Click(object sender, EventArgs e)
        {
            if ((TestCase)ComboBoxResultSelectTestCase.SelectedItem != null)
            {
                TestCase tc = (TestCase)ComboBoxResultSelectTestCase.SelectedItem;

                tc.Status = (string)ComboBoxStatus.SelectedItem;
                tc.Result = (string)ComboBoxResultsResult.SelectedItem;
                tc.Notes = TextBoxResultNotes.Text;
            }

            TestPlan.Fixes = TextBoxResultTestPlanFixes.Text;
            TestPlan.Regression = TextBoxResultTestPlanRegression.Text;

            ButtonColorAnimation(ButtonResultSave, Color.LightGreen);
        }

        private void ButtonResultCancel_Click(object sender, EventArgs e)
        {
            ButtonColorAnimation(ButtonResultCancel, Color.PaleVioletRed);
            CurrentPanel.Hide();
            CurrentPanel.Refresh();
        }

        private void ButtonTestCasesDetailedViewSave_Click(object sender, EventArgs e)
        {
            if (ComboBoxSelectTestCase.SelectedItem != null)
            {
                TestPlan.GetTestCases()[ComboBoxSelectTestCase.SelectedIndex].ID = TextBoxTestCasesDetailedViewID.Text;
                TestPlan.GetTestCases()[ComboBoxSelectTestCase.SelectedIndex].Tag = (string)ComboBoxTestCasesDetailedViewTag.SelectedItem;
                TestPlan.GetTestCases()[ComboBoxSelectTestCase.SelectedIndex].Description = TextBoxTestCasesDetailedViewDescription.Text;
                TestPlan.GetTestCases()[ComboBoxSelectTestCase.SelectedIndex].Steps = TextBoxTestCasesDetailedViewSteps.Text;
                TestPlan.GetTestCases()[ComboBoxSelectTestCase.SelectedIndex].ExpectedBehaviour = TextBoxTestCasesDetailedViewBehavior.Text;
                TestPlan.GetTestCases()[ComboBoxSelectTestCase.SelectedIndex].TestScenario = TextBoxTestCasesDetailedViewScenario.Text;
                TestPlan.GetTestCases()[ComboBoxSelectTestCase.SelectedIndex].PreConditions = TextBoxTestCasesDetailedViewConditions.Text;
                FillDataGridViewTestCases();
                ButtonColorAnimation(ButtonTestCasesDetailedViewSave, Color.LightGreen);
            }
            
        }

        private void ComboBoxResultSelectTestCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            TestCase tc = (TestCase)ComboBoxResultSelectTestCase.SelectedItem;
            TextBoxResultNotes.Text = tc.Notes;

            if (tc.Status != "")
                ComboBoxStatus.Text = tc.Status;

            if (tc.Result != "")
                ComboBoxResultsResult.Text = tc.Result;
        }

        // Summary panel functions

        private void ButtonSummaryOk_Click(object sender, EventArgs e)
        {
            ButtonColorAnimation(ButtonSummaryOk, Color.LightGreen);
            CurrentPanel.Hide();
            CurrentPanel.Refresh();
        }

        // Report panel functions
        private void ButtonPanelHTMLOpenInBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonColorAnimation(ButtonPanelHTMLOpenInBrowser, Color.LightGreen);
                Process.Start("..\\..\\..\\template\\report.html");
            }
            catch
            {
                this.NotifyLoadFile.ShowBalloonTip(100, "Error", "The report.xlsx cannot be opened.", ToolTipIcon.Error);
            }
        }

        private void OpenXlsxReport_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonColorAnimation(OpenXlsxReport, Color.LightGreen);
                Process.Start("..\\..\\..\\workbook\\report.xlsx");
            }
            catch
            {
                this.NotifyLoadFile.ShowBalloonTip(100, "Error", "The report.xlsx cannot be opened.", ToolTipIcon.Error);
            }
        }

        private void CreateReportHTML()
        {
            List<string> htmlDoc = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader("..\\..\\..\\template\\template.html"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        htmlDoc.Add(line);
                    }
                }
            }
            catch
            {
                NotifyLoadFile.ShowBalloonTip(100, "Error", "File is not available", ToolTipIcon.Error);
            }

            if (TestPlan.GetTestCases().Count > 0)
            {
                List<List<string>> TestCasesRows = new List<List<string>>();

                foreach (TestCase tc in TestPlan.GetTestCases())
                    TestCasesRows.Add(new TestCaseTableRow(tc).LinesOfCode);

                int currentLine = 96;

                for (int i = 70; i < htmlDoc.Count; ++i)
                {
                    if (htmlDoc[i].Contains("<!--$start_table_rows-->"))
                    {
                        currentLine = i + 1;
                        break;
                    }
                }

                for (int i = 0; i < TestCasesRows.Count; ++i)
                {
                    for (int j = 0; j < TestCasesRows[i].Count; ++j)
                    {
                        htmlDoc.Insert(currentLine, TestCasesRows[i][j]);
                        ++currentLine;
                    }
                }
            }

            for (int i = 0; i < htmlDoc.Count; ++i)
            {
                if (htmlDoc[i].Contains("$test_plan_name"))
                    htmlDoc[i] = "\t\t\t\t\t<h1 class=\"mt - 4\">" + TestPlan.Name + "</h1><br>";

                if (htmlDoc[i].Contains("$test_plan_introduction"))
                    htmlDoc[i] = "\t\t\t\t\t\t\t<li class=\"breadcrumb - item active\">" + TestPlan.Introduction + "</li>";

                if (htmlDoc[i].Contains("$test_plan_environment"))
                    htmlDoc[i] = "\t\t\t\t\t\t\t<li class=\"breadcrumb - item active\">" + TestPlan.SetupEnvironment + "</li>";

                if (htmlDoc[i].Contains("$test_plan_scope"))
                    htmlDoc[i] = "\t\t\t\t\t\t\t<li class=\"breadcrumb - item active\">" + TestPlan.Scope + "</li>";

                if (htmlDoc[i].Contains("$test_plan_regression"))
                    htmlDoc[i] = "\t\t\t\t\t\t\t<li class=\"breadcrumb - item active\">" + TestPlan.Regression + "</li>";

                if (htmlDoc[i].Contains("$test_plan_fixes"))
                    htmlDoc[i] = "\t\t\t\t\t\t\t<li class=\"breadcrumb - item active\">" + TestPlan.Fixes + "</li>";
            }

            using (StreamWriter sw = new StreamWriter("..\\..\\..\\template\\report.html"))
            {
                foreach (string line in htmlDoc)
                    sw.WriteLine(line);
            }
        }

        public void EditBarChartDatasets()
        {
            List<string> chartBar = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader("..\\..\\..\\template\\assets\\chart-bar.js"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        chartBar.Add(line);
                    }
                }
            }
            catch
            {
                NotifyLoadFile.ShowBalloonTip(100, "Error", "File is not available", ToolTipIcon.Error);
            }

            TestPlan.BuildDatasets();

            chartBar[4] = "dataFunctionalNewFeaturesBar = [" + TestPlan.FunctionalNewFeatures + "];";
            chartBar[5] = "dataFunctionalEnhancementBar = [" + TestPlan.FunctionalEnhancements + "];";
            chartBar[6] = "dataNonFunctionalNewFeaturesBar = [" + TestPlan.NonFunctionalNewFeatures + "];";
            chartBar[7] = "dataNonFunctionalEnhancementBar = [" + TestPlan.NonFunctionalEnhancements + "];";

            using (StreamWriter sw = new StreamWriter("..\\..\\..\\template\\assets\\chart-bar.js"))
            {
                foreach (string line in chartBar)
                    sw.WriteLine(line);
            }
        }

        private void EditPieChartDatasets()
        {
            List<string> chartPie = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader("..\\..\\..\\template\\assets\\chart-pie.js"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        chartPie.Add(line);
                    }
                }
            }
            catch
            {
                NotifyLoadFile.ShowBalloonTip(100, "Error", "File is not available", ToolTipIcon.Error);
            }

            TestPlan.BuildResults();

            chartPie[4] = "dataFunctionalNewFeatures = [" + TestPlan.FunctionalNewFeaturesResults[1].ToString() + ", " + TestPlan.FunctionalNewFeaturesResults[0].ToString() + "];";
            chartPie[5] = "dataFunctionalEnhancements = [" + TestPlan.FunctionalEnhancementsResults[1].ToString() + ", " + TestPlan.FunctionalEnhancementsResults[0].ToString() + "];";
            chartPie[6] = "dataNonFunctionalNewFeatures = [" + TestPlan.NonFunctionalNewFeaturesResults[1].ToString() + ", " + TestPlan.NonFunctionalNewFeaturesResults[0].ToString() + "];";
            chartPie[7] = "dataNonFunctionalEnhancements = [" + TestPlan.NonFunctionalEnhancementsResults[1].ToString() + ", " + TestPlan.NonFunctionalEnhancementsResults[0].ToString() + "];";

            using (StreamWriter sw = new StreamWriter("..\\..\\..\\template\\assets\\chart-pie.js"))
            {
                foreach (string line in chartPie)
                    sw.WriteLine(line);
            }
        }


        // Extra Functionality ->Animations<-
        public void ButtonColorAnimation(Button button, Color color)
        {
            Color lastColor = button.BackColor;
            button.BackColor = color;
            CurrentPanel.Refresh();
            Thread.Sleep(500);
            button.BackColor = lastColor;
        }
    }
}
