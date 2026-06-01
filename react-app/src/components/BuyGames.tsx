import { useNavigate } from "react-router-dom";
import "../styles/Pages.css";

export default function BuyGames() {
  const navigate = useNavigate();

  const gamesList = [
    {
      id: 1,
      title: "Elden Ring",
      price: "$59.99",
      image: "🎮",
      rating: "4.8/5",
    },
    {
      id: 2,
      title: "Cyberpunk 2077",
      price: "$49.99",
      image: "🌆",
      rating: "4.5/5",
    },
    {
      id: 3,
      title: "The Witcher 3",
      price: "$39.99",
      image: "⚔️",
      rating: "4.9/5",
    },
    {
      id: 4,
      title: "Baldur's Gate 3",
      price: "$59.99",
      image: "🗡️",
      rating: "5.0/5",
    },
    {
      id: 5,
      title: "Starfield",
      price: "$69.99",
      image: "🚀",
      rating: "4.7/5",
    },
    {
      id: 6,
      title: "Palworld",
      price: "$29.99",
      image: "👾",
      rating: "4.6/5",
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
        <h1>🛍️ Buy Games</h1>
        <p>Discover and purchase games from our extensive collection</p>
      </section>

      {/* Filters */}
      <div className="filters-section">
        <input
          type="text"
          placeholder="Search games..."
          className="search-input"
        />
        <select className="filter-select">
          <option>All Genres</option>
          <option>Action</option>
          <option>RPG</option>
          <option>Strategy</option>
          <option>Adventure</option>
        </select>
        <select className="filter-select">
          <option>Price: Any</option>
          <option>Under $20</option>
          <option>$20 - $50</option>
          <option>$50+</option>
        </select>
      </div>

      {/* Games Grid */}
      <div className="games-grid">
        {gamesList.map((game) => (
          <div key={game.id} className="game-card">
            <div className="game-image">{game.image}</div>
            <h3>{game.title}</h3>
            <p className="rating">⭐ {game.rating}</p>
            <p className="price">{game.price}</p>
            <button className="btn btn-primary">Add to Cart</button>
          </div>
        ))}
      </div>
    </div>
  );
}
