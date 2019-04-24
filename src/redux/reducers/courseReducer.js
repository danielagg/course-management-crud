import * as types from "../actions/actionTypes";

export default function courseReducer(state = [], action) {
  switch (action.type) {
    case types.CREATE_COURSE:
      return [...state, { ...action.course }]; //add a new course to the array, but respect immutability
    default:
      return state;
  }
}
