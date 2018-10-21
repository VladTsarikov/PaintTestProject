using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace TestFramework.white.elements
{
    public abstract class BaseElement 
    {
        protected string Name;
        protected SearchCriteria SearchCriteria;

        protected BaseElement(SearchCriteria searchCriteria, string name)
        {
            SearchCriteria = searchCriteria;
            Name = name;
        }

        public void Click()
        {
            Logger.Log($"Clicking on {GetName()}");
            GetElement().Click();
        }

        public void SetValue(object value)
        {
            Logger.Log($"Setting value to {GetName()}");
            GetElement().SetValue(value);
        }

        public abstract IUIItem GetElement();

        public string GetName()
        {
            return Name;
        }
    }
}
