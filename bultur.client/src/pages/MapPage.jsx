import InteractiveMap from '../components/InteractiveMap/InteractiveMap'
import MapSideData from '../components/MapSideData/MapSideData'
import { useEffect, useState } from "react";
import Loader from '../components/Loader/Loader'

function MapPage() {
    const [regionsData, setRegionsData] = useState([]);
    const [loading, setLoading] = useState(true);

    useEffect(() => {
        if (loading) {
            fetch("https://localhost:7160/api/Regions")
                .then((res) => res.json())
                .then((data) => {
                    setRegionsData(data)
                    setLoading(false)
                });
        }
    }, []);

    return (
        <>
            {loading ? <Loader /> : <>
                <div className="map-container">
                    <InteractiveMap regions={regionsData} />
                    <MapSideData />
                </div>
                <div>
                    <h2>Most popular cities</h2>
                    Cards for Sofia, Plovdiv, Stara Zagora, Varna, Burgas - slider
                </div>
                <div>
                    <h2>Attractions to check</h2>
                    Carusel 10-15 of AttractionImages leading to attraction details
                </div>
            </>}
        </>
    )
}

export default MapPage;