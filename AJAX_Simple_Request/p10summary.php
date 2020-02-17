<?php

$pizzaLikes = 0;

$filename = "p10.csv";

if ( file_exists($filename) )
{
	$file = file_get_contents($filename);
	$lines = explode("\n", $file);

	for ($x=0; $x<count($lines); $x++)
	{
		$data = explode(",", $lines[$x]);
		if (count($data) > 1)
        {
            if (strcmp(trim($data[8]),"Y") == 0)
            {
            $pizzaLikes++;
            }
		}
	}
}

sleep(5);

echo $pizzaLikes;

?>

