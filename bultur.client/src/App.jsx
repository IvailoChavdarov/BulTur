import './styles/global.scss';
import TopNav from './components/TopNav/TopNav.jsx';
import Footer from './components/Footer/Footer.jsx';
import { Routes, Route, BrowserRouter } from 'react-router-dom'
import HomePage from './pages/HomePage'
import AttractionsPage from './pages/AttractionsPage'
import TypesPage from './pages/TypesPage'
import TypePage from './pages/TypePage'
import MapPage from './pages/MapPage';
function App() {

    return (
        <BrowserRouter>
            <TopNav />
            <Routes>
                <Route path="/" element={<HomePage />} />
                <Route path="/attractions" element={<AttractionsPage />} />
                <Route path="/types" element={<TypesPage />} />
                <Route path="/type/:id" element={<TypePage />} />
                <Route path="/map" element={<MapPage />} />
            </Routes>
            <Footer/>
        </BrowserRouter>
    );
    
}

export default App;