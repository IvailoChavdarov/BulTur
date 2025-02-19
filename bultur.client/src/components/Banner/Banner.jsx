import PropTypes from 'prop-types';
import "./Banner.scss"
function Banner({ title, subTitle, subTitleExplain, backgroundImage }) {
    const bannerBackgroundStyle = { backgroundImage: `url(${backgroundImage})` };

    return (
        <div className="banner" style={bannerBackgroundStyle}>
            <div className="filter-dark">
            </div>
            <div className="banner-inner" >
                {title ? <h1>{title}</h1> : ""}
                {subTitle ? <h2>{subTitle}</h2> : ""}
                {subTitleExplain ? <h4>{subTitleExplain}</h4>: ""}
            </div> 
        </div>
    );
}

Banner.propTypes = {
    title: PropTypes.string.isRequired,
    subTitle: PropTypes.string,
    backgroundImage: PropTypes.string,
    subTitleExplain: PropTypes.string
};

export default Banner;