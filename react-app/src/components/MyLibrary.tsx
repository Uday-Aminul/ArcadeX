import { useNavigate } from "react-router-dom";
import "../styles/Pages.css";

export default function MyLibrary() {
  const navigate = useNavigate();

  const myGames = [
    {
      id: 1,
      title: "Elden Ring",
      playTime: "120 hours",
      status: "Currently Playing",
      image: "🎮",
    },
    {
      id: 2,
      title: "The Witcher 3",
      playTime: "85 hours",
      status: "Completed",
      image: "⚔️",
    },
    {
      id: 3,
      title: "Cyberpunk 2077",
      playTime: "64 hours",
      status: "In Progress",
      image: "🌆",
    },
    {
      id: 4,
      title: "Baldur's Gate 3",
      playTime: "200 hours",
      status: "Completed",
      image: "🗡️",
    },
    {
      id: 5,
      title: "Starfield",
      playTime: "45 hours",
      status: "In Progress",
      image: "🚀",
    },
    {
      id: 6,
      title: "Palworld",
      playTime: "30 hours",
      status: "Currently Playing",
      image: "👾",
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
        <h1>📚 My Library</h1>
        <p>Your personal game collection</p>
      </section>

      {/* Stats */}
      <div className="stats-section">
        <div className="stat-card">
          <h3>Total Games</h3>
          <p className="stat-number">{myGames.length}</p>
        </div>
        <div className="stat-card">
          <h3>Total Play Time</h3>
          <p className="stat-number">544 hrs</p>
        </div>
        <div className="stat-card">
          <h3>Games Completed</h3>
          <p className="stat-number">2</p>
        </div>
        <div className="stat-card">
          <h3>Games In Progress</h3>
          <p className="stat-number">2</p>
        </div>
      </div>

      {/* Games Grid */}
      <div className="games-grid">
        {myGames.map((game) => (
          <div key={game.id} className="library-card">
            <div className="game-image">{game.image}</div>
            <h3>{game.title}</h3>
            <p className="status-badge">{game.status}</p>
            <p className="play-time">⏱️ {game.playTime}</p>
            <div className="action-buttons">
              <button className="btn btn-primary">Play</button>
              <button className="btn btn-outline">Sell</button>
            </div>
          </div>
        ))}
      </div>
    </div>
  );
}
