import React from "react";
import classes from './AuthButton.module.css';

const AuthButton = function ({children, ...props}) {
	return (
		<button className={classes.authButton}>
			<a href="#">{children}</a>
		</button>
	)
}

export default AuthButton