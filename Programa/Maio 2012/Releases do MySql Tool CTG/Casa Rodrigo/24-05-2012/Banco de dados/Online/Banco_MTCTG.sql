create table tbl_conexoes(
codigo int not null AUTO_INCREMENT PRIMARY KEY,
nome_cone varchar(255) not null,
ip_conexao varchar(255) not null,
usuario varchar(255) not null,
senha varchar(128) not null,
porta int unsigned not null,
id_usuario int unsigned not null, 
data_atualizacao date not null
foreign key (id_usuario) references tbl_login(codigo)
);

create table tbl_login(
codigo int not null AUTO_INCREMENT PRIMARY KEY,
login varchar(255) not null,
senha varchar(128) not null,
);

create table tbl_janelas(
codigo int not null AUTO_INCREMENT PRIMARY KEY,
tipo int unsigned not null, 
ativo BOOLEAN not null, 
funcao int unsigned not null, 
id_usuario int unsigned not null, 
data_alteracao date not null,
foreign key (id_usuario) references tbl_login(codigo),
);