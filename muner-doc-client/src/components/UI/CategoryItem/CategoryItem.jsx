import React from "react";
import classes from "./CategoryItem.module.css";


const CategoryItem = function({img, title, ...props}){
 return(
	<div className={classes.category}>
					<img src={img} alt="document" />
					<p>{title}</p>
	</div>
 )
}

export default CategoryItem;