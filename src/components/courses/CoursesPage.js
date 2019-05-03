import React, { useState } from "react";
import PropTypes from "prop-types";
import { connect } from "react-redux";
import * as courseActions from "../../redux/actions/courseActions";
import { bindActionCreators } from "redux";

const CoursesPage = props => {
  const [course, setCourse] = useState({ title: "" });

  const handleChange = event => {
    setCourse({ title: event.target.value });
  };

  const handleSubmit = event => {
    event.preventDefault();

    // action must be wrapped in a dispatch call, cannot call it directly
    // props.dispatch(courseActions.createCourse(course));
    //props.createCourse(course);
    props.actions.createCourse(course);
  };

  return (
    <>
      <form onSubmit={handleSubmit}>
        <h1>Courses</h1>
        <h2>Add course</h2>
        <input type="text" onChange={handleChange} value={course.title} />
        <input type="submit" value="Add" />
      </form>

      {/* Display courses from store */}
      {props.courses.map(course => (
        <div key={course.title}>{course.title}</div>
      ))}
    </>
  );
};

// determines what state is passed down to current component (via props)
const mapStateToProps = state => {
  // request only the bare minimum needed for component
  return { courses: state.courses };
};

CoursesPage.propTypes = {
  courses: PropTypes.array.isRequired,
  //dispatch: PropTypes.func.isRequired
  //createCourse: PropTypes.func.isRequired
  actions: PropTypes.object.isRequired
};

// determines what actions are available for the current component
const mapDispatchToProps = dispatch => {
  return {
    // createCourse: course => dispatch(courseActions.createCourse(course))
    actions: bindActionCreators(courseActions, dispatch)
  };
};

export default connect(
  mapStateToProps,
  mapDispatchToProps
)(CoursesPage);
