import { Link } from "react-router-dom"
import "./Home.scss"

const Home: React.FC = () => {
    const logo = require("../../images/School-Building-with-Background.png")

    return (
        <>
            <div data-testid="background-container" className="background-container">
                <div className="logo">
                    <img src={logo} alt="School building image"/>
                </div>
            </div>
        </>
    )
}

export default Home