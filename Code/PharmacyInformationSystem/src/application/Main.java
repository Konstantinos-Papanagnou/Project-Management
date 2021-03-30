package application;
	
import javafx.application.Application;
import javafx.stage.Stage;
import application.loginInterface.LoginScene;


public class Main extends Application {
	@Override
	public void start(Stage window) {
		window.setTitle("Pharmacy Information System");
		window.setMinHeight(600);
		window.setMinWidth(800);
		LoginScene scene = new LoginScene();
		window.setScene(scene.getLoginScene());
		window.show();
	}
	
	public static void main(String[] args) {
		launch(args);
	}
}
