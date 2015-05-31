<div id="login_box">
  <form action="#" method="post">
    <p>
      <center>
      Login:
      <input name="tb_login" id="login_text_box" type="text" />
    </p>
    <p> Senha:
      <input name="tb_senha" id="login_text_box" type="password" />
    </p>
    <p>
      <input name="btn_logar" id="botoes" type="submit" value="Logar" />
    </p>
    </center>
  </form>
</div>
<?php
  if(isset($_POST['btn_logar']))
  {
	if($_POST['tb_login'] != NULL && $_POST['tb_senha'] != NULL)
	{
		$conn = $class_conn->querys("SELECT * FROM tbl_usuarios WHERE login = '".$_POST['tb_login']."' AND senha = '".$_POST['tb_senha']."' LIMIT 1;");
		if(mysql_num_rows($conn) == 1)
		{
			$arrayConta = mysql_fetch_array($conn);
			echo '<script type="text/javascript"> alert(\'Bem vindo! '.$arrayConta['nome'].'\'); </script>';
			$_SESSION['login'] = $arrayConta['login'];
			$_SESSION['nome'] = $arrayConta['nome'];
			$_SESSION['email'] = $arrayConta['email'];
			echo '<meta http-equiv="refresh" content=";URL=./?pag=home">';
		}
		else
		{
			echo '<script type="text/javascript"> alert(\'Login ou senha inválidos!\nPor favor tente novamente.\'); </script>';	
		}
		
	}
	else
	{
	?>
<script type="text/javascript">
	alert('Por favor, preencha todos os campos corretamente.');
	</script>
<?php
	}
  }
?>
<div id="login_box_log">
  <form action="#" method="post">
      <center>
    <p>
    <br />
      <input name="btn_minhaconta" id="botoespainel" type="submit" value="Minha conta" />
    </p>
     <p>
     <br />
      <input name="btn_chave" id="botoespainel" type="submit" value="Chave de ativação" />
    </p>
     <p>
     <br />
      <input name="btn_servidores" id="botoespainel" type="submit" value="Servidores salvos" />
    </p>
    </center>
  </form>
</div>
