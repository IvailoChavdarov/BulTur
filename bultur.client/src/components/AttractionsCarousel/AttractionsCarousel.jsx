import PropTypes from 'prop-types';
import './AttractionsCarousel.scss'
import AttractionsCarouselItem from '../AttractionsCarouselItem/AttractionsCarouselItem'
import Slider from "react-slick";
import "slick-carousel/slick/slick.css";
import "slick-carousel/slick/slick-theme.css";

function AttractionsCarousel({ attractions }) {
    const settings = {
        dots: true,
        infinite: true,
        speed: 700,
        slidesToShow: 4,
        slidesToScroll: 4
    };
    return (
        <div className="AttractionsCarousel" id="carousel">
            <Slider {...settings}>
            {attractions.map(attraction =>
                <AttractionsCarouselItem key={attraction.id}
                    id={attraction.id}
                    name={attraction.name}
                    description={attraction.description}
                    image={attraction.bannerImageUrl}
                    town={attraction.townName}
                    type={attraction.typeName}
                />
                )}
            </Slider>
        </div>
    )
}

export default AttractionsCarousel;

AttractionsCarousel.propTypes = {
    attractions: PropTypes.object
};