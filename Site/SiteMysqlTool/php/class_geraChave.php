<?php
	class GeradorDeChaves
	{
		function GerarChave()
		{
			$Chave = 'ABCDEFGHIJKLMNOPQRSTWXYZ0123456789';
			$ChaveFinal = "";
			for($i = 0; $i<5;$i++)
			{		
				for($x = 0; $x < 5; $x++)
				{
					$ChaveFinal .= $Chave[rand(0,strlen($Chave))];				
				}		
				$ChaveFinal .= "-";
			}
			$ChaveReturn = trim (substr_replace($ChaveFinal,' ',-1));
			return $ChaveReturn;
		}
	}
?>