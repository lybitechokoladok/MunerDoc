import { BrowserRouter, Route, Routes } from "react-router-dom";
import StartPage from "./pages/StartPage";
import Login from "./pages/Login";
import Registration from "./pages/Registartion";
import Documents from "./pages/Documents";

function App() {
  return (
   <BrowserRouter>
	 	<Routes>
			<Route path="/" element={<StartPage/>}/>
			<Route path="/login" element={<Login/>}/>
			<Route path="/registration" element={<Registration/>}/>
			<Route path="/documents" element={<Documents/>}/>
		</Routes>
	 </BrowserRouter>
  );
}

export default App;
