﻿using System;
using TechTalk.SpecFlow;

namespace TestFeature
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
           
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            
        }
    }
}
