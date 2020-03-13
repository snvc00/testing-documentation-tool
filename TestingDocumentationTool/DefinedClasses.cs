using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingDocumentationTool
{
    class TestPlan
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
        public string FunctionalEnhacenments;
        public string NonFunctionalNewFeatures;
        public string NonFunctionalEnhacenments;
        public int[] FunctionalNewFeaturesResults;
        public int[] FunctionalEnhacenmentsResults;
        public int[] NonFunctionalNewFeaturesResults;
        public int[] NonFunctionalEnhacenmentsResults;

        public TestPlan()
        {
            this.Name = "";
            this.Introduction = "";
            this.SetupEnvironment = "";
            this.Scope = "";
            this.Fixes = "";
            this.Regression = "";
            this.FunctionalNewFeatures = "";
            this.FunctionalEnhacenments = "";
            this.NonFunctionalNewFeatures = "";
            this.NonFunctionalEnhacenments = "";
            this.FunctionalNewFeaturesResults = new int[2];
            this.FunctionalEnhacenmentsResults = new int[2];
            this.NonFunctionalNewFeaturesResults = new int[2];
            this.NonFunctionalEnhacenmentsResults = new int[2];
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

        void EvaluateCategory(TestCase _TestCase)
        {
            //[0] FunctionalNewFeature
            //[1] NonFuncitonalNewFeature
            //[2] FunctionalEnhacenment
            //[3] NonFunctionalEnhacenment

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
            else if (_TestCase.TestArea == "Enhacenment")
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
                FunctionalEnhacenments += key.Value[2].ToString() + ",";
                NonFunctionalEnhacenments += key.Value[3].ToString() + ",";
            }

            FunctionalNewFeatures = FunctionalNewFeatures.Substring(0, FunctionalNewFeatures.Length - 1);
            NonFunctionalNewFeatures = NonFunctionalNewFeatures.Substring(0, NonFunctionalNewFeatures.Length - 1);
            FunctionalEnhacenments = FunctionalEnhacenments.Substring(0, FunctionalEnhacenments.Length - 1);
            NonFunctionalEnhacenments = NonFunctionalEnhacenments.Substring(0, NonFunctionalEnhacenments.Length - 1);
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
                else if (tc.TestArea == "Enhacenment")
                {
                    if (tc.Type == "Functional")
                    {
                        if (tc.Result == "Passed")
                        {
                            FunctionalEnhacenmentsResults[0]++;
                        }
                        else if (tc.Result == "Failed")
                        {
                            FunctionalEnhacenmentsResults[1]++;
                        }
                    }
                    else
                    {
                        if (tc.Result == "Passed")
                        {
                            NonFunctionalEnhacenmentsResults[0]++;
                        }
                        else if (tc.Result == "Failed")
                        {
                            NonFunctionalEnhacenmentsResults[1]++;
                        }
                    }
                }
            }
        }

    }

    class TestCase
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
}
