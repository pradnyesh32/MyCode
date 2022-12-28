import { useEffect,useState } from "react";
import { useLocation ,useHistory} from "react-router-dom";
import EmployeeService from "./EmployeeService";
const EmployeeEdit=()=>{
    let [empob,setempob]=useState({empid:"",ename:"",sal:""});
    let state=useLocation().state;
    let history=useHistory();

    useEffect(()=>{
        setempob({...state.employee})

    },[])
    const updateData=()=>{
        EmployeeService.updateemeployee(empob)
        .then((result)=>{
            console.log(result.data);
            history.push("/list");
        })
        .catch(()=>{})
    }
    const handleChange=(event)=>{
        const {name,value}=event.target;
        setempob({...empob,[name]:value});
    }
    return(
        <div>
 <form>
  <div className="form-group">
    <label htmlFor="empid">Employee Id</label>
    <input type="text" className="form-control" name="empid" id="empid" 
    value={empob.empid}
    onChange={handleChange}
    placeholder="Enter empid"/>
   
  </div>
  <div className="form-group">
    <label htmlFor="ename">Employee Name</label>
    <input type="text" className="form-control" name="ename" id="ename"
     value={empob.ename}
     onChange={handleChange}
     placeholder="Enter name"/>
  </div>
  <div className="form-group">
    <label htmlFor="sal">Employee Salary</label>
    <input type="text" className="form-control" name="sal" id="sal"
     value={empob.sal}
     onChange={handleChange}
     placeholder="Enter Salary"/>
  </div>
  <button type="button" class="btn btn-primary" onClick={updateData}>update Employee</button>
</form>
        </div>
        
    )
}

export default EmployeeEdit;