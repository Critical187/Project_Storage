/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package movingballsfx;

import java.util.logging.Level;
import java.util.logging.Logger;

public class BallRunnable implements Runnable {

    private final Ball ball;
    private boolean isReader;
    private ReaderWriterMonitor monitor;
    private boolean hasEntered = false;

    public BallRunnable(Ball ball, boolean isReader, ReaderWriterMonitor monitor) {
        this.ball = ball;
        this.isReader = isReader;
        this.monitor = monitor;
    }

    private void busySleep(long ms) {
          try {
        Thread.currentThread().sleep(ms);
         } catch (InterruptedException ex) {
         Logger.getLogger(BallRunnable.class.getName()).log(Level.SEVERE, null, ex);
          }
    }

    @Override
    public void run() {
        while (!Thread.currentThread().isInterrupted()) {
            if (ball.isEnteringCs()) {
                if (isReader) {
                    monitor.enterReader();
                } else {
                    monitor.enterWriter();
                }
                hasEntered = true;
            }
            ball.move();
            busySleep(ball.getSpeed());
            if (ball.isLeavingCs()) {
                if (isReader) {
                    monitor.exitReader();
                } else {
                    monitor.exitWriter();
                }
                hasEntered = false;
            }
        }
        if (hasEntered) {
            if (isReader) {
                monitor.exitReader();
            } else {
                monitor.exitWriter();
            }
        }

    }
}
