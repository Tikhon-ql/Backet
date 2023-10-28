import React from "react"
import { ThemeProvider, Typography, createTheme, Box } from "@mui/material"
import Home from "./components/Home"

const App: React.FC<{}> = ({}) => {

    const theme = createTheme({})
    return (
        <Home />
    )
}

export default App