import { Component, OnInit } from '@angular/core';
import { Coordinates } from '../../modelos/mock-coordinates';
import { Evento } from '../../modelos/evento';
import { single } from 'rxjs/operators';

@Component({
  selector: 'app-mapa',
  templateUrl: './mapa.component.html',
  styleUrls: ['./mapa.component.css']
})
export class MapaComponent implements OnInit {

  eventos = Coordinates;
  titulo = 'Mapa de Eventos';
  lat = -17.391848;
  lng = -66.256003;
  eventoActual = new Evento();
  constructor() { }

  ngOnInit() {
  }
  modalEvento(evento: Evento) {
    this.eventoActual = evento;
    document.getElementById("openModalButton").click();
  }
}
