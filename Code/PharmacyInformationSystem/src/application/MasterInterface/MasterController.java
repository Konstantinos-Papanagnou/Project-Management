package application.MasterInterface;

import java.io.IOException;

import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;

public class MasterController {
	public Scene getScene() {
		Scene scene = null;
		try {
			Parent root = FXMLLoader.load(getClass().getResource("Master.fxml"));
			scene = new Scene(root);
			//root.getStylesheets().add(getClass().getResource("application.css").toExternalForm());
			return scene;
		} catch (IOException e) {
			return null;
		}
	}
}
