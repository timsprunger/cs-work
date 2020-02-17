/*
    p12.java
    Tim Sprunger
    The p12 class creates a new instance of the p12GUI.java Grahpical 
    User Interface
 */

package p12;

import javax.swing.*;

public class P12 {

    public static void main(String[] args) {
        p12GUI newFrame = new p12GUI();
        newFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        newFrame.pack(); 
        newFrame.setVisible(true);
    }   
}
