/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javafxbusy;

import java.awt.Insets;
import javafx.event.ActionEvent;
import java.util.Calendar;
import javafx.application.Application;
import javafx.event.EventHandler;
import javafx.geometry.Pos;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.layout.VBox;
import javafx.stage.Stage;

/**
 *
 * @author Joris
 */
public class BusyApplication extends Application {

    /**
     * The main() method is ignored in correctly deployed JavaFX application.
     * main() serves only as fallback in case the application can not be
     * launched through deployment artifacts, e.g., in IDEs with limited FX
     * support. NetBeans ignores main().
     *
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        launch(args);
    }

    private Button btn1;
    public Button btn2;
    public Label label1;
    
    @Override
    public void start(Stage primaryStage) {
        
        label1 = new Label("");
        MyHandler handler = new MyHandler(this);
        btn2 = new Button();
        btn2.setText("Start worker");
        btn2.setOnAction(handler);
        btn1 = new Button();
        btn1.setText("Show current time");
        btn1.setOnAction(handler);
        
        
        // TODO: VBox, Scene, Stage actions
        VBox   v = new VBox(15);
        v.getChildren().add(btn1);
        v.getChildren().add(btn2);
        v.getChildren().add(label1);
        v.setAlignment(Pos.CENTER);
        
        Scene s = new Scene
             (v,380,125);
        primaryStage.setTitle
                 ("Main Screen");
        primaryStage.setScene(s);
        primaryStage.show();

        label1.setText(Calendar.getInstance().getTime().toString()
                + "; milliseconds: "
                + Calendar.getInstance().get(Calendar.MILLISECOND));
    }
    
}
class MyHandler implements EventHandler<ActionEvent>
{
    BusyApplication app = new BusyApplication();
    BusyWorker worker;
    public MyHandler(BusyApplication bs) {
        app = bs;
    }

    @Override
    public void handle(ActionEvent event) {
        if(event.getSource()==app.btn2){
            worker = new BusyWorker(5000);
            worker.busyJob();
        }
        app.label1.setText(Calendar.getInstance().getTime().toString()
                + "; milliseconds: "
                + Calendar.getInstance().get(Calendar.MILLISECOND));
    }
    
}