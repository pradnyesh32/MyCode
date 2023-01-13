import axios from 'axios';

class EmployeeService{

    constructor(){
        this.baseurl="http://localhost:4000/";
    }

    getEmployees(){
        return axios.get(this.baseurl);
    }
} 

export default new EmployeeService;