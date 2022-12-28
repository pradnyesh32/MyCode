import Header from "./Header";
const addData=()=>{
    // EmployeeService.addEmployee(empob)
    // .then((result)=>{
    //     console.log(result.data);
    //     history.push("/list");
    // })
    // .catch(()=>{})
}   

return(
    <div>
        <h2>TransFlower Faculty Feedback Form</h2>
        
        <form>
            <h4>Center : Transflower Learning Pvt.Ltd. </h4>
  <div className="form-group">
    <label htmlFor="modulename">Module</label>
    <h4>props.modulename</h4>
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
  <button type="button" className="btn btn-primary" onClick={addData}>Add Employee</button>
</form>
    </div>
)

export default feedbackform;