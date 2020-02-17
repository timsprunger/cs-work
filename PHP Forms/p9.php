<!DOCTYPE html>
<html>

<head>
    <title>Process Questionnaire</title>
    <meta charset="UTF-8"/>
    <link rel="stylesheet" type="text/css" href="p9.css"/>
</head>

<body>
    
<h1 id="headingleft">Thank you for completing the "Getting to know you questionnaire"!
</h1>

<?php

// Get Post Values 
$firstname = $_POST["firstname"];

if ($firstname == "")
{
	die("Error: Must Enter First Name");
}	

if (preg_match("/^[a-zA-Z]+$/", $firstname) != 1)
{
	die("Error: First Name Can Only Contain Letters");
}	

$lastname = $_POST["lastname"];

if ($lastname == "")
{
	die("Error: Must Enter Last Name");
}	

if (preg_match("/^[a-zA-Z]+$/", $lastname) != 1 )
{
	die("Error: Name Can Only Contain Letters");
}

$address = $_POST["address"];

if ($address == "")
{
	die("Error: Must Enter Address");
}

if (preg_match("/^\d+ [a-zA-Z]+([.])? ([a-zA-Z0-9]+) ?([a-zA-Z]+)?([.])?$/", $address) != 1)
{
	die("Error: Address Can Only Contain Letters, Numbers, Spaces, and Optional Period at End");
}	

$apt = $_POST["apt"];

$city = $_POST["city"];

if ($city == "")
{
    die("Error: Must Enter City");
}
      
if (preg_match("/^[a-zA-Z]+([.])? ?[a-zA-Z]+[.]? ?([a-zA-Z]+)?([.])?$/", $city) != 1)
{
    die("Error: City Can Only Contain Letters and Periods");
}

$state = $_POST["state"];
    
if ($state == "")
{
    die("Error: Must Enter State");
}
    
if (preg_match("/^[a-zA-Z]+ ?[a-zA-Z]+?$/", $state) != 1)
{
    die("Error: State Can Only Contain Letters");
}

$zip = $_POST["zip"];
    
if ($zip == "")
{
    die("Error: Must Enter Zip Code");
}

if (preg_match("/^\d{5}(-\d{4})?$/", $zip) != 1)
{
    die("Error: Zip Code Can Only Contain Numbers and Option Dash for Extension");
}

$movie = $_POST["movie"];

$meal = $_POST["meal"];    
  
if (isset($_POST["pizza"]))
	$pizza = "Y";
else
	$pizza = "N";
    
$family = $_POST["family"];

if ($family == "")
{
	die("Error: Must Enter Family Size");
}

if (preg_match("/^[0-9]+$/", $family) != 1 )
{
	die("Error: Must Enter Number For Family Size");
}

$about = $_POST["about"];

if ($about == "")
{
	die("Error: Description Cannot Be Left Blank");
}


//Store Data
$newData = "$firstname, $lastname, $address, $apt, $city, $state, $zip, $movie, $meal, $pizza, $family, $about\n";

$fileName = "p9.csv";

//Append Data || Create New File If It Does Not Exist
if (file_exists($fileName)){
	file_put_contents($fileName, $newData, FILE_APPEND);
} 
else 
{
    file_put_contents($fileName, $newData);
}

?>

<h3>Confirmation Data for <?php echo $firstname . " " . $lastname?></h3>
    
<?php 
        
    $totalPeople = 0;
    $averagePeople = 0;
    
    $allData = file_get_contents("p9.csv");
    
    $lineData = explode("\n", $allData);
    
    for ($x=0; $x<count($lineData); $x++)
    {
        $data = explode(",", $lineData[$x]);
        
        $totalPeople = $totalPeople + intval($data[10]);
    }
    
    $averagePeople = $totalPeople / ( count($lineData) - 1);
    
?>
       
<p>
   First Name: <?php echo $firstname ?><br>
   Last Name: <?php echo $lastname ?><br>
   Address: <?php echo $address ?><br>
   Apt: <?php 
            if ($apt == "")
            {
                echo "None"; ?><br><?php
            }
            else
            {
                echo $apt ?><br><?php
            }?>    
   City: <?php echo $city ?><br>
   State: <?php echo $state ?><br>
   Zip: <?php echo $zip ?><br> 
   Favorite Genre of Movies: <?php echo $movie ?><br>
   Favorite Meal: <?php echo $meal ?><br>
   Like Pizza: <?php echo $pizza ?><br>
   Number of People in Family: <?php echo $family ?><br>
   Description of <?php echo $firstname . " " . $lastname?>: <?php echo $about ?><br>
</p>
    
<h3>Average Number of Individuals in Each Family: <?php echo number_format($averagePeople, 2) ?></h3>

</body>
</html> 