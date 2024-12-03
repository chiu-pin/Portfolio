import React, { useState, useEffect } from "react";
import "../styles/timelinestyle.css";

const Resume = () => {
  useEffect(() => {
    let skills = document.querySelectorAll(".skill-level");
    skills.forEach(function(skill) {
      let value = skill.getAttribute("data-value");
      skill.style.width = value + "%";
    });
    const animateSteps = () => {
        const steps = document.querySelectorAll('.timeline-step');
        let delay = 0;
  
        steps.forEach(step => {
          setTimeout(() => {
            step.classList.add('animate');
          }, delay);
          delay += 250; 
        });
      };
      animateSteps();
  }, []);

  
    const [videos, setVideos] = useState([]);
  
    useEffect(() => {
      const fetchVideos = async () => {
        const apiKey = "AIzaSyD_r5NxVsXVtEtEdYMfq0E4Ar7neFCZijo";  // 替换成你的YouTube API密钥
        const playlistId = "PLLMWJSUqOESOPcf7xZ-G1NaIAf2bGfO3f"; // 你的播放列表ID
        const apiUrl = `https://youtube.googleapis.com/youtube/v3/playlistItems?part=snippet&maxResults=15&playlistId=${playlistId}&key=${apiKey}`;
  
        try {
          const response = await fetch(apiUrl);
          if (!response.ok) {
            throw new Error("Failed to fetch videos");
          }
          const data = await response.json();
          setVideos(data.items);  // 假设返回的数据中有 `items` 字段包含视频信息
        } catch (error) {
          console.error("Error:", error);
        }
      };
  
      fetchVideos();
    }, []);  // 依赖数组为空，表示这个 effect 只在组件挂载时运行一次
  

  return(
     <div class="container">                      
      <div class="row text-center justify-content-center mb-5">
          <div class="col-xl-6 col-lg-8">
              <h2 class="font-weight-bold">MY life time</h2>              
              <p class="text-muted">know me quickly throung timeline</p>
          </div>
      </div>

    <div class="row">
        <div class="col">
            <div class="timeline-steps aos-init aos-animate" data-aos="fade-up">
                <div class="timeline-step">
                    <div class="timeline-content" data-toggle="popover" data-trigger="hover" data-placement="top" title="" data-content="And here's some amazing content. It's very engaging. Right?" data-original-title="2004">
                        <div class="inner-circle"></div>
                        <p class="h6 mt-3 mb-1">2000</p>
                        <p class="h6 text-muted mb-0 mb-lg-0">Born</p>
                    </div>
                </div>
                <div class="timeline-step">
                    <div class="timeline-content" data-toggle="popover" data-trigger="hover" data-placement="top" title="" data-content="And here's some amazing content. It's very engaging. Right?" data-original-title="2005">
                        <div class="inner-circle"></div>
                        <p class="h6 mt-3 mb-1">2022.3</p>
                        <p class="h6 text-muted mb-0 mb-lg-0">Intership as progammer</p>
                    </div>
                </div>
                <div class="timeline-step">
                    <div class="timeline-content" data-toggle="popover" data-trigger="hover" data-placement="top" title="" data-content="And here's some amazing content. It's very engaging. Right?" data-original-title="2010">
                        <div class="inner-circle"></div>
                        <p class="h6 mt-3 mb-1">2022.6</p>
                        <p class="h6 text-muted mb-0 mb-lg-0">Gradution form Bachler</p>
                    </div>
                </div>
                <div class="timeline-step mb-0">
                    <div class="timeline-content" data-toggle="popover" data-trigger="hover" data-placement="top" title="" data-content="And here's some amazing content. It's very engaging. Right?" data-original-title="2020">
                        <div class="inner-circle"></div>
                        <p class="h6 mt-3 mb-1">2023</p>
                        <p class="h6 text-muted mb-0 mb-lg-0">Start studying Mater of IT at QUT</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br></br>
    <div class="Bothcontainer">
     
        <div class="skill-container">   
        <h2>Skill</h2>
            <div class="skill-box">
                <span class="title">Java</span>
                <div class="skill-bar">
                    <span class="skill-per html">
                        
                    </span>
                </div>
            </div>
            <div class="skill-box">
                <span class="title">C#</span>
                <div class="skill-bar">
                    <span class="skill-per css">
                        
                    </span>
                </div>
            </div>
            <div class="skill-box">
                <span class="title">C</span>
                <div class="skill-bar">
                    <span class="skill-per javascript">
                        
                    </span>
                </div>
            </div>
            <div class="skill-box">
                <span class="title">JavaScript</span>
                <div class="skill-bar">
                    <span class="skill-per javascript">
                        
                    </span>
                </div>
            </div>
        </div>   
        <div class="skill-container">
            <h2>Personality</h2>
            <div class="skill-box">
                <span class="title">Teamwork</span>
                <div class="skill-bar">
                    <span class="skill-per html">
                        
                    </span>
                </div>
            </div>
            <div class="skill-box">
                <span class="title">Postive</span>
                <div class="skill-bar">
                    <span class="skill-per css">
                     
                    </span>
                </div>
            </div>
            <div class="skill-box">
                <span class="title">Friendly</span>
                <div class="skill-bar">
                    <span class="skill-per css">
                        
                    </span>
                </div>
            </div>
            <div class="skill-box">
                <span class="title">Cautious</span>
                <div class="skill-bar">
                    <span class="skill-per nodejs">
                       
                    </span>
                </div>
            </div>
        </div>   
    </div>
    <div className="language-container">                      
        <div className="row text-center justify-content-center mb-5">
            <div className="col-xl-6 col-lg-8">
            <h2 className="font-weight-bold">Language</h2>
            <div className="video-list">
                {videos.map((video) => (
                <div className="video-item" key={video.id}>
                    <iframe
                    src={`https://www.youtube.com/embed/${video.snippet.resourceId.videoId}`}
                    allowfullscreen
                    title={video.snippet.title}
                    ></iframe>
                    <div className="video-description">
                    <p>{video.snippet.title} - <a href={`https://www.youtube.com/watch?v=${video.snippet.resourceId.videoId}`}>Watch Video</a></p>
                    <p>description: {video.snippet.description}</p>
                    </div>
                </div>
                ))}
            </div>           
            </div>
        </div>
</div>

  </div>
  );
};

export default Resume;
