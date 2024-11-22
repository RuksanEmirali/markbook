import "./NavigationBar.scss"
import { Container } from "react-bootstrap"
import { Nav } from "react-bootstrap"
import { Navbar } from "react-bootstrap"
import { NavDropdown } from "react-bootstrap"
import { Link } from "react-router-dom"


const NavigationBar: React.FC = () => {
  const logo = require("../images/Logo.png")
  return (
    <>
      <Navbar expand="lg" fixed="top" bg="dark" data-bs-theme="dark" className="bg-body-tertiary">
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
            <Navbar.Collapse className="justify-content-end">
              <Link to="/" className="navbar-brand">
                <img src={logo} alt="Markbook Logo" height="50" />
              </Link>
            </Navbar.Collapse>
          </Navbar.Collapse>
        </Container>
      </Navbar>
    </>

  )
}

export default NavigationBar
