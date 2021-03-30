package application;
	
import javafx.application.Application;
import javafx.stage.Stage;
import javafx.scene.Scene;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.VBox;
import javafx.fxml.FXMLLoader;


public class Main extends Application {
	@Override
	public void start(Stage window) {
		try {
			window.setTitle("Pharmacy Information System");
			VBox root = (VBox)FXMLLoader.load(getClass().getResource("Login.fxml"));
			Scene scene = new Scene(root,800,600);
			window.setMinHeight(600);
			window.setMinWidth(800);
			root.getStylesheets().add(getClass().getResource("application.css").toExternalForm());
			window.setScene(scene);
			window.show();
		} catch(Exception e) {
			e.printStackTrace();
		}
	}
	
	public static void main(String[] args) {
		launch(args);
	}
}
