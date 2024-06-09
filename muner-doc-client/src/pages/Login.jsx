import React from "react";
import AuthNavHeader from "../components/AuthNavHeader";
import '../styles/Login.css';
import LoginCard from "../components/LoginCard";

const Login = () =>{
	return(
		<div className="appMain">
			<AuthNavHeader headerText="новый в MunerDoc?" navHeaderText="Зарегистрироваться →" link="/registration"/>
			<LoginCard/>
		</div>
	)
}

export default Login;