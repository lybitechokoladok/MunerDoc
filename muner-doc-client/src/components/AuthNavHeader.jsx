import React, { useState } from "react";
import logo from '../assets/logo.svg';

const AuthNavHeader = ({headerText, navHeaderText, link}) =>{
	return(
		<div className="headerWrapper">
			<img src={logo} alt="logo" />
      <p>{headerText}</p>
      <button>
       <a href={link}>{navHeaderText}</a>
      </button>
		</div>
	)
}
export default AuthNavHeader;