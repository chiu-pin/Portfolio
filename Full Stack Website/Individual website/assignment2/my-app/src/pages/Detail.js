import React, { useState, useEffect } from "react";
import { useLocation } from 'react-router-dom';
import "../styles/detailstyle.css";

const  Detail= () => {
    const location = useLocation();
    const params = new URLSearchParams(location.search);
    const title = params.get('title'); // 从 location.search 中获取 URL 参数
    const [repos, setRepos] = useState([]); 

  useEffect(() => {
    const apiUrl = `https://api.github.com/repos/chiu-pin/${title}`;

    const fetchRepos = async () => {
        try {
          const response = await fetch(apiUrl);
          if (!response.ok) {
            throw new Error("Failed to fetch repositories");
          }
          const data = await response.json();
          setRepos(data); 
        } catch (error) {
          console.error("Error:", error);
        }
      };
  
      fetchRepos(); 
    }, []); 
   
 return(
      <div className="parent-container">
        <div className="detail-section">
          <h2>Repository Details</h2>
          <ul>
            <li>Name: {repos.name}</li>
            <li>Description: {repos.description}</li>
            <li>Forks: {repos.forks}</li>
            <li>Open issues: {repos.open_issues}</li>
            <li>Watchers: {repos.watchers}</li>
            <li>Default branch: {repos.default_branch}</li>
            <li>Temp clone token: {repos.temp_clone_token}</li>
            <li>Network count: {repos.network_count}</li>
            <li>Subscribers count: {repos.subscribers_count}</li>
            <li>Watch code: <a href={repos.html_url}>{repos.html_url}</a></li>
          </ul>
        </div>
      </div>
 )
};

export default Detail;