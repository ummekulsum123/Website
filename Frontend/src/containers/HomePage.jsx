import React, { useEffect, useState } from 'react';
import styled from 'styled-components';
import Grid from '@material-ui/core/Grid';
import Button from '@material-ui/core/Button';
import Autocomplete from '@material-ui/lab/Autocomplete';
import TextField from '@material-ui/core/TextField';
import { getDateNow } from '../sources/date';
import Header from '../containers/Header'

const HomePage = () => {
  return (
      <Container>
        <Header />

      </Container>
  )
  };
export default HomePage;

const Container = styled.div`
  display: flex;
  justify-content: space-between;
  
`;

const FilterContainer = styled(Grid)`
  height: 80px;
  align-items: center;
  margin-bottom: 15px;
  padding: 25px 15px;
`;
