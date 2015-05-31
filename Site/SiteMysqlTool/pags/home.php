<!--Autor(es): Marcus Vinicius Campos | V: 1.0 | 28/06/2012-->
	<?php
		$x = 0;
		
        //$conn = $class_conn->querys("SELECT * FROM tbl_noticias ORDER BY(data_cadastro) DESC;");	
        $arrayNoticia = $class_conn->querys("SELECT * FROM tbl_noticias ORDER BY(data_cadastro) DESC limit 10;");	           	
       
        
       /* while(mysql_num_rows($conn) > $x)
        {
		$autor = $arrayNoticia;
        $titulo = $arrayNoticia['titulo']{$x};
        $descricao = $arrayNoticia['descricao']{$x};
        $url = $arrayNoticia['URL']{$x};
        $data_cadastro = $arrayNoticia['data_cadastro']{$x};           
         ?>
            <html>
                 <body>
                      <div id="caixaDeConteudo">
                        <?php
                          echo 'Titulo: '.$titulo.'     '.'Autor: '.$autor.'<html><br /></html>'.$descricao;	
                        ?>
                         </div>
                 </body>		
            </html>
            <?php
            $x++;
        }
		*/
		
		while($row = mysql_fetch_array($arrayNoticia, MYSQL_ASSOC))
		{
			 ?>
            <html>
                 <body>
                      <div id="caixaDeConteudo">
                        <?php
                           printf('Titulo: %s   Autor: %s'.'<html><br /></html>'.'%s',$row['titulo'],$row['autor'],$row['descricao']);	
                        ?>
                         </div>
                 </body>		
            </html>
            <?php
            $x++;			
		}
			
    ?>