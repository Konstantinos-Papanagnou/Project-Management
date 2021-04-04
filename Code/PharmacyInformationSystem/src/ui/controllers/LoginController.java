package ui.controllers;

import application.Main;
import javafx.event.*;
import javafx.scene.control.*;

public class LoginController {
	
	public TextField text;
	public Label label;
	
	public void onButtonClick(ActionEvent e) 
	{
		label.setText("Hello " + text.getText());
		label.setVisible(true);
		//Main.changeScene();
	}
}
