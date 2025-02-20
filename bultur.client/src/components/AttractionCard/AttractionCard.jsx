import PropTypes from 'prop-types';
import './AttractionCard.scss';
import { Link } from 'react-router-dom'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faLocationDot } from '@fortawesome/free-solid-svg-icons'

function AttractionCard({id, name, description, image, town, type }) {
    return (
        <div className="attraction-card">
            <div className="attraction-card-data">
                <img src={image} />
                <div className="links-overlay">
                    <Link className="type-link">{type}</Link>
                </div>
                <Link className="location-link"><FontAwesomeIcon icon={faLocationDot} />{town}</Link>
                <h4>{name}</h4>
                <p>{description}</p>
                <Link to={'/' + id} className="seeMore-link">See more</Link>
            </div>
        </div>
    )
}
export default AttractionCard;

AttractionCard.propTypes = {
    id: PropTypes.string,
    name: PropTypes.string,
    description: PropTypes.string,
    image: PropTypes.string,
    town: PropTypes.string,
    type: PropTypes.string
};