using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Serilog;
using TechTalk.SpecFlow;
namespace SpecFlowHooks
{
    [Binding]
    public sealed class Hooks
    {
        private static ILogger _log = new LoggerConfiguration().Enrich.FromLogContext().WriteTo.Console().CreateLogger();

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            _log.Information("Starting");
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            _log.Information("Stopped");
        }
    }
}