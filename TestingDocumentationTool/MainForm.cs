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

namespace TestingDocumentationTool
{
    public partial class MainWindow : Form
    {
        string AvailableLightMode;
        public MainWindow()
        {
            InitializeComponent();
            AvailableLightMode = "DARK MODE";
            LabelWindowLightMode.Text = AvailableLightMode;
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

        }

        private void ButtonTestCases_Click(object sender, EventArgs e)
        {

        }

        private void ButtonResults_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSummary_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDownloadXLS_Click(object sender, EventArgs e)
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
            ButtonSetupTestPlan.Image = Image.FromFile("..\\..\\..\\static\\setupDarkMode.png");
            ButtonTestCases.Image = Image.FromFile("..\\..\\..\\static\\testDarkMode.png");
            ButtonResults.Image = Image.FromFile("..\\..\\..\\static\\resultsDarkMode.png");
            ButtonSummary.Image = Image.FromFile("..\\..\\..\\static\\summaryDarkMode.png");
            ButtonDownloadXLS.Image = Image.FromFile("..\\..\\..\\static\\downloadXlsDarkMode.png");

            ButtonClose.Image = Image.FromFile("..\\..\\..\\static\\closeWDarkMode.png");
            ButtonMinimize.Image = Image.FromFile("..\\..\\..\\static\\minimizeDarkMode.png");
            ButtonLinkedIn.Image = Image.FromFile("..\\..\\..\\static\\linkedinDarkMode.png");
            ButtonGitHub.Image = Image.FromFile("..\\..\\..\\static\\githubDarkMode.png");

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

            ButtonSetupTestPlan.Image = Image.FromFile("..\\..\\..\\static\\setup.png");
            ButtonTestCases.Image = Image.FromFile("..\\..\\..\\static\\test.png");
            ButtonResults.Image = Image.FromFile("..\\..\\..\\static\\results.png");
            ButtonSummary.Image = Image.FromFile("..\\..\\..\\static\\summary.png");
            ButtonDownloadXLS.Image = Image.FromFile("..\\..\\..\\static\\downloadXls.png");

            ButtonClose.Image = Image.FromFile("..\\..\\..\\static\\closeW.png");
            ButtonMinimize.Image = Image.FromFile("..\\..\\..\\static\\minimize.png");
            ButtonLinkedIn.Image = Image.FromFile("..\\..\\..\\static\\linkedin.png");
            ButtonGitHub.Image = Image.FromFile("..\\..\\..\\static\\github.png");

            Refresh();
        }
    }
}
