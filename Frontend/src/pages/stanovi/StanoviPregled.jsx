import { useEffect, useState } from "react";
import StanoviService from "../../services/StanoviService";
import { Button, Table } from "react-bootstrap";
import { NumericFormat } from "react-number-format";
import moment from "moment";
import { GrValidate } from "react-icons/gr";
import { Link } from "react-router-dom";
import { RouteNames } from "../../constants";

export default function StanoviPregled() {
    const [stanovi, setStanovi] = useState([]);

    async function dohvatiStanovi() {
        const odgovor = await StanoviService.get();
        if (odgovor.greska) {
            alert(odgovor.poruka);
            return;
        }
        setStanovi(odgovor.poruka);
    }

    useEffect(() => {
        dohvatiStanovi();
    }, []);

    function obrisi(sifra) {
        if (!confirm('Sigurno obrisati')) {
            return;
        }
        brisanjeStanovi(sifra);
    }

    async function brisanjeStanovi(sifra) {
        const odgovor = await StanoviService.brisanje(sifra);
        if (odgovor.greska) {
            alert(odgovor.poruka);
            return;
        }
        dohvatiStanovi();
    }

    return (
        <>
            <Link to={RouteNames.STANOVI_NOVI} className="btn btn-success siroko">
                Dodaj novi stan
            </Link>
            <Table striped bordered hover responsive>
                <thead>
                    <tr>
                        <th>Kvadratura</th>
                        <th>Adresa</th>
                        <th>Oprema</th>
                        <th>Slika</th>
                    
                    </tr>
                </thead>
                <tbody>
                    {stanovi && stanovi.map((stan, index) => (
                        <tr key={index}>
                            <td>{stan.kvadratura}</td>
                            <td>{stan.adresa}</td>
                            <td>{stan.oprema}</td>
                            <td>
                                <img src={stan.slika} alt="Slika stana" style={{ width: '100px' }} />
                            </td>
                            <td>
                                <Button variant="danger" onClick={() => obrisi(stan.sifra)}>
                                    Obriši
                                </Button>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </Table>
        </>
    );
}