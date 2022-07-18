using TechTalk.SpecFlow;

namespace Current_Project
{
    [Binding]
    public class Before_hook : Hook
    {

        [BeforeScenario(tags:"tag1")]
        public void FirstBeforeScenario()
        {
           
        }

    }
}