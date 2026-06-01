# Project Structure Guide

Welcome to the refactored GameVault React project! This document explains the new scalable folder structure.

## Overview

The project has been reorganized into a clean, modular structure that follows best practices for scalability and maintainability.

```
src/
├── assets/              # Images, icons, fonts
├── components/          # Reusable components
│   ├── common/         # Shared components (Header, Footer, etc.)
│   └── UI/             # Presentational UI components (Button, Card, etc.)
├── layout/             # Layout components (Header, Footer, Sidebar)
├── pages/              # Page components (routed pages)
├── features/           # Feature-specific modules
│   └── auth/           # Authentication module (Login, Register)
│   └── dashboard/      # Dashboard module (placeholder)
├── hooks/              # Custom React hooks
├── context/            # React Context for global state
├── redux/              # Redux store configuration
│   ├── store/          # Store setup
│   └── slices/         # Redux slices
├── services/           # API services and external integrations
├── utils/              # Utility functions and constants
│   ├── helpers/        # Helper functions
│   └── constants/      # Application constants
├── styles/             # Global styles
│   ├── index.css       # Main CSS file
│   ├── Global.css      # Global styles and animations
│   ├── Layout.css      # Header/Layout styles
│   └── Pages.css       # Page-specific styles
├── App.tsx             # Main App component
└── main.tsx            # Application entry point
```

## Folder Descriptions

### `/assets`

Contains all static assets including:

- Images
- Icons
- Fonts
- SVG files

**Usage:**

```tsx
import logo from "@/assets/logo.png";
```

### `/components`

Reusable components organized by type:

- **`common/`**: Shared components used across multiple pages
- **`UI/`**: Presentational UI components

### `/layout`

Layout components for app structure:

- `Header.tsx` - Navigation header
- `Footer.tsx` - Footer component
- `Sidebar.tsx` - Sidebar navigation

**Usage:**

```tsx
import { Header } from "@/layout";
```

### `/pages`

Page components that correspond to routes:

- `Home.tsx`
- `BuyGames.tsx`
- `SellGame.tsx`
- `MyLibrary.tsx`
- `Wishlist.tsx`
- `Community.tsx`
- `Deals.tsx`

**Usage in App.tsx:**

```tsx
import Home from "@/pages/Home";
```

### `/features`

Feature-based modules containing all code related to a specific feature:

- **`auth/`**: Authentication (Login, Register, Auth logic)
- **`dashboard/`**: Dashboard feature (placeholder)

Each feature folder should be self-contained with its own components, hooks, and services.

### `/hooks`

Custom React hooks for reusable logic:

- `useAuth.ts` - Authentication hook
- `useFetch.ts` - Data fetching hook
- etc.

**Usage:**

```tsx
import { useAuth } from "@/hooks/useAuth";
```

### `/context`

React Context providers for global state:

- `AuthContext.ts` - Authentication context
- `ThemeContext.ts` - Theme context
- etc.

**Usage:**

```tsx
import { useAuth } from "@/context/AuthContext";
```

### `/redux`

Redux store setup for complex state management:

- **`store/`**: Store configuration and middleware
- **`slices/`**: Redux slices (actions + reducers)

### `/services`

API services and external integrations:

- `api.ts` - Base API configuration
- `gameService.ts` - Games API endpoints
- `userService.ts` - User API endpoints

**Usage:**

```tsx
import { gameService } from "@/services/gameService";
const games = await gameService.getGames();
```

### `/utils`

Utility functions and constants:

- **`helpers/`**: Helper functions (formatPrice, validateEmail, etc.)
- **`constants/`**: Application constants (API URLs, routes, etc.)

**Usage:**

```tsx
import { ROUTES } from "@/utils/constants/appConstants";
import { formatPrice } from "@/utils/helpers/stringHelpers";
```

### `/styles`

Global application styles:

- `index.css` - CSS variables and base styles
- `Global.css` - Button styles, animations, hero sections
- `Layout.css` - Navigation and layout styles
- `Pages.css` - Page-specific component styles

## Import Paths

For cleaner imports, you can use path aliases. Update your `tsconfig.json`:

```json
{
  "compilerOptions": {
    "baseUrl": ".",
    "paths": {
      "@/*": ["src/*"],
      "@/components/*": ["src/components/*"],
      "@/pages/*": ["src/pages/*"],
      "@/utils/*": ["src/utils/*"]
    }
  }
}
```

Then use imports like:

```tsx
import Home from "@/pages/Home";
import { Header } from "@/layout";
import { useAuth } from "@/hooks/useAuth";
```

## Code Examples

### Adding a New Page

1. Create file in `src/pages/About.tsx`
2. Add route in `src/App.tsx`

```tsx
// src/pages/About.tsx
export default function About() {
  return <div>About Page</div>;
}

// src/App.tsx
import About from "@/pages/About";

// In Routes:
<Route path="/about" element={<About />} />;
```

### Adding a Custom Hook

```tsx
// src/hooks/useForm.ts
import { useState } from "react";

export const useForm = (initialValues) => {
  const [values, setValues] = useState(initialValues);

  const handleChange = (e) => {
    setValues({
      ...values,
      [e.target.name]: e.target.value,
    });
  };

  return { values, handleChange };
};

// Usage in component
import { useForm } from "@/hooks/useForm";
```

### Adding a Service

```tsx
// src/services/userService.ts
export const userService = {
  getUser: async (id) => {
    const response = await fetch(`/api/users/${id}`);
    return response.json();
  },
  updateUser: async (id, data) => {
    const response = await fetch(`/api/users/${id}`, {
      method: "PUT",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(data),
    });
    return response.json();
  },
};

// Usage in component
import { userService } from "@/services/userService";
const user = await userService.getUser(userId);
```

## Best Practices

1. **Feature Isolation**: Keep feature code together in `/features`
2. **Reusability**: Extract common logic to `/hooks` or `/utils`
3. **Separation of Concerns**: UI in components, logic in hooks/services
4. **Naming Conventions**:
   - Components: PascalCase (Header.tsx)
   - Hooks: camelCase with 'use' prefix (useAuth.ts)
   - Utils: camelCase (formatPrice, validateEmail)
   - Constants: UPPER_SNAKE_CASE (API_BASE_URL)
5. **Styling**: Keep styles organized by page/component in `/styles`

## Next Steps

1. Install any additional dependencies as needed
2. Set up environment variables in `.env`
3. Configure Redux if needed (install @reduxjs/toolkit, react-redux)
4. Add API service calls
5. Implement authentication logic
6. Add more features following the established structure

## Project Running

```bash
# Install dependencies
npm install

# Start development server
npm run dev

# Build for production
npm run build

# Run linter
npm run lint
```

Happy coding! 🚀
