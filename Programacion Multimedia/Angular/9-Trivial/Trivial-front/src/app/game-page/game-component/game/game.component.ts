import { Component } from '@angular/core';
import { Subscription } from 'rxjs';
import { QuestionsService } from 'src/services/questions-service/questions.service';

@Component({
  selector: 'game-page',
  templateUrl: './game.component.html',
  styleUrls: ['./game.component.css']
})
export class GameComponent {
  public question: any;
  public scoreboard: any;
  private questionSubscription: Subscription | undefined;

  constructor(private questionsService: QuestionsService) {
    this.scoreboard = {
      rightAnswers: 0,
      wrongAnswers: 0
    }
  }

  ngOnInit() {
    this.questionSubscription = this.questionsService.getQuestion().subscribe({
      next: (question) => {
        this.question = question;
      },
      error: (error) => {
        console.error('Error obteniendo la pregunta: ', error);
      },
    });

    this.getNewQuestion();
  }

  getNewQuestion() {
    this.questionsService.getQuestion();
  }

  ngOnDestroy() {
    if (this.questionSubscription) {
      this.questionSubscription.unsubscribe();
    }
  }

  checkAnswer(answer: any) {
    this.scoreboard = this.questionsService.checkAnswer(answer);
  }
}