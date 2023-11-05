import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { CabeceraComponent } from './cabecera/cabecera.component';
import { PanelComponent } from './panel/panel.component';
import { PrincipalComponent } from './principal/principal.component';
import { DiferenciaFechasPipe } from './tuberias/diferenciaFechas/diferencia-fechas.pipe';

@NgModule({
  declarations: [
    AppComponent,
    CabeceraComponent,
    PanelComponent,
    PrincipalComponent,
    DiferenciaFechasPipe
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
