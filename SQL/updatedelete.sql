select * from smjerovi where sifra=2;

update smjerovi set izvodiseod='2024-06-06 19:10' where sifra=2;

update smjerovi set cijena = 999.42, vaucer=0 where sifra=3;

-- svim smjerovima smanji cijenu za 10%
select * from smjerovi;
update smjerovi set cijena = cijena * 0.9;
select * from smjerovi;

-- povećajte cijene svim smjerovima za 6,5%
update smjerovi set cijena = cijena * 1.065;

-- smanjite svim smjerovima cijenu za 10 €
update smjerovi set cijena = cijena - 10;

select * from polaznici;
--update polaznici set prezime ='Prpić';
