using TestFramework.white;
using TestFramework.white.elements;
using TestFramework.White.Elements;
using TestStack.White.UIItems.Finders;

namespace Calculator.windows
{
    public class MainWindow: BaseWindow
    {
        public MainWindow() : base(ApplicationFactory.Window, "Main Paint Window")
        {
        }

        public void ClickPanelButtonByIndex(int index)
        {
            new CustomButton(SearchCriteria.ByText("Ribbon").AndByClassName("NetUIHWND"),"File Button").GetExtend(index).Click();
        }

        public void ClickMenuItem(string item)
        {
            new MenuItem(SearchCriteria.ByText(item),$"{item} Menu Item").Click();
        }

        public void ClickPanelSplitButton(string name)
        {
            new CustomSplitButton(SearchCriteria.ByText(name), $"{name} Button").GetExtend().Click();
        }

        public void ClickPanelButtonByName(string name)
        {
            new Button(SearchCriteria.ByText(name), $"{name} Button").Click();
        }

        public void ClickCloseButton()
        {
            new Button(SearchCriteria.ByAutomationId("Close"), "Close Button").Click();
        }
    }
}
