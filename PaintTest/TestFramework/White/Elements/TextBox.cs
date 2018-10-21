using TestFramework.white;
using TestFramework.white.elements;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace TestFramework.White.Elements
{
    public class TextBox : BaseElement
    {
        public TextBox(SearchCriteria searchCriteria, string name) : base(searchCriteria, name)
        {
        }

        public override IUIItem GetElement()
        {
            Logger.Log($"Getting {GetName()}...");
            return ApplicationFactory.Window.Get<TestStack.White.UIItems.TextBox>(SearchCriteria);
        }
    }
}
