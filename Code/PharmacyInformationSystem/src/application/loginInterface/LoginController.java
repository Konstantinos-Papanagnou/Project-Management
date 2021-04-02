package application.loginInterface;

import java.io.IOException;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.layout.VBox;
import businessLogic.loginFunctionality.AuthenticationFailure;
import businessLogic.loginFunctionality.AuthenticationHandler;

public class LoginController {
	AuthenticationHandler handler;
	@FXML
	Button loginBtn;
	@FXML
	Label wrongCredsLbl;
	@FXML
	TextField usernameBox;
	@FXML
	TextField passwordBox;

	@FXML
	private void loginClicked(ActionEvent e) {
		if(handler == null) {
			wrongCredsLbl.setText("Could not connect to the database. Your database is either Corrupted or Offline.");
			wrongCredsLbl.setVisible(true);
			return;
		}
		try {
			handler.authenticateUser(usernameBox.getText(), passwordBox.getText());
			application.Main.window.setScene(new application.MasterInterface.MasterController().getScene());
		} catch (AuthenticationFailure e1) {
			wrongCredsLbl.setText(e1.getMessage());
			wrongCredsLbl.setVisible(true);
		}
		wrongCredsLbl.setVisible(true);
	}
	
	
	
	public Scene getScene() {
		Scene scene = null;
		try {
			VBox root = (VBox)FXMLLoader.load(getClass().getResource("Login.fxml"));
			scene = new Scene(root);
			root.getStylesheets().add(getClass().getResource("application.css").toExternalForm());
			handler = new AuthenticationHandler();
		} catch (IOException e) {
			
			e.printStackTrace();
		}catch(AuthenticationFailure e) {
			wrongCredsLbl.setText(e.getMessage());
			wrongCredsLbl.setVisible(true);
		}finally {
			return scene;
		}
	}
}
