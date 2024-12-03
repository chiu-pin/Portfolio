import React, { useState, useEffect } from "react";
import { AgGridReact } from "ag-grid-react";
import '../../node_modules/ag-grid-community/styles/ag-grid.css';
import '../../node_modules/ag-grid-community/styles/ag-theme-balham.css';

const Portfolio = () => {
  const [repos, setRepos] = useState([]); // 存储从API获取的所有仓库
  const [searchTerm, setSearchTerm] = useState(''); // 搜索词
  const [filteredRepos, setFilteredRepos] = useState([]); // 过滤后的仓库，用于显示

  useEffect(() => {
    const apiUrl = "https://api.github.com/users/chiu-pin/repos";

    const fetchRepos = async () => {
      try {
        const response = await fetch(apiUrl);
        if (!response.ok) {
          throw new Error("Failed to fetch repositories");
        }
        const data = await response.json();
        setRepos(data);
        setFilteredRepos(data); // 初始时显示所有仓库
      } catch (error) {
        console.error("Error:", error);
      }
    };

    fetchRepos(); 
  }, []); 

  const onCellClicked = (event) => {
    const selectedName = event.data.projectname; 
    window.location.href = `/detail?title=${selectedName}`;
  };

  const handleSearchChange = (event) => {
    setSearchTerm(event.target.value);
  };

  const handleSearch = () => {
    const filteredData = repos.filter(repo =>
      repo.name.toLowerCase().includes(searchTerm.toLowerCase())
    );
    setFilteredRepos(filteredData);
  };

  const rowData = filteredRepos.map(repo => ({
    projectname: repo.name,
    language: repo.language,
    create: repo.created_at
  }));

  const table = {
    columns: [
      { headerName: "Name", field: "projectname" },
      { headerName: "language", field: "language" },
      { headerName: "create", field: "create" },
    ],
    rowData: rowData,
  };

  return (
    <div>
      <div className="tablecontainer">
        <h1>My GitHub Repositories</h1>
        <div classname="searchcontainer">
        <input 
          type="text" 
          placeholder="Search by name..." 
          value={searchTerm} 
          onChange={handleSearchChange}
          style={{ marginBottom: '10px', marginRight: '10px' }}
        /><button onClick={handleSearch} style={{ marginBottom: '10px' }}>Search</button>
        </div>
        <div
          className="ag-theme-balham"
          style={{
            height: "300px",
            width: "600px",
          }}
        >
          <AgGridReact
            columnDefs={table.columns}
            rowData={table.rowData}
            pagination={true}
            onCellClicked={onCellClicked} 
          />
        </div>
      </div>  
    </div>
  );
};

export default Portfolio;