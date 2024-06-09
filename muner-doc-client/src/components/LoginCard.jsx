import React from "react";

const LoginCard =() => {
	return(
		<div class="main">
                <div className="cardWrapper">
                    <div className="card">
                        <form action="/signup">
                            <div className="formWrapper">
                                <div className="input">
                                    <div>
                                        <p>Enter your email</p>
                                        <input type="email" className="emailInput"/>
                                    </div>
                                    <div className="formBottom">
                                        <div className="formBottomInput">
                                            <p>Enter your password</p>
                                        <input type="password" className="passwordInput"/>
                                        </div>
                                    </div>
                                </div>
                                <button className="continueInput">Continue</button>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
	)
}

export default LoginCard;