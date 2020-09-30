import React, { useEffect, useState } from "react";
import styled from "styled-components";
import Header from "../components/Header";
import TopContentBlock from "../containers/TopContentBlock";
import NewsBlock from "../containers/NewsBlock";
import MiddleContentBlock from "../containers/MiddleContentBlock";

const HomePage = () => {
  return (
    <Container>
      <Header />
      <TopContentBlock />
      <NewsBlock />
      <MiddleContentBlock />
    </Container>
  );
};
export default HomePage;

const Container = styled.div`
  display: flex;
  flex-direction: column;
`;
