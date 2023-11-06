import React from "react"
import { ThemeProvider, Typography, createTheme, Box } from "@mui/material"
import Home from "./components/Home"
import Header from "./components/Header"
import Login from "./pages/Login";
import { Routes, Route, Navigate, HashRouter} from 'react-router-dom';
import Registration from "./pages/Registration";

const App: React.FC<{}> = ({}) => {

    const theme = createTheme({})
    return (
        <>
            <HashRouter basename="/">
                <Header/>
                <Routes>
                    <Route path="/" element={<Home/>}/>
                    <Route path="/login" element={<Login/>}/>
                    <Route path="/register" element={<Registration/>}/>
                </Routes>
            </HashRouter>

        </>

    )
}

export default App