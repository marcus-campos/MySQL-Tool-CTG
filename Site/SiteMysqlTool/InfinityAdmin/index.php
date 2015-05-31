  <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
  <html xmlns="http://www.w3.org/1999/xhtml">
  <head>
  <!--Autor(es): Marcus Vinicius Campos | V: 1.0 | 28/06/2012-->
  <link rel="stylesheet" href="css/style.css" type="text/css" />
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>Painel de administração</title>
  <?php
   session_start();
   require("./php/class_conexao.php");
   $class_conn = new conexao_mysql();
  ?>
  </head>
  
  <body>
  
  <!--Logo do topo-->
  <div id="logo_topo"></div>
  
  <?php
 
  	if(isset($_SESSION['loginPainel']) && isset($_SESSION['nomePainel']))
	{
		//echo '<center><b><br /><br /><br /><br /><br /><br /><br /><font size = "20">Em construção!!!</font></b></center>';
		?>
          <div id="menu_topo"> 
          <ul id="menu_topo">
    		<li><a href="./?pag=noticias">Noticias</a></li>
    		<li><a href="./?pag=downloads">Downloads</a></li>    		
            <li><a href="./?pag=cadm">Administradores</a></li>
            <li><a href="./?pag=sair">Sair</a></li>
  		  </ul>
          </div>
          
          <div id="moldura">
             <?php
			 	if(isset($_GET['pag']))
   {
	   switch($_GET['pag'])
	   {
		case 'noticias': 
				 include('./pags/noticias.php');
				break;  
	    case 'downloads': 
				 include('./pags/downloads.php');
				break;  
	  	case 'cadm': 
				 include('./pags/cadm.php');
				break;
		case 'sair': 
				 include('./php/sair.php');
				break;		
	   }
   }
			 ?>
          </div>
        <?php
	}
	else
	{
		?>
        
  <!--Painel-->
  <div id="painel_fundo"> 
  <form action="#" method="post">  
   		<input name="tb_login" id="painel_textBox" type="text" />   		
        <input name="tb_senha" id="painel_textBox" type="password" />    
        <input name="btn_logar" id="painel_botao" type="submit" value="Logar" />        
  </form>
  <?php 
	}
  ?>
   </div> 
   <?php
	
   
   if(isset($_POST['btn_logar']))
   {
	if($_POST['tb_login'] != NULL && $_POST['tb_senha'] != NULL)
	{ 
		$conn = $class_conn->querys("SELECT * FROM tbl_adm WHERE login = '".$_POST['tb_login']."' AND senha = '".$_POST['tb_senha']."' LIMIT 1;");
		if(mysql_num_rows($conn) == 1)
		{
			$arrayConta = mysql_fetch_array($conn);
			echo '<script type="text/javascript"> alert(\'Bem vindo! '.$arrayConta['nome'].'\'); </script>';
			$_SESSION['loginPainel'] = $arrayConta['login'];
			$_SESSION['nomePainel'] = $arrayConta['nome'];		
			echo '<meta http-equiv="refresh" content="0;URL=./?pag=noticias">';	
		}
		else
		{
			echo '<script type="text/javascript"> alert(\'Login ou senha inválidos!\nPor favor tente novamente.\'); </script>';	
		}
	}
   }
   
	?>
    <?php
		if(isset($_SESSION['loginPainel']) && isset($_SESSION['nomePainel']))
	{
		if(isset($_GET['pag']))
		{
			?>
            <div id="moldura">
            <?php
			if($_GET['pag'] == "noticias")
			{
	?>
    
    
    <center><h1><b>Noticias</b></h1></center>
    <form action="#" method="post">
    <center>
Codigo:
<input type="text" name="rtb_codigo" />
<input type="submit" name="btn_deletar" value="Deletar" />
</center>
<br />
</form>

<?php
$x = 0;
        $arrayNoticia = $class_conn->querys("SELECT codigo,titulo,URL FROM tbl_noticias ORDER BY(data_cadastro) DESC;");
		if(mysql_num_rows($arrayNoticia) < 1)
		{
			echo 'Não há noticias publicadas...';
		}
		else
		{
			while($row = mysql_fetch_array($arrayNoticia, MYSQL_ASSOC))
			{
	     ?>
            <html>
                 <body>                      
                        <?php
                           printf('Codigo: %s    Titulo: %s   URL: %s'.'<html><br /></html>',$row['codigo'],$row['titulo'],$row['URL']);	
                        ?>                       
                 </body>		
            </html>
            <?php
            $x++;			
		}
		}
			}
			else
			if($_GET['pag'] == "cadm")
			{
				?>
                <center><h1><b>Administradores</b></h1></center>
    <form action="#" method="post">
    <center>
Codigo:
<input type="text" name="rtb_codigoADM" />
<input type="submit" name="btn_deletarADM" value="Deletar" />
</center>
<br />
</form>
<?php
				$x = 0;
        $arrayNoticia = $class_conn->querys("SELECT codigo,nome,login FROM tbl_adm;");
		if(mysql_num_rows($arrayNoticia) < 1)
		{
			echo 'Não há registro de administradores...';
		}
		else
		{
			while($row = mysql_fetch_array($arrayNoticia, MYSQL_ASSOC))
			{
	     ?>
            <html>
                 <body>                      
                        <?php
                           printf('Codigo: %s    Nome: %s   login: %s'.'<html><br /></html>',$row['codigo'],$row['nome'],$row['login']);	
                        ?>                       
                 </body>		
            </html>
            <?php
            $x++;			
		}
		}
			}
		}
?>
</div>
<?php 

	}
	else
	{
	return;	
	}
	?>
    <?php
if(isset($_POST['btn_deletar']))
   {
	   if($_POST['rtb_codigo'] != NULL)
	{
		if(mysql_num_rows($arrayNoticia) < 1)
		{
			echo '<script type="text/javascript"> alert(\'Não há como apagar algo que não exista!\'); </script>';	
		}
		else
		{
		 $arrayNoticia = $class_conn->querys("Delete from tbl_noticias where codigo = '".$_POST['rtb_codigo']."';");
		 echo '<script type="text/javascript"> alert(\'Noticia deletada com sucesso!\'); </script>';	
		}
	}
   }
   else
   if(isset($_POST['btn_deletarADM']))
   {
	   if($_POST['rtb_codigoADM'] != NULL)
	{
		if(mysql_num_rows($arrayNoticia) < 1)
		{
			echo '<script type="text/javascript"> alert(\'Não há como apagar algo que não exista!\'); </script>';	
		}
		else
		{
		 $arrayNoticia = $class_conn->querys("Delete from tbl_adm where codigo = '".$_POST['rtb_codigoADM']."';");
		 echo '<script type="text/javascript"> alert(\'Administrador deletado com sucesso!\'); </script>';	
		}
	}
   }
?>
    
  </body>
  </html>