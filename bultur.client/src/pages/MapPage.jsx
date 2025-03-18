import InteractiveMap from '../components/InteractiveMap/InteractiveMap'
import MapSideData from '../components/MapSideData/MapSideData'
import { useEffect, useState } from "react";
import Loader from '../components/Loader/Loader'
import AttractionsCarousel from '../components/AttractionsCarousel/AttractionsCarousel';

function MapPage() {
    const [regionsData, setRegionsData] = useState([]);
    const [attractionsData, setAttractionsData] = useState([]);
    const [loading, setLoading] = useState(true);
    console.log(document.querySelector('.map-container'))
    useEffect(() => {
        if (loading) {
            fetch("https://localhost:7160/api/Regions")
                .then((res) => res.json())
                .then((data) => {
                    setRegionsData(data)
                    setLoading(false)
                });
            fetch("https://localhost:7160/api/Attractions")
                .then((res) => res.json())
                .then((data) => {
                    setAttractionsData(data)
                    setLoading(false)
                });
            //TODO fix loader conditions
            //TODO add get specific ammount of attractions in controller to send data to attractions carousel and items
        }
    }, []);

    return (
        <>
            {loading ? <Loader /> : <>
                <div className="map-container">
                    <InteractiveMap regions={regionsData} />
                    <MapSideData />
                </div>
                <div className="">
                    <h2>Most popular cities</h2>
                    Cards for Sofia, Plovdiv, Stara Zagora, Varna, Burgas - slider
                </div>
                <div>
                    <h2>Attractions to check</h2>
                    <AttractionsCarousel attractions={attractionsData } />
                </div>
            </>}
        </>
    )
}

export default MapPage;