<?php

$firstname = $_POST["firstname"];
$lastname = $_POST["lastname"];
$address = $_POST["address"];
$city = $_POST["city"];
$state = $_POST["state"];
$zip = $_POST["zip"];
$movie = $_POST["movie"];
$meal = $_POST["meal"];    
 
if (isset($_POST["pizza"]))
	$pizza = "Y";
else
	$pizza = "N";
    
$family = $_POST["family"];
$about = $_POST["about"];

//Store Data
$newData = "$firstname, $lastname, $address, $city, $state, $zip, $movie, $meal, $pizza, $family, $about\n";

$fileName = "p10.csv";

//Append Data || Create New File If It Does Not Exist
if (file_exists($fileName)){
	file_put_contents($fileName, $newData, FILE_APPEND);
} 
else 
{
    file_put_contents($fileName, $newData);
}

sleep(2);

echo "Submission Complete — Thank You $firstname!";

?>