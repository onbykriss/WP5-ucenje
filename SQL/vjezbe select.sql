﻿
--- use edunovawp5;

select * from grupe;

select * from smjerovi where sifra=1;   ----tako se ne radi....radit cemo da spojimo tablice

--- kuharica prema materialima

---želim spojiti naziv grupe i naziv smjera u jednu relaciju
-- select -- uvjek ostavim prvo praznu ( jer ču na kraju rec sta želim selektirat)
-- v biveru si pogledaj relaciju između tablica
-- select -- uvjek ostavim prazan prostor iza selekta ( jer ču na kraju rec sta želim selektirat)
---TO JE ZADNJE STO NAPISEM --- a.naziv as smjer, b.naziv as grupa

-- onda idem from---i želim -- (ime tablice) SMJEROVI budu A (inner join - relacija, želiš informacije koje su u presjeku kruga A i kruga B) tablica GRUPE budu B
-- from smjerovi a inner join grupe b
-- on --- povezuje kolone u tablicama
-- a.sifra je kolona u tablici smjerovi, b.smjer je kolona u tablici grupe
-- a = b
-- on a.sifra = b.smjer

--select a.brojslobodnihmjesta as kolkojihima, b.polaznik as onitamo
--from grupe a inner join clanovi b
--on a.sifra = b.grupa

select a.naziv as smjer, b.naziv as grupa
from smjerovi a inner join grupe b
on a.sifra = b.smjer

select a. --( smo preimenovali ) 
select a.naziv as smjer, b.naziv as grupa
from smjerovi a inner join grupe b
on  --- po kojem ključu ide veza 
on a.sifra ---smjerovima sam dao zamjensko ime A
on a.sifra = b.smjer

--- želimo izvuc sve smjerove 
--- sad je odabro sve smjerove i one koje nemaju grupe kao sto je žćčđš
select a.naziv as smjer, b.naziv as grupa
from smjerovi a left join grupe b
on a.sifra = b.smjer


---želimo sad pokazat ime i prezimena polaznika u grupama
select a.naziv as smjer, b.naziv as grupe, d.ime, d.prezime 
-- 1veza
from smjerovi a inner join grupe b on a.sifra = b.smjer
-- 2veza
inner join clanovi c on b.sifra = c.grupa
-- 3veza
inner join polaznici d on d.sifra = c.polaznik

--- želim da se pokazuje specifična informaciju
-- pokaži sva imena koja počnu sa P
where d.ime like 'P%';

---oreder by znači želim po koloni uredit/posložit tablicu
select a.naziv as smjer, b.naziv as grupe, d.ime, d.prezime 
from smjerovi a inner join grupe b on a.sifra = b.smjer
inner join clanovi c on b.sifra = c.grupa
inner join polaznici d on d.sifra = c.polaznik
where d.ime like 'P%'
order by 4 desc;

--- kolko ima clanova po grupi---znači moramo spojiti grupe i članove!
select a.naziv count(b.clanovi) as polaznika
from grupa a inner join clanovi b
on a.sifra = b.grupa
grup by a.naziv


select a.naziv, count(b.polaznik) as polaznici
--- from (grupe a) =to pomeni da si dala tabeli grupe ime a) inner join (clanovi b = in tabeli clanovi ime b)
on a.sifra = b.grupa  --- ON JE VEDNO DEFINIRANA RELACIJA veza MED TABELEMA
group by a.naziv

---primjer bez a,b,c 
select grupe.naziv, count(clanovi.polaznik)
from grupe inner join clanovi
on grupe.sifra = clanovi.grupa
group by grupe.naziv
having count(clanovi.polaznik)>5;  ---pokazuje samo one grupe koje imaju vise od 5 polaznika

