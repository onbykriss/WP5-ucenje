import StanoviService from "../../services/StanoviService";
import { Button, Row, Col, Form } from "react-bootstrap";
import moment from "moment";
import { Link, useNavigate } from "react-router-dom";
import { RouteNames } from "../../constants";

export default function StanoviPromjena() {
    const navigate = useNavigate();

    function obradiSubmit(e) { // e je event
        e.preventDefault(); // nemoj odraditi zahtjev na server
    }

    return (
        <>
            Promjena stana
            <Form onSubmit={obradiSubmit}>
                
                <Form.Group controlId="kvadratura">
                    <Form.Label>Kvadratura</Form.Label>
                    <Form.Control type="number" min={10} max={500} name="kvadratura" required />
                </Form.Group>
                
                <Form.Group controlId="adresa">
                    <Form.Label>Adresa</Form.Label>
                    <Form.Control type="text" name="adresa" required />
                </Form.Group>

                <Form.Group controlId="oprema">
                    <Form.Label>Oprema</Form.Label>
                    <Form.Control type="text" name="oprema" required />
                </Form.Group>
                

                <Row className="akcije">
                    <Col xs={6} sm={12} md={3} lg={6} xl={6} xxl={6}>
                        <Link to={RouteNames.STAN_PREGLED} className="btn btn-danger siroko">
                            Odustani
                        </Link>
                    </Col>
                    <Col xs={6} sm={12} md={9} lg={6} xl={6} xxl={6}>
                        <Button variant="success" type="submit" className="siroko">
                            Promijeni stan
                        </Button>
                    </Col>
                </Row>
            </Form>
        </>
    );
}