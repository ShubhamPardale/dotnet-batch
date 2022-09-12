function Phones(){
    return( 
    <div >
      <PhoneChild brand="Apple" model="Iphone 13 Pro" os="IOS"/>
      </div>
    );
  }
  function PhoneChild(props){
    return(
       <h2>
        Your Phone brand is "{props.brand}" and model "{props.model}" and with {props.os} operating system.
      </h2>
    );
  }
  
  //ReactDOM.render(<App />, document.getElementById('app'));
  export default Phones;