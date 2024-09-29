import React from 'react';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import NavDropdown from 'react-bootstrap/NavDropdown';
import Offcanvas from 'react-bootstrap/Offcanvas';
import Container from 'react-bootstrap/Container';
import Form from 'react-bootstrap/Form';
import { useNavigate } from 'react-router-dom';
import { RouteNames } from '../constants';

export default function NavBarEdunova() {

   const navigate = useNavigate()
    
  return (
    <>
      {['xl'].map((expand) => (
        <Navbar key={expand} expand={expand} className="bg-body-tertiary mb-3">
          <Container fluid>
            <Navbar.Brand className='ruka'
            onClick={()=>navigate(RouteNames.HOME)}>Edunova APP</Navbar.Brand>
            
            <Navbar.Toggle aria-controls={`offcanvasNavbar-expand-${expand}`} />
            
            <Navbar.Offcanvas
              id={`offcanvasNavbar-expand-${expand}`}
              aria-labelledby={`offcanvasNavbarLabel-expand-${expand}`}
              placement="end"
            >
              <Offcanvas.Header closeButton>
                <Offcanvas.Title id={`offcanvasNavbarLabel-expand-${expand}`}>
                  Edunova App
                </Offcanvas.Title>
              </Offcanvas.Header>
              <Offcanvas.Body>
                <Nav className="justify-content-end flex-grow-1 pe-3">
                  <Nav.Link href="https://kristinandric-001-site1.etempurl.com/swagger/index.html" target="_blank">Swagger</Nav.Link>
                  <NavDropdown title="Programi" id="basic-nav-dropdown">
                    <NavDropdown.Item 
                    onClick={()=>navigate(RouteNames.SMJER_PREGLED)} >Smjerovi</NavDropdown.Item>
                    <NavDropdown.Item 
                    href="#action/2">Polaznici</NavDropdown.Item>
                    <NavDropdown.Item 
                    href="#action/3">Grupe</NavDropdown.Item></NavDropdown>
                </Nav>
                <Form className="d-flex">
                </Form>
              </Offcanvas.Body>
            </Navbar.Offcanvas>
          </Container>
        </Navbar>
      ))}
    </>
  );
}