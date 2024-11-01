import React from 'react';
import logo from './logo.svg';
import './App.css';
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Home from './Pages/Home/Home'
import Students from './Pages/Students/Students'


function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path='/' element={<Home/>} />
        <Route path='/' element={<Students/>} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
