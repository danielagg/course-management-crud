import React from "react";
import { Link } from "react-router-dom";

const HomePage = () => (
  <div>
    <h1>Pluralsight Admin</h1>
    <p>React, Redux and React Router for ultra-responsibe web apps.</p>

    <Link to="about">About Us</Link>
  </div>
);

export default HomePage;
