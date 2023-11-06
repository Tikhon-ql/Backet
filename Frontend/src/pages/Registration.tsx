import * as React from 'react';
import Box from '@mui/material/Box';
import FilledInput from '@mui/material/FilledInput';
import FormControl from '@mui/material/FormControl';
import FormHelperText from '@mui/material/FormHelperText';
import Input from '@mui/material/Input';
import InputLabel from '@mui/material/InputLabel';
import OutlinedInput from '@mui/material/OutlinedInput';
import Button from '@mui/material/Button';
import api from './../api/api';
import {Link} from 'react-router-dom';

const Registration: React.FC<{}> = ()=>{

    const [email,setEmail] = React.useState("");
    const [password,setPassword] = React.useState("");
    const [passwordConfirmation,setPasswordConfirmation] = React.useState("");

    function register()
    {
        var requestData = {
            email: email,
            password: password,
            passwordConfirmation: passwordConfirmation
        };
        api.post("authentication/registration",requestData).then(()=>{

        });
    }

    return <Box
    component="form"
    sx={{"margin":"0 auto"}}
    noValidate
    autoComplete="off"
  >
    <FormControl variant="standard" sx={{ margin:"0 auto", width: '25ch' }}>
      <Input id="email" name="email" required placeholder='Email' onChange={(e)=>{setEmail(e.target.value)}}/>
      <Input id="password" name="password" type="password" required placeholder='Password' onChange={(e)=>{setPassword(e.target.value)}}/>
      <Input id="password" name="password" type="password" required placeholder='Confirm password' onChange={(e)=>{setPassword(e.target.value)}}/>
      <Button value={"Login"} onClick={()=>{register()}} color='error' variant="outlined">Register</Button>
    </FormControl>
  </Box>
}

export default Registration;