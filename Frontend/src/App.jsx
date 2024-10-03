import 'bootstrap/dist/css/bootstrap.min.css'
import Container from 'react-bootstrap/Container';
import './App.css'
import NavBarNekretnine from './Components/NavBarNekretnine';
import { Route, Routes } from 'react-router-dom';
import { RouteNames } from './constants';
import Pocetna from './pages/Pocetna';
import StanoviPregled from './pages/stanovi/StanoviPregled';
import StanoviDodaj from './pages/stanovi/StanoviDodaj';


function App() {

  return (
    <>
    <Container>
      <NavBarNekretnine />
      <Routes>
        <Route path={RouteNames.HOME} element={<Pocetna/>} />

        <Route path={RouteNames.STANOVI_PREGLED} element={<StanoviPregled/>}/>
        <Route path={RouteNames.STAN_NOVI} element={<StanoviDodaj/>}/>

      </Routes>
      <hr/>
      &copy; Nekretnine Zell am See 2024
    </Container>
    
    </>
  )
}

export default App