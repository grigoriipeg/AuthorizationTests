using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading.Tasks;

namespace AuthorizationTests
{
    public class Tests
    {
        private IWebDriver driver;

        private readonly By _singInButton = By.XPath("//span[text()='�����']");
        private readonly By _second = By.XPath($"//span[text()='������ ��������']");
        private readonly By _AuthInputButton = By.XPath($"//input[@name='username']");
        private readonly By _next = By.XPath($"//span[text()='����������']");
        private readonly By _AuthInputButton1 = By.XPath($"//input[@name='password']");
        private const string _login = "vladimir-andreev-2013@yandex.ru";
        private const string _password = "Test_Cian_2022";
        private readonly By _enter = By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div/div[2]/div/form/div[2]/button/span");

        [SetUp]
        public void Setup() //� ������ ��� ��������� SetUp ���������� ��, ��� ����� ����� ������ 
                            //� ������� ����������� ������������� ����������� (�� �����), ��������� �� ���-��������.
        {
            driver = new OpenQA.Selenium.Edge.EdgeDriver(); // �������� ��������
            driver.Navigate().GoToUrl("https://cian.ru"); // �������� �����
            driver.Manage().Window.Maximize(); // �������� �������� �� ���� �����
        }

        [Test]
        public void Test1() //� �������� Test �����������, ��� �� ��������� (��������, ��������, �������, �������� � �.�.)
        {
            var singIn = driver.FindElement(_singInButton);
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
            enter.Click();
        }


        [TearDown]
        public void TearDown() //����� TearDown ���������� ����� ����������� ������. ����� ���������� �������� ���-����������
        {

        }

    }
}