package ui.controllers;

import java.net.URL;
import java.util.ResourceBundle;
import javafx.collections.*;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.*;

public class UserEditController{
	@FXML
	private ComboBox  roles;
	@FXML
	private Label label;
	private ObservableList list;
	
	@FXML
	public void initialize() {
		/*list = roles.getItems();
		list.add("Option A");
		list.add("Option B");
		list.add("Option C");
		list.add("Option D");
		*/
		roles.getItems().removeAll(roles.getItems());
		roles.getItems().addAll("Option A", "Option B", "Option C");
		roles.getSelectionModel().select("Option B");
    }
}
