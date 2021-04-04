package application;
	
import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.image.Image;
import javafx.stage.Stage;

import java.io.IOException;

import application.loginInterface.LoginController;
import businessLogic.User;


public class Main extends Application {
	
	public static Stage window;
	public static final double WIDTH = 1000;
	public static final double HEIGHT = 800;
	@Override
	public void start(Stage primaryStage) {
		window = primaryStage;
		window.setTitle("Pharmacy Information System");
		window.setMinHeight(HEIGHT);
		window.setMinWidth(WIDTH);
		FXMLLoader loader = new FXMLLoader();
        loader.setController(new application.mainInterface.MainController(new User("", "", "", 0, "kopapa", null, 0, null )));
        loader.setLocation(getClass().getResource("mainInterface/Main.fxml"));
        Parent root = null;
		try { // fx:controller="application.mainInterface.MainController"
			root = loader.load();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			System.out.println(e.getMessage());
		}
		root.getStylesheets().add(getClass().getResource("application.css").toExternalForm());
        Scene scene = new Scene(root);
        window.setScene(scene);
		//window.setScene(new application.mainInterface.MainController(new User("", "", "", 0, "kopapa", null, 0, null )).getScene());
		//window.setScene(new LoginController().getScene());
		window.getIcons().add(new Image(getClass().getResourceAsStream("loginInterface/WelcomeImage.png")));
		window.show();
	}
	
	public static void main(String[] args) throws ClassNotFoundException {
		launch(args);
	}
}
