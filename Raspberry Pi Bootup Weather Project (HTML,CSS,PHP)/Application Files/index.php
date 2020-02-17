<!DOCTYPE html>

<html>

<head>
	<meta charset="utf-8">
	<link rel="stylesheet" type="text/css" href="pirates.css">
	<title>Huntington Weather</title>
	<link href="https://fonts.googleapis.com/css?family=Bad+Script&display=swap" rel="stylesheet">
</head>

<body>

<div class="flex">
	<img src="map_of_huntington_in.jpg" alt="HU_photo" align="right" width="428" height="428">

	<div class="data">
		<h1>Huntington, Indiana</h1> 

		<?php
			$json = file_get_contents('http://api.openweathermap.org/data/2.5/weather?id=4921729&APPID=bd5398218654d346ee7a1d2c2d119ba0&units=imperial');
			
			$data = json_decode($json);

			echo '<h3>Geographic Location</h3>';
			echo '<p>Longitude: ', $data->coord->lon, '&deg; </p>';
			echo '<p>Latitude: ', $data->coord->lat, '&deg; </p>';
			echo '<h3>Current Description</h3>';

			foreach ($data->weather as $weather) {
				echo '<p>', $weather->description, '</p>';
			}

			echo '<h3>Current Conditions</h3>';
			echo '<p>Current Temp: ', $data->main->temp, '&deg; F</p>';
			echo '<p>Humidity: ', $data->main->humidity, '%</p>';
			echo '<p>Wind Speed: ', $data->wind->speed, ' m/h</p>';
			echo '<p>Clouds: ', $data->clouds->all, '%</p>';
		?>
	</div>
</body>
</html>


