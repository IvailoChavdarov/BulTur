import "./TopNav.scss";
import { NavLink } from 'react-router-dom'
import logo from '../../assets/images/logo-circle.png'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faMapPin } from '@fortawesome/free-solid-svg-icons'
import { faMapLocationDot } from '@fortawesome/free-solid-svg-icons'
import { faList } from '@fortawesome/free-solid-svg-icons'
import { faCircleInfo } from '@fortawesome/free-solid-svg-icons'
import { faMagnifyingGlass } from '@fortawesome/free-solid-svg-icons'

function TopNav() {
    return (
        <nav className="TopNav">
            <NavLink to="/"><img className="logo-button" src={logo} alt="BulTur" /></NavLink>
            <NavLink to="/attractions" className="topNav-link"><span className="topNav-link-text"><FontAwesomeIcon icon={faMapPin} />Attractions</span></NavLink>
            <NavLink to="/types" className="topNav-link"><span className="topNav-link-text"><FontAwesomeIcon icon={faList} />Types</span></NavLink>
            <NavLink to="/map" className="topNav-link"><span className="topNav-link-text"><FontAwesomeIcon icon={faMapLocationDot} />Map</span></NavLink>
            
            <div className="icons-container">
                <NavLink to="/search"><FontAwesomeIcon icon={faMagnifyingGlass} /></NavLink>
                <NavLink to="/about"><FontAwesomeIcon icon={faCircleInfo} /></NavLink>
            </div>
        </nav>
    )
}

export default TopNav;