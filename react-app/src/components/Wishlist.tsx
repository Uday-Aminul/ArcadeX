import { useNavigate } from "react-router-dom";
import "../styles/Pages.css";

export default function Wishlist() {
  const navigate = useNavigate();

  const wishlistGames = [
    {
      id: 1,
      title: "Dragon's Dogma 2",
      price: "$59.99",
      image: "🐉",
      inStock: true,
    },
    {
      id: 2,
      title: "Final Fantasy XVI",
      price: "$69.99",
      image: "✨",
      inStock: true,
    },
    {
      id: 3,
      title: "Street Fighter 6",
      price: "$44.99",
      image: "🥊",
      inStock: false,
    },
    {
      id: 4,
      title: "Tekken 8",
      price: "$64.99",
      image: "👊",
      inStock: true,
    },
    {
      id: 5,
      title: "Metaphor: ReFantazio",
      price: "$59.99",
      image: "🎭",
      inStock: true,
    },
    {
      id: 6,
      title: "Silent Hill 2 Remake",
      price: "$69.99",
      image: "👻",
      inStock: false,
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
        <h1>❤️ My Wishlist</h1>
        <p>Games you're interested in</p>
      </section>

      {/* Filters */}
      <div className="filters-section">
        <select className="filter-select">
          <option>All Items</option>
          <option>In Stock</option>
          <option>Out of Stock</option>
        </select>
        <select className="filter-select">
          <option>Sort By</option>
          <option>Newest Added</option>
          <option>Price: Low to High</option>
          <option>Price: High to Low</option>
        </select>
      </div>

      {/* Wishlist Grid */}
      <div className="games-grid">
        {wishlistGames.map((game) => (
          <div
            key={game.id}
            className={`wishlist-card ${!game.inStock ? "out-of-stock" : ""}`}
          >
            <div className="game-image">{game.image}</div>
            <h3>{game.title}</h3>
            <p className="price">{game.price}</p>
            {!game.inStock && (
              <p className="out-of-stock-label">Out of Stock</p>
            )}
            <div className="action-buttons">
              <button className="btn btn-primary" disabled={!game.inStock}>
                {game.inStock ? "Add to Cart" : "Notify Me"}
              </button>
              <button className="btn btn-outline">Remove</button>
            </div>
          </div>
        ))}
      </div>
    </div>
  );
}
