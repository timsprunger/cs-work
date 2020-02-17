import java.util.concurrent.TimeUnit;
import java.util.Scanner;
import java.io.*;

public class recoverFile
{
    public static void main (String[] args)
    {
        //dataFiles
        File dataFileA = new File("dataA.txt");
        File dataFileB = new File("dataB.txt");
        File dataFileC = new File("dataC.txt");
        File dataFileParity = new File("dataParity.txt");
        File recoveredOriginalFile = new File("recoveredOriginalFile.txt");
        

        try{
            if (dataFileA.exists() == false)
                dataFileA.createNewFile();
                
            if (dataFileB.exists() == false)
                dataFileB.createNewFile();            
                
            if (dataFileC.exists() == false)
                dataFileC.createNewFile();           
                
            if (dataFileParity.exists() == false)
                dataFileParity.createNewFile();   
        }
        catch (EOFException e) {
            System.out.println("EOF Error: " + e.toString());
        }
        catch (Exception e) {
            System.out.println("Error: " + e.toString());
        }

        //define variables
        String diskFailureLetter = "";
        byte a = 0;
        byte b = 0;
        byte c = 0;
        byte d = 0;
        byte BCD = 0;
        byte ACD = 0;
        byte ABD = 0;
        byte ABC = 0;
        byte aV = 0;
        byte bV = 0;
        byte cV = 0;
        byte parityV = 0;
        int dataFileBSize = 0;
        int dataFileCSize = 0;
        int bCount = 1;
        int cCount = 1;

        try
        {
            //data input streams
            DataInputStream fileAIn = new DataInputStream(new FileInputStream(dataFileA));
            DataInputStream fileBIn = new DataInputStream(new FileInputStream(dataFileB));
            DataInputStream fileCIn = new DataInputStream(new FileInputStream(dataFileC));   
            DataInputStream fileParityIn = new DataInputStream(new FileInputStream(dataFileParity));

            // data output streams
            DataOutputStream fileAOut = new DataOutputStream(new FileOutputStream(dataFileA, true));
            DataOutputStream fileBOut = new DataOutputStream(new FileOutputStream(dataFileB, true));
            DataOutputStream fileCOut = new DataOutputStream(new FileOutputStream(dataFileC, true));
            DataOutputStream fileParityOut = new DataOutputStream(new FileOutputStream(dataFileParity, true));

            Scanner scnr = new Scanner( System.in ); 
        
            System.out.print("Enter Disk Letter That Was Destroyed: ");
            diskFailureLetter = scnr.next();
            
            System.out.println();
            System.out.println("Processing...");
            TimeUnit.SECONDS.sleep(2);
            System.out.println();     
              
            if ( diskFailureLetter.equals("A") )
            {
                while ( (fileBIn.available() > 0) )
                {    
                    b = fileBIn.readByte();
                    c = fileCIn.readByte();
                    d = fileParityIn.readByte();
                    
                    BCD = (byte) (b^c^d);
                    fileAOut.write(BCD);
                }
            }    
    
            if ( diskFailureLetter.equals("B") )
            {
                while ( (fileAIn.available() > 0) )
                {
                    a = fileAIn.readByte();
                    c = fileCIn.readByte();
                    d = fileParityIn.readByte();
                    
                    ACD = (byte) (a^c^d);
                    fileBOut.write(ACD);
                }
            }    
            
            if ( diskFailureLetter.equals("C") )
            {
                while ( (fileAIn.available() > 0) )
                {
                    a = fileAIn.readByte();
                    b = fileBIn.readByte();
                    d = fileParityIn.readByte();
                    
                    ABD = (byte) (a^b^d);
                    fileCOut.write(ABD);
                }
            }      
            
            if ( diskFailureLetter.equals("D") )
            {
                while ( (fileAIn.available() > 0) )
                {
                    a = fileAIn.readByte();
                    b = fileBIn.readByte();
                    c = fileCIn.readByte();
                    
                    ABC = (byte) (a^b^c);                    
                    fileParityOut.write(ABC);
                }
            }

            System.out.println("Disk " + diskFailureLetter + " Has Been Recovered.");
            
            System.out.println();
            System.out.println("Processing...");
            TimeUnit.SECONDS.sleep(2);
            System.out.println();  
            
            //close all files
            fileAIn.close();
            fileBIn.close();
            fileCIn.close();
            fileParityIn.close();
            fileAOut.close();
            fileBOut.close();
            fileCOut.close();
            fileParityOut.close();
            
            
            if (recoveredOriginalFile.exists() == true)
                recoveredOriginalFile.delete();
                
            recoveredOriginalFile.createNewFile();
            
            
            //open new streams needed for recreating new file
            DataInputStream newfileAIn = new DataInputStream(new FileInputStream(dataFileA));
            DataInputStream newfileBIn = new DataInputStream(new FileInputStream(dataFileB));
            DataInputStream newfileCIn = new DataInputStream(new FileInputStream(dataFileC));   
            DataOutputStream recoveredOriginalFileOut = new DataOutputStream(new FileOutputStream(recoveredOriginalFile, false));  
            
          
            aV = newfileAIn.readByte();
            bV = newfileBIn.readByte();            
            cV = newfileCIn.readByte(); 
            
            dataFileBSize = (int) ( dataFileB.length() );
            dataFileCSize = (int) ( dataFileC.length() );  
            
            
            if (bV == 48)
            {
                dataFileBSize--;
            }
                
            if (cV == 48)
            {
                dataFileCSize--;
            }
            
                
            while ( (newfileAIn.available() > 0) )
            {
                a = newfileAIn.readByte();
                recoveredOriginalFileOut.write(a); 

                if (bCount < dataFileBSize)
                {
                    b = newfileBIn.readByte();
                    recoveredOriginalFileOut.write(b);
                    bCount++;
                }
                if (cCount < dataFileCSize)
                {
                    c = newfileCIn.readByte();
                    recoveredOriginalFileOut.write(c);
                    cCount++;
                }
            }
        
            System.out.println("Original Text File Has Been Destroyed and Rebuilt.");
            
            //close files
            fileAIn.close();
            fileBIn.close();
            fileCIn.close();
            recoveredOriginalFileOut.close();
            
        }
        catch (EOFException e) {
            System.out.println("EOF Error: " + e.toString());
        }
        catch (Exception e) {
            System.out.println("Error: " + e.toString());
        }
    }
}
