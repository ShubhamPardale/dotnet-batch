import React from "react";
import './Phone.css';

class Phones extends React.Component{
    constructor(props){
        super(props);

        this.state={brand:"Apple",model:" Iphone 13 Pro",OS:"ios"};
        
    }
    render(){
        return(

            <div >
                <h2>Your Phone brand is "{this.state.brand}" and model "{this.state.model}" and with {this.state.OS} operating system.</h2>
            </div>

        );
    }
}export default Phones;