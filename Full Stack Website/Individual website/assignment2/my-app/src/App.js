import React from "react";
import { BrowserRouter, Routes, Route } from "react-router-dom";

import Layout from "./Layout";
import Homepage from "./pages/Homepage";
import About from "./pages/About";
import Resume from "./pages/Resume";
import Detail from "./pages/Detail";
import Protfolio from "./pages/Protfolio";
import "./styles/style.css";


function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Layout />}>
          <Route index element={<Homepage />}></Route>
          <Route path="about" element={<About />}></Route>
          <Route path="resume" element={<Resume />}></Route>
          <Route path="protfolio" element={<Protfolio />}></Route>
          <Route path="detail" element={<Detail />} /> 
        </Route>
      </Routes>
    </BrowserRouter>
  );
}

export default App;
