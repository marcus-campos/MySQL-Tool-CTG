<!--Autor(es): Marcus Vinicius Campos | V: 1.0 | 28/06/2012-->
  <form action="#" method="post">
     <center>
    <p>    
      Nome:
      <input name="tb_nome" id="cadastro_text_box" type="text" />
    </p>
    <p>
      Login:
      <input name="tb_login" id="cadastro_text_box" type="text" />
    </p>
    <p>
      Senha:
      <input name="tb_senha" id="cadastro_text_box" type="password" />
    </p>
    <p> Confirmação de senha:
      <input name="tb_senha2" id="cadastro_text_box" type="password" />
    </p>
    <p> Email:
      <input name="tb_email" id="cadastro_text_box" type="text" />
    </p>
    <p>
      <input name="btn_cadastrar" type="submit" id="botoes" value="Cadastrar" />
    </p>
    <p>
     <a href="./?pag=home">Cancelar</a>
    </p>
    </center>
  </form>
  <?php
  

	$Chave = new GeradorDeChaves();
	$class_conn = new conexao_mysql();
  		if(isset($_POST['btn_cadastrar']))
		{
			$conn = $class_conn->querys("SELECT * FROM tbl_login WHERE login = '".$_POST['tb_login']."' AND email = '".$_POST['tb_email']."'");
			if($_POST['tb_login'] == NULL or $_POST['tb_nome'] == NULL or $_POST['tb_senha'] == NULL or $_POST['tb_email'] == NULL or $_POST['tb_senha2'] == NULL)
			{
				echo '<script type="text/javascript"> alert(\'Preencha todos os campos corretamente!\'); </script>';
			}
			else
			if($_POST['tb_senha'] != $_POST['tb_senha2'])
			{
				echo '<script type="text/javascript"> alert(\'As senhas não correspondem!\'); </script>';
			}
			else
			if(mysql_num_rows($conn) > 0)
			{
				echo '<script type="text/javascript"> alert(\'Já existe 1 login com nome!\'); </script>';
			}
			else
			{
				$conn = $class_conn->querys("INSERT INTO tbl_login VALUES('','".$_POST['tb_nome']."','".$_POST['tb_login']."','".$_POST['tb_senha']."','".$_POST['tb_email']."');");	
				echo '<script type="text/javascript"> alert(\'Cadastro efetuado com sucesso!!\'); </script>';
			}
			
		}
  ?>