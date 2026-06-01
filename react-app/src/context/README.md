/\*\*

- React Context API Setup
-
- This folder contains context providers for global state management.
- Use Context API for themes, user authentication, notifications, etc.
-
- Example usage:
- import { useAuth } from './AuthContext';
-
- const { user, setUser } = useAuth();
  \*/

// Example Context Template:
// import React, { createContext, useContext, useState } from 'react';
//
// const AuthContext = createContext();
//
// export const AuthProvider = ({ children }) => {
// const [user, setUser] = useState(null);
//
// return (
// <AuthContext.Provider value={{ user, setUser }}>
// {children}
// </AuthContext.Provider>
// );
// };
//
// export const useAuth = () => useContext(AuthContext);
