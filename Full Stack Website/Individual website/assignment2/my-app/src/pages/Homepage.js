import React from "react";
import { motion } from "framer-motion";
import "../styles/homepagestyle.css";

const Homapage = () => {
  return (
    <body class="homepage">
      <div class="container w-100">
        <div class="homepagecontainer">
        <motion.div whileHover={{ scale: 1.1 }} whileTap={{ scale: 0.9 }}>
          <h1>Hi,I am Pinchieh Chiu</h1>
          <h4>Welcome to my Website</h4>
          <h4>Quickly to click the navbar to know the detail of me</h4>
          </motion.div>
        </div>
      </div>
    </body>
  );
};

export default Homapage;
