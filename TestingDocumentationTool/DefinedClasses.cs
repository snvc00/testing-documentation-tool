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
        public Dictionary<string, int> Component_Quantity;
        public string FunctionalNewFeatures;
        public string FunctionalEnhacenments;
        public string NonFunctionalNewFeatures;
        public string NonFunctionalEnhacenments;

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
            this.TestCases = new List<TestCase>();
            this.Component_Quantity = new Dictionary<string, int>();
            //InitDictionary();
        }

        private void InitDictionary()
        {
            this.Component_Quantity.Add("", 0);
            this.Component_Quantity.Add("", 0);
            this.Component_Quantity.Add("", 0);
            this.Component_Quantity.Add("", 0);
            this.Component_Quantity.Add("", 0);
            this.Component_Quantity.Add("", 0);
            this.Component_Quantity.Add("", 0);
            this.Component_Quantity.Add("", 0);
            this.Component_Quantity.Add("", 0);
            this.Component_Quantity.Add("", 0);
            this.Component_Quantity.Add("", 0);
            this.Component_Quantity.Add("", 0);
            this.Component_Quantity.Add("", 0);
            this.Component_Quantity.Add("", 0);
            this.Component_Quantity.Add("", 0);
            this.Component_Quantity.Add("", 0);
            this.Component_Quantity.Add("", 0);
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
            EvaluateCategory();
            TestCases.Add(_TestCase);
        }

        void EvaluateCategory()
        {

        }

        public void RemoveTestCase(int _TestCaseIndex)
        {
            TestCases.RemoveAt(_TestCaseIndex);
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
