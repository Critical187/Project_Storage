/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication1;

import people.Butler;
import people.HouseRobot;
import people.Housekeeper;
import people.Person;

/**
 *
 * @author Ilia
 */
public class JavaApplication1 {

    /**
     * @param args the command line arguments
     */
    static void print(Object o){
        System.out.println(o);
    }
    static void print(String o){
        System.out.println(o);
    }
    public static void main(String[] args) {
        {
        Person[] people = new Person[]{new Person("Tim", 0), new Person("Jim", 0), new Person("Bill",0), new Person("Quill",0), new Person("Stil", 0), new Person("Dill", 0), new Person("Mil",0)};
         if(args.length > 0){
             if(args[0].equals("who"))
                 for(Person p : people)
                     print(p.getName());
             else{
                 
                 for(String arg : args){
                     boolean found = false;
                     for(Person p : people ){
                         if(p.getName().equals(arg))
                         {
                             found = true;
                             break;
                         }
                     }
                     
                     if(found)
                         print("Person found");
                     else
                         print("Person not found");
                 }
                     
         
             }
         }
        }
        
        Housekeeper[] keepers = new Housekeeper[]{new Butler("Tim", 100),new HouseRobot(),new HouseRobot(),new HouseRobot()};
        
        for(Housekeeper keep : keepers){
            keep.wash();
            keep.vacuumClean();
        }
        
        HouseRobot robot = new HouseRobot();
        Butler butler = new Butler("Buttler", 1);
        
        robot.wash();
        print("Robot washed and has energy left:" + robot.getEnergy());
        robot.vacuumClean();
        print("Robot vaccumend and has energy left:" + robot.getEnergy());
        
        butler.wash();
        print(butler.getName() + " washed and has balance of:" + butler.getMoney());
        butler.vacuumClean();
        print(butler.getName() + " vaccumend and has balance of:" + butler.getMoney());
        
        
        // TODO code application logic here
        Person p = new Person("John", 100);
        Person p1 = new Person("Not John", -100);
        System.out.println();
        p.walk();
        p1.walk();
        
        p.spendMoney();
        p1.spendMoney();
    }
    
}
