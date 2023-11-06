import {Grid, Paper, Box, List, ListItemButton, ListItemText, Typography, MenuList, MenuItem, Button, Popper, Grow, ClickAwayListener}  from '@mui/material';
import Image from 'mui-image';
import logo from './../assets/imgs/logo.png';
import React from "react";
import {useEffect} from "react"
import {Link} from "react-router-dom"


const Header: React.FC<{}> = ({}) => {
    const [isAuthorized, setIsAuthorized] = React.useState(false);
    useEffect(()=>{
    },[isAuthorized]);

    return <Grid container style={{"backgroundColor":"#404040"}}>
        <Grid item xs = {6}>
            <Box sx={{display:"flex"}}>
                            <Image width={100} fit="cover" src={logo}/>
                            <Typography variant="h4" sx={{marginY:"auto"}} color={"#AA0000"}>Backet</Typography>
            </Box>
        </Grid>
        <Grid item xs = {6}>
            <ul style={{position:"absolute", listStyle:'none', margin:0, padding:0}}>
                {isAuthorized ? <>
                <li style={{right:0}}>
                    <Button variant='outlined' color='error'>Logout</Button>
                </li>
                </> : 
                <>
                <li style={{right:0}}>
                    <Link to="/login">
                        <Button variant='outlined' color='error' onClick={()=>{}}>Login</Button>
                    </Link>
                </li>
                </>}
            </ul>
        </Grid>
    </Grid>
}

export default Header;