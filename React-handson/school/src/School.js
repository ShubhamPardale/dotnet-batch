function School(){
    return( 
    <div >
      <SchoolChild name="St Joseph High School"  location="Panvel" />
      </div>
    );
  }
  function SchoolChild(props){
    return(
       <h1>
        School name is "{props.name}" and is located in "{props.location}" city.
      </h1>
    );
  }
  
  export default School;