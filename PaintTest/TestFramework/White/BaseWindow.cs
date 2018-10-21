using NUnit.Framework;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.ScreenObjects;

namespace TestFramework.white
{
    public class BaseWindow: AppScreen
    {
        protected string Title;
        protected Window WindowName;

        public BaseWindow(Window window, string title) : base(window, null)
        {
            Title = title;
            WindowName = window;
            AssertIsOpen();
        }

        public void AssertIsOpen()
        {
             Assert.IsTrue(WindowName.Visible,$"{Title} has not opened");
        }      
    }
}
