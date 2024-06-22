select * from smjerovi where sifra=2;

update smjerovi set izvodiseod='2024-06-06 19:10' where sifra=2;

update smjerovi set cijena =999.42, vaucer=0 where sifra=3;

---svim smijerovima smanji cijenu za 10%
select * from smjerovi;
update smjerovi set cijena = cijena * 0.9;
select * from smjerovi;

---povečaj te cijene svim smjerovima za 6,5%
select * from smjerovi;
update smjerovi set cijena = cijena * 1.065;
select * from smjerovi;

--smanjite svim smerovima cijenu za 10 €
select * from smjerovi;
update smjerovi set cijena = cijena - 10;
select * from smjerovi;

select * from polaznici;
---update polaznici set prezime = 'Prpić';

update polaznici set oib = '00653662367' where sifra =1;

select * from grupe;

update grupe set smjer = null where sifra=1;

delete from smjerovi;

delete from grupe;

delete from clanovi;


