# 🎮 GameVault

A modern game marketplace platform built with React, TypeScript, and Vite. Buy, sell, trade games, and connect with the gaming community!

## 📋 Table of Contents

- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Running the Project](#running-the-project)
- [Building for Production](#building-for-production)
- [Project Structure](#project-structure)
- [Available Pages](#available-pages)
- [Technologies Used](#technologies-used)
- [Troubleshooting](#troubleshooting)

## ✨ Features

- 🛍️ **Buy Games** - Browse and purchase games with filters and search
- 💰 **Sell Games** - List your games for sale with detailed forms
- 📚 **My Library** - Manage your personal game collection
- ❤️ **Wishlist** - Save games you want to buy
- 👥 **Community** - Connect with gamers, forums, and discussions
- 🔥 **Deals & Offers** - Discover exclusive deals and limited-time offers
- 🎨 Modern UI with responsive design
- ⚡ Fast development with Vite and HMR
- 🔒 TypeScript for type safety

## 📦 Prerequisites

Before running the project, make sure you have:

- **Node.js** (v16 or higher) - [Download here](https://nodejs.org/)
- **npm** (comes with Node.js) - Check with `npm --version`

To verify your installation:

```bash
node --version
npm --version
```

## 🚀 Installation

1. **Clone or navigate to the project directory:**

   ```bash
   cd "d:\web engg\react-app"
   ```

2. **Install dependencies:**

   ```bash
   npm install
   ```

   This installs all required packages:
   - React 19.2.4
   - React Router v7.14.0
   - Vite 8.0.4
   - TypeScript
   - ESLint

## ▶️ Running the Project

### Development Server

Start the development server with hot module replacement (HMR):

```bash
npm run dev
```

This will:

- Start the Vite dev server
- Open your default browser (usually at `http://localhost:5173`)
- Enable hot reload - changes save automatically

**Output example:**

```
VITE v8.0.8 ready in 442 ms

Local: http://localhost:5173/
```

Visit `http://localhost:5173` in your browser to see the app running.

### Keyboard Shortcut

You can also use **Ctrl+Shift+B** in VS Code to run the configured dev task.

## 🏗️ Building for Production

Create an optimized production build:

```bash
npm run build
```

This will:

- Compile TypeScript to JavaScript
- Minify and bundle all assets
- Generate optimized build in the `dist/` folder
- Output size: ~150KB (gzipped)

### Preview Production Build

To preview the production build locally:

```bash
npm run preview
```

## 📁 Project Structure

```
react-app/
├── src/
│   ├── components/
│   │   ├── Home.tsx              # Homepage with 6 feature buttons
│   │   ├── BuyGames.tsx          # Game marketplace
│   │   ├── SellGame.tsx          # Seller form
│   │   ├── MyLibrary.tsx         # Personal game collection
│   │   ├── Wishlist.tsx          # Wishlist management
│   │   ├── Community.tsx         # Community hub & forums
│   │   ├── Deals.tsx             # Deals & offers showcase
│   │   ├── Login.tsx             # Login page
│   │   ├── Register.tsx          # Registration page
│   │   └── Auth.css              # Auth styles
│   ├── styles/
│   │   └── Pages.css             # All page styling
│   ├── App.tsx                   # Main app component & routing
│   ├── App.css                   # Global app styling
│   ├── main.tsx                  # React entry point
│   └── index.css                 # Global styles
├── public/                       # Static assets
├── index.html                    # HTML entry point
├── package.json                  # Dependencies & scripts
├── tsconfig.json                 # TypeScript config
├── vite.config.ts               # Vite configuration
├── eslint.config.js             # ESLint rules
└── README.md                     # This file
```

## 📄 Available Pages

| Page           | Route         | Description                        |
| -------------- | ------------- | ---------------------------------- |
| Home           | `/`           | Landing page with feature overview |
| Buy Games      | `/buy-games`  | Browse and purchase games          |
| Sell Game      | `/sell-game`  | List games for sale                |
| My Library     | `/my-library` | Personal game collection           |
| Wishlist       | `/wishlist`   | Saved games to buy                 |
| Community      | `/community`  | Forums and discussions             |
| Deals & Offers | `/deals`      | Limited-time deals                 |
| Login          | `/login`      | User login page                    |
| Register       | `/register`   | User registration page             |

## 💻 Technologies Used

- **React 19.2.4** - UI framework
- **React Router v7.14.0** - Client-side routing
- **TypeScript** - Type-safe JavaScript
- **Vite 8.0.4** - Fast build tool
- **CSS3** - Modern styling with gradients and animations
- **ESLint** - Code quality

## 🐛 Troubleshooting

### Port 5173 Already in Use

If you see "port already in use" error:

```bash
# Kill the process using the port
# On Windows:
netstat -ano | findstr :5173
taskkill /PID <PID> /F

# Or just use a different port:
npm run dev -- --port 3000
```

### Dependencies Not Installing

```bash
# Clear npm cache
npm cache clean --force

# Remove node_modules and package-lock.json
rm -r node_modules package-lock.json

# Reinstall
npm install
```

### TypeScript Errors

```bash
# Rebuild TypeScript
npm run build
```

### Hot Module Replacement (HMR) Not Working

- Hard refresh your browser: **Ctrl+Shift+R** (Chrome) or **Ctrl+F5** (Firefox)
- Check that you're modifying `.tsx` or `.css` files
- Restart the dev server

### Browser Not Opening Automatically

Manually open: http://localhost:5173/

## 📝 Available Scripts

```bash
npm run dev      # Start development server
npm run build    # Build for production
npm run preview  # Preview production build
npm run lint     # Run ESLint checks
```

## 🎯 Next Steps

1. ✅ Run `npm install` to install dependencies
2. ✅ Run `npm run dev` to start the development server
3. ✅ Open http://localhost:5173 in your browser
4. ✅ Explore all 6 feature pages by clicking the buttons
5. ✅ Customize and add backend integration as needed

## 📞 Support

For issues or questions:

- Check the [Vite docs](https://vitejs.dev)
- Check the [React docs](https://react.dev)
- Check the [React Router docs](https://reactrouter.com)

---

**Happy coding! 🚀**
import reactDom from 'eslint-plugin-react-dom'

export default defineConfig([
globalIgnores(['dist']),
{
files: ['**/*.{ts,tsx}'],
extends: [
// Other configs...
// Enable lint rules for React
reactX.configs['recommended-typescript'],
// Enable lint rules for React DOM
reactDom.configs.recommended,
],
languageOptions: {
parserOptions: {
project: ['./tsconfig.node.json', './tsconfig.app.json'],
tsconfigRootDir: import.meta.dirname,
},
// other options...
},
},
])

```

```
