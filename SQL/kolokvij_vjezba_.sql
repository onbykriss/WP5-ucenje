use master;
go
drop database if exists kolokvij_vjezba;
go
create database kolokvij_vjezba;
go
use kolokvij_vjezba;

create table svekar(
sifra int not null primary key identity(1,1),
bojaociju varchar(40) not null,
prstena int,
dukserica varchar(41),
lipa decimal(13,8),
eura decimal(12,7),
majica varchar(35)
);

create table sestra_svekar(
sifra int not null primary key identity(1,1),
sestra int not null,
svekar int not null
);

create table sestra(
sifra int not null primary key identity(1,1),
introvertno bit,
haljina varchar(31) not null,
maraka decimal(16,6),
hlace varchar(46) not null,
narukvica int not null
);

create table zena(
sifra int not null primary key identity(1,1),
treciputa datetime,
hlace varchar(46),
kratkamajica varchar(31) not null,
jmbag char(11) not null,
bojaociju varchar(39) not null,
haljina varchar(44),
sestra int not null
);


create table muskarac(
sifra int not null primary key identity(1,1),
bojaociju varchar(50) not null,
hlace varchar(30),
modelnaocala varchar(43),
maraka decimal(14,5) not null,
zena int not null
);


create table mladic(
sifra int not null primary key identity(1,1),
suknja varchar(50) not null,
kuna decimal(16,8) not null,
drugiputa datetime,
asocialno bit,
ekstroventno bit not null,
dukserica varchar(48) not null,
muskarac int
);


create table punac(
sifra int not null primary key identity(1,1),
ogrlica int,
gustoca decimal(14,9),
hlace varchar(41) not null
);

create table cura(
sifra int not null primary key identity(1,1),
novcica decimal(16,5) not null,
gustoca decimal(18,6) not null,
lipa decimal(13,10),
ogrlica int not null,
bojakose varchar(38),
suknja varchar(36),
punac int
);


alter table sestra_svekar add foreign key (svekar) references svekar(sifra);
alter table sestra_svekar add foreign key (sestra) references sestra(sifra);
alter table zena add foreign key (sestra) references sestra(sifra);
alter table muskarac add foreign key (zena) references zena(sifra);
alter table mladic add foreign key (muskarac) references muskarac(sifra);
alter table cura add foreign key (punac) references punac(sifra);


insert into sestra(introvertno,haljina,maraka,hlace,narukvica) values 
(0,'Roza',264,'Cavali',1),
(1,'Zelena',690,'Dolce',3),
(1,'Crvena',402,'Chanel',2);
select * from sestra;

insert into sestra_svekar(sestra,svekar) values
(1,1),
(2,1),
(3,1);
select * from sestra_svekar;

insert into zena(treciputa,hlace,kratkamajica,jmbag,bojaociju,haljina,sestra) values 
('2020-11-03','kratke','Polo',12345678910,'zelena','Maxmara',1),
('2022-05-14','tricetrt','Dolce',78945612375,'plave','DG',2),
('2023-08-08','jeans','RLoren',36925814752,'crne','LV',3);
select * from zena;

insert into muskarac(bojaociju,hlace,modelnaocala,maraka,zena) values 
('crne','Pamuk','Dior',125,1),
('smeđe','Platnene','Gucci',350,2),
('turkiz','bijele','Miumiu',599,3);
select * from muskarac;

insert into cura(novcica,gustoca,lipa,ogrlica,bojakose,suknja,punac) values
(50.35,15.78,54.15,6,'blond','United',1),
(78.99,15.78,23.33,7,'crna','Lili',2),
(66.37,15.78,54.56,8,'crvena','Joop',3);
select * from cura;

---2. U tablici cura postavite svim zapisima kolonu gustoca na vrijednost 15,77.

insert into punac(ogrlica,gustoca,hlace) values
(6,15.78,'crne'),
(7,15.78,'bijele'),
(8,15.78,'žute');
select * from punac;

---3. U tablici mladic obrišite sve zapise čija je vrijednost kolone kuna veće od 15,78.

insert into mladic(suknja,kuna,drugiputa,asocialno,ekstroventno,dukserica) values
('lila',15.23,'1999-03-27',0,1,'strikana'),
('narancasta',13.25,'1998-04-20',0,1,'karirasta'),
('plava',11.02,'2000-11-01',0,1,'semiz');
select * from mladic;

insert into svekar(bojaociju,prstena,dukserica,lipa,eura,majica) values
('zelena',2,'leder',14.66,12.7,'LV'),
('plava',3,'crvenoplava',90.5,33.58,'Dior'),
('zuta',4,'crvenocrna',80.25,158.25,'Chanel');
select * from svekar;

---4. Izlistajte kratkamajica iz tablice zena uz uvjet 
---da vrijednost kolone hlace sadrže slova ana.

select * from zena;

select kratkamajica from zena 
where hlace like '%ana'

---5. Prikažite :
----dukserica iz tablice svekar, 
----asocijalno iz tablice mladic
----hlace iz tablice muskarac

----uz uvjet da su vrijednosti kolone hlace iz tablice zena počinju slovom a 
----da su vrijednosti kolone haljina iz tablice sestra sadrže niz znakova ba.

----Podatke posložite po hlace iz tablice muskarac silazno. 

select * from mladic;
select * from muskarac;
select * from svekar;

select f.dukserica,a.asocialno,b.hlace
from mladic a 
inner join muskarac b on a.muskarac = b.sifra 
inner join zena c on b.zena = c.sifra
inner join sestra d on c.sestra = d.sifra
inner join sestra_svekar e on e.sestra = d.sifra
inner join svekar f on e.svekar = f.sifra
where c.hlace like 'a%' and d.haljina like '%ba'
order by b.hlace desc;

