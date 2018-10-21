using TestFramework.white;
using TestFramework.white.elements;
using TestFramework.White.Elements;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace Calculator.Windows
{
    public class OpenFileWindow : BaseWindow
    {
        public OpenFileWindow(Window window, string title) : base(window, title)
        {
        }

        public void SetFileData(string fieldName,string data)
        {
            new TextBox(SearchCriteria.ByText(fieldName), $"{fieldName} TextBox").SetValue(data);
        }

        public void ClickButtonByName(string name)
        {
            new Button(SearchCriteria.ByText(name), $"{name} Button").Click();
        }
    }
}
