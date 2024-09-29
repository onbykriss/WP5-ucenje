import { useEffect } from "react"
import SmjerService from "../../services/SmjerService"


export default function SmjeroviPregled(){

async function dohvatiSmjerove(){
    await SmjerService.get();
}

useEffect(()=>{
dohvatiSmjerove();
}, [])

return (
<>
Ovdje ce doci pregled smjerova
</>
)
}