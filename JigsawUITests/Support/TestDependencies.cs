using Autofac;
using JigsawUITests.Objects;
using OpenQA.Selenium;
using Pages.Base;
using SeleniumWebDriver;
using SpecFlow.Autofac;
using System;
using System.Linq;
using TechTalk.SpecFlow;
using TestConfiguration;

namespace JigsawUITests.Support
{
    /// <summary>
    /// TestDependencies.
    /// </summary>
    public static class TestDependencies
    {
        [ScenarioDependencies]
        public static ContainerBuilder CreateContainerBuilder()
        {
            Configurator.Create();

            var builder = new ContainerBuilder();

            builder.RegisterInstance(new SeleniumContext(Configurator.Settings.Browser).WebDriver).As<IWebDriver>().SingleInstance();

            builder.RegisterTypes(typeof(BasePage).Assembly.GetTypes().ToArray()).InstancePerLifetimeScope();
            builder.RegisterType<MyProfileForm>().InstancePerLifetimeScope();

            builder.RegisterTypes(typeof(TestDependencies).Assembly.GetTypes().Where(t => Attribute.IsDefined(t, typeof(BindingAttribute))).ToArray());

            return builder;
        }
    }
}
