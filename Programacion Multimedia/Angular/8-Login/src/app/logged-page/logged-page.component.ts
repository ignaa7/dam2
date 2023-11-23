import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'logged-page',
  templateUrl: './logged-page.component.html',
  styleUrls: ['./logged-page.component.css']
})
export class LoggedPageComponent {
  username: string = '';
  password: string = '';

  constructor(private route: ActivatedRoute) {
    this.route.queryParams.subscribe(params => {
      this.username = params['username'];
      this.password = params['password'];
    });
  }
}
