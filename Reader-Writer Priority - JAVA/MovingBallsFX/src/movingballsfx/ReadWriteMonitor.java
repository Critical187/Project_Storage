/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package movingballsfx;

/**
 *
 * @author Vader
 */
public class ReadWriteMonitor {

    private int readersActive;
    private int writersActive;
    private int readersWaiting;
    private int writersWaiting;
    public synchronized void enterReader() throws InterruptedException 
    {
        while((writersActive != 0) || (writersWaiting > 0))
        {
            readersWaiting++;
            wait();
            readersWaiting--;
        }

        readersActive++;
    }
    
    public synchronized void exitReader()
    {
        readersActive--;
        notifyAll();
    }

    public synchronized void enterWriter() throws InterruptedException 
    {
        while((readersActive != 0) || (readersWaiting > 0))
        {
            writersWaiting++;
            wait();
            writersWaiting--;
        }
        writersActive++;
    }

    public synchronized void exitWriter(){
        writersActive--;
        notifyAll();
    }
}
