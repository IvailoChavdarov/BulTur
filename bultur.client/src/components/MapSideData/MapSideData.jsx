import './MapSideData.scss'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faTree } from '@fortawesome/free-solid-svg-icons'
import { faBuildingColumns } from '@fortawesome/free-solid-svg-icons'
import { faFire } from '@fortawesome/free-solid-svg-icons'
import { faUtensils } from '@fortawesome/free-solid-svg-icons'
import { faMoneyBillWave } from '@fortawesome/free-solid-svg-icons'

function MapSideData() {
    return (
        <div className="map-side">
            <h1>Why visit Bulgaria?</h1>
            <div className="map-side-content">
                <p> From the beautiful shores of the Black Sea, through the sharp Balkan Mountains to the snowy peaks of Vitosha, Bulgaria is a country of diverse landscapes, rich history, and vibrant culture. Nestled in the heart of the Balkans, this hidden gem offers something for every traveler - whether you seek adventure, history, relaxation, or culinary delights.</p>
                <ul>
                    <li><FontAwesomeIcon icon={faBuildingColumns} color="whitesmoke" /><span className="idea-title">Ancient heritage</span> - Discover Thracian tombs, Roman amphitheaters, and medieval fortresses scattered across the country.</li>
                    <li><FontAwesomeIcon icon={faTree} color="forestgreen" /><span className="idea-title">Breathtaking nature</span> - Explore the serene beaches of the Black Sea, the lush forests of the Rhodope Mountains, and the glacial lakes of Rila and Pirin.</li>
                    <li><FontAwesomeIcon icon={faFire} color="orangered" /><span className="idea-title">Authentic culture and traditions</span> - Experience vibrant festivals, traditional dances, and the famous Bulgarian rose oil production.</li>
                    <li><FontAwesomeIcon icon={faUtensils} color="#ffd117" /><span className="idea-title">Delicious cuisine</span> - Savor local specialties like Banitsa, Shopska Salad, and the unique Bulgarian yogurt.</li>
                    <li><FontAwesomeIcon icon={faMoneyBillWave} color="darkgreen" /><span className="idea-title">Affordable and welcoming</span> - Enjoy world-class experiences at budget-friendly prices, with warm hospitality from the locals.</li>
                </ul>
            </div>
        </div>
        
  );
}

export default MapSideData;