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
                <div className="top-buttons">
                    <Link to="students">
                    <button id="submit-button" data-testid="submit-button" className="btn btn-primary btn-lg custom-button">
                        Students
                    </button>
                    </Link>
                </div>
            </div>
        </>
    )
}

export default Home