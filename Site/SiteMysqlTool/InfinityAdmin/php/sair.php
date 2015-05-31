<!--Autor(es): Marcus Vinicius Campos | V: 1.0 | 28/06/2012-->
<?php
if(isset($_SESSION['loginPainel']) && isset($_SESSION['nomePainel']))
	{
  session_unset();   // Destroi
  session_destroy(); // Destroi
  ?>
  <script type="text/javascript"> alert('Logout realizado com sucesso!\nVocê será redirecinado para pagina principal em instantes.'); </script>
  <?php
  echo '<meta http-equiv="refresh" content="0;URL=#">';
	}
	else
	{
		echo 'Por favor logue para usar esta função';	
	}
  ?>