<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<!--Autor(es): Marcus Vinicius Campos | V: 1.0 | 28/06/2012-->
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Painel de controle</title>
</head>

<body>
<form action="#" method="post">
Nome:
<input type="text" id="caixaDeTexto" name="rtb_Nome" />
Login:
<input type="text" id="caixaDeTexto" name="rtb_Login" />
Senha:
<input type="text" id="caixaDeTexto" name="rtb_Senha" />
Confirma senha:
<input type="text" id="caixaDeTexto" name="rtb_CSenha" />
Email:
<input type="text" id="caixaDeTexto" name="rtb_Email" />
<br />
<br />
<input type="submit" name="btn_cadastro" value="Cadastrar" />
</form>
</body>
</html>
<?php
if(isset($_POST['btn_cadastro']))
{
	if(isset($_POST['rtb_Nome']) != NULL && isset($_POST['rtb_Login']) != NULL && isset($_POST['rtb_Senha']) != NULL && isset($_POST['rtb_CSenha']) != NULL && isset($_POST['rtb_Email']) != NULL)
	{
		if($_POST['rtb_Senha'] == $_POST['rtb_CSenha'])
		{
		$conn = $class_conn->querys("INSERT INTO tbl_adm VALUES('','".$_POST['rtb_Nome']."','".$_POST['rtb_Login']."','".$_POST['rtb_Senha']."',1,'".$_POST['rtb_Email']."');");
		echo '<script type="text/javascript"> alert(\'Cadastro efetuado com sucesso!\'); </script>';
		}
		else
		{
			echo '<script type="text/javascript"> alert(\'As senhas não coencidem!\'); </script>';
		}
	}
	else
	{
			echo '<script type="text/javascript"> alert(\'Preencha todos os campos corretamente!\'); </script>';
	}
}
?>