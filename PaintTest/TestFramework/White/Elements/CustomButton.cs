using System.Windows.Automation;
using TestFramework.white;
using TestFramework.white.elements;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace TestFramework.White.Elements
{
    public class CustomButton : BaseElement
    {
        public CustomButton(SearchCriteria searchCriteria, string name) : base(searchCriteria, name)
        {
        }

        public override IUIItem GetElement()
        {
            Logger.Log($"Getting {GetName()}...");
            return ApplicationFactory.Window.Get<Panel>(SearchCriteria);
        }

        public UIItem GetExtend(int index)
        {
            var menuElements = GetElement().AutomationElement
                .FindAll(TreeScope.Children, Condition.TrueCondition);
            return new UIItem(menuElements[index], GetElement().ActionListener);
        }
    }
}
