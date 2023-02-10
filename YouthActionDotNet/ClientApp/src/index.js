import React from 'react';
import ReactDOM from "react-dom/client";
import './index.css';
import './styles/main.scss'
import './App.css';
import './styles/appCommon.scss';

import App from './App';
//import reportWebVitals from './reportWebVitals';
import { BrowserRouter } from 'react-router-dom';

const container = document.getElementById("root");

const root = ReactDOM.createRoot(container);

root.render(
<BrowserRouter><App/></BrowserRouter>)

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
//reportWebVitals();
