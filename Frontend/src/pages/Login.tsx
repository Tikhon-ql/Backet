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

const Login: React.FC<{}> = ()=>{

    const [email,setEmail] = React.useState("");
    const [password,setPassword] = React.useState("");

    function login()
    {
        var requestData = {
            email: email,
            password: password
        };
        api.post("authentication/login",requestData).then(()=>{

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
      <Input id="password" name="password" required placeholder='Password' onChange={(e)=>{setPassword(e.target.value)}}/>
      <Button value={"Login"} onClick={()=>{login()}} color='error' variant="outlined">Login</Button>
      <Link to="/register"><Button color='error' variant="outlined">Register</Button></Link>
    </FormControl>
  </Box>
}

export default Login;