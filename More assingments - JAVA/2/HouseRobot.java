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
public class HouseRobot implements Housekeeper {
    private int energy;

    public void setEnergy(int energy) {
        this.energy = energy;
    }

    public int getEnergy() {
        return energy;
    }
    @Override
    public void wash() {
        this.energy -= 10;
    }

    @Override
    public void vacuumClean() {
        this.energy -= 1;
    }
    
}
