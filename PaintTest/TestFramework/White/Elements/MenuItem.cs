using TestFramework.white;
using TestFramework.white.elements;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace TestFramework.White.Elements
{
    public class MenuItem : BaseElement
    {
        public MenuItem(SearchCriteria searchCriteria, string name) : base(searchCriteria, name)
        {
        }

        public override IUIItem GetElement()
        {
            Logger.Log($"Getting {GetName()}...");
            return ApplicationFactory.Window.Get<TestStack.White.UIItems.MenuItems.Menu>(SearchCriteria);
        }
    }
}
