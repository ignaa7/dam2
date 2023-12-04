import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginPageComponent } from './login-page/login-page.component';
import { SignupPageComponent } from './signup-page/signup-page/signup-page.component';
import { GameComponent } from './game-page/game-component/game/game.component';
import { QuestionComponent } from './game-page/question-component/question/question.component';
import { ScoreboardComponent } from './game-page/scoreboard-component/scoreboard/scoreboard.component';
import { QuestionsService } from 'src/services/questions-service/questions.service';
import { AuthService } from 'src/services/auth-service/auth.service';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    LoginPageComponent,
    SignupPageComponent,
    GameComponent,
    QuestionComponent,
    ScoreboardComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [
    QuestionsService,
    AuthService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
