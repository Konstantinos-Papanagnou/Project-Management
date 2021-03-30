package application.loginInterface;

import java.io.IOException;

import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.scene.layout.VBox;

public class LoginScene {

	public Scene getLoginScene() {
		try {
			VBox root = (VBox)FXMLLoader.load(getClass().getResource("Login.fxml"));
			Scene scene = new Scene(root,800,600);
			root.getStylesheets().add(getClass().getResource("application.css").toExternalForm());
			return scene;
		} catch (IOException e) {
			
			// TODO Auto-generated catch block
			e.printStackTrace();
			return null;
		}
	}
}
