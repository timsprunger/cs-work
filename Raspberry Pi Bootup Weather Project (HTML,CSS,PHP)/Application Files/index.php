<!DOCTYPE html>

<html>

<head>
<meta charset="utf-8">
<link rel="stylesheet" type="text/css" href="pirates.css">
<title>Huntington Weather</title>
</head>

<body>

<h1>Huntington, Indiana</h1> 

<p>_____________________________________________</p>

<img src="map_of_huntington_in.jpg" alt="HU_photo" align="right" width="428" height="428">

<?php

$json = file_get_contents('http://api.openweathermap.org/data/2.5/weather?id=4921729&APPID=bd5398218654d346ee7a1d2c2d119ba0&units=imperial');
$data = json_decode($json);

echo '<h2>Geographic Location</h2>';

echo '<p>Longitude: ', $data->coord->lon, '&deg; </p>';

echo '<p>Latitude: ', $data->coord->lat, '&deg; </p>';

echo '<h2>Current Description</h2>';

foreach ($data->weather as $weather) {
echo '<p>', $weather->description, '</p>';
}

echo '<h2>Current Conditions</h2>';

echo '<p>Current Temp: ', $data->main->temp, '&deg; F</p>';

echo '<p>Humidity: ', $data->main->humidity, '%</p>';

echo '<p>Wind Speed: ', $data->wind->speed, ' m/h</p>';

echo '<p>Clouds: ', $data->clouds->all, '%</p>';

?>

</body>
</html>


