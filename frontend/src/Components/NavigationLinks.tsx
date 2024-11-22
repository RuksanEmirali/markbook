import { Link } from "react-router-dom"

const NavigationLinks: React.FC = () => {
  return (
    <ul className="navbar-nav mb-2 mb-lg-0 d-flex w-100 justify-content-around" data-testid="navigationLinks">
      <li className="nav-item">
        <Link to="/" className="nav-link" data-testid="homeLink">
          Home
        </Link>
      </li>
      <li className="nav-item">
        <Link to="/students" className="nav-link">
          Student List
        </Link>
        <li className="nav-item">
          <Link to="/students/search" className="nav-link">
            Search Students
          </Link>
        </li>
      </li>
    </ul>
  )
}

export default NavigationLinks
