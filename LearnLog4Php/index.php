<!DOCTYPE html>
<!--
To change this license header, choose License Headers in Project Properties.
To change this template file, choose Tools | Templates
and open the template in the editor.
-->
<?php
date_default_timezone_set('Asia/Bangkok');

require_once 'log4php/Logger.php';
Logger::configure('log4php.xml');

// get logger by name, if this name isn't listed 
// as a logger name in the configuration 
// file you will get the root level logger


$logger = Logger::getLogger('log4php');
$logger->info("beginning log4php example");

try {
    throw new Exception("log4php example error");
}
catch(Exception $e) {
    $logger->error($e->getMessage());
}
?>
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <?php
        echo "Hello World";
        ?>
    </body>
</html>
