import React from "react";
import logo from '../assets/logo.svg';
import NavButton from "./UI/NavButton/NavButton";
import AuthButton from "./UI/AuthButton/AuthButton";

const Header = function () {
	return (
		<header>
			<div className="navbar">
				<img src={logo} alt="logo" />
				<ul className="navButtonWrapper">
					<NavButton> Главная</NavButton>
					<NavButton> О продукте</NavButton>
				</ul>
				<div className="authWrapper">
					<AuthButton>Вход</AuthButton>
					<AuthButton>Авторизация</AuthButton>
				</div>
			</div>
		</header>
	)
}

export default Header