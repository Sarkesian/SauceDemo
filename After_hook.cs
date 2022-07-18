using TechTalk.SpecFlow;

namespace Current_Project
{
    [Binding]
    public class After_hook : Hook
    {
        [AfterScenario(tags:"tag1")]
        public void AfterScenario()
        {
            _driver.Quit();
        }
    }
}