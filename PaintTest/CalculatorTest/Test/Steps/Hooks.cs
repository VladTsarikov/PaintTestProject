using NLog;
using TechTalk.SpecFlow;
using TestFramework.Resources;
using TestFramework.white;
using Logger = TestFramework.white.Logger;

namespace CalculatorTest.test.steps
{
    [Binding]
    internal class Hooks
    {
        private static readonly string AppPath = ApplicationRes.AppPath;
        private static readonly string AppExtension = ApplicationRes.AppExtension;
        private static readonly string AppName = ApplicationRes.AppName;
        private static readonly string MainWindowName = ApplicationRes.AppMainWindownName;

        [BeforeScenario]
        public void Before()
        {
            Logger.Log("Tests are starting...", LogLevel.Info);
            ApplicationFactory.Launch($"{AppPath}{AppName}{AppExtension}", MainWindowName);
        }

        [AfterScenario]
        public void After()
        {
            Logger.Log("Tests has finished", LogLevel.Info);
            ApplicationFactory.Close();
        }
    }
}
