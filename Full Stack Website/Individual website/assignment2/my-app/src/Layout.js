import { NavLink, Outlet } from "react-router-dom";
import React from "react";
import Footer from "./components/Footer";
import Header from "./components/Header";
import Sidebar from "./components/Sidebar";
import { Helmet } from "react-helmet";

const Layout = () => {
  return (
    <div>
      <Helmet>
        <meta charSet="utf-8" />
        <meta
          name="viewport"
          content="width=device-width, initial-scale=1"
        />
        <title>PinChieh</title>
        <meta name="description" content="PinChieh" />
        <link
          rel="stylesheet"
          href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css "
          integrity="sha384-xOolHFLEh07PJGoPkLv1IbcEPTNtaed2xpHsD9ESMhqIYd0nLMwNLD69Npy4HI+N" crossorigin="anonymous">    
          </link>
      </Helmet>
      <Header />
      <nav>
        <ul>
          <li>
            <NavLink to="/" exact activeClassName="active">
              Homepage
            </NavLink>
          </li>
          <li>
            <NavLink to="/about">About</NavLink>
          </li>
          <li>
            <NavLink to="/resume">Resume</NavLink>
          </li>
          <li>
            <NavLink to="/protfolio">Portfolio</NavLink>
          </li>
        </ul>
      </nav>
      <Sidebar />
      <Outlet />
      <Footer />
    </div>
  );
};

export default Layout;
