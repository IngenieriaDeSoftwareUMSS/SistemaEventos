import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { Event } from '../../../modelos/event';


@Injectable()
export class EventoService {
  private headers: HttpHeaders;
  private accesPointUrl = '/api/events';
  constructor( private http: HttpClient) {
    this.headers = new HttpHeaders({'Content-Type': 'application/json'});
   }
  getEventos() {
    return this.http.get(this.accesPointUrl, {headers: this.headers});
  }
  addEvent(evento: Event) {
    return this.http.post(this.accesPointUrl, JSON.stringify(evento), {headers: this.headers}).toPromise();
  }

}
