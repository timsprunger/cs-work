/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package p12;

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

/**
 *
 * @author timsprunger
 */

public class aboutForm extends JFrame implements ActionListener {

    JLabel createdLabel; 
    JLabel byLabel;
    JLabel imageLabel;
    JButton okButton;

    public aboutForm() 
    {
        createdLabel = new JLabel("Program Created");
        byLabel = new JLabel("By Tim Sprunger");

        imageLabel = new JLabel();
        Icon myPic = new ImageIcon(getClass().getResource("logo.jpg"));

        imageLabel.setIcon(myPic);

        okButton = new JButton("  Close  ");
        okButton.addActionListener(this);

        this.setLayout(new GridBagLayout());
        GridBagConstraints layoutConst;

        layoutConst = new GridBagConstraints();
        layoutConst.insets = new Insets(50, 10, 10, 0);
        layoutConst.gridx = 1;
        layoutConst.gridy = 0;
        add(createdLabel, layoutConst);

        layoutConst = new GridBagConstraints();
        layoutConst.insets = new Insets(0, 10, 10, 0);
        layoutConst.gridx = 1;
        layoutConst.gridy = 1;
        add(byLabel, layoutConst);

        layoutConst = new GridBagConstraints();
        layoutConst.insets = new Insets(0, 10, 0, 0);
        layoutConst.gridx = 1;
        layoutConst.gridy = 2;
        add(okButton, layoutConst);

        layoutConst = new GridBagConstraints();
        layoutConst.insets = new Insets(10, 10, 10, 10);
        layoutConst.gridx = 0;
        layoutConst.gridy = 0;
        layoutConst.gridheight = 3;
        add(imageLabel, layoutConst);

        setTitle("P11 About Form – Tim Sprunger");  
        this.setResizable(false);
        this.setSize(450, 350);

    }
    
    @Override
    public void actionPerformed(ActionEvent event) {
        
        this.dispose();
        
    }

    public static void main(String[] args) {
        aboutForm aboutFrame = new aboutForm();
        aboutFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        aboutFrame.setVisible(true);
        return;
    }

}
