import React from "react";
import classes from './AboutProductSectionCard.module.css'

const AboutProductSectionCard = function ({children, ...props}) {
	return (
		<div className={classes.card}>
			{children}
		</div>
	)
}

export default AboutProductSectionCard