<?php
error_reporting(E_ERROR);


class Login{
    
    private function query($sql, $arg=null, $fetch = false){
        require "connection.php";
        $q = $db->prepare($sql);
        $q->execute();
        return $fetch ? $q->fetch(2) : $q;
    }
    
    private function userExists($email,&$hashedPassword)
    {
        $hashedPassword = $this->query("SELECT password FROM main_myuser WHERE email='$email'",null,true)["password"];
        return $hashedPassword != null;
    }
    
    public function validate($email,$password)
    {
        if ($this->userExists($email,$hashedPassword))
        {
            $hashedPassword = str_replace('$','\$',$hashedPassword);
            $status =  shell_exec("python scripts/hasher.py $password $hashedPassword");
            $nickname = $this->query("SELECT nickname FROM main_myuser WHERE email='$email'",null,true)["nickname"];
            return $nickname;
        }
        return 0;
    }
}
$login = new Login();
if ($_GET["action"] == "validate")
{
    echo $login->validate($_GET['email'],$_GET['password']);
}
?>