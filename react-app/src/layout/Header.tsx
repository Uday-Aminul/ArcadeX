import { useNavigate } from "react-router-dom";
import "../styles/Layout.css";

export default function Header() {
  const navigate = useNavigate();

  return (
    <nav className="navbar">
      <div className="nav-container">
        <div className="logo">
          <h1 onClick={() => navigate("/")} style={{ cursor: "pointer" }}>
            🎮 GameVault
          </h1>
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
            <button className="btn btn-link" onClick={() => navigate("/login")}>
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
  );
}
