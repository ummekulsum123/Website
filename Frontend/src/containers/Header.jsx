import React, { useEffect, useState } from 'react';
import styled from 'styled-components';

import logo from '../assets/logo.svg'
import burger from '../assets/burger.svg'


const Header = () => {
  return (
      <Container>
<div><img src={logo} alt="ИУ-2"/>ИУ-2</div>
          <img src={burger} alt="menu"/>
      </Container>
  )
  };
export default Header;

const Container = styled.div`
  display: flex;
  justify-content: space-between;
  width: 100%;
  height: 80px;
`;

const Burger = styled.div`

`;
