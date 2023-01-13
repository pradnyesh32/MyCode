
import './App.css';
import { BrowserRouter,Route, Router, Switch } from 'react-router-dom';

import EmployeeAdd from './components/EmployeeAdd';

function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Switch>
          <Route path="/" component={EmployeeAdd}></Route>
        </Switch>
      </BrowserRouter>
    </div>
  );
}

export default App;
