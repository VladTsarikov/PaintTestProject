using TestFramework.white;
using TestFramework.white.elements;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace Calculator.Windows.Dialogues
{
    public class SaveChangesDialogue : BaseWindow
    {
        public SaveChangesDialogue() : base(ApplicationFactory.Window.ModalWindow("Paint"), "Save Changes Dialogue")
        {
        }

        public void ClickButtonByName(string name)
        {
            new Button(SearchCriteria.ByText(name), $"{name} Button").Click();
        }
    }
}
