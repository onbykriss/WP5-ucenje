use knjiznica;

select top 10 percent * from autor;

select distinct ime from autor 
where ime not like '%k%'
and ime like 'z%'
and ime not like '%a%'
order by ime;


select * from izdavac;

-- svim izdavacima kojima neznamo jesu li aktivni ili ne, postavite da nisu aktivni
select * from izdavac
update izdavac set aktivan=1 where aktivan is null; 

---unesite sebe kao autora

select * from autor;

insert into autor (sifra,ime,prezime,datumrodenja) values 
(4,'Kristina','Andrić','1983-02-26');

-- islistajte sva mjesta iz Osječko baranjske županije
select * from mjesto where postanskibroj like '31%';

use svastara;

-- idete u svatove i želite kupiti poklon u vrijednosti 
-- 100 do 150 €, koliko vam je artikala na izboru
select * from Artikli where cijena>100 and cijena<150;

-- želim da bude kucanski aparat
select count(*) from Artikli;


use svastara;

select * from kupci;
select ime,prezime,jmbg from kupci;
select * from Kupci where jmbg like '0%';   --- samo da izabere jmbg sa prvim brojem 0

select * from kupci where len(ime)=4;   --- ako zelis samo 4 slova imena da se izbere

select * from Dobavljaci;