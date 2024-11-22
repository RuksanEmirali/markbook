import "./Header.scss"
import { Link } from "react-router-dom"
import NavigationBar from "../Components/NavigationBar"

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
              <NavigationBar/>
            </div>
          </div>
        </nav>
      </div>
    )
  }
  
  export default Header