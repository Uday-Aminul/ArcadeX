import { useNavigate } from "react-router-dom";
import "../styles/Pages.css";

export default function Community() {
  const navigate = useNavigate();

  const forums = [
    {
      id: 1,
      title: "General Discussion",
      posts: 1250,
      members: 5420,
      icon: "💬",
    },
    {
      id: 2,
      title: "Buy & Sell",
      posts: 3890,
      members: 8932,
      icon: "💳",
    },
    {
      id: 3,
      title: "Game Recommendations",
      posts: 2150,
      members: 6784,
      icon: "⭐",
    },
    {
      id: 4,
      title: "Trading Hub",
      posts: 1820,
      members: 4521,
      icon: "🔄",
    },
    {
      id: 5,
      title: "Technical Support",
      posts: 945,
      members: 3210,
      icon: "🔧",
    },
    {
      id: 6,
      title: "Events & Tournaments",
      posts: 520,
      members: 2105,
      icon: "🏆",
    },
  ];

  const recentPosts = [
    {
      id: 1,
      title: "Looking for Elden Ring DLC buyers",
      author: "GamerX123",
      replies: 12,
      time: "2 hours ago",
    },
    {
      id: 2,
      title: "Best RPGs under $30?",
      author: "CasualPlayer",
      replies: 45,
      time: "5 hours ago",
    },
    {
      id: 3,
      title: "Selling complete PS5 game collection",
      author: "RetroCollector",
      replies: 28,
      time: "1 day ago",
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
        <h1>👥 Community</h1>
        <p>Connect with gamers worldwide</p>
      </section>

      {/* Community Stats */}
      <div className="community-stats">
        <div className="stat-card">
          <h3>Total Members</h3>
          <p className="stat-number">50,240</p>
        </div>
        <div className="stat-card">
          <h3>Active Discussions</h3>
          <p className="stat-number">12,845</p>
        </div>
        <div className="stat-card">
          <h3>Daily Active Users</h3>
          <p className="stat-number">8,320</p>
        </div>
      </div>

      {/* Forums */}
      <div className="community-section">
        <h2>Forums</h2>
        <div className="forums-grid">
          {forums.map((forum) => (
            <div key={forum.id} className="forum-card">
              <div className="forum-icon">{forum.icon}</div>
              <h3>{forum.title}</h3>
              <p>Posts: {forum.posts}</p>
              <p>Members: {forum.members}</p>
              <button className="btn btn-primary">Visit Forum</button>
            </div>
          ))}
        </div>
      </div>

      {/* Recent Posts */}
      <div className="community-section">
        <h2>Recent Discussions</h2>
        <div className="posts-list">
          {recentPosts.map((post) => (
            <div key={post.id} className="post-item">
              <div className="post-content">
                <h4>{post.title}</h4>
                <p>
                  by <strong>{post.author}</strong> • {post.time}
                </p>
              </div>
              <button className="btn btn-outline">
                View ({post.replies} replies)
              </button>
            </div>
          ))}
        </div>
      </div>

      {/* Create Post Button */}
      <div className="create-post-section">
        <button className="btn btn-primary btn-large">Create New Post</button>
      </div>
    </div>
  );
}
