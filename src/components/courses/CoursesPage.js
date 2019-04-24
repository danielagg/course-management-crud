import React from "react";
import PropTypes from "prop-types";
import { connect } from "react-redux";
import * as courseActions from "../../redux/actions/courseActions";

class CoursesPage extends React.Component {
  state = {
    course: {
      title: ""
    }
  };

  handleChange = event => {
    const course = { ...this.state.course, title: event.target.value };
    this.setState({ course });
  };

  handleSubmit = event => {
    event.preventDefault();
    this.props.dispatch(courseActions.createCourse(this.state.course));
  };

  render() {
    return (
      <>
        <form onSubmit={this.handleSubmit}>
          <h1>Courses</h1>
          <h2>Add course</h2>
          <input
            type="text"
            onChange={this.handleChange}
            value={this.state.course.title}
          />
          <input type="submit" value="Add" />
        </form>
        {this.props.courses.map(course => (
          <p key={course.title}>{course.title}</p>
        ))}
      </>
    );
  }
}

// determines what part of the state do we expose to the component
function mapStateToProps(state, ownProps) {
  return {
    courses: state.courses
  };
}

// determines what actions do we expose to the component
function mapDispatchToProps() {}

CoursesPage.propTypes = {
  dispatch: PropTypes.func.isRequired,
  courses: PropTypes.array.isRequired
};

export default connect(mapStateToProps)(CoursesPage);
