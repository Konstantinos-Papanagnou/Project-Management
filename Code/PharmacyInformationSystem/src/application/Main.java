package application;
	
import javafx.application.Application;
import javafx.scene.image.Image;
import javafx.stage.Stage;
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
		window.setScene(new application.mainInterface.MainController(new User("", "", "", 0, "kopapa", null, 0, null )).getScene());
		//window.setScene(new LoginController().getScene());
		window.getIcons().add(new Image(getClass().getResourceAsStream("loginInterface/WelcomeImage.png")));
		window.show();
	}
	
	public static void main(String[] args) throws ClassNotFoundException {
		launch(args);
	}
}
