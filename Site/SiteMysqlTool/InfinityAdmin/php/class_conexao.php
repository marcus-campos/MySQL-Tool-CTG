<!--Autor(es): Marcus Vinicius Campos | V: 1.0 | 28/06/2012-->
<?php
	class conexao_mysql
	{
		function conexao_mysql()
		{
			$conn = mysql_connect('127.0.0.1','root','');
			mysql_select_db('mysqltoolctg',$conn) or die ('Serviço temporiariamente indisponível! [Erro:#001]');
			mysql_query("SET NAMES 'utf8'");
			mysql_query("SET characters_set_connection=utf8");
			mysql_query("SET characters_set_client=utf8");
		    mysql_query("SET characters_set_results=utf8");
		}
		
		function querys($query)
		{
			if(substr($query,0,6) == "INSERT" or substr($query,0,6) == "UPDATE") 
			{
				$conn = mysql_query($query) or die ('Não foi possivel realizar o processo de inserção');
			}
			else
			{
			$conn = mysql_query($query) or die ('Não foi possivel realizar o processo de seleção');	
			return $conn;	
			}
		}
	}
?>