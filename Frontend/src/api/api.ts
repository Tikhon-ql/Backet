import axios from "axios";

const api = axios.create({
    baseURL: "http://localhost:7803/",
});

api.interceptors.request.use(
    config => {
        config.headers['Authorization'] = `Bearer ${localStorage.getItem('accessToken')}`;
        return config;
    },
    error=>{
        console.dir(error);
        console.error();
        return Promise.reject(error);
    }
);

api.interceptors.response.use(
    response => {
        return response;
    },
    error => {
        return Promise.reject(error);
    }
)

export default api;