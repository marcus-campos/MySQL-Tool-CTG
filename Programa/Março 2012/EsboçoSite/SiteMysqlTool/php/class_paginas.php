<?php
	class paginas
	{
		function includepagina($enderecoPG)
		{
			switch($enderecoPG)
			{
				case 'home': 
				 include('./pags/home.php');
				break;
				case 'downloads': 
				 include('./pags/downloads.php');
				break;
				case 'sobre': 
				 include('./pags/sobre.php');
				break;
				case 'contato': 
				 include('./pags/contato.php');
				break;
				case 'cadastro': 
				 include('./pags/cadastro.php');
				break;
				case 'sair': 
				 include('./pags/sair.php');
				break;
				break;
				case 'chave': 
				 include('./pags/chave_ativacao.php');
				break;
				default:
				  include('./pags/home.php');
				break;
			}
		}
	}
?>