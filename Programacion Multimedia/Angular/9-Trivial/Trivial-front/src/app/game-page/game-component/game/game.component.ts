import { Component } from '@angular/core';
import { QuestionsService } from 'src/services/questions-service/questions.service';

@Component({
  selector: 'game-page',
  templateUrl: './game.component.html',
  styleUrls: ['./game.component.css']
})
export class GameComponent {
  public question: any;
  public scoreboard: any;

  constructor(private questionsService: QuestionsService) {
    this.scoreboard = {
      rightAnswers: 0,
      wrongAnswers: 0
    }
  }

  ngOnInit() {
    this.getNewQuestion();
  }

  getNewQuestion() {
    this.questionsService.getQuestion().subscribe({
      next: (question) => {
        this.questionsService.getQuestion();
        this.question = question;
      },
      error: (error) => {
        console.error('Error obteniendo la pregunta: ', error);
      },
    });
  }

  checkAnswer(answer: any) {
    this.scoreboard = this.questionsService.checkAnswer(answer);
    this.getNewQuestion();
  }
}