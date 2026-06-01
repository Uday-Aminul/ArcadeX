# 📂 Quick Reference - File Structure Guide

## Directory Tree

```
react-app/
│
├── src/
│   ├── assets/                  # Static files (images, icons, fonts)
│   │   └── (add your files here)
│   │
│   ├── components/              # Reusable components
│   │   ├── common/             # Shared across app
│   │   │   └── README.md
│   │   └── UI/                 # Presentational components
│   │       └── README.md
│   │
│   ├── layout/                 # Layout wrappers
│   │   ├── Header.tsx          # 🆕 Navigation header
│   │   ├── index.ts
│   │   └── (add Footer, Sidebar here)
│   │
│   ├── pages/                  # Routed pages (full pages)
│   │   ├── Home.tsx            # 🔄 Homepage
│   │   ├── BuyGames.tsx        # 🔄 Buy games page
│   │   ├── SellGame.tsx        # 🔄 Sell game page
│   │   ├── MyLibrary.tsx       # 🔄 User library
│   │   ├── Wishlist.tsx        # 🔄 Wishlist page
│   │   ├── Community.tsx       # 🔄 Community page
│   │   ├── Deals.tsx           # 🔄 Deals page
│   │   └── index.ts
│   │
│   ├── features/               # Feature modules
│   │   ├── auth/              # Authentication feature
│   │   │   ├── Login.tsx       # 🔄 Login component
│   │   │   ├── Register.tsx    # 🔄 Register component
│   │   │   ├── Auth.css        # 🔄 Auth styles
│   │   │   └── index.ts
│   │   │
│   │   └── dashboard/         # Dashboard feature (placeholder)
│   │       └── (add components here)
│   │
│   ├── hooks/                 # Custom React hooks
│   │   ├── README.md
│   │   └── (add useAuth.ts, useFetch.ts, etc.)
│   │
│   ├── context/               # React Context API
│   │   ├── README.md
│   │   └── (add AuthContext.ts, ThemeContext.ts, etc.)
│   │
│   ├── redux/                 # Redux state management
│   │   ├── README.md
│   │   ├── store/            # Store configuration
│   │   │   └── (add store.ts)
│   │   └── slices/           # Redux slices
│   │       └── (add userSlice.ts, gameSlice.ts, etc.)
│   │
│   ├── services/              # API services
│   │   ├── README.md
│   │   └── (add gameService.ts, userService.ts, etc.)
│   │
│   ├── utils/                 # Utilities & helpers
│   │   ├── README.md
│   │   ├── helpers/          # Helper functions
│   │   │   └── stringHelpers.ts  # 🆕 Utility functions
│   │   └── constants/        # Constants
│   │       └── appConstants.ts   # 🆕 App constants
│   │
│   ├── styles/               # Global styles
│   │   ├── index.css         # Main entry
│   │   ├── Global.css        # 🆕 Buttons, animations
│   │   ├── Layout.css        # 🆕 Header/navbar
│   │   └── Pages.css         # All page styles
│   │
│   ├── App.tsx               # 🔄 Main app (updated imports)
│   ├── App.css               # Old file (can delete)
│   ├── main.tsx              # Entry point
│   └── index.css             # 🔄 Global CSS setup
│
├── public/                   # Public assets
│   └── vite.svg
│
├── dist/                     # Build output (created after npm run build)
│
├── package.json              # Dependencies & scripts
├── tsconfig.json             # TypeScript config
├── vite.config.ts            # Vite config
├── eslint.config.js          # Linting rules
│
├── PROJECT_STRUCTURE.md      # 🆕 Detailed guide
├── REFACTORING_SUMMARY.md    # 🆕 What was done
├── COMPLETION_CHECKLIST.md   # 🆕 Completion status
├── README.md                 # Project info
└── QUICKSTART.md             # Quick start guide

Legend:
🆕 = Newly created
🔄 = Moved/Updated
```

## Quick Navigation

### To Find...

| What             | Where                                 |
| ---------------- | ------------------------------------- |
| Home page        | `src/pages/Home.tsx`                  |
| Login page       | `src/features/auth/Login.tsx`         |
| Navigation bar   | `src/layout/Header.tsx`               |
| Button styles    | `src/styles/Global.css`               |
| Page styles      | `src/styles/Pages.css`                |
| App routes       | `src/App.tsx`                         |
| Constants        | `src/utils/constants/appConstants.ts` |
| Helper functions | `src/utils/helpers/stringHelpers.ts`  |
| Custom hooks     | `src/hooks/`                          |
| API services     | `src/services/`                       |

## Common Tasks

### Add a New Page

1. Create `src/pages/YourPage.tsx`
2. Add to `src/App.tsx` routes
3. Import styles from `../styles/`

```tsx
// src/pages/YourPage.tsx
import "../styles/Pages.css";
import "../styles/Layout.css";

export default function YourPage() {
  return <div>Your Page</div>;
}
```

### Add a Custom Hook

1. Create `src/hooks/useYourHook.ts`
2. Export from `src/hooks/index.ts` (optional)

```tsx
// src/hooks/useYourHook.ts
import { useState } from "react";

export const useYourHook = () => {
  const [state, setState] = useState(null);
  return { state, setState };
};
```

### Add an API Service

1. Create `src/services/yourService.ts`

```tsx
// src/services/yourService.ts
export const yourService = {
  getData: async () => {
    const response = await fetch("/api/endpoint");
    return response.json();
  },
};
```

### Add a Utility Function

Add to `src/utils/helpers/stringHelpers.ts` or create new file.

### Add a Feature

1. Create `src/features/yourFeature/`
2. Add components inside
3. Create `index.ts` for exports

## Import Examples

### Pages

```tsx
import Home from "@/pages/Home";
// or
import { Home } from "@/pages";
```

### Auth Components

```tsx
import { Login, Register } from "@/features/auth";
```

### Layout

```tsx
import { Header } from "@/layout";
```

### Utilities

```tsx
import { ROUTES } from "@/utils/constants/appConstants";
import { formatPrice } from "@/utils/helpers/stringHelpers";
```

### Styles

```tsx
import "../styles/Pages.css";
import "../styles/Layout.css";
```

## NPM Scripts

```bash
npm run dev      # Start dev server (http://localhost:5173)
npm run build    # Build for production
npm run lint     # Run ESLint
npm run preview  # Preview built app
```

## File Size Summary

- TypeScript Components: 9 files
- CSS Files: 4 files
- Utility Files: 3 files
- Documentation: 10 files
- Total Source Files: ~30 files

## Style Organization

### Global Styles

- **index.css**: CSS variables, base styles
- **Global.css**: Buttons, animations, hero sections
- **Layout.css**: Navigation bar, header styles
- **Pages.css**: Page component styles (cards, grids, forms)

## TypeScript Configuration

All components use TypeScript for type safety.

- React components: `.tsx` files
- Pure utilities: `.ts` files

## Key Features Implemented

✅ 7 page components
✅ 2 authentication components
✅ Reusable header layout
✅ Global CSS variables
✅ Utility functions (8 helpers)
✅ App constants
✅ Modular folder structure
✅ TypeScript support
✅ Clean imports with index exports

## Next Enhancements

- Add Redux (install @reduxjs/toolkit)
- Add custom hooks (useAuth, useFetch, etc.)
- Add API services (gameService, userService, etc.)
- Add more features in `/features` folder
- Add tests in `__tests__` folders

---

**Status**: ✅ Production Ready
**Last Updated**: 2026-05-02
