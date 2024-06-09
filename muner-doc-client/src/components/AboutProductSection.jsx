import React from "react";
import ColumnLine from "./UI/ColumnLine/ColumnLine";
import AboutProductSectionCard from "./UI/AboutProductSectionCard/AboutProductSectionCard";
import simpleCard from '../assets/simpleCard.svg';
import setting from '../assets/setting.svg';
import share from '../assets/share.svg';

const AbountProductSection = function (){
	return(
		<div className="section">
			<ColumnLine>
				<path d="M7.5 1.75C7.5.784 8.284 0 9.25 0h5.5c.966 0 1.75.784 1.75 1.75V4h4.75c.966 0 1.75.784 1.75 1.75v14.5A1.75 1.75 0 0 1 21.25 22H2.75A1.75 1.75 0 0 1 1 20.25V5.75C1 4.784 1.784 4 2.75 4H7.5Zm-5 10.24v8.26c0 .138.112.25.25.25h18.5a.25.25 0 0 0 .25-.25v-8.26A4.235 4.235 0 0 1 18.75 13H5.25a4.235 4.235 0 0 1-2.75-1.01Zm19-3.24v-3a.25.25 0 0 0-.25-.25H2.75a.25.25 0 0 0-.25.25v3a2.75 2.75 0 0 0 2.75 2.75h13.5a2.75 2.75 0 0 0 2.75-2.75Zm-6.5-7a.25.25 0 0 0-.25-.25h-5.5a.25.25 0 0 0-.25.25V4h6Z"></path>
			</ColumnLine>
			<div className="aboutContentWrapper">
				<AboutProductSectionCard>
					<img src={simpleCard} alt="simple card" />
					<h1>Используй как хочется.</h1>
					<p>Используй гибкие инструменты для создания шаблона своей мечты</p>
				</AboutProductSectionCard>
				<AboutProductSectionCard>
					<img src={setting} alt="setting" />
					<h1>Настрой все под себя</h1>
					<p>MunerDoc позволить тебе настраивать практически все что угодно</p>
				</AboutProductSectionCard>
				<AboutProductSectionCard>
					<img src={share} alt="share" />
					<h1>Делись со всеми</h1>
					<p>Публикуй свои шаблоны, получай оценки и комментарии от других пользователей</p>
				</AboutProductSectionCard>
      </div>
		</div>
	)
}

export default AbountProductSection