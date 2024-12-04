import "./Header.scss"
import { Link } from "react-router-dom"
import NavigationBar from "../Components/NavigationBar"

const Header: React.FC = () => {
    const logo = require("../images/Logo.png")
  
    return (
        <nav className="navbar">
              <NavigationBar/>
        </nav>
    )
  }
  
  export default Header