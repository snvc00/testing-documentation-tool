/// <summary>
/// 
/// @ author: Santiago Valle
/// 
/// @ project: testing-documentation-tool
/// 
/// @ description: Auxiliary classes implementation.
/// 
/// <remarks>
/// 
/// @ classes:
///     TestPlan
///     TestCase
///     TestCaseTableRow
///     Excel
/// 
/// @ fields:
///     System.String TestPlan.Name
///     System.String TestPlan.Introduction
///     System.String TestPlan.SetupEnvironment
///     System.String TestPlan.Scope
///     System.String TestPlan.Fixes
///     System.String TestPlan.Regression
///     System.String TestPlan.FunctionalNewFeatures
///     System.String TestPlan.FunctionalEnhancements
///     System.String TestPlan.NonFunctionalNewFeatures
///     System.String TestPlan.NonFunctionalEnhancements
///     System.Int32[] TestPlan.FunctionalNewFeaturesResults
///     System.Int32[] TestPlan.FunctionalEnhancementsResults
///     System.Int32[] TestPlan.NonFunctionalNewFeaturesResults
///     System.Int32[] TestPlan.NonFunctionalEnhancementsResults
///     System.Collections.Generic.List<TestCase> TestPlan.TestCases
///     System.Collections.Generic.Dictionary<string, int[]> TestPlan.Component_Quantity
///     System.String TestCase.TestArea
///     System.String TestCase.Type
///     System.String TestCase.Component
///     System.String TestCase.ID
///     System.String TestCase.TestScenario
///     System.String TestCase.Description
///     System.String TestCase.Tag
///     System.String TestCase.PreConditions
///     System.String TestCase.Steps
///     System.String TestCase.ExpectedBehaviour
///     System.String TestCase.Notes
///     System.String TestCase.Result
///     System.String TestCase.Status
///     System.Collections.Generic.List<string> TestCaseTableRow.LinesOfCode
///     System.String Excel.FileName
///     Microsoft.Office.Interop.Excel.Application Excel.App
///     Microsoft.Office.Interop.Excel.Workbook Excel.Workbook
///     System.Windows.Forms.NotifyIcon Excel.MainFormNotifyIcon
/// 
/// @ functions:
///     public TestPlan.TestPlan()
///     private void TestPlan.InitDictionary()
///     public IReadOnlyList<TestCase> TestPlan.GetTestCasesReadOnly()
///     public List<TestCase> TestPlan.GetTestCases()
///     public void TestPlan.AddTestCase(TestCase _TestCase)
///     private void TestPlan.EvaluateCategory(TestCase _TestCase)
///     public void TestPlan.RemoveTestCase(int _TestCaseIndex)
///     public void TestPlan.BuildDatasets()
///     public void TestPlan.BuildResults()
///     public TestCase.TestCase()
///     public TestCase.TestCase(string _TestArea, string _Type, string _Component, string _ID)
///     public TestCase.TestCase(TestCase _OtherTestCase)
///     public void TestCase.Clean()
///     public override string TestCase.ToString()
///     public TestCaseTableRow.TestCaseTableRow(TestCase tc)
///     public Excel.Excel(string _fileName, NotifyIcon _mainFormNotifyIcon)
///     public void Excel.PerformChanges(TestPlan _TestPlan)
///     public void Excel.OpenReport()
///     private void Excel.Clear()
///     public void Excel.LoadData(TestPlan _TestPlan)
///     public string Excel.GetFilePath()
/// 
/// </remarks>
/// 
///     @ namespace: TestingDocumentationTool
/// 
/// </summary>


