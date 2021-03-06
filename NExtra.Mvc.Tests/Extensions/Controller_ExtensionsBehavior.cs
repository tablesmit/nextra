using System.Globalization;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using NExtra.Mvc.Extensions;
using NSubstitute;
using NUnit.Framework;

namespace NExtra.Mvc.Tests.Extensions
{
    [TestFixture]
    public class Controller_ExtensionsBehavior
    {
        private ControllerTestClass _controller;


        [SetUp]
        public void SetUp()
        {
            var request = Substitute.For<HttpRequestBase>();
            request.HttpMethod.Returns("GET");
            var httpContext = Substitute.For<HttpContextBase>();
            httpContext.Request.Returns(request);
            var controllerContext = new ControllerContext(httpContext, new RouteData(), Substitute.For<ControllerBase>());

            var valueProvider = Substitute.For<IValueProvider>();
            valueProvider.GetValue("action").Returns(new ValueProviderResult("CurrentAction", "CurrentAction", CultureInfo.CurrentCulture));
            valueProvider.GetValue("controller").Returns(new ValueProviderResult("CurrentController", "CurrentController", CultureInfo.CurrentCulture));
	        
            _controller = new ControllerTestClass { ControllerContext = controllerContext, ValueProvider = valueProvider };
        }


        [Test]
        public void ActionName_ShouldReturnCorrectValue()
        {
            Assert.That(_controller.Action(), Is.EqualTo("CurrentAction"));
        }

        [Test]
        public void Name_ShouldReturnCorrectValue()
        {
            Assert.That(_controller.Name(), Is.EqualTo("CurrentController"));
        }


        internal class ControllerTestClass : Controller { }
    }
}
