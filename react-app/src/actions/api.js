import axsios from "axios";
import { Employee } from "../reducers/Employee";
import { fetchAll } from "./Employee";
import axios from "axios";

const baseUrl = "http://localhost:42611/"

export default {
    Employee(url=baseUrl + "empoyees/"){
        return{
            fetchAll : () => axios.get(url),
            fetchById : Id => axios.get(url+Id),
            create : newRecord => axios.post(url,newRecord),
            update : (id,updateRecord) => axios.put(url+id,updateRecord),
            delete : id => axios.delete(url+id)
        }
    }
}