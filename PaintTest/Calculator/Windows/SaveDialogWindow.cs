using TestFramework.white;
using TestFramework.white.elements;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace Calculator.Windows
{
    public class SaveDialogWindow : BaseWindow
    {
        public SaveDialogWindow(Window window, string title) : base(window, title)
        {
        }

        public void ClickButtonByName(string name)
        {
            new Button(SearchCriteria.ByText(name), $"{name} Button").Click();
        }
    }
}
