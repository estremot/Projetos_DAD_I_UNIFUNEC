create database amigo;

-- sexo = {codsexo, nomesexo}
create table sexo(
	codsexo integer identity(1,1) primary key,
	nomesexo varchar(9) not null unique
);

-- Cidade = {codcidade, nomecidade}
create table cidade(
	codcidade integer identity(1,1) primary key,
	nomecidade varchar(80) not null unique
);

-- Bairro = {codbairro, nomebairro}
create table bairro(
	codbairro integer identity(1,1) primary key,
	nomebairro varchar(80) not null unique
);

--Rua = {codrua, nomerua}
create table rua(
	codrua integer identity(1,1) primary key,
	nomerua varchar(80) not null unique
);

-- Cep = {codcep, numerocep}
create table cep(
	codcep integer identity(1,1) primary key,
	numerocep char(9) not null unique
);

--Estado = {codestado, nomeestado, sigla}
create table estado(
	codestado integer identity(1,1) primary key,
	nomeestado varchar(80) not null unique,
	sigla char(2) not null unique
);

--partido = {codpartido, nomepartido, siglapartido}
create table partido(
	codpartido integer identity(1,1) primary key,
	nomepartido varchar(80) not null unique,
	siglapartido varchar(15) not null unique
);

-- presidente = {codpresidente, nomepresidente, codpartidofk}
create table presidente(
	codpresidente integer identity(1,1) primary key,
	nomepresidente varchar(80) not null,
	codpartidofk integer references partido(codpartido)
);

-- pais = {codpais, nomepais, codpresidentefk}
create table pais(
	codpais integer identity(1,1) primary key,
	nomepais varchar(80) not null unique,
	codpresidentefk integer references presidente(codpresidente)
);

-- Amigo = {codamigo, nomeamigo, codsexofk, codcidadefk, 
--codbairrofk, codruafk, codcepfk, codestadofk, codpaisfk, 
--numerocasa, email, telefone}

create table amigo(
	codamigo integer identity(1,1) primary key,
	nomeamigo varchar(80) not null,
	codsexofk integer references sexo(codsexo) on delete cascade on update cascade,
	codcidadefk integer references cidade(codcidade) on delete cascade on update cascade,
	codbairrofk integer references bairro(codbairro) on delete cascade on update cascade,
	codruafk integer references rua(codrua) on delete cascade on update cascade,
	codcepfk integer references cep(codcep) on delete cascade on update cascade,
	codestadofk integer references estado(codestado) on delete cascade on update cascade,
	codpaisfk integer references pais(codpais) on delete cascade on update cascade,
	numerocasa varchar(10) not null,
	email varchar(100) not null unique,
	telefone varchar(15) not null
);


