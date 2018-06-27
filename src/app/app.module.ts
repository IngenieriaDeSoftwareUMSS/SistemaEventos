import { BrowserModule } from '@angular/platform-browser';
import { NgModule, ApplicationRef } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { MapaComponent } from './componentes/mapa/mapa.component';

import { AgmCoreModule } from '@agm/core';
import { RegistroComponent } from './componentes/usuario/registro/registro.component';
import { CrearEventoComponent } from './componentes/evento/crear-evento/crear-evento.component';
import { EventoService } from './componentes/evento/crear-evento/evento.service';
import { HttpClientModule } from '@angular/common/http';
@NgModule({
  declarations: [
    AppComponent,
    MapaComponent,
    RegistroComponent,
    CrearEventoComponent
  ],
  imports: [
    BrowserModule,
    CommonModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    AgmCoreModule.forRoot({
      apiKey: 'AIzaSyD0O6RTnNKcK0iKfgQxe379q8aqW82IBmo'
    })
  ],
  providers: [EventoService],
  bootstrap: [AppComponent]
})
export class AppModule { }
