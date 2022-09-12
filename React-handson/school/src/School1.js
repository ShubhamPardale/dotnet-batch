import React from "react";


class School1 extends React.Component{
    constructor(props){
        super(props);

        this.state={name:"St Joseph High School", location:"Panvel"};
        
    }
    render(){
        return(
            <div>
                <h1>School name is "{this.state.name}" and is located in "{this.state.location}" city.</h1>
            </div>

        );
    }
}export default School1;