import { ACTION_TYPES } from "../actions/Employee";

//export { ACTION_TYPES} from "../actions/Employee";
const initialState = {
    list:[]
}
export const Employee = (state=initialState, action) =>{
    switch(action.type)
    {
        case ACTION_TYPES.FETCH_ALL:
            return{
                ...state,
                list:[...action.payload]
            }
        default:
            return state;
    }
}