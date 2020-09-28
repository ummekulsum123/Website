import React from 'react';
import { Switch, Route, Redirect } from 'react-router-dom';
import HomePage from "./containers/HomePage";

const RoutePath = () => {
  return (
    <>
      <Switch key="main-router">
        <Route path={`/home`} component={HomePage} />
        <Redirect to={`/home`} />
      </Switch>
    </>
  );
};

export default RoutePath;
