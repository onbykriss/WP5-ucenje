create database opcina;

create table nacelnici(
sifra int not null primary key identity(1,1),
ime varchar(100),
prezime varchar(50),
datumrodenja date
);