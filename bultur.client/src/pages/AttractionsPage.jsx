import Banner from '../components/Banner/Banner'
import AttractionsCards from '../components/AttractionsCards/AttractionsCards'
import Loader from '../components/Loader/Loader'
import { useEffect, useState } from "react";

function AttractionsPage() {
    const [attractions, setAttractions] = useState([]);
    const [loading, setLoading] = useState(true); 

    useEffect(() => {
        if (loading) {
            fetch("https://localhost:7160/api/Attractions")
                .then((res) => res.json())
                .then((data) => {
                    setAttractions(data)
                    setLoading(false)
                });
        }
    }, []);

    return (
        <>
            <Banner subTitle='"I love your Balkans, forests, screes, rocks and their clear and cold springs! I love you, my dear end! I love you with all my soul and heart, even if you are doomed to severe suffering and trouble! Everything that is left in my orphaned soul, good and holy - everything is yours! "' backgroundImage="../../src/assets/images/attractionsBanner1.png" subTitleExplain='- Lyuben Karavelov, "I love you, my dear fatherland!"' />
            <h2>Most popular attractions</h2>
            {/*TODO: Create Loader component*/ }
            {loading ? <Loader/> : <AttractionsCards attractions={attractions} />}
        </>
    )
}

export default AttractionsPage;