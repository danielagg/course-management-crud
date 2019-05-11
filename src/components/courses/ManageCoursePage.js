import React, { useState, useEffect } from "react";
import PropTypes from "prop-types";
import { connect } from "react-redux";
import { loadCourses } from "../../redux/actions/courseActions";

const ManageCoursePage = props => {
  const [course, setCourse] = useState({ title: "" });

  useEffect(() => {
    if (props.courses.length === 0) {
      props.loadCourses().catch(err => {
        console.log("Failed loading courses" + err);
      });
    }
  }, []);

  return (
    <>
      <h2>Manage course</h2>
    </>
  );
};

ManageCoursePage.propTypes = {
  courses: PropTypes.array.isRequired,
  loadCourses: PropTypes.func.isRequired
};

// determines what state is passed down to current component (via props)
const mapStateToProps = state => {
  // request only the bare minimum needed for component
  return { courses: state.courses };
};

// determines what actions are available for the current component
const mapDispatchToProps = {
  loadCourses
};

export default connect(
  mapStateToProps,
  mapDispatchToProps
)(ManageCoursePage);
