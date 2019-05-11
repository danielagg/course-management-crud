import React, { useState, useEffect } from "react";
import PropTypes from "prop-types";
import { connect } from "react-redux";
import * as courseActions from "../../redux/actions/courseActions";
import { bindActionCreators } from "redux";
import { Link } from "react-router-dom";

const CoursesPage = props => {
  const [course, setCourse] = useState({ title: "" });

  useEffect(() => {
    if (props.courses.length === 0) {
      props.actions.loadCourses().catch(err => {
        console.log("Failed loading courses" + err);
      });
    }
  }, []);

  const handleChange = event => {
    setCourse({ title: event.target.value });
  };

  const handleSubmit = event => {
    event.preventDefault();

    // action must be wrapped in a dispatch call, cannot call it directly
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
        <div key={course.id}>
          <Link to={"/course/" + course.id}>{course.name}</Link>
        </div>
      ))}
    </>
  );
};

CoursesPage.propTypes = {
  courses: PropTypes.array.isRequired,
  actions: PropTypes.object.isRequired
};

// determines what state is passed down to current component (via props)
const mapStateToProps = state => {
  // request only the bare minimum needed for component
  return { courses: state.courses };
};

// determines what actions are available for the current component
const mapDispatchToProps = dispatch => {
  return {
    actions: bindActionCreators(courseActions, dispatch)
  };
};

export default connect(
  mapStateToProps,
  mapDispatchToProps
)(CoursesPage);
