import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { Child2PageRoutingModule } from './child2-routing.module';

import { Child2Page } from './child2.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    Child2PageRoutingModule
  ],
  declarations: [Child2Page]
})
export class Child2PageModule {}