using _Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace TestingDocumentationTool
{
    public class TestPlan
    {
        public string Name;
        public string Introduction;
        public string SetupEnvironment;
        public string Scope;
        public string Fixes;
        public string Regression;
        List<TestCase> TestCases;
        public Dictionary<string, int[]> Component_Quantity;
        public string FunctionalNewFeatures;
        public string FunctionalEnhancements;
        public string NonFunctionalNewFeatures;
        public string NonFunctionalEnhancements;
        public int[] FunctionalNewFeaturesResults;
        public int[] FunctionalEnhancementsResults;
        public int[] NonFunctionalNewFeaturesResults;
        public int[] NonFunctionalEnhancementsResults;

        public TestPlan()
        {
            this.Name = "";
            this.Introduction = "";
            this.SetupEnvironment = "";
            this.Scope = "";
            this.Fixes = "";
            this.Regression = "";
            this.FunctionalNewFeatures = "";
            this.FunctionalEnhancements = "";
            this.NonFunctionalNewFeatures = "";
            this.NonFunctionalEnhancements = "";
            this.FunctionalNewFeaturesResults = new int[2];
            this.FunctionalEnhancementsResults = new int[2];
            this.NonFunctionalNewFeaturesResults = new int[2];
            this.NonFunctionalEnhancementsResults = new int[2];
            this.TestCases = new List<TestCase>();
            this.Component_Quantity = new Dictionary<string, int[]>();
            InitDictionary();
        }

        private void InitDictionary()
        {
            this.Component_Quantity.Add("Login", new int[4]);
            this.Component_Quantity.Add("Home", new int[4]);
            this.Component_Quantity.Add("Keyword", new int[4]);
            this.Component_Quantity.Add("Test Cases", new int[4]);
            this.Component_Quantity.Add("Test Suites", new int[4]);
            this.Component_Quantity.Add("Imported Scripts", new int[4]);
            this.Component_Quantity.Add("Collections", new int[4]);
            this.Component_Quantity.Add("Parameters", new int[4]);
            this.Component_Quantity.Add("Templates", new int[4]);
            this.Component_Quantity.Add("Profiles", new int[4]);
            this.Component_Quantity.Add("Commands", new int[4]);
            this.Component_Quantity.Add("Robot Framework", new int[4]);
            this.Component_Quantity.Add("Products", new int[4]);
            this.Component_Quantity.Add("Libraries", new int[4]);
            this.Component_Quantity.Add("Phases", new int[4]);
            this.Component_Quantity.Add("Users", new int[4]);
            this.Component_Quantity.Add("Tutorial", new int[4]);
        }

        public IReadOnlyList<TestCase> GetTestCasesReadOnly()
        {
            return TestCases.AsReadOnly();
        }

        public List<TestCase> GetTestCases()
        {
            return TestCases;
        }

        public void AddTestCase(TestCase _TestCase)
        {
            EvaluateCategory(_TestCase);
            TestCases.Add(_TestCase);
        }

        private void EvaluateCategory(TestCase _TestCase)
        {
            //[0] FunctionalNewFeature Count
            //[1] NonFuncitonalNewFeature Count
            //[2] FunctionalEnhancement Count
            //[3] NonFunctionalEnhancement Count

            if (_TestCase.TestArea == "New Feature")
            {
                if (_TestCase.Type == "Functional")
                {
                    Component_Quantity[_TestCase.Component][0]++;
                }
                else
                {
                    Component_Quantity[_TestCase.Component][1]++;
                }
            }
            else if (_TestCase.TestArea == "Enhancements")
            {
                if (_TestCase.Type == "Functional")
                {
                    Component_Quantity[_TestCase.Component][2]++;
                }
                else
                {
                    Component_Quantity[_TestCase.Component][3]++;
                }
            }
        }

        public void RemoveTestCase(int _TestCaseIndex)
        {
            TestCases.RemoveAt(_TestCaseIndex);
        }

        public void BuildDatasets()
        {
            foreach (KeyValuePair<string, int[]> key in Component_Quantity)
            {
                FunctionalNewFeatures += key.Value[0].ToString() + ",";
                NonFunctionalNewFeatures += key.Value[1].ToString() + ",";
                FunctionalEnhancements += key.Value[2].ToString() + ",";
                NonFunctionalEnhancements += key.Value[3].ToString() + ",";
            }

            FunctionalNewFeatures = FunctionalNewFeatures.Substring(0, FunctionalNewFeatures.Length - 1);
            NonFunctionalNewFeatures = NonFunctionalNewFeatures.Substring(0, NonFunctionalNewFeatures.Length - 1);
            FunctionalEnhancements = FunctionalEnhancements.Substring(0, FunctionalEnhancements.Length - 1);
            NonFunctionalEnhancements = NonFunctionalEnhancements.Substring(0, NonFunctionalEnhancements.Length - 1);
        }

        public void BuildResults()
        {
            foreach (TestCase tc in TestCases)
            {
                if (tc.TestArea == "New Feature")
                {
                    if (tc.Type == "Functional")
                    {
                        if (tc.Result == "Passed")
                        {
                            FunctionalNewFeaturesResults[0]++;
                        }
                        else if (tc.Result == "Failed")
                        {
                            FunctionalNewFeaturesResults[1]++;
                        }
                    }
                    else
                    {
                        if (tc.Result == "Passed")
                        {
                            NonFunctionalNewFeaturesResults[0]++;
                        }
                        else if (tc.Result == "Failed")
                        {
                            NonFunctionalNewFeaturesResults[1]++;
                        }
                    }
                }
                else if (tc.TestArea == "Enhancement")
                {
                    if (tc.Type == "Functional")
                    {
                        if (tc.Result == "Passed")
                        {
                            FunctionalEnhancementsResults[0]++;
                        }
                        else if (tc.Result == "Failed")
                        {
                            FunctionalEnhancementsResults[1]++;
                        }
                    }
                    else
                    {
                        if (tc.Result == "Passed")
                        {
                            NonFunctionalEnhancementsResults[0]++;
                        }
                        else if (tc.Result == "Failed")
                        {
                            NonFunctionalEnhancementsResults[1]++;
                        }
                    }
                }
            }
        }

    }

    public class TestCase
    {
        public string TestArea;
        public string Type;
        public string Component;
        public string ID;
        public string TestScenario;
        public string Description;
        public string Tag;
        public string PreConditions;
        public string Steps;
        public string ExpectedBehaviour;
        public string Notes;
        public string Result;
        public string Status;

        public TestCase()
        {
            this.TestArea = "";
            this.Type = "";
            this.Component = "";
            this.ID = "";
            this.TestScenario = "";
            this.Description = "";
            this.Tag = "";
            this.PreConditions = "";
            this.Steps = "";
            this.ExpectedBehaviour = "";
            this.Notes = "";
            this.Result = "";
            this.Status = "";
        }

        public TestCase(string _TestArea, string _Type, string _Component, string _ID)
        {
            this.TestArea = _TestArea;
            this.Type = _Type;
            this.Component = _Component;
            this.ID = _ID;
            this.TestScenario = "";
            this.Description = "";
            this.Tag = "";
            this.PreConditions = "";
            this.Steps = "";
            this.ExpectedBehaviour = "";
            this.Notes = "";
            this.Result = "";
            this.Status = "";
        }

        public TestCase(TestCase _OtherTestCase)
        {
            this.TestArea = _OtherTestCase.TestArea;
            this.Type = _OtherTestCase.Type;
            this.Component = _OtherTestCase.Component;
            this.ID = _OtherTestCase.ID;
            this.TestScenario = _OtherTestCase.TestScenario;
            this.Description = _OtherTestCase.Description;
            this.Tag = _OtherTestCase.Tag;
            this.PreConditions = _OtherTestCase.PreConditions;
            this.Steps = _OtherTestCase.Steps;
            this.ExpectedBehaviour = _OtherTestCase.ExpectedBehaviour;
            this.Status = _OtherTestCase.Status;
            this.Result = _OtherTestCase.Result;
            this.Notes = _OtherTestCase.Notes;
        }

        public void Clean()
        {
            this.TestArea = "";
            this.Type = "";
            this.Component = "";
            this.ID = "";
            this.TestScenario = "";
            this.Description = "";
            this.Tag = "";
            this.PreConditions = "";
            this.Steps = "";
            this.ExpectedBehaviour = "";
            this.Notes = "";
        }

        public override string ToString()
        {
            return this.ID;
        }
    }

    class TestCaseTableRow
    {
        public List<string> LinesOfCode;

        public TestCaseTableRow(TestCase tc)
        {
            LinesOfCode = new List<string>();

            LinesOfCode.Add("\t\t\t\t\t\t\t\t\t\t\t<tr>");
            LinesOfCode.Add("\t\t\t\t\t\t\t\t\t\t\t\t<td>" + tc.TestArea + "</td>");
            LinesOfCode.Add("\t\t\t\t\t\t\t\t\t\t\t\t<td>" + tc.Component + "</td>");
            LinesOfCode.Add("\t\t\t\t\t\t\t\t\t\t\t\t<td>" + tc.Type + "</td>");
            LinesOfCode.Add("\t\t\t\t\t\t\t\t\t\t\t\t<td>" + tc.ID + "</td>");
            LinesOfCode.Add("\t\t\t\t\t\t\t\t\t\t\t\t<td>" + tc.TestScenario + "</td>");
            LinesOfCode.Add("\t\t\t\t\t\t\t\t\t\t\t\t<td>" + tc.Description + "</td>");
            LinesOfCode.Add("\t\t\t\t\t\t\t\t\t\t\t\t<td>" + tc.Tag + "</td>");
            LinesOfCode.Add("\t\t\t\t\t\t\t\t\t\t\t\t<td>" + tc.PreConditions + "</td>");
            LinesOfCode.Add("\t\t\t\t\t\t\t\t\t\t\t\t<td>" + tc.Steps + "</td>");
            LinesOfCode.Add("\t\t\t\t\t\t\t\t\t\t\t\t<td>" + tc.ExpectedBehaviour + "</td>");
            LinesOfCode.Add("\t\t\t\t\t\t\t\t\t\t\t\t<td>" + tc.Status + "</td>");
            LinesOfCode.Add("\t\t\t\t\t\t\t\t\t\t\t\t<td>" + tc.Result + "</td>");
            LinesOfCode.Add("\t\t\t\t\t\t\t\t\t\t\t</tr>");
        }
    }

    public class Excel
    {
        string FileName;
        _Excel.Application App;
        _Excel.Workbook Workbook;
        NotifyIcon MainFormNotifyIcon;

        public Excel(string _fileName, NotifyIcon _mainFormNotifyIcon)
        {
            this.FileName = _fileName;
            this.App = new _Excel.Application();
            this.App.DefaultFilePath = Directory.GetCurrentDirectory() + "\\..\\..\\..\\workbook\\";
            this.Workbook = (_Excel.Workbook)App.Workbooks.Open(App.DefaultFilePath + FileName);
            this.MainFormNotifyIcon = _mainFormNotifyIcon;
        }

        public void PerformChanges(TestPlan _TestPlan)
        {
            try
            {
                Clear();

                _TestPlan.BuildDatasets();
                _TestPlan.BuildResults();

                // Test Plan General Information
                App.Worksheets["Test Plan"].Range["E1"].Value = _TestPlan.Name;
                App.Worksheets["Test Plan"].Range["E5"].Value = _TestPlan.Introduction;
                App.Worksheets["Test Plan"].Range["E11"].Value = _TestPlan.SetupEnvironment;
                App.Worksheets["Test Plan"].Range["E15"].Value = _TestPlan.Scope;
                App.Worksheets["Test Plan"].Range["E19"].Value = _TestPlan.Fixes;
                App.Worksheets["Test Plan"].Range["E23"].Value = _TestPlan.Regression;

                // Test Cases
                int row = 2;
                string range;
                _Excel.Range selectedCells;
            
                foreach (TestCase tc in _TestPlan.GetTestCasesReadOnly())
                {
                    App.Worksheets["Test Cases"].Range["A" + row.ToString()].Value = tc.TestArea;
                    App.Worksheets["Test Cases"].Range["B" + row.ToString()].Value = tc.Component;
                    App.Worksheets["Test Cases"].Range["C" + row.ToString()].Value = tc.Type;
                    App.Worksheets["Test Cases"].Range["D" + row.ToString()].Value = tc.ID;
                    App.Worksheets["Test Cases"].Range["E" + row.ToString()].Value = tc.TestScenario;
                    App.Worksheets["Test Cases"].Range["F" + row.ToString()].Value = tc.Description;
                    App.Worksheets["Test Cases"].Range["G" + row.ToString()].Value = tc.Tag;
                    App.Worksheets["Test Cases"].Range["H" + row.ToString()].Value = tc.PreConditions;
                    App.Worksheets["Test Cases"].Range["I" + row.ToString()].Value = tc.Steps;
                    App.Worksheets["Test Cases"].Range["J" + row.ToString()].Value = tc.ExpectedBehaviour;
                    App.Worksheets["Test Cases"].Range["K" + row.ToString()].Value = tc.Status;
                    App.Worksheets["Test Cases"].Range["L" + row.ToString()].Value = tc.Result;

                    range = "A" + row.ToString() + ":" + "L" + row.ToString();
                    selectedCells = App.Worksheets["Test Cases"].Range[range];
                    selectedCells.Borders.Color = Color.LightGray;
                    selectedCells.Borders.Weight = 2;

                    ++row;
                }

                // Passed - Failed
                App.Worksheets["Charts Data"].Range["A4"].Value = _TestPlan.FunctionalNewFeaturesResults[0];
                App.Worksheets["Charts Data"].Range["B4"].Value = _TestPlan.FunctionalNewFeaturesResults[1];
                App.Worksheets["Charts Data"].Range["C4"].Value = _TestPlan.FunctionalNewFeaturesResults[0];
                App.Worksheets["Charts Data"].Range["D4"].Value = _TestPlan.FunctionalNewFeaturesResults[1];
                App.Worksheets["Charts Data"].Range["E4"].Value = _TestPlan.FunctionalNewFeaturesResults[0];
                App.Worksheets["Charts Data"].Range["F4"].Value = _TestPlan.FunctionalNewFeaturesResults[1];
                App.Worksheets["Charts Data"].Range["G4"].Value = _TestPlan.FunctionalNewFeaturesResults[0];
                App.Worksheets["Charts Data"].Range["H4"].Value = _TestPlan.FunctionalNewFeaturesResults[1];

                // General Charts | A == 65, Q == 81.
                string[] functionalNF = _TestPlan.FunctionalNewFeatures.Split(',');
                string[] functionalEN = _TestPlan.FunctionalEnhancements.Split(',');
                string[] nonFunctionalNF = _TestPlan.NonFunctionalNewFeatures.Split(',');
                string[] nonFunctionalEN = _TestPlan.NonFunctionalEnhancements.Split(',');
            
                for (int i = 65; i < 82; ++i)
                {
                    App.Worksheets["Charts Data"].Range[(char)i + "8"].Value = functionalNF[i - 65];
                    App.Worksheets["Charts Data"].Range[(char)i + "12"].Value = functionalEN[i - 65];
                    App.Worksheets["Charts Data"].Range[(char)i + "16"].Value = nonFunctionalNF[i - 65];
                    App.Worksheets["Charts Data"].Range[(char)i + "20"].Value = nonFunctionalEN[i - 65];
                }

                App.ActiveWorkbook.Sheets[1].Select();
                Workbook.Close(true); 
                App.Quit();
            }
            catch
            {
                App.Quit();
                MainFormNotifyIcon.ShowBalloonTip(100, "Error", "An error occurred trying to save changes", ToolTipIcon.Error);
            }
        }

        public void OpenReport()
        {
            Process.Start(App.DefaultFilePath + FileName);
        }

        private void Clear()
        {
            int row = 2;
            string range = "A" + row.ToString() + ":" + "L" + row.ToString();
            _Excel.Range selectedCells = App.Worksheets["Test Cases"].Range[range];

            while (App.Worksheets["Test Cases"].Range["A" + row.ToString()].Value != null || selectedCells.Borders.Color.ToString() != "16119285") // 16119285 == Color.LightGray.ToString()
            {     
                App.Worksheets["Test Cases"].Range["A" + row.ToString()].Value = "";
                App.Worksheets["Test Cases"].Range["B" + row.ToString()].Value = "";
                App.Worksheets["Test Cases"].Range["C" + row.ToString()].Value = "";
                App.Worksheets["Test Cases"].Range["D" + row.ToString()].Value = "";
                App.Worksheets["Test Cases"].Range["E" + row.ToString()].Value = "";
                App.Worksheets["Test Cases"].Range["F" + row.ToString()].Value = "";
                App.Worksheets["Test Cases"].Range["G" + row.ToString()].Value = "";
                App.Worksheets["Test Cases"].Range["H" + row.ToString()].Value = "";
                App.Worksheets["Test Cases"].Range["I" + row.ToString()].Value = "";
                App.Worksheets["Test Cases"].Range["J" + row.ToString()].Value = "";
                App.Worksheets["Test Cases"].Range["K" + row.ToString()].Value = "";
                App.Worksheets["Test Cases"].Range["L" + row.ToString()].Value = "";


                range = "A" + row.ToString() + ":" + "L" + row.ToString();
                selectedCells = App.Worksheets["Test Cases"].Range[range];
                selectedCells.Borders.Color = Color.WhiteSmoke;

                ++row;
            }

            Workbook.Save();
        }

        public void LoadData(TestPlan _TestPlan)
        {
            // Test Plan General Information
            _TestPlan.Name = App.Worksheets["Test Plan"].Range["E1"].Value;
            _TestPlan.Introduction = App.Worksheets["Test Plan"].Range["E5"].Value;
            _TestPlan.SetupEnvironment = App.Worksheets["Test Plan"].Range["E11"].Value;
            _TestPlan.Scope = App.Worksheets["Test Plan"].Range["E15"].Value;
            _TestPlan.Fixes = App.Worksheets["Test Plan"].Range["E19"].Value;
            _TestPlan.Regression = App.Worksheets["Test Plan"].Range["E23"].Value;

            // Test Cases
            int row = 2;
            TestCase tc = new TestCase();

            while (App.Worksheets["Test Cases"].Range["A" + row.ToString()].Value != null)
            { 
                tc.TestArea = App.Worksheets["Test Cases"].Range["A" + row.ToString()].Value.ToString();
                tc.Component = App.Worksheets["Test Cases"].Range["B" + row.ToString()].Value.ToString();
                tc.Type = App.Worksheets["Test Cases"].Range["C" + row.ToString()].Value.ToString();
                tc.ID = App.Worksheets["Test Cases"].Range["D" + row.ToString()].Value.ToString();
                tc.TestScenario = App.Worksheets["Test Cases"].Range["E" + row.ToString()].Value.ToString();
                tc.Description = App.Worksheets["Test Cases"].Range["F" + row.ToString()].Value.ToString();
                tc.Tag = App.Worksheets["Test Cases"].Range["G" + row.ToString()].Value.ToString();
                tc.PreConditions = App.Worksheets["Test Cases"].Range["H" + row.ToString()].Value.ToString();
                tc.Steps = App.Worksheets["Test Cases"].Range["I" + row.ToString()].Value.ToString();
                tc.ExpectedBehaviour = App.Worksheets["Test Cases"].Range["J" + row.ToString()].Value.ToString();
                tc.Status = App.Worksheets["Test Cases"].Range["K" + row.ToString()].Value.ToString();
                tc.Result = App.Worksheets["Test Cases"].Range["L" + row.ToString()].Value.ToString();

                _TestPlan.AddTestCase(new TestCase(tc));

                ++row;
            }

            Workbook.Close(false);
            App.Quit();
        }

        public string GetFilePath()
        {
            return App.DefaultFilePath + FileName;
        }
    }
}
