import logo from './logo.svg';
import './App.css';
import {store} from "./actions/store";
import {Provider} from "react-redux";
import Employees from './components/Employees';

function App() {
  return (
    <Provider store={store}>
      <Employees/>
    </Provider>
  );
}

export default App;
