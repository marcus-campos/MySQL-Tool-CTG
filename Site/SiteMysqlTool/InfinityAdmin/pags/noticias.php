<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<!--Autor(es): Marcus Vinicius Campos | V: 1.0 | 28/06/2012-->
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Painel de controle</title>
</head>

<body>
<form action="#" method="post">
Titulo:
<input type="text" id="caixaDeTexto" name="rtb_titulo" />
URL:
<input type="text" id="caixaDeTexto" name="rtb_URL" />
Autor:
<input type="text" id="caixaDeTexto" name="rtb_Autor" />
Noticia:
<input type="text" id="caixaDeTexto" name="rtb_noticias" />
<br />
<br />
<input type="submit" name="btn_noticias" value="Cadastrar" />
</form>
</body>
</html>

<?php
if(isset($_POST['btn_noticias']))
{
	$conn = $class_conn->querys("SELECT * FROM tbl_noticias WHERE URL = '".$_POST['rtb_URL']."'");
	if($_POST['rtb_titulo'] == NULL or $_POST['rtb_URL'] == NULL or $_POST['rtb_Autor'] == NULL or $_POST['rtb_noticias'] == NULL)
	{
		echo '<script type="text/javascript"> alert(\'Preencha todos os campos corretamente!\'); </script>';
	}
	else
	if(mysql_num_rows($conn) > 0)
	{
		echo '<script type="text/javascript"> alert(\'Já existe uma noticia com esta mesma URL!\'); </script>';
	}
	else
	{
		$conn = $class_conn->querys("INSERT INTO tbl_noticias VALUES('','".$_POST['rtb_titulo']."','".$_POST['rtb_noticias']."','".$_POST['rtb_URL']."','".$_POST['rtb_Autor']."',sysdate());");
	}
}
?>
