/*
    p12GUI.java
    Tim Sprunger
    Graphical User Interface for p12.java
 */

package p12;

import java.io.BufferedReader;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.EOFException;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.PrintWriter;
import java.text.DecimalFormat; 
import javax.swing.*;

public class p12GUI extends javax.swing.JFrame 
{

    public p12GUI() 
    {
        initComponents();
    }

    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        sizeButtonGroup = new javax.swing.ButtonGroup();
        title = new javax.swing.JLabel();
        nameLabel = new javax.swing.JLabel();
        nameText = new javax.swing.JTextField();
        pizzaToppings = new javax.swing.JLabel();
        pepperoniRadioButton = new javax.swing.JRadioButton();
        sausageRadioButton = new javax.swing.JRadioButton();
        baconRadioButton = new javax.swing.JRadioButton();
        pickOne = new javax.swing.JLabel();
        hamRadioButton = new javax.swing.JRadioButton();
        blackOlivesRadioButton = new javax.swing.JRadioButton();
        chickenRadioButton = new javax.swing.JRadioButton();
        addressLabel = new javax.swing.JLabel();
        addressText = new javax.swing.JTextField();
        deliverBox = new javax.swing.JCheckBox();
        totalText = new javax.swing.JTextField();
        calculateButton = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();
        smallRadioButton = new javax.swing.JRadioButton();
        mediumRadioButton = new javax.swing.JRadioButton();
        largeRadioButton = new javax.swing.JRadioButton();
        totalPepperoniLabel = new javax.swing.JLabel();
        totalPepperoniTextField = new javax.swing.JTextField();
        submitButton = new javax.swing.JButton();
        totalDeliveredLabel = new javax.swing.JLabel();
        totalDeliveredTextField = new javax.swing.JTextField();
        jMenuBar = new javax.swing.JMenuBar();
        fileMenu = new javax.swing.JMenu();
        newItem = new javax.swing.JMenuItem();
        exitItem = new javax.swing.JMenuItem();
        helpMenu = new javax.swing.JMenu();
        aboutItem = new javax.swing.JMenuItem();
        csMenu = new javax.swing.JMenu();
        saveTextMenuItem = new javax.swing.JMenuItem();
        openTextMenuItem = new javax.swing.JMenuItem();
        saveBinaryMenuItem = new javax.swing.JMenuItem();
        openBinaryMenuItem = new javax.swing.JMenuItem();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        title.setText("Pizza Order");

        nameLabel.setText("Name:");

