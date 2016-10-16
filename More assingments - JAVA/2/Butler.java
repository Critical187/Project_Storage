/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package people;

/**
 *
 * @author user
 */
public class Butler extends Person implements Housekeeper{

    public Butler(String name, int money) {
        super(name, money);
    }

    @Override
    public void wash() {
       setMoney(this.getMoney() + 10);
    }

    @Override
    public void vacuumClean() {
        setMoney(this.getMoney() + 20);
    }
    
}
