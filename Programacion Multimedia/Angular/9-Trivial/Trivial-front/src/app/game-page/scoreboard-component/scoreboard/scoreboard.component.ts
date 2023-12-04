import { Component, Input } from '@angular/core';

@Component({
  selector: 'scoreboardPanel',
  templateUrl: './scoreboard.component.html',
  styleUrls: ['./scoreboard.component.css']
})
export class ScoreboardComponent {
  @Input() rightAnswersCount: Number = 0;
  @Input() wrongAnswersCount: Number = 0;

  constructor() {}
}
