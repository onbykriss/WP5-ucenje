import { HttpService } from "./HttpService";

async function get(){
    return await HttpService.get('/Stanovi')
    .then((odgovor)=>{
        //console.log(odgovor.data)
        //console.table(odgovor.data)
        return {greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{
        //console.log(e)
        return {greska: true, poruka: 'Problem kod dohvaćanja stanova'}   
    })
}

async function brisanje(sifra){
    return await HttpService.delete('/Stanovi/' + sifra)
    .then(()=>{
        return {greska: false, poruka: 'Obrisano'}
    })
    .catch(()=>{
        return {greska: true, poruka: 'Problem kod brisanja stana'}   
    })
}

export default {
    get,
    brisanje
}