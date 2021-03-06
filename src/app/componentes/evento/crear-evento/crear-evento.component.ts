import { Component, OnInit } from '@angular/core';
import { Event } from '../../../modelos/event';
import { EventoService } from './evento.service';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
@Component({
  selector: 'app-crear-evento',
  templateUrl: './crear-evento.component.html',
  styleUrls: ['./crear-evento.component.css']
})
export class CrearEventoComponent implements OnInit {
  public eventsData: Array<any>;
  public currentEvent: any;
  frmGuardarEvento: FormGroup;
  constructor( private eventoSrv: EventoService, private fb: FormBuilder ) {
    this.frmGuardarEvento = this.fb.group({
      'nombreE': ['Nombre', Validators.required],
      'descripcionE': ['Descripción', Validators.required],
      'direccionE': ['Dirección'],
      'fechaInicio': ['2018-06-07T03:44:00-04:00', Validators.required],
      'fechaFin': ['2018-06-07T03:44:00-04:00', Validators.required],
      'costoE': ['0'],
      'categoriaE': ['Categoría']
    });
    eventoSrv.getEventos().subscribe((data: any) => this.eventsData = data);
  }
  ngOnInit() {
  }
  guardarEvento() {
     const frm = this.frmGuardarEvento.value;
     const evento: Event = new Event();
     evento.nombreEvento = frm.nombreE;
     evento.descripcion = frm.descripcionE;
     evento.direccionEvento = frm.direccionE;
     evento.fechaInicio = frm.fechaInicio;
     evento.fechaFin = frm.fechaFin;
     evento.costoEvento = frm.costoE;
     evento.categoria = frm.categoriaE;
     // console.log(evento);
     this.eventoSrv.addEvent(evento).then();
  }
}
