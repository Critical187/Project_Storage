package javafxmandelbrot;

import java.util.Arrays;
import java.util.Iterator;
import javafx.application.Platform;
import javafx.scene.canvas.GraphicsContext;

/**
 *
 * @author Joris
 */
public class PixelManager implements Runnable {

    private final GraphicsContext gc;
    private Pixel[] pixelArray;
    private int counter = 0;
    PixelManager(GraphicsContext gc, int size) {
        this.gc = gc;
        pixelArray = new Pixel[size];
    }

    public synchronized void add(Pixel p) {
        
        // TODO: add p to pixelArray
        if(counter < pixelArray.length){
           pixelArray[counter] = p; 
           counter++;
        }
        
    }

    
    public void show() {
        // TODO: display all pixels in pixelArray[], and empty the array afterwards
            Platform.runLater(this);
        
        
            // hint: 
            // one pixel, displayed as a 1x1 rectangle
            // gc.setFill(p.getColor());
            // gc.fillRect(p.getX(), p.getY(), 1, 1);
    }

    @Override
    public void run() {
        for(int i=0; i<counter; i++){
            Pixel p = this.pixelArray[i];
            if(p==null) continue;
            gc.setFill(p.getColor());
            gc.fillRect(p.getX(), p.getY(), 1, 1);
            pixelArray[i] = null;
        }
    }
}
