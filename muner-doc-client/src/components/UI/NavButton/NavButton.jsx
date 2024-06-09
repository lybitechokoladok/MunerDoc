import React from "react";
import classes from './NavButton.module.css';

const NavButton = function({children, ...props}) {
	return (
		<li className={classes.headerMenuItem}>
		<button {...props} className={classes.headerMenuItemButton}>
				{children}
		</button>
</li>
	)
}

export default NavButton