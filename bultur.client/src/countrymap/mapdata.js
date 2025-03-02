var accentColor = getComputedStyle(document.documentElement)
    .getPropertyValue("--accentColor")
    .trim();
var mainColor = getComputedStyle(document.documentElement)
    .getPropertyValue("--mainColor")
    .trim();

var simplemaps_countrymap_mapdata = {
  main_settings: {
    //General settings
    width: window.innerWidth > 1000 ? document.getElementsByClassName("map-container")[0].clientWidth/2 : "responsive",
    background_color: "#FFFFFF",
    background_transparent: "yes",
    border_color: mainColor,
    state_shortTitle: "",
    state_color: "",
    state_hover_color: "",
    state_url: "",
    border_size: "1.5",
    all_states_inactive: "no",
    all_states_zoomable: "no",
    
    //Location defaults
    location_shortTitle: "Location shortTitle",
    location_url: "",
    location_color: "#FF0067",
    location_opacity: 0.8,
    location_hover_opacity: 1,
    location_size: "15",
    location_type: "circle",
    location_border_color: "#FFFFFF",
    location_border: 2,
    location_hover_border: 2.5,
    all_locations_inactive: "no",
    all_locations_hidden: "no",
    
    //Label defaults
    label_color: "#ffffff",
    label_hover_color: "#ffffff",
    label_size: 16,
    label_font: "Arial",
    label_display: "auto",
    label_scale: "yes",
    hide_labels: "no",
    hide_eastern_labels: "no",
   
    //Zoom settings
    zoom: "yes",
    manual_zoom: "no",
    back_image: "no",
    initial_back: "no",
    initial_zoom: "-1",
    initial_zoom_solo: "no",
    region_opacity: 1,
    region_hover_opacity: 0.6,
    zoom_out_incrementally: "yes",
    zoom_percentage: 0.99,
    zoom_time: 0.5,
    
    //Popup settings
    popup_color: "white",
    popup_opacity: 0.9,
    popup_shadow: 1,
    popup_corners: 5,
    popup_font: "12px/1.5 Verdana, Arial, Helvetica, sans-serif",
    popup_nocss: "no",
    
    //Advanced settings
    div: "map",
    auto_load: "yes",
    url_new_tab: "no",
    images_directory: "default",
    fade_time: 0.1,
    link_text: "View Website",
    popups: "detect",
    state_bannerImageUrl: "",
    state_image_position: "",
    location_bannerImageUrl: "",
    border_hover_color: accentColor
  },
  state_specific:{}
};


fetch("https://localhost:7160/api/Regions")
.then((data) => data.json())
.then(regionsData => {
    regionsData.forEach(element => {
      simplemaps_countrymap_mapdata.state_specific["BG" + element.id.toString().padStart(2, '0')] = element
      simplemaps_countrymap_mapdata.state_specific["BG" + element.id.toString().padStart(2, '0')].url = "/" + element.name
        simplemaps_countrymap_mapdata.state_specific["BG" + element.id.toString().padStart(2, '0')].shortTitle = '<q> '+element.shortTitle+ ' </q><div class="mapPopupText"><img src="'+element.coatOfArmsImageUrl+'"><p>' + element.description+'</p></div>'
    });
})
.then(()=>{
  let funct = document.createElement("script")
    funct.src = "/src/countrymap/countrymap.js"
  document.body.appendChild(funct)
})