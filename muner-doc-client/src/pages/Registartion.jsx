import React from "react";
import "../styles/Reg.css";
import AuthNavHeader from "../components/AuthNavHeader";
import RegistrationCard from "../components/RegistrationCard";


const Registration = () => {
	return(
		<div className="appMain">
			<AuthNavHeader headerText="уже есть аккаунт?" navHeaderText="Авторизоваться →" link="/login"/>
			<RegistrationCard/>
		</div>
	)
}

export default Registration;