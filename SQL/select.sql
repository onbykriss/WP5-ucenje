select * from smjerovi;

-- filtriranje kolona
-- * sve kolone
-- naziv kolone, konstanta i izraz

select naziv, cijena, *, naziv, 
'Osijek' as grad, 2 as broj,
getdate() as datum from smjerovi;


-- filtriranja redova
select * from polaznici;

-- where klauzula
-- operatori: = jednako, 

select * from polaznici where ime='Luka';

-- != različito
select * from polaznici where ime!='Luka';

-- < > >= <=
select * from polaznici where sifra<5;

-- logički operatori: and, or i not
-- boolean operatori: https://i.ytimg.com/vi/7dvqfpXEjdg/maxresdefault.jpg
select ime, prezime from polaznici where sifra>5 and sifra<10;

select * from polaznici where sifra=1 or sifra=2;

select * from polaznici where not sifra = 2;

-- ostali operatori
-- like

select distinct ime from polaznici where ime  like '%a%'
order by ime desc;

-- Uz najmanju moguću grešku s obzirom na podatke
-- Izlistajte sve žene u grupi
select * from polaznici where ime like '%a';

-- Izlistajte sve polaznike čije prezime počinje slovom M
select * from polaznici where prezime like 'm%';

-- in

select * from polaznici where sifra in (2,7,12,25);

-- between

select * from polaznici where sifra between 2 and 8;
-- na null vrijednosti se uvijek ide s dva operator: is null, is not null
select * from smjerovi where izvodiseod is not null; 


use knjiznica;

select top 10 percent * from autor;

select distinct ime from autor
where ime not like '%k%'
and ime like 'z%'
and ime not like '%a%'
order by ime;

select * from izdavac;

-- svim izdavačima za koje ne znamo jesu li aktivni ili ne
-- postavite da nisu aktivni

-- Uneseti sebe kao autora

select * from mjesto where postanskiBroj like '31%';
-- islistajte sva mjesta iz Osječko baranjske županije


use svastara;
select count(*) from artikli;
-- idete u svatove i želite kupiti poklon u vrijednosti
-- 100 do 150 €, koliko Vam je artikala na izboru?
-- kućanski aparat
select * from ArtikliNaPrimci;
