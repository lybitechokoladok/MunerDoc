import React from "react";
import Header from './components/Header';
import './styles/App.css';
import MainContent from "./components/MainContent";
import Footer from "./components/Footer";

function App() {
  return (
    <div className="App">
     <Header/>
		 <MainContent/>
		 <Footer/>
    </div>
  );
}

export default App;
