﻿using OpenQA.Selenium;

namespace OrangeHRMTest.Elements
{
    public class ButtonElement
    {
        private readonly IWebElement _webElement;

        public ButtonElement(IWebElement webElement)
        {
            _webElement = webElement;
        }

        public void Click()
        {
            _webElement.Click();
        }
    }
}
