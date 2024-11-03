import React, {useState, useEffect} from "react";
import {connect} from "react-redux"
import * as actions from "../actions/Employee";

const Employees = (props) => {
    


    return(<div>from Employees</div>);
}
const mapStateToProps = state => {
    return{
        EmployeeList:state.Employee.list
    }
}

const mapActionToProps = {
    fetchAllEmployees: actions.fetchAll
}

export default connect(mapStateToProps)(Employees);