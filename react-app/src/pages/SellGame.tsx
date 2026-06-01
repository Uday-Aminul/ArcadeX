import { useNavigate } from "react-router-dom";
import "../styles/Pages.css";
import "../styles/Layout.css";

export default function SellGame() {
  const navigate = useNavigate();

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
        <h1>💰 Sell Your Game</h1>
        <p>List your game and start earning today</p>
      </section>

      {/* Sell Form */}
      <div className="form-container">
        <form className="sell-form">
          <div className="form-group">
            <label htmlFor="gameTitle">Game Title</label>
            <input
              type="text"
              id="gameTitle"
              placeholder="Enter the game title"
              required
            />
          </div>

          <div className="form-group">
            <label htmlFor="platform">Platform</label>
            <select id="platform" required>
              <option>Select Platform</option>
              <option>PC</option>
              <option>PlayStation 5</option>
              <option>Xbox Series X</option>
              <option>Nintendo Switch</option>
            </select>
          </div>

          <div className="form-group">
            <label htmlFor="condition">Condition</label>
            <select id="condition" required>
              <option>Select Condition</option>
              <option>Like New</option>
              <option>Used - Excellent</option>
              <option>Used - Good</option>
              <option>Used - Fair</option>
            </select>
          </div>

          <div className="form-group">
            <label htmlFor="price">Asking Price</label>
            <input
              type="number"
              id="price"
              placeholder="Enter your asking price"
              min="0"
              step="0.01"
              required
            />
          </div>

          <div className="form-group">
            <label htmlFor="description">Description</label>
            <textarea
              id="description"
              placeholder="Describe the condition and any included items"
              rows={4}
            ></textarea>
          </div>

          <div className="form-group">
            <label htmlFor="image">Upload Images</label>
            <input type="file" id="image" multiple accept="image/*" />
          </div>

          <button type="submit" className="btn btn-primary">
            List Game for Sale
          </button>
        </form>
      </div>
    </div>
  );
}
