using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using SeleniumWebDriverTemplateProject;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SeleniumWebDriverTemplateProject.Pages;
using OpenQA.Selenium.Firefox;

namespace SeleniumWebDriverTemplateProject.SimpleTests
{
    [TestFixture]
    class SimpleLoginTest
    {
        private IWebDriver Driver;

        [Test]
        public void Cat()
        {
            IWebDriver Chrome = new ChromeDriver();

            Chrome.Navigate().GoToUrl("http://store.demoqa.com/");

            var GoToAccountButton = Chrome.FindElement(By.CssSelector("#account a"));
            GoToAccountButton.Click();

            var userNameTextBox = Chrome.FindElement(By.Id("log"));
            userNameTextBox.SendKeys("anna");
            var password = Chrome.FindElement(By.Id("pwd"));
            password.SendKeys("anna");

            var loginButton = Chrome.FindElement(By.Id("login"));
            loginButton.Click();

        }
        [Test]
        public void AbvTest()
        {
            IWebDriver Firefox = new FirefoxDriver();
            Firefox.Navigate().GoToUrl("https://www.abv.bg/");

            var userTextBox = Firefox.FindElement(By.Id("username"));
            userTextBox.SendKeys("ani_figo@abv.bg");

            var passwordTextBox = Firefox.FindElement(By.Id("password"));
            passwordTextBox.SendKeys("5625");

            var vhodButton = Firefox.FindElement(By.Id("loginBut"));
            vhodButton.Click();

            Thread.Sleep(10000);



            var IsLogin = Firefox.FindElement(By.Id("gwt-uid-378"));
            string someText = IsLogin.Text;  //!! 
            Assert.AreEqual("ani_figo@abv.bg", someText);


            IsLogin.Click();

            var Exit = Firefox.FindElement(By.Id("gwt-uid-381"));
            Thread.Sleep(1000);
            Exit.Click();

            //var sega = firefox.findelements(by.id("searchfieldinbox")); //masiv 
            //var kakvoe = sega.count;   //poluchenoto chislo 

            //assert.areequal(0,kakvoe);         // expected, actual   

            var NapishiButton = Firefox.FindElements(By.Id("abv-button"));
            var drugaStranicaBroi = NapishiButton.Count;

            Assert.AreEqual(0, drugaStranicaBroi);
            //очкавам да няма няма този елемент на следващата страница и в такъв случай няма да има елементи от горния масив 


            Firefox.Quit();
        }

        [Test]
        public void MusicLoginTest()
        {
            IWebDriver Firefox = new FirefoxDriver();
            Firefox.Navigate().GoToUrl("http://qaf2017demo1-001-site1.dtempurl.com/");

            var logInButton = Firefox.FindElement(By.Id("loginLink"));
            logInButton.Click();

            var emailButton = Firefox.FindElement(By.Id("Email"));
            emailButton.SendKeys("Administrator@Test.com");

            var passButton = Firefox.FindElement(By.Id("Password"));
            passButton.SendKeys("YouShouldChangeThisPassword1!");

            Thread.Sleep(1000);

            var enter = Firefox.FindElement(By.ClassName("btn"));
            enter.Click();

            Thread.Sleep(5000);


            var IsLogin = Firefox.FindElement(By.CssSelector("#logoutForm a"));
            string someText = IsLogin.Text;
            Assert.AreEqual("Hello Administrator@test.com!", someText);



            var logOffbutton = Firefox.FindElement(By.CssSelector("ul.navbar-right > li:nth-child(2) > a:nth-child(1)"));
            logOffbutton.Click();


       var isLogOut = Firefox.FindElements(By.CssSelector("ul.navbar-right > li:nth-child(2) > a:nth-child(1)"));
       var LoginPage = isLogOut.Count;

            Assert.AreEqual(1, LoginPage);

            Thread.Sleep(1000);

            Firefox.Quit();



        }
        [Test]
        public void CompletePurchase()
        {
            IWebDriver Firefox = new FirefoxDriver();
            Firefox.Navigate().GoToUrl("http://qaf2017demo1-001-site1.dtempurl.com/");

            var logInButton = Firefox.FindElement(By.Id("loginLink"));
            logInButton.Click();

            var emailButton = Firefox.FindElement(By.Id("Email"));
            emailButton.SendKeys("Administrator@Test.com");

            var passButton = Firefox.FindElement(By.Id("Password"));
            passButton.SendKeys("YouShouldChangeThisPassword1!");

            Thread.Sleep(1000);

            var enter = Firefox.FindElement(By.ClassName("btn"));
            enter.Click();

            Thread.Sleep(5000);

            var chooseProduct = Firefox.FindElement(By.CssSelector("li.col-lg-2:nth-child(2) > a:nth-child(1)"));
            chooseProduct.Click();

            Thread.Sleep(5000);

            var addToCart = Firefox.FindElement(By.CssSelector(".button > a:nth-child(1)"));
           addToCart.Click();

           Thread.Sleep(5000);

           var CheckoutPage = Firefox.FindElement(By.CssSelector(".button > a:nth-child(1)"));
            CheckoutPage.Click();

            Thread.Sleep(5000);

            var FirstName = Firefox.FindElement(By.Id("FirstName"));
            FirstName.SendKeys("Anna");

            var LastName = Firefox.FindElement(By.Id("LastName"));
            LastName.SendKeys("Ilieva");

            var Adress = Firefox.FindElement(By.Id("Address"));
            Adress.SendKeys("Sofia");
            
            var City = Firefox.FindElement(By.Id("City"));
            City.SendKeys("Sofia");

            var State = Firefox.FindElement(By.Id("State"));
            State.SendKeys("blqblq");

            var PostalCode = Firefox.FindElement(By.Id("PostalCode"));
            PostalCode.SendKeys("123456");


            var Country = Firefox.FindElement(By.Id("Country"));
            Country.SendKeys("Bulgaria");

            var Phone = Firefox.FindElement(By.Id("Phone"));
            Phone.SendKeys("0886856253");

            var Email = Firefox.FindElement(By.Id("Email"));
            Email.SendKeys("Administrator@Test.com");

            var PromoCode = Firefox.FindElement(By.Id("PromoCode"));
            PromoCode.SendKeys("FREE");

            Thread.Sleep(2000);

            var submitButton = Firefox.FindElement(By.CssSelector("div.container:nth-child(2) > form:nth-child(1) > input:nth-child(6)"));
            submitButton.Click();

            Thread.Sleep(1000);

            Firefox.Quit();


        }
    }
}
