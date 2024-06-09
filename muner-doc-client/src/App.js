import { BrowserRouter, Route, Routes } from "react-router-dom";
import StartPage from "./pages/StartPage";
import Login from "./pages/Login";
import Registration from "./pages/Registartion";

function App() {
  return (
   <BrowserRouter>
	 	<Routes>
			<Route path="/" element={<StartPage/>}/>
			<Route path="/login" element={<Login/>}/>
			<Route path="/registration" element={<Registration/>}/>
		</Routes>
	 </BrowserRouter>
  );
}

export default App;
