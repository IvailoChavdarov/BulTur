import { useParams } from "react-router-dom";
import { useEffect, useState } from "react";
import Loader from '../components/Loader/Loader'
import Banner from '../components/Banner/Banner'
import AttractionsCards from '../components/AttractionsCards/AttractionsCards'

function TypePage() {
    let { id } = useParams();
    const [typeData, setTypeData] = useState();
    const [loading, setLoading] = useState(true);
    const fetchUrl = "https://localhost:7160/api/AttractionTypes/" + id
    useEffect(() => {
        if (loading) {
            fetch(fetchUrl)
                .then((res) => res.json())
                .then((data) => {
                    setTypeData(data)
                    setLoading(false)
                });
        }
    }, []);
    return (
        <>
            {loading ? <Loader /> :
                <>
                    <Banner title={typeData.name} subTitle={`Explore Bulgaria's ${typeData.name} attractions.`} backgroundImage={typeData.bannerImageUrl} />
                    <AttractionsCards attractions={typeData.attractionsData} />
                </>
            }
        </>
    )
}

export default TypePage;