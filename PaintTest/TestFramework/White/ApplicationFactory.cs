using TestFramework.Resources;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;

namespace TestFramework.white
{
    public static class ApplicationFactory
    {
        private static Application _application;
        private static string _windowName;

        public static Application Application
        {
            get
            {
                if (_application == null)
                {
                    Launch(ApplicationRes.AppName, ApplicationRes.AppMainWindownName);
                }
                return _application;
            }
            private set => _application = value;
        }

        public static void Launch(string appName, string windowName)
        {
            Logger.Log($"Launching application {appName}...");
            Application = Application.Launch(appName); 
            _windowName = _application.GetWindow(windowName).Name;
            Window = Application.GetWindow(_windowName);
        }

        public static void Close()
        {
            Logger.Log("Closing application...");
            Window.Close();
            _application.Kill();
        }

        public static Window Window { get; set; }
    }
}
