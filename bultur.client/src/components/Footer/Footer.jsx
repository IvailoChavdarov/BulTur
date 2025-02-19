import "./Footer.scss";
import { NavLink } from 'react-router-dom'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faGithub } from '@fortawesome/free-brands-svg-icons'
import { faLinkedin } from '@fortawesome/free-brands-svg-icons'
import { faInstagram } from '@fortawesome/free-brands-svg-icons'
import { faFacebook } from '@fortawesome/free-brands-svg-icons'
function Footer() {
    return (
        <footer className="footer-main">
            <div className="footer-col">
                <h3>More</h3>
                <NavLink target="_blank" to="https://www.meteo.bg/en" className="topNav-link">The weather</NavLink>
                <NavLink target="_blank" to="https://www.skyscanner.net/flights-to/bg/cheap-flights-to-bulgaria.html" className="topNav-link">Flights</NavLink>
                <NavLink to="/login" className="topNav-link">Staff portal</NavLink>
            </div>
            <div className="footer-col">
                <h3>Useful links</h3>
                <NavLink target="_blank" to="https://www.novinite.com/" className="topNav-link">News</NavLink>
                <NavLink target="_blank" to="https://www.tourism.government.bg/" className="topNav-link">Ministry of Tourism</NavLink>
            </div>
            <div className="footer-col">
                <h3>Contacts</h3>
                <div className="socials-container">
                    <NavLink to="https://github.com/IvailoChavdarov" target="_blank" className="topNav-link"><FontAwesomeIcon icon={faGithub} /></NavLink>
                    <NavLink to="https://www.linkedin.com/in/ivaylo-chavdarov-5ab76b294/" target="_blank" className="topNav-link"><FontAwesomeIcon icon={faLinkedin} /></NavLink>
                    <NavLink to="https://www.instagram.com/ivailo_chavdarov/" target="_blank" className="topNav-link"><FontAwesomeIcon icon={faInstagram} /></NavLink>
                    <NavLink to="https://www.facebook.com/ivailo.chavdarov.90" target="_blank" className="topNav-link"><FontAwesomeIcon icon={faFacebook} /></NavLink>
                </div>
            </div>
            <div className="footer-bottom">
                BulTur - 2025
            </div>
        </footer>
    )
}

export default Footer;