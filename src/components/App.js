import React from "react";
import { Route, Switch } from "react-router-dom";
import Header from "./common/Header";
import PageNotFound from "./PageNotFound";
import HomePage from "./home/HomePage";
import AboutPage from "./about/AboutPage";
import CoursesPage from "./courses/CoursesPage";

const App = () => {
  return (
    <div>
      <Header />
      <Switch>
        <Route exact path="/" component={HomePage} />
        <Route path="/about" component={AboutPage} />
        <Route path="/courses" component={CoursesPage} />
        <Route component={PageNotFound} />
      </Switch>
    </div>
  );
};

export default App;
