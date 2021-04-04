package application.mainInterface;

import java.io.IOException;

import application.loginInterface.LoginController;
import businessLogic.User;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.image.ImageView;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.Pane;

public class MainController {
	public MainController(User user) {
		this.user = user;
		//usernameLbl.setText(user.getUsername());
	}
	User user;
	
	@FXML
	Label usernameLbl;
	@FXML
	Button logoutBtn;
	@FXML
	ImageView toMainMenuView;
	@FXML
	Pane manageWarehouseView;
	@FXML
	Pane viewStatisticsView;
	@FXML
	Pane manageUsersView;
	@FXML
	Pane manageSalesView;
	@FXML
	Pane userInformationView;

	
	@FXML
	private void logoutClick(ActionEvent e) {
		application.Main.window.setScene(new LoginController().getScene());
	}
	
	
	
	
	public Scene getScene() {
		Scene scene = null;
		try {
			BorderPane root = FXMLLoader.load(getClass().getResource("Main.fxml"));
			scene = new Scene(root);
			root.getStylesheets().add(getClass().getResource("../application2.css").toExternalForm());
			return scene;
		} catch (IOException e) {
			System.out.println(e.getMessage());
			System.exit(1);//return null;
			return null;
		}
	}
}
