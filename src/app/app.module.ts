import { BrowserModule } from '@angular/platform-browser';
import { NgModule, ApplicationRef } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { MapaComponent } from './componentes/mapa/mapa.component';

import { AgmCoreModule } from '@agm/core';
import { RegistroComponent } from './componentes/usuario/registro/registro.component';
import { MostraComponent } from './componentes/usuario/mostra/mostra.component';

@NgModule({
  declarations: [
    AppComponent,
    MapaComponent,
    RegistroComponent,
    MostraComponent
  ],
  imports: [
    BrowserModule,
    CommonModule,
    FormsModule,
    AgmCoreModule.forRoot({
      apiKey: 'AIzaSyD0O6RTnNKcK0iKfgQxe379q8aqW82IBmo'
    })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
