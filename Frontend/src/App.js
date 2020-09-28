import React from "react";
import { Route } from "react-router-dom";
import HomePage from "./containers/HomePage";

function App() {
  return <Route component={HomePage} />;
}

export default App;
