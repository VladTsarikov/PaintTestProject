using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace TestFramework.white.elements
{
    public class Button: BaseElement
    {
        public Button(SearchCriteria searchCriteria, string name) : base(searchCriteria, name)
        {
        }

        public override IUIItem GetElement()
        {
            Logger.Log($"Getting {GetName()}...");
            return ApplicationFactory.Window.Get<TestStack.White.UIItems.Button>(SearchCriteria);
        }
    }
}
