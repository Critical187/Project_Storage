/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package people;

/**
 *
 * @author Ilia
 */
public class Person {
    private String name;
    private int money;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setMoney(int money) {
        this.money = money;
    }

    public int getMoney() {
        return money;
    }
    
    public Person(String name, int money){
        this.setName(name);
        this.setMoney(money);
    }
    
    public void walk(){
        System.out.println(this.name + " Is Walking");
    }
    
    public void spendMoney(){
        System.out.println(this.name + " Is SpendingMoney, resulted balance: " + (--money));
    }
    
    @Override
    public String toString(){
        return this.getName()+":"+this.getMoney();
    }
}
