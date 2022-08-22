//import logo from './logo.svg';
import './App.css';
//import ReactDOM from 'react-dom/client';

function App(){
  return( 
  <div className='App-header'>
    <AppChild name="Matt" />
    </div>
  );
}
function AppChild(props){
  return(
     <h1>
      My name is {props.name}
    </h1>
  );
}

//ReactDOM.render(<App />, document.getElementById('app'));
export default App;