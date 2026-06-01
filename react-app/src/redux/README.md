/\*\*

- Redux Store Configuration
-
- This folder contains Redux store setup and configuration.
- Use Redux for complex state management across your application.
-
- Structure:
- - store/: Store configuration
- - slices/: Redux slices (actions + reducers)
-
- Example usage:
- import { useDispatch, useSelector } from 'react-redux';
- import { setUser } from '../slices/userSlice';
-
- const dispatch = useDispatch();
- const user = useSelector(state => state.user);
- dispatch(setUser(newUser));
  \*/

// Example Store Setup:
// import { configureStore } from '@reduxjs/toolkit';
// import userReducer from '../slices/userSlice';
//
// export const store = configureStore({
// reducer: {
// user: userReducer,
// },
// });
