import React from "react";
import './App.css'
class Car extends React.Component{
    constructor(props){
        super(props);

        this.state={brand:"Ford",model:"Mustang"};
        
    }
    render(){
        return(

            <div className='App-header'>
                <h1>My Car "{this.state.brand}" and model "{this.state.model}"</h1>
            </div>

        );
    }
}export default Car;