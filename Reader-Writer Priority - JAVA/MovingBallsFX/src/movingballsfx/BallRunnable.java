/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package movingballsfx;

import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Peter Boots
 */
public abstract class BallRunnable implements Runnable {

    private final Ball ball;
    protected final ReadWriteMonitor monitor;
    
    protected void update(){
        ball.move();
    }
    
    protected boolean isLeavingCs(){
        return  ball.isLeavingCs();
    }
    
    protected boolean isEnteringCs(){
        return  ball.isEnteringCs();
    }

    public BallRunnable(Ball ball, ReadWriteMonitor monitor) {
        this.ball = ball;
        this.monitor = monitor;
    }
    
    protected abstract void onRun();

    private void busySleep(long ms)
    {
        try {
            Thread.currentThread().sleep(ms);
        } catch (InterruptedException ex) {
            Logger.getLogger(BallRunnable.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    @Override
    public void run() {
        while (!Thread.currentThread().isInterrupted()) {
            if(isEnteringCs() || isLeavingCs())
                onRun();
            else
                update();
            busySleep(ball.getSpeed());
        }
    }
}
