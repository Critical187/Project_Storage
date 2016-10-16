/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package movingballsfx;

import java.util.concurrent.TimeUnit;
import java.util.concurrent.locks.Condition;
import java.util.concurrent.locks.Lock;
import java.util.concurrent.locks.ReentrantLock;
import java.util.logging.Level;
import java.util.logging.Logger;

public class ReaderWriterMonitor {
    Lock lock = new ReentrantLock();
    Condition reader = lock.newCondition();
    Condition writer = lock.newCondition();
    private int writersActive = 0;
    private int writersWaiting = 0;
    private int readersWaiting = 0;
    private int readersActive = 0;
    private boolean readerPriority = false;
    
    public void SetPriority(boolean priority){
        readerPriority = priority;
    }

    public void enterReader() {
        lock.lock();
        try{
        while ((writersActive != 0 || writersWaiting  > 0)) {
                if(readerPriority && writersActive == 0) break;
                readersWaiting++;
                reader.await();
                readersWaiting--;
            
            
        }
        readersActive++;
        } catch (InterruptedException ex) {
                Logger.getLogger(ReaderWriterMonitor.class.getName()).log(Level.SEVERE, null, ex);
            }
        finally
            {
                lock.unlock();
            }
        
    }

    public void exitReader() {
        lock.lock();
        try{
            readersActive--;
            if(writersActive == 0 || (readerPriority && writersActive == 0))
            {
                reader.signalAll();
            }
            if(writersActive == 0 || (readerPriority && readersWaiting == 0))
            {
                writer.signal();
            }
        }
        finally{
           lock.unlock(); 
        }
    }
    
    public void enterWriter() {
        lock.lock();
        try{
       while (((readersActive != 0) || writersActive == 1) || (readerPriority && readersWaiting != 0)) {
                writersWaiting++;
                writer.await();
                writersWaiting--;
        }
       writersActive++;
       } catch (InterruptedException ex) {
                Logger.getLogger(ReaderWriterMonitor.class.getName()).log(Level.SEVERE, null, ex);
            }
            finally
            {
                lock.unlock();
                
            }
    }

    public void exitWriter() {
        lock.lock();
        try{
            writersActive--;
            if(((readersActive == 0) || writersActive == 0) || (!readerPriority && readersActive == 0))
            {
                writer.signal();
            }
            if((writersWaiting ==0) || (readerPriority && writersActive == 0))
            {
                reader.signalAll();
            }
        }
        finally{
            lock.unlock();
        }
    }
}
