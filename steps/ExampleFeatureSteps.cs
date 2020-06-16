using System;
using TechTalk.SpecFlow;

namespace specflow_example.StepDefinitions
{
    [Binding]
    public class ExampleFeatureSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public ExampleFeatureSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"precondition")]
        public void GivenPrecondition()
        {
            _scenarioContext.Pending();
        }

        [When(@"action")]
        public void WhenAction()
        {
            _scenarioContext.Pending();
        }

        [Then(@"testable outcome")]
        public void ThenTestableOutcome()
        {
            _scenarioContext.Pending();
        }
    }
}