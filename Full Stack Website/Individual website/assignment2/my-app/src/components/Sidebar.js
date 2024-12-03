import React from "react";
import InstagramIcon from '../picture/IG.png'; 
import FacebookIcon from '../picture/Facebook.png'; 
import YoutubeIcon from '../picture/Youtube.png'; 

const Footer = () => {
  return (
    <div class="sidebar">
      <ul class="list-unstyled">
        <li>
          <a href="https://www.instagram.com/me.cpj___898">
            <img src={InstagramIcon} alt="Instagram"/>
          </a>
        </li>
        <li>
          <a href="https://www.facebook.com/qiao.li.338">
            <img src={FacebookIcon} alt="Facebook"/>
          </a>
        </li>
        <li>
          <a href="https://youtube.com/@jessica890831?si=WLABuoP-pA_S3uR0">
            <img src={YoutubeIcon} alt="Youtube"/>
          </a>
        </li>
      </ul>
    </div>
  );
};

export default Footer;
