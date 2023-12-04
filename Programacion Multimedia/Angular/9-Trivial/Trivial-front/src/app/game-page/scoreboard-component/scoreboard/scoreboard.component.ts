import { Component, Input } from '@angular/core';

@Component({
  selector: 'scoreboardPanel',
  templateUrl: './scoreboard.component.html',
  styleUrls: ['./scoreboard.component.css']
})
export class ScoreboardComponent {
  @Input() scoreboard: any;
  public rightAnswersCount: Number = 0;
  public wrongAnswersCount: Number = 0;

  constructor() {}

  ngOnChanges() {
    if (this.scoreboard) {
      this.rightAnswersCount = this.scoreboard.rightAnswers;
      this.wrongAnswersCount = this.scoreboard.wrongAnswers;
    }
  }
}
