import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, map } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class QuestionsService {
  private apiUrl: string;
  private currentQuestion: any;
  private scoreboard: any;

  constructor(private http: HttpClient) { 
    this.apiUrl = 'http://localhost:3000/getQuestion';

    this.scoreboard = {
      rightAnswers: 0,
      wrongAnswers: 0
    }
  }

  public getQuestion(): Observable<any> {
    return this.http.get<any>(this.apiUrl).pipe(
      map((response) => {
        this.currentQuestion = response;

        return {
          questionText: response.questionText,
          answers: [response.correctAnswer, ...response.wrongAnswers],
        };
      })
    );
  }

  public checkAnswer(answer: string): Object {
    if (answer === this.currentQuestion.correctAnswer) {
      this.scoreboard.rightAnswers++;
    } else {
      this.scoreboard.wrongAnswers++;
    }

    return this.scoreboard;
  }
}
