import { Component, OnInit } from '@angular/core';
import { Coordinates } from '../mock-coordinates'

@Component({
  selector: 'app-map',
  templateUrl: './map.component.html',
  styleUrls: ['./map.component.css']
})
export class MapComponent implements OnInit {
  coordinates = Coordinates
  title: string = 'Mapa de eventos';
  lat: number = -17.391848;
  lng: number = -66.256003;
  constructor() { }

  ngOnInit() {
  }

}
