import { useEffect, useState } from "react";
//import { useHistory } from "react-router-dom";
import EmployeeService from "./EmployeeService";

const EmployeeAdd=()=>{
    let [emp,setemp] = useState([]);
    //let history = useHistory();

    useEffect(()=>{
        EmployeeService.getEmployees().then((response)=>{
            setemp(response.data);
        }).catch((err)=>{
            console.log(err);
        });
    },[]);

    // useEffect(()=>{
    //     EmployeeService.getEmployees().
    //     then((responce)=>{
    //         setemp(responce.data);
    //     }).catch((err)=>{
    //         console;err.log(err);
    //     });
    // },[flag]);

    const renderList=()=>{
        return emp.map((e)=>{
            return <tr key={e.loginid}><td>{e.loginid}</td><td>{e.password}</td></tr>
        });
    }

    return (
            <div>
            <table border="2" align="center" >
            <tbody>
                {renderList()}
            </tbody>
            </table>
            </div>
    );


}

export default EmployeeAdd;