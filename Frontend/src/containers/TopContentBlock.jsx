import React, { useEffect, useState } from "react";
import styled from "styled-components";
import Button from "@material-ui/core/Button";
import vectorForTopHomePage from "../assets/vectorForTopHomePage.svg";

const TopContentBlock = () => {
  return (
    <Container>
      <LeftContainer>
        <Title>Кафедра ИУ-2 ждет тебя</Title>
        <Text>
          Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do
          eiusmod tempor incididunt ut labore et dolore magna aliqua. Lorem
          ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod
          tempor incididunt ut labore et dolore.
        </Text>
        <Button>Подробнее</Button>
      </LeftContainer>
      <RightContainer>
        <img src={vectorForTopHomePage} alt="vector" />
      </RightContainer>
    </Container>
  );
};
export default TopContentBlock;

const Container = styled.div`
  display: flex;
  justify-content: space-between;
  width: 100%;
  height: calc(100vh - 80px);
  box-sizing: border-box;
  align-items: center;
  padding: 16px 170px 0 105px;
`;

const RightContainer = styled.div`
  display: flex;
  width: 50%;
  height: 100%;
  box-sizing: border-box;
`;

const LeftContainer = styled.div`
  display: flex;
  flex-direction: column;
  width: 50%;
  height: 100%;
  box-sizing: border-box;
`;

const Title = styled.span`
  font-family: Lato;
  font-style: normal;
  font-weight: 900;
  font-size: 64px;
  line-height: 77px;
width: 462px;
white-space: pre-wrap;
  color: #000000;
`;

const Text = styled.span`
  font-family: Rubik;
  font-style: normal;
  font-weight: 300;
  font-size: 14px;
  line-height: 17px;
  font-feature-settings: "pnum" on, "lnum" on;
width: 430px;
white-space: pre-wrap;
  color: #000000;
`;
