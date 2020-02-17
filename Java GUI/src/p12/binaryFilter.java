/*
    binaryFilter.java
    Tim Sprunger
    Filter for Binary Files (.dat)
 */

package p12;

import java.io.*;

public class binaryFilter extends javax.swing.filechooser.FileFilter
{
    public boolean accept(File f)
    {
        return f.getName().toLowerCase().endsWith(".dat") || f.isDirectory();
    }
    
    public String getDescription()
    {
        return "Binary File (*.dat)";
    } 
}
