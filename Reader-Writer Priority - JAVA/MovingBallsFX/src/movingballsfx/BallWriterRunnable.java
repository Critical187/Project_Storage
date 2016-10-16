/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package movingballsfx;

import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Vader
 */
public class BallWriterRunnable extends BallRunnable {
    
    public BallWriterRunnable(Ball ball, ReadWriteMonitor monitor) {
        super(ball, monitor);
    }

    @Override
    protected void onRun() {
        try {
            monitor.enterWriter();
        } catch (InterruptedException ex) {
            Logger.getLogger(BallWriterRunnable.class.getName()).log(Level.SEVERE, null, ex);
        }
        update();
        monitor.exitWriter();
    }
    
}
