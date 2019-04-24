export default function courseReducer(state = [], action) {
  switch (action.type) {
    case "CREATE_COURSE":
      return [...state, { ...action.course }]; //add a new course to the array, but respect immutability
    default:
      return state;
  }
}
