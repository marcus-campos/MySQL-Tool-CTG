<?php
if(isset($_SESSION['login']) && $_SESSION['nome'] && $_SESSION['email'])
	{
 session_unset();   // Destroi
  session_destroy(); // Destroi
  ?>
  <script type="text/javascript"> alert('Logout realizado com sucesso!\nVocê será redirecinado para pagina principal em instantes.'); </script>
  <?php
  echo '<meta http-equiv="refresh" content="0;URL=./?pag=home">';
	}
	else
	{
		echo 'Por favor logue paraa usar esta função';	
	}
  ?>