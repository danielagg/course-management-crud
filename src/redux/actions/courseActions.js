import * as types from "./actionTypes";
import Axios from "axios";

export function createCourse(course) {
  return { type: types.CREATE_COURSE, course };
}

export function loadCoursesSuccess(courses) {
  return { type: types.LOAD_COURSE_SUCCESS, courses };
}

// todo: move API call to separate responsibilities
export function loadCourses() {
  return async function(dispatch) {
    try {
      const courses = await Axios.get("https://localhost:44371/api/courses");
      dispatch(loadCoursesSuccess(courses.data));
    } catch (err) {
      console.log("Could not fetch course data, " + err);
      throw err; // todo
    }
  };
}
