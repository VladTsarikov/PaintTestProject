using System.Drawing;
using Calculator.windows;
using Calculator.Windows.Dialogues;
using CalculatorTest.Resources;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TestFramework.White;

namespace CalculatorTest.test.steps
{
    [Binding]
    internal class CalculatorSteps
    {
        private MainWindow _mainWindow;
        private OpenFileDialogue _openFileDialogue;
        private SaveChangesDialogue _saveChangesDialogue;
        private readonly string _imagePath = $"{ImageRes.ImagePath}{ImageRes.ImageName}";
        private Image _image;

        [Given("The Paint Has Opened")]
        public void OpenPaintMainWindow()
        {
            _mainWindow = new MainWindow();
        }

        [When("I Click Main Menu Button By Index '(.*)'")]
        public void ClickPanelButtonByIndex(int index)
        {
            _mainWindow.ClickPanelButtonByIndex(index);
        }

        [When("I Click '(.*)' Menu Item")]
        public void ClickMenuItem(string fileItem)
        {
            _mainWindow.ClickMenuItem(fileItem);
        }

        [When("I Set Image Path In File Name Field")]
        public void SetFilePath()
        {
            _openFileDialogue = new OpenFileDialogue();
            _openFileDialogue.SetFilePath(_imagePath);
            _image = Image.FromFile(_imagePath);
        }

        [When("I Click '(.*)' Button In Open File Dialogue Window")]
        public void ClickOpenFileButton(string buttonName)
        {
            _openFileDialogue.ClickButtonByName(buttonName);
        }

        [When("I Click Split Panel Button By Name '(.*)'")]
        public void ClickSplitPanelButton(string name)
        {
            _mainWindow.ClickPanelSplitButton(name);
        }

        [When("I Click Panel Button By Name '(.*)'")]
        public void ClickCutButton(string name)
        {
            _mainWindow.ClickPanelButtonByName(name);
        }

        [When("I Click Close Button")]
        public void ClickCloseButton()
        {
            _mainWindow.ClickCloseButton();    
        }

        [When("I Click '(.*)' Button In Save Changes Dialogue Window")]
        public void ClickDoNotSaveButton(string name)
        {
            _saveChangesDialogue = new SaveChangesDialogue();
            _saveChangesDialogue.ClickButtonByName(name);
        }

        [Then("The Image Was Not Changed")]
        public void GetResult()
        {
            var compareImage = Image.FromFile(_imagePath);
            Assert.IsTrue(FileUtils.CompareImages(_image, compareImage),"Image has been changed");
        }
    }
}
