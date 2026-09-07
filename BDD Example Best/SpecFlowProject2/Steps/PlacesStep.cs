
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject2.Steps
{
    [Binding]
    public class PlacesSteps
    {
        string city, location, res;

        [Given(@"the city is (.*) And the location is (.*)")]
        public void GivenTheCityIsLondonAndTheLocationIsSouth(string city, string location)
        {
            this.city = city;
            this.location = location;
        }

        [When(@"the users asks for interesting location")]
        public void WhenTheUserAsksForInterestingLocation()
        {
            res = LocationFinder.getInterstingParts(city, location);
        }

        [Then(@"the location is (.*)")]
        public void ThenTheLocationShouldBeGreenwich(string locationOfInterest)
        {
            Assert.AreEqual(locationOfInterest, res);
        }

        private Student stu;

        [Given(@"I have entered following info for Student")]
        public void GivenIHaveEnteredFollowingInfoForStudent(Table x)
        {
            // converting supplied input data directly to an instance of Student
            stu = x.CreateInstance<Student>();
        }

        [When(@"I press the Add button")]
        public void When_I_press_the_Add_button()
        {
        }
    }
}
