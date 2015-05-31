<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<script type="text/javascript" src="./js/jquery-1.7.1.min.js">
</script>
<script type="text/javascript" src="./js/script.js">
</script>
<link type="text/css" href="css/style.css" rel="stylesheet" />
<?php
session_start();
	require("./php/class_paginas.php");
	require("./php/class_geraChave.php");
	require("./php/class_conexao.php");
	$Chave = new GeradorDeChaves();
	$class_conn = new conexao_mysql();
	$classPG = new paginas();	
?>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>MySQL Tool CTG</title>
</head>

<body>
<div id="top_bar">
  <div id="logo01"> </div>
  <ul id="menu_top">
    <li><a href="./?pag=home">Home</a></li>
    <li><a href="./?pag=downloads">Downloads</a></li>
    <li><a href="./?pag=sobre">Sobre nós</a></li>
    <li><a href="./?pag=contato">Contato</a></li>
  </ul>
  <div id="menu_top_bots_b">
  	<?php
	if(isset($_SESSION['login']) && isset($_SESSION['nome']))
	{
		?>
	<div id="menu_top_bots"> <a href="./?pag=sair">Sair</a> </div>
    <div id="menu_top_bots" class="minhaConta"><a href="#">Minha Conta</a></div>
    <?php	
	}
	else
	{
	?>
    <div id="menu_top_bots"> <a href="./?pag=cadastro">Criar conta</a> </div>
    <div id="menu_top_bots" class="login"><a href="#">Logar</a></div>
	<?php 
	}
	?>
  </div>
  </div>
  <?php
	include('./php/login.php');
  ?>
  <div id="home_body">
    <?php
    /*
	  Se o metodo _GET existir e for diferente de nulo, ele chama o metodo include pagina da class_paginas e inclui a pagina requerida.
	*/
  	if(isset($_GET['pag']) && $_GET['pag'] != NULL)	
	{
		
  		$classPG->includepagina($_GET['pag']);
	}
	else
	{
		include './pags/home.php';	
	}
  ?>
  </div>

<div id="home_bot"> 
<div id="logo_bot"> </div>
<div id="home_creditos">
©2012 - MySql Tool - Todos os direitos reservados, Powered by: Marcus Vinicius Campos
</div>
</div>
</body>
</html>