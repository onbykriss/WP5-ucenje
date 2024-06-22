
--- use edunovawp5;

select * from grupe;

select * from smjerovi where sifra=1;   ----tako se ne radi....radit cemo da spojimo tablice

--- kuharica prema materialima

select a.naziv as smjer, b.naziv as grupa
from smjerovi a inner join grupe b
on a.sifra = b.smjer

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

