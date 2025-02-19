import './styles/global.scss';
import TopNav from './components/TopNav/TopNav.jsx';
import Footer from './components/Footer/Footer.jsx';
import { Routes, Route, BrowserRouter } from 'react-router-dom'
import HomePage from './pages/HomePage'
import AttractionsPage from './pages/AttractionsPage'
function App() {

    return (
        <BrowserRouter>
            <TopNav />
            <Routes>
                <Route path="/" element={<HomePage />} />
                <Route path="/attractions" element={<AttractionsPage />} />
            </Routes>
            <Footer/>
        </BrowserRouter>
    );
    
}

export default App;