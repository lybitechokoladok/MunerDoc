import React from "react";
import classes from './ColumnLine.module.css';

const ColumnLine = function (props) {
	return(
		<div className={classes.column}>
      <div className={classes.gitLine}></div>
      <div class={classes.homeCampaingGlowingIcon}>
      	<div className={classes.homeCampaingGlowingIconWrapper}>
					<svg className={classes.oction} viewBox="0 0 24 24" data-view-component="true">
            {props.children}
          </svg>
          <span className={classes.homeCampaingGlowingIconGlow}></span>
        </div>
      </div>
      <div className={classes.gitLine} id={classes.gitLine1}></div>
		</div>
	)
}

export default ColumnLine