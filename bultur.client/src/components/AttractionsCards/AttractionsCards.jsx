import PropTypes from 'prop-types';
import './AttractionsCards.scss'
import AttractionCard from '../AttractionCard/AttractionCard'
function AttractionsCards({ attractions }) {
    console.log(attractions)
    return (
        <div className="attractionCards-container">
            {attractions.map(attraction =>
                <AttractionCard key={attraction.id}
                    id={attraction.id}
                    name={attraction.name}
                    description={attraction.description}
                    image={attraction.bannerImageUrl}
                    town={attraction.townName}
                    type={attraction.typeName}
                />
            )}
        </div>
    )
}

export default AttractionsCards;

AttractionsCards.propTypes = {
    attractions: PropTypes.object
};