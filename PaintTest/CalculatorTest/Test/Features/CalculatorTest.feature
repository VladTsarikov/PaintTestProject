Feature: Paint
      
@PaintTests
Scenario: Open Image For Editing
Given The Paint Has Opened
When I Click Main Menu Button By Index '2'
	And I Click 'Open' Menu Item 
	And I Set Image Path In File Name Field
	And I Click 'Open' Button In Open File Dialogue Window
	And I Click Split Panel Button By Name 'Select'
	And I Click 'Select all' Menu Item 
	#And I Click Close Button
	#And I Click 'Don't Save' Button In Save Changes Dialogue Window
#Then The Image Was Not Changed



	



	


 



	


