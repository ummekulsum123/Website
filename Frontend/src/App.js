import React from "react";
import { Route } from "react-router-dom";
import styled from "styled-components";
import HomePage from "./containers/HomePage";

function App() {
  return <Route component={HomePage} />;
}

const Container = styled.div`
  width: 100%;
  height: 100%;
  background-color: #f0f4f7;
  min-height: 100vh;
`;

export default App;
