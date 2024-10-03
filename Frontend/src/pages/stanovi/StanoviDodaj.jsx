import { useState } from "react";
import StanoviService from "../../services/StanoviService";
import { Button, Row, Col, Form } from "react-bootstrap";
import { Link, useNavigate } from "react-router-dom";
import { RouteNames } from "../../constants";

export default function StanoviDodaj() {
    const navigate = useNavigate();
    const [formData, setFormData] = useState({
        kvadratura: '',
        adresa: '',
        oprema: '',
        slika: ''
    });

    function handleChange(e) {
        const { name, value } = e.target;
        setFormData(prevState => ({
            ...prevState,
            [name]: value
        }));
    }

    async function obradiSubmit(e) {
        e.preventDefault();
        const odgovor = await StanoviService.dodaj(formData);
        if (odgovor.greska) {
            alert(odgovor.poruka);
            return;
        }
        navigate(RouteNames.STANOVI_PREGLED);
    }

    return (
        <>
            Dodavanje stanova
            <Form onSubmit={obradiSubmit}>
                <Form.Group controlId="kvadratura">
                    <Form.Label>kvadratura</Form.Label>
                    <Form.Control
                        type="number"
                        step={0.01}
                        name="kvadratura"
                        value={formData.kvadratura}
                        onChange={handleChange}
                        required
                    />
                </Form.Group>

                <Form.Group controlId="adresa">
                    <Form.Label>adresa</Form.Label>
                    <Form.Control
                        type="text"
                        name="adresa"
                        value={formData.adresa}
                        onChange={handleChange}
                        required
                    />
                </Form.Group>

                <Form.Group controlId="oprema">
                    <Form.Label>oprema</Form.Label>
                    <Form.Control
                        type="text"
                        name="oprema"
                        value={formData.oprema}
                        onChange={handleChange}
                        required
                    />
                </Form.Group>

                <Row className="akcije">
                    <Col xs={6} sm={12} md={3} lg={6} xl={6} xxl={6}>
                        <Link to={RouteNames.STANOVI_PREGLED} className="btn btn-danger siroko">
                            Odustani
                        </Link>
                    </Col>
                    <Col xs={6} sm={12} md={3} lg={6} xl={6} xxl={6}>
                        <Button type="submit" className="btn btn-success siroko">
                            Dodaj
                        </Button>
                    </Col>
                </Row>
            </Form>
        </>
    );
}