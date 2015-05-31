<?php
	if(isset($_SESSION['login']) && $_SESSION['nome'] && $_SESSION['email'])
	{
		?>

<div id="chave_box"> </div>
<?php
	}
	else
	{
		echo 'Por favor logue primeiro para usar esta função';
	}
?>
