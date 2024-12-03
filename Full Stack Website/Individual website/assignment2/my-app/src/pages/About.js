import React, { useState, useEffect } from "react";
import myPhoto from "../picture/S__78094397.jpg";
import "../styles/aboutstyle.css";
import { motion, AnimatePresence } from 'framer-motion';


const About = () => {
  const [isVisible, setIsVisible] = useState(false);
  useEffect(() => {
    setIsVisible(true); // 当组件挂载时设置为可见
    return () => setIsVisible(false); // 当组件卸载时设置为不可见
  }, []);
  
 

  return (
    // 使用 Fragment 包裹所有內容
    <AnimatePresence>
      {isVisible && (
        <motion.div
          initial={{ opacity: 0 }}
          animate={{ opacity: 1 }}
          exit={{ opacity: 0 }}
          layoutId="about" // 假设你想在页面间有一个共享的元素转换效果
        >
          <div className="about-section">
            <div className="about-content">
              <h1>About Me</h1>              
              <p>
                I'm currently pursuing a Master of IT at QUT, specializing in software
                development. I'm passionate about coding, from web app development to
                programming C, C#, Java.
              </p>
              <p>
                Side projects and work knowledge are what give me a strong skillset to
                bring to the workforce. My internships and graduation essay experience
                have given me a deeper understanding of programming and teamwork. I
                live in Brisbane, Australia where I study master of IT at the
                University of Queensland.
              </p>
              <p>I am always interested in opportunities to expand my experience!</p>
            </div>
            <div className="about-image">
              <img src={myPhoto} alt="photo of me" />
            </div>
          </div>
        </motion.div>
      )}

      
    </AnimatePresence>
  );
};

export default About;