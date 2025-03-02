import { useEffect } from "react";
import "./InteractiveMap.scss";

function InteractiveMap() {
    useEffect(() => {
        const mapdataScript = document.createElement("script");
        mapdataScript.src = "/src/countrymap/mapdata.js";
        mapdataScript.async = true;
        document.body.appendChild(mapdataScript);
        mapdataScript.onload = () => {
            if (window.simplemaps_countrymap) {
                window.simplemaps_countrymap.load();
            }
        };
    }, []);
    return (
        <>
            <div id="map"></div>
        </>
    )
}
export default InteractiveMap;
