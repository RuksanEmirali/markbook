import "./Header.scss"
import { Link } from "react-router-dom"
import NavigationLinks from "../Components/NavigationLinks"

const Header: React.FC = () => {
    const logo = require("../images/Logo.png")
  
    return (
      <div className="show-header">
        <nav className="navbar navbar-inverse">
          <div className="container-fluid">
            <div className="navbar-header">
              <Link to="/" className="navbar-brand">
                <img src={logo} alt="Markbook Logo" width="200" />
              </Link>
              <NavigationLinks/>
            </div>
          </div>
        </nav>
      </div>
    )
  }
  
  export default Header