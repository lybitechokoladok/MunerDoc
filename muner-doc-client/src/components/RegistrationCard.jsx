import React from "react";

const RegistrationCard = () =>{
	return(
		<div class="main">
                <div class="card-wrapper">
                    <div class="card">
                        <div class="card-text">
                            <span>
                                Добро пожаловать в MunerDoc!
                                <br/>
                                Давайте Начнем
                            </span>
                        </div>
                        <form action="/signup">
                            <div class="form-wrapper">
                                <div class="inputs">
                                    <div>
                                        <p>Введите Email</p>
                                        <input type="email" class="email-input"/>
                                    </div>
                                    <div class="form-bottom">
                                        <div class="form-bottom-input">
                                            <p>Введите пароль</p>
                                        <input type="password" class="password-input"/>
                                        </div>
                                    </div>
                                </div>
                                <button class="continue-input">Продолжить</button>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
	)
}

export default RegistrationCard;