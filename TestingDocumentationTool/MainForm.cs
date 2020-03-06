using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace TestingDocumentationTool
{
    public partial class MainWindow : Form
    {
        string AvailableLightMode;
        Panel CurrentPanel;
        TestPlan TestPlan;

        /* Login
           Home
           Keyword
           Test Cases
           Test Suites
           Imported Scripts
           Collection
           Parameters
           Templates
           Profiles
           Commands
           Robot Framework
           Products
           Libraries
           Phases
           Users
           Information */

        /* UX
           Functionality
           Performance
           Integration
           Usability
           Security
           User Acceptance */


        public MainWindow()
        {
            InitializeComponent();
            AvailableLightMode = "DARK MODE";
            LabelWindowLightMode.Text = AvailableLightMode;
            TestPlan = new TestPlan();
        }

        // Window Control Buttons
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // App Functionality Buttons

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
            PanelSetupTestPlanContinuation.Hide();
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
        }

        private void ButtonSummary_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDownloadXLS_Click(object sender, EventArgs e)
        {

        }

        private void ButtonGenerateHtmlFile_Click(object sender, EventArgs e)
        {

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
            ButtonDownloadXLS.Image = Image.FromFile("..\\..\\..\\static\\downloadXlsDarkMode.png");
            ButtonGenerateHtmlFile.Image = Image.FromFile("..\\..\\..\\static\\generateHtmlFileDarkMode.png");

            ButtonClose.Image = Image.FromFile("..\\..\\..\\static\\closeWDarkMode.png");
            ButtonMinimize.Image = Image.FromFile("..\\..\\..\\static\\minimizeDarkMode.png");
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
            ButtonDownloadXLS.Image = Image.FromFile("..\\..\\..\\static\\downloadXls.png");
            ButtonGenerateHtmlFile.Image = Image.FromFile("..\\..\\..\\static\\generateHtmlFile.png");

            ButtonClose.Image = Image.FromFile("..\\..\\..\\static\\closeW.png");
            ButtonMinimize.Image = Image.FromFile("..\\..\\..\\static\\minimize.png");
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
                TestPlan.TestCases.Add(new TestCase(ComboBoxSetupTestPlanTestArea.Text, ComboBoxSetupTestPlanType.Text, ComboBoxSetupTestPlanComponent.Text, textBox1.Text));
                LabelSetupTestPlanTestOutput.ForeColor = Color.LightGreen;
                LabelSetupTestPlanTestOutput.Text = "Test case added succesfully";
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

            for (int i = 0; i < TestPlan.TestCases.Count; ++i)
            {
                TestPlan.TestCases[i].TestScenario = (string)DataGridViewTestCases.Rows[i].Cells[4].Value;
                TestPlan.TestCases[i].Description = (string)DataGridViewTestCases.Rows[i].Cells[5].Value;
                TestPlan.TestCases[i].Tag = (string)DataGridViewTestCases.Rows[i].Cells[6].Value.ToString();
                TestPlan.TestCases[i].PreConditions = (string)DataGridViewTestCases.Rows[i].Cells[7].Value;
                TestPlan.TestCases[i].Steps = (string)DataGridViewTestCases.Rows[i].Cells[8].Value;
                TestPlan.TestCases[i].ExpectedBehaviour = (string)DataGridViewTestCases.Rows[i].Cells[9].Value;
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
            ComboBoxSelectTestCase.DataSource = TestPlan.TestCases;
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

                for (int i = DataGridViewTestCases.Rows.Count; i < TestPlan.TestCases.Count; ++i)
                {
                    tc = TestPlan.GetTestCases()[i];
                    DataGridViewTestCases.Rows.Add(tc.TestArea, tc.Type, tc.Component, tc.ID, tc.TestScenario, tc.Description,(object)tc.Tag, tc.PreConditions, tc.Steps, tc.ExpectedBehaviour);
                }
                
            }       
        }

        // Test cases detailed view
        private void ComboBoxSelectTestCase_SelectedIndexChanged(object sender, EventArgs e)
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
                ButtonColorAnimation(ButtonTestCasesDetailedViewRemove, Color.PaleVioletRed);
            }
        }

        private void ButtonTestCasesDetailedViewSave_Click(object sender, EventArgs e)
        {
            if (ComboBoxSelectTestCase.SelectedItem != null)
            {
                TestPlan.TestCases[ComboBoxSelectTestCase.SelectedIndex].ID = TextBoxTestCasesDetailedViewID.Text;
                TestPlan.TestCases[ComboBoxSelectTestCase.SelectedIndex].Tag = (string)ComboBoxTestCasesDetailedViewTag.SelectedItem;
                TestPlan.TestCases[ComboBoxSelectTestCase.SelectedIndex].Description = TextBoxTestCasesDetailedViewDescription.Text;
                TestPlan.TestCases[ComboBoxSelectTestCase.SelectedIndex].Steps = TextBoxTestCasesDetailedViewSteps.Text;
                TestPlan.TestCases[ComboBoxSelectTestCase.SelectedIndex].ExpectedBehaviour = TextBoxTestCasesDetailedViewBehavior.Text;
                TestPlan.TestCases[ComboBoxSelectTestCase.SelectedIndex].TestScenario = TextBoxTestCasesDetailedViewScenario.Text;
                TestPlan.TestCases[ComboBoxSelectTestCase.SelectedIndex].PreConditions = TextBoxTestCasesDetailedViewConditions.Text;
                FillDataGridViewTestCases();
                ButtonColorAnimation(ButtonTestCasesDetailedViewSave, Color.LightGreen);
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
