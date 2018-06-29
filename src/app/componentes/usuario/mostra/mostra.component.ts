import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-mostra',
  templateUrl: './mostra.component.html',
  styleUrls: ['./mostra.component.css']
})
export class MostraComponent implements OnInit {

  constructor() { }
  public apellido = 'obando';
  public  usuarios = [
    'Jazzmany', 'mauricio' , 'adrian' , 'gustavo'
];
  ngOnInit() {
  }

}