---where filtrira one podatke koje je unio covjek, where ide na fizička imena
---having filtrira agregirane podatke (podatki koji ne postoje direktno u bazi nek su stvoreni putem nekog izračuna cca.prosjek, ukupni broj...

use svastara;
---dobiti moramo sva mjesta u osjecko-baranskoj zupaniji
select * from Mjesta
select * from Opcine
select * from Zupanije

select c.naziv as mjesto, b.naziv as obcine, a.naziv as zupanija
from Zupanije a inner join Opcine b
on a.sifra = b.zupanija
inner join Mjesta c on b.sifra = c.opcina
where a.naziv like 'osje%'
order by 1;

-- koja občina u osječko-baranjskoj zupaniji ima najviše mjesta
--- a = zupanija, b = opcine, c = mjesta

select b.naziv as občine, count(c.sifra) as brojmjesta
from Zupanije a inner join Opcine b
on a.sifra = b.zupanija
inner join Mjesta c on b.sifra = c.opcina
where a.naziv like 'spli%'
group by b.naziv  
order by brojmjesta desc;

--- --- uprava svaštara d.o.o. je odlučila 2018
--- 5 direktora svojih dobavljača odvesti
--- na krstarenje. Koga čemo povesti? 
--- u 2018 godini znaci moras stavit ---- where _______ between 'datum' and 'datum'

select * from Dobavljaci
select * from ArtikliNaPrimci

select top 5 a.naziv, 
sum(c.kolicina * c.cijena) as ukupno,
min(c.kolicina * c.cijena) as minimalno,
max(c.kolicina * c.cijena) as maksimalno
from Dobavljaci a inner join Primke b
on a.sifra = b.dobavljac
inner join ArtikliNaPrimci c on b.sifra = c.primka
where b.datum between '2017-01-01' and '2017-12-31'
group by a.naziv
having min(c.kolicina * c.cijena)>0    ----želim izbacit O u tablici minimum
order by 3 desc, 2 desc;

---kupci i mjesta-----u tablici kupci ima zapis od kdje dolazi kupac ime mjesta.......znaci mozemo nadograditi vanski kljuc
---izlistajte imena i prezimena kupaca koji 
---dolaze iz mjesta u kojem vi živite

select * from Kupci
select * from Mjesta

select distinct a.ime,a.prezime, b.naziv
from kupci a inner join Mjesta b
on a.mjesto = b.sifra
where b.naziv in ('Osijek','Split')  ---kad žeim 2 mjesta ili dve informacije tad stavljam IN i u oklepaju ('') vejice zgoraj---
order by a.prezime;

----kad želim nesto jedinstbeno koje se ne ponavlja tad stavljam DISTINCT
select distinct a.ime
from kupci a inner join Mjesta b
on a.mjesto = b.sifra
where b.naziv = 'Osijek'
order by a.ime;

--Idete u svatove i planirate kupiti poklon
---u rasponu 1000-1100 eura, koliko artikala možete kupiti?

select * from Artikli where cijena between 1000 and 1100
order by 6 desc;


select count(jedinicaMjere) from Artikli
where cijena between 1000 and 1100


select count(*) from Artikli; ---vsi artikli u bazi

---kad zelis nac iglu u sjeni artikala....
select distinct artikl from ArtikliNaPrimci;  
select * from Artikli where
sifra not in (select distinct artikl from ArtikliNaPrimci);


---unesi sebe kao kupca 
select * from Kupci
insert into Kupci (ime, jmbg, prezime, adresa, mjesto)
values ('Kristina','1254325425412','Andric','Loleka 3',10000)


select * from Kupci
where mjesto = 10000
order by 1;

---ispisite nazive mjesta u rh koji imaju iste nazive s
----s pripadajucim brojem ponavljanja
----count(*) znaci brojanje 

select naziv, count(*) from Mjesta   ----izaberi naziv i broji u tablici mjesta
group by naziv having count(*)>1  ----grupiraj prema nazivu i broji sve sto je veče od 1
order by 2 desc;
 
 select ime, count(*) as ponavljanja from Kupci
 group by ime having count(*)>1
 order by 2 desc;

 select naziv, count(*) from Proizvodi
 group by naziv having count(*)>1
 order by 2 desc;




select a.naziv as smjer, b.naziv as grupa
from smjerovi a left join grupe b
on a.sifra = b.smjer


select a.naziv as smjer, 
b.naziv as grupa,
d.ime, d.prezime
from smjerovi a inner join grupe b
on a.sifra = b.smjer
inner join clanovi c on b.sifra=c.grupa
inner join polaznici d on c.polaznik = d.sifra
where ime like 'P%'
order by 4;

--- broj clanova po grupi
select a.naziv, count(b.polaznik) as polaznika
from grupe a inner join clanovi b
on a.sifra = b.grupa
group by a.naziv;
having count(b.polaznik)>5;

use svastara;

--- želim vidjeti sve nazive mjesta u osječkoj-baranskoj županiji
select b.naziv as opcina, count(a.sifra) as mjesta
from mjesta a inner join opcine b
on a.opcina = b.sifra
inner join zupanije c on b.zupanija=c.sifra
where c.naziv like '%split%'
group by b.naziv
order by 2 desc;

--- uprava svaštara d.o.o. je odlučila 2018
--- 5 direktora svojih dobavljača odvesti
--- na krstarenje. Koga čemo povesti?

select top 5 a.naziv, 
sum(c.kolicina*c.cijena) as ukupno,
min(c.kolicina*c.cijena) as minimalno,
max(c.kolicina*c.cijena) as maksimalno
from Dobavljaci a inner join Primke b
on a.sifra=b.dobavljac
inner join ArtikliNaPrimci c on b.sifra=c.primka
where b.datum between '2017-01-01' and '2017-12-31' 
group by a.naziv
having min(c.kolicina*c.cijena)>0
order by 3 desc, 2 desc;


---izlistajte imena i prezimena kupaca koji 
---dolaze iz mjesta u kojem vi živite

select b.*
from mjesta a inner join kupci b
on a.sifra = b.mjesto
where a.naziv in('Osijek','Punitovci');

---Idete u svatove i planirate kupiti poklon
---u rasponu 1000-1100 eura, koliko artikala možete kupiti?

select * from Artikli where cijena between 1000 and 1100
order by 6 desc;

select count (*) from Artikli;

select distinct artikl from ArtikliNaPrimci;

select * from artikli where
sifra not in (select distinct artikl from ArtikliNaPrimci);

---obrišite jih

delete from artikli where
sifra not in (select distinct artikl from ArtikliNaPrimci);

---unesite sebe kao kupca s mjestom u kojem živite
select * from Kupci
select * from kupci where ime like 'Kristin&' and mjesto = 10000
order by prezime;

use svastara;

insert into kupci (ime,jmbg,prezime,adresa,mjesto) values
('Kristina','0000000000000', 'Andrić', 'Luke Petrinje 5', 10000);

select * from kupci where prezime like 'Andri%' and ime like 'Kristin%';

