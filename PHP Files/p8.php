<!--
    Tim Sprunger
    p8.php
    April 18, 2018
    This PHP program explores the use of the server-sided
    scripting language PHP to dynamically create a web page. 
    The program dynamically adds jpg files from a directory and 
    adds captions from a text-delimited files to the appropriate 
    images.
-->

<!DOCTYPE HTML>
<html>
    
<head>
	<meta charset="UTF-8"/>
    <title>P8 PHP Web Links</title>
    
    <style>
        body{
            margin-left: 50px;
        }
        
        p{
            font-size: 2em; 
            width: 350px;
            text-align: center;
            padding-left: 10px;
            padding-right: 10px;
        }
        
        h1{
            font-size: 4em;
            margin-bottom: 0;
        }

        
        .images{
            display: inline-block;
            margin: 15px 5px 15px 5px;
        }

        img {
            margin: 5px 5px 5px 5px;
            border: 5px solid black;
            border-radius: 10%;
        }
        
        img:hover {
            opacity: 0.75;
        }
    </style> 
</head>

<body>
    <h1>P8 – Image Thumbnails</h1>
    <hr>
    <?php
        
    $images = glob("*.jpg");
    sort($images);
    
    $allData = file_get_contents("captions.txt");
    $lineData = explode("\n", $allData);
    sort($lineData);
            
    for($x=0; $x<count($images); $x++)
    {
        ?>
        
        <p class = "images">
            <a href = "<?php echo $images[$x]; ?>">
            <img src = "<?php echo $images[$x]; ?>" width = "350";>
            </a>
        <?php
            for($i=0; $i<count($lineData); $i++)
            {
                $itemData = explode(",", $lineData[$i]);
            
                if(strcmp($images[$x], $itemData[0]) == 0)
                {
                echo $itemData[1];
                }              
            }   
        ?>    
        </p>
        <?php   
    } 
    ?>
    
<hr>
</body>
    
</html>