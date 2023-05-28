using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading.Tasks;

namespace AuthorizationTests
{
    public class Tests
    {
        private IWebDriver driver;

        private readonly By _singInButton = By.XPath("//span[text()='Войти']");
        private readonly By _second = By.XPath($"//span[text()='Другим способом']");
        private readonly By _AuthInputButton = By.XPath($"//input[@name='username']");
        private readonly By _next = By.XPath($"//span[text()='Продолжить']");
        private readonly By _AuthInputButton1 = By.XPath($"//input[@name='password']");
        private const string _login = "vladimir-andreev-2013@yandex.ru";
        private const string _password = "Test_Cian_2022";
        private readonly By _enter = By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div/div[2]/div/form/div[2]/button/span");

        private readonly By _PostingAnAd = By.XPath("//span[text()='+ Разместить объявление']");
        private readonly By _TypeOfAccount = By.XPath("//div[@data-mark='switcher_button||true']"); 
        private readonly By _TypeOfDeal = By.XPath("//div[@data-mark='switcher_button|adType.dealType|sale']");
        private readonly By _TypeOfRealty = By.XPath("//div[@data-mark='switcher_button|adType.propertyType|residential']");
        private readonly By _TypeOfObject = By.XPath($"//span[text()='Квартира']");
        private readonly By _AddressInput = By.XPath($"//input[@name='geo.userInput']");
        private const string _address = "Санкт-Петербург, Невский проспект, 55";
        private const string _MetroStation = "Невский проспект";
        private const string _Minutes = "8";
        private readonly By _MetroStationInput = By.XPath($"//input[@name='geo.undergrounds.0.id']");
        private readonly By _MinutesInput = By.XPath($"//input[@name='geo.undergrounds.0.time']");
        private readonly By _TypeOfMovement = By.XPath($"//span[text()='пешком']");
        private readonly By _TypeOfMovement2 = By.XPath($"//li[@class='cui-dropdown__item']");
        private readonly By _MainMetro = By.XPath($"//*[@id='address']/div/cian-af-retry-notice/div/div/cian-af-dynamic-segment-inputs/div/div/cian-ui-compile-directive[4]/cian-af-address-underground/div/div[2]/div[3]/div/div/div[4]/div/label");
        private readonly By _DeleteMetro = By.XPath($"//*[@id='address']/div/cian-af-retry-notice/div/div/cian-af-dynamic-segment-inputs/div/div/cian-ui-compile-directive[4]/cian-af-address-underground/div/div[2]/div[3]/div/div/div[5]/cian-af-icon");
        private readonly By _NextButton = By.XPath("//span[text()='Дальше']");


        [SetUp]
        public void Setup() // В методе под атрибутом SetUp происходит то, что будет перед тестом 
                            // в скобках прописываем инициализацию экземпляров (их вызов), переходим на веб-страницу.
        {
            driver = new OpenQA.Selenium.Edge.EdgeDriver(); // открытие браузера
            driver.Navigate().GoToUrl("https://cian.ru"); // открытие сайта
            driver.Manage().Window.Maximize(); // открытие браузера на весь экран
        }

        [Test]
        public void Test1() // В атрибуте Test прописываем, что мы проверяем (действия, переходы, вкладки, подсчеты и т.д.)
        {
            /*var singIn = driver.FindElement(_singInButton);
            singIn.Click();

            Task.Delay(1000).Wait();
            var second = driver.FindElement(_second);
            second.Click();

            var login = driver.FindElement(_AuthInputButton);
            login.SendKeys(_login);

            Task.Delay(1000).Wait();
            var next = driver.FindElement(_next);
            next.Click();

            Task.Delay(3000).Wait();
            var password = driver.FindElement(_AuthInputButton1);
            password.SendKeys(_password);

            Task.Delay(1000).Wait();
            var enter = driver.FindElement(_enter);
            enter.Click();*/

            var posting = driver.FindElement(_PostingAnAd);
            posting.Click();

            Task.Delay(1000).Wait();
            var account = driver.FindElement(_TypeOfAccount);
            account.Click();

            //Task.Delay(1000).Wait();
            var deal = driver.FindElement(_TypeOfDeal);
            deal.Click();

            //Task.Delay(1000).Wait();
            var realty = driver.FindElement(_TypeOfRealty);
            realty.Click();

            //Task.Delay(1000).Wait();
            var typeObject = driver.FindElement(_TypeOfObject);
            typeObject.Click();

            Task.Delay(1000).Wait();
            var addressClear = driver.FindElement(_AddressInput);
            addressClear.Clear();

            Task.Delay(1000).Wait();
            var address = driver.FindElement(_AddressInput);
            address.SendKeys(_address);

            Task.Delay(5000).Wait();
            var metroClear = driver.FindElement(_MetroStationInput);
            metroClear.Clear();

            Task.Delay(1000).Wait();
            var metro = driver.FindElement(_MetroStationInput);
            metro.SendKeys(_MetroStation);

            Task.Delay(1000).Wait();
            var minutesClear = driver.FindElement(_MinutesInput);
            minutesClear.Clear();

            Task.Delay(1000).Wait();
            var minutes = driver.FindElement(_MinutesInput);
            minutes.SendKeys(_Minutes);

            Task.Delay(1000).Wait();
            var movement = driver.FindElement(_TypeOfMovement);
            movement.Click();

            Task.Delay(1000).Wait();
            var movement2 = driver.FindElement(_TypeOfMovement2);
            movement2.Click();

            Task.Delay(1000).Wait();
            var main = driver.FindElement(_MainMetro);
            main.Click();

            Task.Delay(1000).Wait();
            var delete = driver.FindElement(_DeleteMetro);
            delete.Click();


            /*Task.Delay(5000).Wait();
            var next = driver.FindElement(_NextButton);
            next.Click();*/

        }


        [TearDown]
        public void TearDown() //Метод TearDown вызывается после прохождения тестов. Здесь происходит закрытие веб-приложений
        {

        }

    }
}