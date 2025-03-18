import PropTypes from 'prop-types';
import "./AttractionsCarouselItem.scss";
import { Link } from 'react-router-dom'

function AttractionCarouselItem({ id, name, description, image, town, type }) {
    return (
        <div className="attraction-carousel-card">
            <div className="attraction-carousel-card-data">
                <img src={image} />
                <h4>{name}</h4>
                <div className="attraction-links">
                    <Link className="location-link">{town}</Link><span> - </span>
                    <Link className="type-link" to={"/type/" + type}>{type}</Link>
                </div>
                <p>{description}</p>
                <Link to={'/' + id} className="seeMore-link">See more</Link>
            </div>
        </div>
    )
}
export default AttractionCarouselItem;

AttractionCarouselItem.propTypes = {
    id: PropTypes.string,
    name: PropTypes.string,
    description: PropTypes.string,
    image: PropTypes.string,
    town: PropTypes.string,
    type: PropTypes.string
};