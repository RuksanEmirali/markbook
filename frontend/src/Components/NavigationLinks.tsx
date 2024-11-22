import { Link } from "react-router-dom"
import { Container } from "react-bootstrap"
import { Nav } from "react-bootstrap"
import { Navbar } from "react-bootstrap"
import { NavDropdown } from "react-bootstrap"

const NavigationLinks: React.FC = () => {
  return (
    <>
    <Navbar expand="lg" className="bg-body-tertiary">
      <Container>
        <Navbar.Brand href="#home">Markbook</Navbar.Brand>
        <Navbar.Toggle aria-controls="basic-navbar-nav" />
        <Navbar.Collapse id="basic-navbar-nav">
          <Nav className="me-auto">
            <Nav.Link href="/">Home</Nav.Link>
            <NavDropdown title="Students" id="basic-nav-dropdown">
              <NavDropdown.Item href="/students">List</NavDropdown.Item>
              <NavDropdown.Item href="/students/search">
                Search
              </NavDropdown.Item>
            </NavDropdown>
          </Nav>
        </Navbar.Collapse>
      </Container>
    </Navbar>
    </>


    
    // <ul className="navbar-nav mb-2 mb-lg-0 d-flex w-100 justify-content-around" data-testid="navigationLinks">
    //   <li className="nav-item">
    //     <Link to="/" className="nav-link" data-testid="homeLink">
    //       Home
    //     </Link>
    //   </li>
    //   <li className="nav-item">
    //     <Link to="/students" className="nav-link">
    //       Student List
    //     </Link>
    //     <li className="nav-item">
    //       <Link to="/students/search" className="nav-link">
    //         Search Students
    //       </Link>
    //     </li>
    //   </li>
    // </ul>
  )
}

export default NavigationLinks
