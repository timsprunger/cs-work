
import java.util.Scanner;
import java.io.*;

public class readAndWrite {

    public static void main(String[] args) {
        //input file
        File inputFile = new File("inputFile.txt");
        
        //dataFiles
        File dataFileA = new File("dataA.txt");
        File dataFileB = new File("dataB.txt");
        File dataFileC = new File("dataC.txt");
        File dataFileParity = new File("dataParity.txt");
        
        //define variables
        int inputFileSize = 0;
        int numDummyBytes = 0;
        byte a = 0;
        byte b = 0;
        byte c = 0;
        byte d = 0;
        byte scenarioOneParityByte = 0;
        byte scenarioTwoParityByte = 0;
        byte scenarioThreeParityByte = 0;
        byte dummyByte = 80;
        byte aV = 0;
        byte bV = 0;
        byte cV = 0;
        byte parityV = 0;
        
        
        try {
            //data input stream
            DataInputStream fileIn = new DataInputStream(new FileInputStream(inputFile));
            
            // data output streams
            DataOutputStream fileAOut = new DataOutputStream(new FileOutputStream(dataFileA, false)); //true = append
            DataOutputStream fileBOut = new DataOutputStream(new FileOutputStream(dataFileB, false)); //true = append
            DataOutputStream fileCOut = new DataOutputStream(new FileOutputStream(dataFileC, false)); //true = append
            DataOutputStream fileParityOut = new DataOutputStream(new FileOutputStream(dataFileParity, false)); //true = append           
            
            inputFileSize = (int) inputFile.length();
            
            if (inputFileSize % 3 == 0)
            {
                numDummyBytes = 0;
                aV = 49; //valid
                bV = 49; //valid
                cV = 49; //valid
                parityV = 49; //valid
            }
            else if (inputFileSize % 3 == 1)
            {
                numDummyBytes = 2;
                aV = 49; //valid
                bV = 48; //not valid
                cV = 48; //not valid
                parityV = 49; //valid
            }
            else
            {
                numDummyBytes = 1;
                aV = 49; //not valid
                bV = 49; //valid
                cV = 48; //not valid
                parityV = 49; //valid
                
            }
                
            if (numDummyBytes == 0)
            {
                fileAOut.writeByte(aV);
                fileBOut.writeByte(bV);
                fileCOut.writeByte(cV);
                fileParityOut.writeByte( (byte) (aV^bV^cV) );
                
                while (fileIn.available() > 0)
                {
                    if (fileIn.available() > 0)
                    {
                        a = fileIn.readByte();
                        fileAOut.writeByte(a);
                    }
                    
                    if (fileIn.available() > 0)
                    {
                        b = fileIn.readByte();
                        fileBOut.writeByte(b);
                    }
                    
                    if (fileIn.available() > 0)
                    {
                        c = fileIn.readByte();
                        fileCOut.writeByte(c);
                    }
                    
                    scenarioOneParityByte = (byte) (a^b^c);
                    fileParityOut.write(scenarioOneParityByte);
                
                }    
            }
            
            if (numDummyBytes == 1)
            {
                fileAOut.writeByte(aV);
                fileBOut.writeByte(bV);
                fileCOut.writeByte(cV);
                fileParityOut.writeByte( (byte) (aV^bV^cV) );
            
                while (fileIn.available() > 0)
                {
                    if (fileIn.available() > 0)
                    {
                        a = fileIn.readByte();
                        fileAOut.writeByte(a);
                    }
                    
                    if (fileIn.available() > 0)
                    {
                        b = fileIn.readByte();
                        fileBOut.writeByte(b);
                    }
                    
                    if (fileIn.available() > 0)
                    {
                        c = fileIn.readByte();
                        fileCOut.writeByte(c);
                    }
                    
                    if (fileIn.available() == 0)
                    {
                        c = dummyByte;
                        fileCOut.write(dummyByte);
                    }
                    
                    scenarioTwoParityByte = (byte) (a^b^c);
                    fileParityOut.write(scenarioTwoParityByte);
                }    
            }
            
            if (numDummyBytes == 2)
            {
                fileAOut.writeByte(aV);
                fileBOut.writeByte(bV);
                fileCOut.writeByte(cV);
                fileParityOut.writeByte( (byte) (aV^bV^cV) );
            
                while (fileIn.available() > 0)
                {
                    if (fileIn.available() > 0)
                    {
                        a = fileIn.readByte();
                        fileAOut.writeByte(a);
                    }
                    
                    if (fileIn.available() > 0)
                    {
                        b = fileIn.readByte();
                        fileBOut.writeByte(b);
                    }
                    
                    if (fileIn.available() > 0)
                    {
                        c = fileIn.readByte();
                        fileCOut.writeByte(c);
                    }
                    
                    if (fileIn.available() == 0)
                    {
                        b = dummyByte;
                        fileBOut.write(dummyByte);
                    }
                    
                    if (fileIn.available() == 0)    
                    {
                        c = dummyByte;
                        fileCOut.write(dummyByte);   
                    }
                    
                    scenarioTwoParityByte = (byte) (a^b^c);
                    fileParityOut.write(scenarioTwoParityByte);
                }    
            }                      

            fileAOut.close();
            fileBOut.close();
            fileCOut.close();
            fileParityOut.close();
            fileIn.close(); 
        }
        catch (EOFException e) {
            System.out.println("EOF Error: " + e.toString());
        }
        catch (Exception e) {
            System.out.println("Error: " + e.toString());
        }
    }
}