using System;
using TechTalk.SpecFlow;


namespace QATest.Steps
{
    [Binding]
    public class AmazonFeatureSteps
    {
        private IWebDriver webDrive;

        [Given(@"I navigate to “www.amazon.com”.")]
        public void NavigateToAmazon()
        {
            webDrive.Navigate().GoToUrl("http://www.amazon.com");
        }

        [When(@"I select the option “Books” in the dropdown next to the search text input criteria\.")]
        public void SelectSearchOption()
        {
            searchOption = webDrive.FindElement(By.Id("searchDropdownBox"));
            searchOption.SelectByValue("Livros");
        }

        [Then(@"I search for “Test automation”.")]
        public void SearchText(string text)
        {
            searchBox = webDrive.FindElement(By.Id("twotabsearchtextbox"));
            searchBox.SendKeys(text);
            searchBox.Submit();
        }

        [Then(@"I select the cheapest book of the page without using any sorting method available\.")]
        public void SelectCheapestBook()
        {
            ScenarioContext.Current.Pending(); //INSERIR A LOGICA
        }

        [When(@"I reach the detailed book page, I check if the name in the header is the same name of the book that I select previously\.")]
        public void VerifyHeader()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
