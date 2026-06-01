import { useNavigate } from "react-router-dom";
import "../styles/Pages.css";

export default function Deals() {
  const navigate = useNavigate();

  const deals = [
    {
      id: 1,
      title: "Flash Sale - 48 Hours Only",
      discount: "50% OFF",
      games: ["Cyberpunk 2077", "The Witcher 3", "Starfield"],
      image: "⚡",
      expiresIn: "47 hours",
    },
    {
      id: 2,
      title: "Weekend Bundle",
      discount: "40% OFF",
      games: ["Baldur's Gate 3", "Elden Ring", "Palworld"],
      image: "📦",
      expiresIn: "2 days",
    },
    {
      id: 3,
      title: "Indie Games Festival",
      discount: "Up to 70% OFF",
      games: ["Hollow Knight", "Stardew Valley", "Cuphead"],
      image: "🎮",
      expiresIn: "5 days",
    },
    {
      id: 4,
      title: "AAA Blockbuster Sale",
      discount: "35% OFF",
      games: ["GTA V", "Red Dead 2", "Spider-Man"],
      image: "🎬",
      expiresIn: "3 days",
    },
    {
      id: 5,
      title: "Strategy Games Week",
      discount: "45% OFF",
      games: ["Civilization VI", "Total War", "XCOM 2"],
      image: "♟️",
      expiresIn: "4 days",
    },
    {
      id: 6,
      title: "RPG Marathon Sale",
      discount: "60% OFF",
      games: ["Dragon's Dogma", "Fallout", "Kingdom Come"],
      image: "⚔️",
      expiresIn: "6 days",
    },
  ];

  return (
    <div className="page-container">
      {/* Navigation Bar */}
      <nav className="navbar">
        <div className="nav-container">
          <div className="logo">
            <h1 onClick={() => navigate("/")} style={{ cursor: "pointer" }}>
              🎮 GameVault
            </h1>
          </div>
          <ul className="nav-links">
            <li>
              <button className="btn btn-link" onClick={() => navigate("/")}>
                Home
              </button>
            </li>
            <li>
              <button
                className="btn btn-link"
                onClick={() => navigate("/login")}
              >
                Login
              </button>
            </li>
          </ul>
        </div>
      </nav>

      {/* Header */}
      <section className="page-header">
        <h1>🔥 Deals & Offers</h1>
        <p>Grab the hottest deals on games</p>
      </section>

      {/* Featured Deal Banner */}
      <div className="featured-deal">
        <div className="featured-content">
          <h2>⚡ MEGA FLASH SALE!</h2>
          <p>Up to 70% off on selected games</p>
          <p className="countdown">⏰ Ends in 47 hours</p>
          <button className="btn btn-primary btn-large">Shop Now</button>
        </div>
      </div>

      {/* Deals Grid */}
      <div className="deals-grid">
        {deals.map((deal) => (
          <div key={deal.id} className="deal-card">
            <div className="deal-badge">{deal.discount}</div>
            <div className="deal-image">{deal.image}</div>
            <h3>{deal.title}</h3>
            <div className="included-games">
              {deal.games.map((game, idx) => (
                <span key={idx} className="game-tag">
                  {game}
                </span>
              ))}
            </div>
            <p className="expires">Expires: {deal.expiresIn}</p>
            <div className="action-buttons">
              <button className="btn btn-primary">View Deal</button>
              <button className="btn btn-outline">Add to Wishlist</button>
            </div>
          </div>
        ))}
      </div>

      {/* Newsletter Section */}
      <div className="newsletter-section">
        <h2>Never Miss a Deal</h2>
        <p>Subscribe to our newsletter for exclusive offers</p>
        <div className="newsletter-form">
          <input type="email" placeholder="Enter your email" />
          <button className="btn btn-primary">Subscribe</button>
        </div>
      </div>
    </div>
  );
}
