create database mysqltoolsctg;

use mysqltoolsctg;

create table tbl_login(
codigo int unsigned not null AUTO_INCREMENT PRIMARY KEY,
login varchar(255) not null,
senha varchar(128) not null
);

create table tbl_conexoes(
cod_conexoes int unsigned not null AUTO_INCREMENT PRIMARY KEY,
nome_cone varchar(255) not null,
ip_conexao varchar(255) not null,
usuario varchar(255) not null,
senha varchar(128) not null,
porta int unsigned not null,
id_usuario int unsigned not null, 
data_atualizacao date not null,
foreign key (id_usuario) references tbl_login(codigo)
);


create table tbl_janelas(
cod_janelas int unsigned not null AUTO_INCREMENT PRIMARY KEY,
tipo int unsigned not null, 
ativo BOOLEAN not null, 
funcao int unsigned not null, 
id_usuario int unsigned not null, 
data_alteracao date not null,
foreign key (id_usuario) references tbl_login(codigo)
);

create table tbl_informacao_addicionais(
cod_informacao_addicionais int unsigned not null AUTO_INCREMENT PRIMARY KEY,
id_usuario int unsigned not null, 
nome_usuario varchar(255) not null,
telefone_residencial varchar(15),
telefone_empresarial varchar(15),
telefone_celular varchar(15),
email varchar(255) not null,
enderco text not null,
cpf bigint,
cnpj bigint,
pergunta_secreta varchar(255) not null,
resposta_secreta varchar(255) not null,
data_cadastro date not null,
data_alteracao date not null,
foreign key (id_usuario) references tbl_login(codigo)
);