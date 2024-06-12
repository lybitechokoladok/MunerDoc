import React from "react";
import logo from "../assets/logo.svg";
import notification from "../assets/notification.svg";
import CategoryItem from "./UI/CategoryItem/CategoryItem";
import document from "../assets/document.svg";
import table from "../assets/table.svg";
import logout from "../assets/logout.svg";

const AccountSideBar = function({username}){
	return(
		<div className="sideNavbar">
			<div className="accountSectionWrapper">
				<img src={logo} alt="account logo" />
				<p>{username}</p>
				<img src={notification} alt="notification" />
			</div>
			<hr />
			<div className="categorySectionWrapper">
				<CategoryItem img={document} title="Документы"/>
				<CategoryItem img={table} title="Таблицы"/>
			</div>
			<hr />
			<CategoryItem img={logout} title="Выход"/>
		</div>
	)
}

export default AccountSideBar;