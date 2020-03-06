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
        public List<TestCase> TestCases;

        public TestPlan()
        {
            this.Name = "";
            this.Introduction = "";
            this.SetupEnvironment = "";
            this.Scope = "";
            this.TestCases = new List<TestCase>();
        }

        public IReadOnlyList<TestCase> GetTestCases()
        {
            return TestCases.AsReadOnly();
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
}
