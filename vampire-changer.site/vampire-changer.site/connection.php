<?php

try{
    $encode = "utf8";
    $db = new PDO("mysql:host=localhost;dbname=u2005838_default;charset=$encode","u2005838_app","BlackAllirgen123");
}catch(Exception $e){
    die("Fatal error: ".$e->getMassege());
}

?>