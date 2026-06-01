/**
 * Application Constants
 *
 * Define all application-wide constants here for easy maintenance.
 * This includes API URLs, feature flags, default values, etc.
 */

export const API_BASE_URL =
  import.meta.env.VITE_API_URL || "http://localhost:3001/api";

export const APP_CONFIG = {
  APP_NAME: "GameVault",
  VERSION: "1.0.0",
  ENVIRONMENT: import.meta.env.MODE,
};

export const ROUTES = {
  HOME: "/",
  LOGIN: "/login",
  REGISTER: "/register",
  BUY_GAMES: "/buy-games",
  SELL_GAME: "/sell-game",
  MY_LIBRARY: "/my-library",
  WISHLIST: "/wishlist",
  COMMUNITY: "/community",
  DEALS: "/deals",
};

export const API_ENDPOINTS = {
  GAMES: "/games",
  USERS: "/users",
  WISHLIST: "/wishlist",
  COMMUNITY: "/community",
};

export const GAME_PLATFORMS = [
  "PC",
  "PlayStation 5",
  "Xbox Series X",
  "Nintendo Switch",
];

export const GAME_CONDITIONS = [
  "Like New",
  "Used - Excellent",
  "Used - Good",
  "Used - Fair",
];

export const GAME_GENRES = [
  "Action",
  "RPG",
  "Strategy",
  "Adventure",
  "Sports",
  "Puzzle",
  "Indie",
];
