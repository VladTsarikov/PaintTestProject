using TestFramework.white;
using TestFramework.white.elements;
using TestFramework.White.Elements;
using TestStack.White.UIItems.Finders;

namespace Calculator.Windows.Dialogues
{
    public class OpenFileDialogue : BaseWindow
    {
        public OpenFileDialogue() : base(ApplicationFactory.Window.ModalWindow("Open"), "Open File Dialogue")
        {
        }

        public void SetFilePath(string filePath)
        {          
            new TextBox(SearchCriteria.ByAutomationId("1148"), "File Name TextBox")
                .SetValue(filePath);
        }

        public void ClickButtonByName(string name)
        {
            new Button(SearchCriteria.ByText(name), $"{name} Button").Click();
        }
    }
}
