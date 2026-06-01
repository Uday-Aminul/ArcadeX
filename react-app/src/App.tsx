import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import "./styles/Global.css";
import "./styles/Pages.css";
// Pages
import Home from "./pages/Home";
import BuyGames from "./pages/BuyGames";
import SellGame from "./pages/SellGame";
import MyLibrary from "./pages/MyLibrary";
import Wishlist from "./pages/Wishlist";
import Community from "./pages/Community";
import Deals from "./pages/Deals";
// Auth Features
import Login from "./features/auth/Login";
import Register from "./features/auth/Register";

function App() {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/login" element={<Login />} />
        <Route path="/register" element={<Register />} />
        <Route path="/buy-games" element={<BuyGames />} />
        <Route path="/sell-game" element={<SellGame />} />
        <Route path="/my-library" element={<MyLibrary />} />
        <Route path="/wishlist" element={<Wishlist />} />
        <Route path="/community" element={<Community />} />
        <Route path="/deals" element={<Deals />} />
      </Routes>
    </Router>
  );
}

export default App;
