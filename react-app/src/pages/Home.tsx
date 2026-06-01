import { useNavigate } from "react-router-dom";
import "../styles/Layout.css";
import "../styles/Global.css";

export default function Home() {
  const navigate = useNavigate();

  return (
    <>
      {/* Navigation Bar */}
      <nav className="navbar">
        <div className="nav-container">
          <div className="logo">
            <h1>🎮 GameVault</h1>
          </div>
          <ul className="nav-links">
            <li>
              <a href="#browse">Browse</a>
            </li>
            <li>
              <a href="#library">My Library</a>
            </li>
            <li>
              <a href="#support">Support</a>
            </li>
            <li>
              <button
                className="btn btn-link"
                onClick={() => navigate("/login")}
              >
                Login
              </button>
            </li>
            <li>
              <button
                className="btn btn-outline"
                onClick={() => navigate("/register")}
              >
                Register
              </button>
            </li>
          </ul>
        </div>
      </nav>

      {/* Hero Section */}
      <section className="hero-section">
        <div className="hero-content">
          <h1 className="hero-title">Welcome to GameVault</h1>
          <p className="hero-subtitle">
            Buy, sell, and trade games with gamers worldwide
          </p>
          <div className="hero-buttons">
            <button
              className="btn btn-primary"
              onClick={() => navigate("/register")}
            >
              Get Started
            </button>
            <button
              className="btn btn-secondary"
              onClick={() => navigate("/login")}
            >
              Login
            </button>
          </div>
        </div>
      </section>

      {/* Main Features Section */}
      <section className="features-section">
        <h2 className="section-title">Main Features</h2>
        <div className="features-grid">
          <div className="feature-card">
            <div className="feature-icon">🛍️</div>
            <h3>Buy Games</h3>
            <p>Browse our extensive collection of games at great prices</p>
            <button
              className="btn btn-primary"
              onClick={() => navigate("/buy-games")}
            >
              Buy Games
            </button>
          </div>

          <div className="feature-card">
            <div className="feature-icon">💰</div>
            <h3>Sell Game</h3>
            <p>Sell your unused games to other gamers in the community</p>
            <button
              className="btn btn-primary"
              onClick={() => navigate("/sell-game")}
            >
              Sell Game
            </button>
          </div>

          <div className="feature-card">
            <div className="feature-icon">📚</div>
            <h3>My Library</h3>
            <p>View and manage your personal game collection</p>
            <button
              className="btn btn-primary"
              onClick={() => navigate("/my-library")}
            >
              My Library
            </button>
          </div>

          <div className="feature-card">
            <div className="feature-icon">❤️</div>
            <h3>Wishlist</h3>
            <p>Keep track of games you want to buy</p>
            <button
              className="btn btn-primary"
              onClick={() => navigate("/wishlist")}
            >
              Wishlist
            </button>
          </div>

          <div className="feature-card">
            <div className="feature-icon">💬</div>
            <h3>Community</h3>
            <p>Connect with other gamers and share experiences</p>
            <button
              className="btn btn-primary"
              onClick={() => navigate("/community")}
            >
              Community
            </button>
          </div>

          <div className="feature-card">
            <div className="feature-icon">🔥</div>
            <h3>Deals</h3>
            <p>Find the best deals and special offers</p>
            <button
              className="btn btn-primary"
              onClick={() => navigate("/deals")}
            >
              Deals
            </button>
          </div>
        </div>
      </section>
    </>
  );
}
