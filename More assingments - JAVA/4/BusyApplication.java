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
    static BusyApplication instance;
    public class UpdateLabel implements Runnable{
        Label label2;
        public UpdateLabel(Label l){
            this.label2 = l;
        }
        @Override
        public void run() {
           label2.setText(Calendar.getInstance().getTime().toString()
                + "; milliseconds: "
                + Calendar.getInstance().get(Calendar.MILLISECOND)); 
        }
        
    }
    public static void main(String[] args) {
        launch(args);
    }

    private Button btn1;
    public Button btn2;
    public Button btn3;
    public Label label1;
    public Label label2;
    public Button btn4;
    
    @Override
    public void start(Stage primaryStage) {
        instance = this;
        label1 = new Label("");
        label2 = new Label("time");
        MyHandler handler = new MyHandler(this);
        btn2 = new Button();
        btn2.setText("Start worker");
        btn2.setOnAction(handler);
        btn1 = new Button();
        btn1.setText("Show current time");
        btn1.setOnAction(handler);
        btn3 = new Button();
        btn3.setText("Create worker and new thread");
        btn3.setOnAction(handler);
        btn4 = new Button();
        btn4.setText("Stop thread");
        btn4.setOnAction(handler);
        
        
        // TODO: VBox, Scene, Stage actions
        VBox   v = new VBox(15);
        v.getChildren().add(btn1);
        v.getChildren().add(btn2);
        v.getChildren().add(btn3);
        v.getChildren().add(btn4);
        v.getChildren().add(label1);
        v.getChildren().add(label2);
        v.setAlignment(Pos.CENTER);
        
        Scene s = new Scene
             (v,360,240);
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
    BusyApplication app = BusyApplication.instance;
    Runnable u = app.new UpdateLabel(app.label2);
    BusyWorker worker;
    public MyHandler(BusyApplication bs) {
        app = bs;
    }
    Thread t1 = null;
    @Override
    public void handle(ActionEvent event) {
        
        if(event.getSource()==app.btn2){
            worker = new BusyWorker(5000);
            worker.busyJob();
        }
        else if(event.getSource()==app.btn3){
            Runnable r = new BusyWorker(u);
            t1 = new Thread(r);
            t1.start();
        }
        else if(event.getSource()==app.btn4){
            t1.interrupt();
        }
        else
        
        app.label1.setText(Calendar.getInstance().getTime().toString()
                + "; milliseconds: "
                + Calendar.getInstance().get(Calendar.MILLISECOND));
    }
    
}