        nameText.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                nameTextActionPerformed(evt);
            }
        });

        pizzaToppings.setText("Pizza Toppings:");

        pepperoniRadioButton.setText("Pepperoni");
        pepperoniRadioButton.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                pepperoniRadioButtonItemStateChanged(evt);
            }
        });

        sausageRadioButton.setText("Sausage");
        sausageRadioButton.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                sausageRadioButtonItemStateChanged(evt);
            }
        });

        baconRadioButton.setText("Bacon");
        baconRadioButton.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                baconRadioButtonItemStateChanged(evt);
            }
        });

        pickOne.setText("($5.00 each)");

        hamRadioButton.setText("Ham");
        hamRadioButton.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                hamRadioButtonItemStateChanged(evt);
            }
        });
        hamRadioButton.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                hamRadioButtonActionPerformed(evt);
            }
        });

        blackOlivesRadioButton.setText("Black Olives");
        blackOlivesRadioButton.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                blackOlivesRadioButtonItemStateChanged(evt);
            }
        });

        chickenRadioButton.setText("Chicken");
        chickenRadioButton.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                chickenRadioButtonItemStateChanged(evt);
            }
        });

        addressLabel.setText("Address:");

        deliverBox.setText("Delivered ($10.00 Fee)");
        deliverBox.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                deliverBoxItemStateChanged(evt);
            }
        });
        deliverBox.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                deliverBoxActionPerformed(evt);
            }
        });

        totalText.setEditable(false);
        totalText.setText("$0.00");
        totalText.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                totalTextActionPerformed(evt);
            }
        });

        calculateButton.setText("Calculate Total");
        calculateButton.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                calculateButtonActionPerformed(evt);
            }
        });

        jLabel1.setText("Pizza Size:");

        sizeButtonGroup.add(smallRadioButton);
        smallRadioButton.setSelected(true);
        smallRadioButton.setText("Small ($8.00)");
        smallRadioButton.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                smallRadioButtonItemStateChanged(evt);
            }
        });
        smallRadioButton.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                smallRadioButtonActionPerformed(evt);
            }
        });

        sizeButtonGroup.add(mediumRadioButton);
        mediumRadioButton.setText("Medium ($10.00)");
        mediumRadioButton.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                mediumRadioButtonItemStateChanged(evt);
            }
        });
        mediumRadioButton.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                mediumRadioButtonActionPerformed(evt);
            }
        });

        sizeButtonGroup.add(largeRadioButton);
        largeRadioButton.setText("Large ($12.00)");
        largeRadioButton.addItemListener(new java.awt.event.ItemListener() {
            public void itemStateChanged(java.awt.event.ItemEvent evt) {
                largeRadioButtonItemStateChanged(evt);
            }
        });

        totalPepperoniLabel.setText("Total Orders with Pepperoni: ");

        submitButton.setText("Submit");
        submitButton.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                submitButtonActionPerformed(evt);
            }
        });

        totalDeliveredLabel.setText("Total Orders Delivered: ");

        fileMenu.setText("File");
        fileMenu.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                fileMenuActionPerformed(evt);
            }
        });

        newItem.setAccelerator(javax.swing.KeyStroke.getKeyStroke(java.awt.event.KeyEvent.VK_N, 0));
        newItem.setText("New");
        newItem.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                newItemActionPerformed(evt);
            }
        });
        fileMenu.add(newItem);

        exitItem.setAccelerator(javax.swing.KeyStroke.getKeyStroke(java.awt.event.KeyEvent.VK_X, 0));
        exitItem.setText("Exit");
        exitItem.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                exitItemActionPerformed(evt);
            }
        });
        fileMenu.add(exitItem);

        jMenuBar.add(fileMenu);

        helpMenu.setText("Help");

        aboutItem.setText("About");
        aboutItem.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                aboutItemActionPerformed(evt);
            }
        });
        helpMenu.add(aboutItem);

        jMenuBar.add(helpMenu);

        csMenu.setText("CS216");

        saveTextMenuItem.setAccelerator(javax.swing.KeyStroke.getKeyStroke(java.awt.event.KeyEvent.VK_S, java.awt.event.InputEvent.CTRL_MASK));
        saveTextMenuItem.setText("Save Text");
        saveTextMenuItem.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                saveTextMenuItemActionPerformed(evt);
            }
        });
        csMenu.add(saveTextMenuItem);

        openTextMenuItem.setText("Open Text");
        openTextMenuItem.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                openTextMenuItemActionPerformed(evt);
            }
        });
        csMenu.add(openTextMenuItem);

        saveBinaryMenuItem.setText("Save Binary");
        saveBinaryMenuItem.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                saveBinaryMenuItemActionPerformed(evt);
            }
        });
        csMenu.add(saveBinaryMenuItem);

        openBinaryMenuItem.setText("Open Binary");
        openBinaryMenuItem.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                openBinaryMenuItemActionPerformed(evt);
            }
        });
        csMenu.add(openBinaryMenuItem);

        jMenuBar.add(csMenu);

        setJMenuBar(jMenuBar);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                        .addGroup(layout.createSequentialGroup()
                            .addGap(48, 48, 48)
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                .addComponent(addressLabel)
                                .addComponent(nameLabel)
                                .addComponent(jLabel1)
                                .addComponent(pizzaToppings))
                            .addGap(18, 18, 18)
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                .addComponent(addressText)
                                .addGroup(layout.createSequentialGroup()
                                    .addComponent(smallRadioButton)
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                    .addComponent(mediumRadioButton)
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                    .addComponent(largeRadioButton))
                                .addComponent(nameText)))
                        .addGroup(layout.createSequentialGroup()
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                .addGroup(layout.createSequentialGroup()
                                    .addGap(70, 70, 70)
                                    .addComponent(pickOne)
                                    .addGap(18, 18, 18))
                                .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                                    .addContainerGap()
                                    .addComponent(calculateButton, javax.swing.GroupLayout.PREFERRED_SIZE, 138, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)))
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(deliverBox)
                                    .addGroup(layout.createSequentialGroup()
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                            .addComponent(sausageRadioButton)
                                            .addComponent(baconRadioButton)
                                            .addComponent(pepperoniRadioButton))
                                        .addGap(18, 18, 18)
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                            .addComponent(blackOlivesRadioButton)
                                            .addComponent(hamRadioButton)
                                            .addComponent(chickenRadioButton)))
                                    .addComponent(totalText))
                                .addGroup(layout.createSequentialGroup()
                                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                        .addComponent(totalPepperoniLabel)
                                        .addComponent(totalDeliveredLabel)
                                        .addComponent(submitButton))
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                        .addComponent(totalPepperoniTextField, javax.swing.GroupLayout.DEFAULT_SIZE, 81, Short.MAX_VALUE)
                                        .addComponent(totalDeliveredTextField))))))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(265, 265, 265)
                        .addComponent(title)))
                .addContainerGap(57, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(43, 43, 43)
                .addComponent(title)
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(nameLabel)
                    .addComponent(nameText, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(addressLabel)
                    .addComponent(addressText, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(smallRadioButton)
                    .addComponent(mediumRadioButton)
                    .addComponent(largeRadioButton))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(pizzaToppings)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(pickOne))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(pepperoniRadioButton)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(sausageRadioButton)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(baconRadioButton))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(hamRadioButton)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(blackOlivesRadioButton)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(chickenRadioButton)))
                .addGap(18, 18, 18)
                .addComponent(deliverBox)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(totalText, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(calculateButton))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(totalPepperoniTextField, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(totalPepperoniLabel))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(totalDeliveredLabel)
                    .addComponent(totalDeliveredTextField, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addComponent(submitButton)
                .addContainerGap(29, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void nameTextActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_nameTextActionPerformed
        
    }//GEN-LAST:event_nameTextActionPerformed

    private void hamRadioButtonActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_hamRadioButtonActionPerformed
        
    }//GEN-LAST:event_hamRadioButtonActionPerformed

    private void totalTextActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_totalTextActionPerformed
       
    }//GEN-LAST:event_totalTextActionPerformed

    private void deliverBoxActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_deliverBoxActionPerformed
       
    }//GEN-LAST:event_deliverBoxActionPerformed

    private void calculateButtonActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_calculateButtonActionPerformed
        double total = 0.0;
        
        if (smallRadioButton.isSelected() == true)
            total = total + 8.00;
        else if (mediumRadioButton.isSelected() == true)
            total = total + 10.00;
        else
            total = total + 12.00;
        
        if (pepperoniRadioButton.isSelected() == true)
            total = total + 5.00;
        
        if (hamRadioButton.isSelected() == true)
            total = total + 5.00;
         
        if (sausageRadioButton.isSelected() == true)
            total = total + 5.00;
        
        if (baconRadioButton.isSelected() == true)
            total = total + 5.00;
        
        if (blackOlivesRadioButton.isSelected() == true)
            total = total + 5.00;
        
        if (chickenRadioButton.isSelected() == true)
            total = total + 5.00;
        
        if (deliverBox.isSelected() == true)
            total = total + 10.00;

        
        DecimalFormat df = new DecimalFormat(".00");
        String totalString = df.format(total);
        totalText.setText("$" +  totalString);
    }//GEN-LAST:event_calculateButtonActionPerformed

    private void exitItemActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_exitItemActionPerformed
        System.exit(0);
    }//GEN-LAST:event_exitItemActionPerformed

    private void aboutItemActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_aboutItemActionPerformed
        aboutForm form = new aboutForm();
        form.setVisible(true);
    }//GEN-LAST:event_aboutItemActionPerformed

    private void mediumRadioButtonActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_mediumRadioButtonActionPerformed
        
    }//GEN-LAST:event_mediumRadioButtonActionPerformed

    private void smallRadioButtonItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_smallRadioButtonItemStateChanged

    }//GEN-LAST:event_smallRadioButtonItemStateChanged

    private void mediumRadioButtonItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_mediumRadioButtonItemStateChanged

    }//GEN-LAST:event_mediumRadioButtonItemStateChanged

    private void largeRadioButtonItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_largeRadioButtonItemStateChanged

    }//GEN-LAST:event_largeRadioButtonItemStateChanged

    private void pepperoniRadioButtonItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_pepperoniRadioButtonItemStateChanged

    }//GEN-LAST:event_pepperoniRadioButtonItemStateChanged

    private void hamRadioButtonItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_hamRadioButtonItemStateChanged

    }//GEN-LAST:event_hamRadioButtonItemStateChanged

    private void sausageRadioButtonItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_sausageRadioButtonItemStateChanged

    }//GEN-LAST:event_sausageRadioButtonItemStateChanged

    private void blackOlivesRadioButtonItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_blackOlivesRadioButtonItemStateChanged

    }//GEN-LAST:event_blackOlivesRadioButtonItemStateChanged

    private void baconRadioButtonItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_baconRadioButtonItemStateChanged

    }//GEN-LAST:event_baconRadioButtonItemStateChanged

    private void chickenRadioButtonItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_chickenRadioButtonItemStateChanged

    }//GEN-LAST:event_chickenRadioButtonItemStateChanged

    private void deliverBoxItemStateChanged(java.awt.event.ItemEvent evt) {//GEN-FIRST:event_deliverBoxItemStateChanged

    }//GEN-LAST:event_deliverBoxItemStateChanged

    private void fileMenuActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_fileMenuActionPerformed
        
    }//GEN-LAST:event_fileMenuActionPerformed

    private void newItemActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_newItemActionPerformed
 
        smallRadioButton.setSelected(true); 
                
        if (pepperoniRadioButton.isSelected() == true)
            pepperoniRadioButton.setSelected(false);
        
        if (baconRadioButton.isSelected() == true)
            baconRadioButton.setSelected(false);
                        
        if (sausageRadioButton.isSelected() == true)
            sausageRadioButton.setSelected(false);
         
        if (hamRadioButton.isSelected() == true)
            hamRadioButton.setSelected(false);
        
        if (blackOlivesRadioButton.isSelected() == true)
            blackOlivesRadioButton.setSelected(false);
        
        if (chickenRadioButton.isSelected() == true)
            chickenRadioButton.setSelected(false);
        
        deliverBox.setSelected(false);
        
        totalText.setText("$0.00"); 
        
        nameText.setText("");
        addressText.setText("");
        
        totalPepperoniTextField.setText("");
        totalDeliveredTextField.setText("");
    }//GEN-LAST:event_newItemActionPerformed

    private void saveTextMenuItemActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_saveTextMenuItemActionPerformed

        String size = "undefined";
        String pepperoni = "N";
        String sausage = "N";
        String bacon = "N";
        String ham = "N";
        String blackOlives = "N";
        String chicken = "N";
        String delivered = "N";
        
        String name = nameText.getText();
        String address = addressText.getText();

        if (smallRadioButton.isSelected() == true)
        {
            size = "small";
        }
        else if (mediumRadioButton.isSelected() == true)
        {
            size = "medium";
        }
        else
        {
            size = "large";
        }
        
        if (pepperoniRadioButton.isSelected() == true)
        {
            pepperoni = "Y";  
        }

       if (sausageRadioButton.isSelected() == true)
        {
            sausage = "Y";  
        }
       
       if (baconRadioButton.isSelected() == true)
        {
            bacon = "Y";  
        }
       
       if (hamRadioButton.isSelected() == true)
        {
            ham = "Y"; 
        }
       
       if (blackOlivesRadioButton.isSelected() == true)
        {
            blackOlives = "Y"; 
        }
       
       if (chickenRadioButton.isSelected() == true)
        {
            chicken = "Y"; 
        }
       
       if (deliverBox.isSelected() == true)
       {
           delivered = "Y";
       }
        
       try{
            File fileOut = new File("p13.txt");
            
            FileOutputStream fos = new FileOutputStream(fileOut, true);
            PrintWriter outFS = new PrintWriter(fos);
            
            outFS.println(name + "," + address + "," + size + "," + pepperoni + "," + sausage + "," + bacon + "," + ham + "," + blackOlives + "," + chicken + "," + delivered);
            
            outFS.flush();
            fos.close();
        }
        catch (Exception e){
            System.out.println( "Error: " + e.toString() );
        }
    }//GEN-LAST:event_saveTextMenuItemActionPerformed

    private void smallRadioButtonActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_smallRadioButtonActionPerformed
        
    }//GEN-LAST:event_smallRadioButtonActionPerformed

    private void openTextMenuItemActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_openTextMenuItemActionPerformed
        try{
            File fileIn = new File("p13.txt");

           int totalPepperoni = 0;
     
            String name1 = "";
            String address1 = "";
            String size1 = "";
            String pepperoni1 = "";
            String sausage1 = "";
            String bacon1 = "";
            String ham1 = "";
            String blackOlives1 = "";
            String chicken1 = "";
            String delivered1 = "";

            BufferedReader dataIn = new BufferedReader(new FileReader(fileIn));
            
            String lineText = dataIn.readLine();
                        
            while (lineText != null)
            {
                if ( !lineText.equals("") )
                {
                    String data[] = lineText.split("\\s*,\\s*");
                    
                    name1 = data[0];
                    address1 = data[1];
                    size1 = data[2];
                    pepperoni1 = data[3];
                    sausage1 = data[4];
                    bacon1 = data[5];
                    ham1 = data[6];
                    blackOlives1 = data[7];
                    chicken1 = data[8];
                    delivered1 = data[9];
                    
                    if ( data[3].equals("Y") )
                    {
                        totalPepperoni++;
                    }                    
                }
                lineText = dataIn.readLine();
            }
            dataIn.close();
            
            totalPepperoniTextField.setText(Integer.toString(totalPepperoni));
            
            nameText.setText(name1);
            addressText.setText(address1);
            
            if (size1.equals("small"))
                smallRadioButton.setSelected(true);
            else if (size1.equals("medium"))
                mediumRadioButton.setSelected(true);
            else
                largeRadioButton.setSelected(true);
            
            if (delivered1.equals("Y"))
                deliverBox.setSelected(true);
            else
                deliverBox.setSelected(false);
            
            if (pepperoni1.equals("Y"))
                pepperoniRadioButton.setSelected(true);
            else
                pepperoniRadioButton.setSelected(false);
            
            if (sausage1.equals("Y"))
                sausageRadioButton.setSelected(true);
            else
                sausageRadioButton.setSelected(false);            
    
            if (bacon1.equals("Y"))
                baconRadioButton.setSelected(true);
            else
                baconRadioButton.setSelected(false);          
            
            if (ham1.equals("Y"))
                hamRadioButton.setSelected(true);
            else
                hamRadioButton.setSelected(false);

            if (blackOlives1.equals("Y"))
                blackOlivesRadioButton.setSelected(true);
            else
                blackOlivesRadioButton.setSelected(false);
            
            if (chicken1.equals("Y"))
                chickenRadioButton.setSelected(true);
            else
                chickenRadioButton.setSelected(false);       
        }
        catch(Exception e){
            System.out.println( "Error: " + e.toString() );
        }     
    }//GEN-LAST:event_openTextMenuItemActionPerformed

    private void submitButtonActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_submitButtonActionPerformed
        System.exit(0);
    }//GEN-LAST:event_submitButtonActionPerformed

    private void saveBinaryMenuItemActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_saveBinaryMenuItemActionPerformed
        //File fileName = new File("p14.dat");
        
        String currentDirectory = System.getProperty("user.dir");
        JFileChooser fileChooser = new JFileChooser(currentDirectory);

        binaryFilter bf = new binaryFilter();
        fileChooser.addChoosableFileFilter(bf);

        int result = fileChooser.showSaveDialog(null);

        if(result == JFileChooser.APPROVE_OPTION)
        {
            File fileName = fileChooser.getSelectedFile();

            try{
                DataOutputStream fileOut = new DataOutputStream(new FileOutputStream(fileName, true));
            
                fileOut.writeUTF( nameText.getText() );
                fileOut.writeUTF( addressText.getText() );
            
                byte b = 0;
            
                if (smallRadioButton.isSelected() == true)
                    b = 1;
                else if (mediumRadioButton.isSelected() == true)
                    b = 2;
                else
                    b = 3;
            
                fileOut.writeByte(b);
            
                boolean pepperoni2 = false;
                boolean sausage2 = false;
                boolean bacon2 = false;
                boolean ham2 = false;
                boolean blackOlives2 = false;
                boolean chicken2 = false;
                
                if (pepperoniRadioButton.isSelected() == true)
                    pepperoni2 = true;
            
                if (sausageRadioButton.isSelected() == true)
                    sausage2 = true;

                if (baconRadioButton.isSelected() == true)
                    bacon2 = true;
            
                if (baconRadioButton.isSelected() == true)
                    bacon2 = true;
            
                if (blackOlivesRadioButton.isSelected() == true)
                    blackOlives2 = true;
            
                if (chickenRadioButton.isSelected() == true)
                    chicken2 = true;
            
                fileOut.writeBoolean(pepperoni2);
                fileOut.writeBoolean(sausage2);
                fileOut.writeBoolean(bacon2);
                fileOut.writeBoolean(ham2);
                fileOut.writeBoolean(blackOlives2);
                fileOut.writeBoolean(chicken2);
            
                boolean delivered2 = false;
            
                if (deliverBox.isSelected() == true)
                    delivered2 = true;
            
                fileOut.writeBoolean(delivered2);        
            }
            catch (Exception e){
                System.out.println( "Error: " + e.toString() );
            }
            this.setTitle( fileName.getName() );
        }
        else
            System.out.println("Cancelled");
    }//GEN-LAST:event_saveBinaryMenuItemActionPerformed

    private void openBinaryMenuItemActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_openBinaryMenuItemActionPerformed
        try{
            int totalDelivered = 0;
            
            String currentDirectory = System.getProperty("user.dir");
            JFileChooser fileChooser = new JFileChooser(currentDirectory);

            binaryFilter bf = new binaryFilter();
            fileChooser.addChoosableFileFilter(bf);

            int result = fileChooser.showOpenDialog(null);

            if(result == JFileChooser.APPROVE_OPTION)
            {
                File fileName = fileChooser.getSelectedFile();
                System.out.println("Approved");

                //File fileName = new File("p14.dat");
            
                DataInputStream fileIn = new DataInputStream(new FileInputStream(fileName));

                while (fileIn.available() > 0) 
                {
                    String name3 = fileIn.readUTF();
                    String address3 = fileIn.readUTF();
                    byte size3 = fileIn.readByte();
                    boolean pepperoni3 = fileIn.readBoolean();
                    boolean sausage3 = fileIn.readBoolean();
                    boolean bacon3 = fileIn.readBoolean();
                    boolean ham3 = fileIn.readBoolean();
                    boolean blackOlives3 = fileIn.readBoolean();
                    boolean chicken3 = fileIn.readBoolean();
                    boolean delivered3 = fileIn.readBoolean();

                    if (delivered3 == true) 
                        totalDelivered++;

                    nameText.setText(name3);
                    addressText.setText(address3);

                    if (size3 == 1) 
                        smallRadioButton.setSelected(true);
                    else if (size3 == 2) 
                        mediumRadioButton.setSelected(true);
                    else 
                        largeRadioButton.setSelected(true);

                    if (pepperoni3 == true) 
                        pepperoniRadioButton.setSelected(true);
                    else 
                        pepperoniRadioButton.setSelected(false);

                    if (sausage3 == true) 
                        sausageRadioButton.setSelected(true);
                    else 
                        sausageRadioButton.setSelected(false);

                    if (bacon3 == true) 
                        baconRadioButton.setSelected(true); 
                    else 
                        baconRadioButton.setSelected(false);

                    if (ham3 == true) 
                        hamRadioButton.setSelected(true);
                    else 
                        hamRadioButton.setSelected(false);

                    if (blackOlives3 == true) 
                        blackOlivesRadioButton.setSelected(true);
                    else 
                        blackOlivesRadioButton.setSelected(false);

                    if (chicken3 == true) 
                        chickenRadioButton.setSelected(true);
                    else 
                        chickenRadioButton.setSelected(false);

                    if (delivered3 == true) 
                        deliverBox.setSelected(true);
                    else 
                        deliverBox.setSelected(false);
                
                    totalDeliveredTextField.setText(Integer.toString(totalDelivered));                    
                }
                this.setTitle( fileName.getName() );
                fileIn.close();
            }
            else
                System.out.println("Cancelled");
        }
        catch(EOFException e){
            System.out.println( "EOF Error: " + e.toString() );
        }
        catch (Exception e){
            System.out.println( "Error: " + e.toString() );
        }
    }//GEN-LAST:event_openBinaryMenuItemActionPerformed

    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(p12GUI.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(p12GUI.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(p12GUI.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(p12GUI.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(() -> {
            new p12GUI().setVisible(true);
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JMenuItem aboutItem;
    private javax.swing.JLabel addressLabel;
    private javax.swing.JTextField addressText;
    private javax.swing.JRadioButton baconRadioButton;
    private javax.swing.JRadioButton blackOlivesRadioButton;
    private javax.swing.JButton calculateButton;
    private javax.swing.JRadioButton chickenRadioButton;
    private javax.swing.JMenu csMenu;
    private javax.swing.JCheckBox deliverBox;
    private javax.swing.JMenuItem exitItem;
    private javax.swing.JMenu fileMenu;
    private javax.swing.JRadioButton hamRadioButton;
    private javax.swing.JMenu helpMenu;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JMenuBar jMenuBar;
    private javax.swing.JRadioButton largeRadioButton;
    private javax.swing.JRadioButton mediumRadioButton;
    private javax.swing.JLabel nameLabel;
    private javax.swing.JTextField nameText;
    private javax.swing.JMenuItem newItem;
    private javax.swing.JMenuItem openBinaryMenuItem;
    private javax.swing.JMenuItem openTextMenuItem;
    private javax.swing.JRadioButton pepperoniRadioButton;
    private javax.swing.JLabel pickOne;
    private javax.swing.JLabel pizzaToppings;
    private javax.swing.JRadioButton sausageRadioButton;
    private javax.swing.JMenuItem saveBinaryMenuItem;
    private javax.swing.JMenuItem saveTextMenuItem;
    private javax.swing.ButtonGroup sizeButtonGroup;
    private javax.swing.JRadioButton smallRadioButton;
    private javax.swing.JButton submitButton;
    private javax.swing.JLabel title;
    private javax.swing.JLabel totalDeliveredLabel;
    private javax.swing.JTextField totalDeliveredTextField;
    private javax.swing.JLabel totalPepperoniLabel;
    private javax.swing.JTextField totalPepperoniTextField;
    private javax.swing.JTextField totalText;
    // End of variables declaration//GEN-END:variables
}
