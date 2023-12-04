import { Component, Input } from '@angular/core';

@Component({
  selector: 'scoreboardPanel',
  templateUrl: './scoreboard.component.html',
  styleUrls: ['./scoreboard.component.css']
})
export class ScoreboardComponent {
  // @Input() scoreboard: any;
  @Input() rightAnswersCount: Number = 0;
  @Input() wrongAnswersCount: Number = 0;

  constructor() {}

  // ngOnChanges() {
  //   console.log(this.scoreboard)
  //   if (this.scoreboard) {
  //     this.rightAnswersCount = this.scoreboard.rightAnswers;
  //     this.wrongAnswersCount = this.scoreboard.wrongAnswers;
  //   }
  // }
}
