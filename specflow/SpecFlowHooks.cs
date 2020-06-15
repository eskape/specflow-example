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
        public static ILogger Log = new LoggerConfiguration().Enrich.FromLogContext().WriteTo.Console().CreateLogger();

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Log.Information("Starting");

        }

        [AfterScenario]
        public static void AfterScenario()
        {
            Log.Information("Stopped");

        }
        

    }
}