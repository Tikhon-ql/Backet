import React from 'react'
import {Grid, Paper, Box, List, ListItemButton, ListItemText, Typography}  from '@mui/material';
import Image from 'mui-image';
import img from './../assets/imgs/aomine.png';
import logo from './../assets/imgs/logo.png';
import api from './../api/api';

const Home: React.FC<{}> = ({}) => {
    api.get("codeasd");
    return (
        <Box sx={{height: "100vh"}}>
            <Grid sx={{height: "100vh"}} container style={{"backgroundColor":"#404040"}}>
                <Grid item xs={6}>
                    <Grid item xs={12}>
                        <List sx={{margin: "100px", backgroundColor:"rgba(0,0,0,.2)"}}>
                            <ListItemButton alignItems='center'>
                                <ListItemText sx={{margin:"auto"}}>
                                    <Typography variant="h2" color={"#AA0000"} textAlign={'center'}>
                                        Top players
                                    </Typography>
                                </ListItemText>
                            </ListItemButton>
                            <ListItemButton>
                                <ListItemText>
                                    <Typography variant="h2" color={"#AA0000"} textAlign={'center'}>
                                        Statistics
                                    </Typography>
                                </ListItemText>
                            </ListItemButton>
                            <ListItemButton>
                                <ListItemText>
                                    <Typography variant="h2" color={"#AA0000"} textAlign={'center'}>
                                        Tutorials
                                    </Typography>
                                </ListItemText>
                            </ListItemButton>
                            <ListItemButton>
                                <ListItemText>
                                    <Typography variant="h2" color={"#AA0000"} textAlign={'center'}>
                                        About us
                                    </Typography>
                                </ListItemText>
                            </ListItemButton>
                            <ListItemButton>
                                <ListItemText>
                                    <Typography variant="h2" color={"#AA0000"} textAlign={'center'}>
                                        Privacy
                                    </Typography>
                                </ListItemText>
                            </ListItemButton>
                        </List>
                    </Grid>
                </Grid>
                <Grid sx={{overflow: "hidden", position: "relative"}} item xs={6}>
                    <Image fit="contain" width={600} height={800} shift="left" src={img} style={{position: "absolute", top: "50px", width: "520px", height: "auto", left: "150px"}}/>
                </Grid>
            </Grid>
        </Box>
    )
}

export default Home 