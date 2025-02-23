import TypesList from '../components/TypesList/TypesList'
import { useEffect, useState } from "react";

function TypesPage() {
    const [types, setTypes] = useState([]);
    const [loading, setLoading] = useState(true);

    useEffect(() => {
        if (loading) {
            fetch("https://localhost:7160/api/AttractionTypes")
                .then((res) => res.json())
                .then((data) => {
                    setTypes(data)
                    setLoading(false)
                });
        }
    }, []);

    return (
        <>
            {/*TODO: Create Loader component*/}
            
            {loading ? <div>Loading...</div> : <TypesList types={types} />}
        </>
    )
}

export default TypesPage;