import React, { useEffect, useState } from 'react';
import RoutePath from './RoutePath';
import AppBar from '@material-ui/core/AppBar';
import Tabs from '@material-ui/core/Tabs';
import Tab from '@material-ui/core/Tab';
import { useHistory, useLocation, Route } from    'react-router-dom';
import styled from 'styled-components';
import HomePage from "./containers/HomePage";

function App() {

    return (
      <>
        <Route component={HomePage} />
      </>
    );

}

const Container = styled.div`
  width: 100%;
  height: 100%;
  background-color: #f0f4f7;
  min-height: 100vh;
`;

export default App;
