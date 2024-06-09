import React from "react";
import ReviewSection from './ReviewSection';
import AbountProductSection from "./AboutProductSection";
import Footer from "./Footer";

const MainContent = function () {
	return(
		<div className="sections">
			<ReviewSection/>
			<AbountProductSection/>
		</div>
	)
}

export default MainContent