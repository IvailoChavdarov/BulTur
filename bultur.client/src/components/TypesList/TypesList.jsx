import PropTypes from 'prop-types';
import { Link } from 'react-router-dom'
import './TypesList.scss'

function TypesPage({ types }) {
    return (
        <div className="types-container">
            {types.map(type =>
                <Link to={'/' + type.name.toLowerCase()} key={type.id} className="type-card">
                    <h1>{type.name}</h1>
                    <img src={type.bannerImageUrl}></img>
                </Link>
            )}
        </div>
    )
}

export default TypesPage;

TypesPage.propTypes = {
    types: PropTypes.object
};