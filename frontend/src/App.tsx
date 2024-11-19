import React from 'react';
import logo from './logo.svg';
import './App.scss';
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Home from './Pages/Home/Home'
import Students from './Pages/Students/Students'
import Header from './Header/Header';
import { SearchStudents } from './Pages/SearchStudents/SearchStudents';


function App() {
  return (
    <BrowserRouter>
    <Header/>
      <Routes>
        <Route path='/' element={<Home/>} />
        <Route path='/students' element={<Students/>} />
        <Route path='/students/search' element={<SearchStudents/>} />

      </Routes>
    </BrowserRouter>

  );
}

export default App;
