import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Course } from 'src/classes/course/course';
import { v4 as uuidv4 } from 'uuid';

@Injectable({
  providedIn: 'root'
})
export class CoursesService {
  private _courses: Course[];
  private _subject: BehaviorSubject<any>;

  constructor() {
    this._courses = [];
    this._subject = new BehaviorSubject([]);
  }

  getObservable() {
    return this._subject.asObservable();
  }

  getCourse(id: string) {
    let course = this._courses.find(course => course.id === id);

    if (course) {
      return {
        id: course.id,
        title: course.title,
        points: course.points
      };
    }

    return null;
  }

  addCourse(course: any): void {
    this._courses.push(new Course(uuidv4(), course['title'], course['points']));
    this.subjectNext();
  }

  deleteCourse(id: string): void {
    this._courses = this._courses.filter(course => course.id !== id);
    this.subjectNext();
  }

  subjectNext() {
    this._subject.next(this._courses.map(
      (course) => {
        return {id: course.id, title: course.title, points: course.points};
      }
    ));
  }
}
