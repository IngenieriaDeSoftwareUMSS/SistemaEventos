"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var event_1 = require("../../../modelos/event");
var evento_service_1 = require("./evento.service");
var forms_1 = require("@angular/forms");
var CrearEventoComponent = /** @class */ (function () {
    function CrearEventoComponent(eventoSrv, fb) {
        this.eventoSrv = eventoSrv;
        this.fb = fb;
        this.frmGuardarEvento = this.fb.group({
            'nombreE': ['', forms_1.Validators.required],
            'descripcionE': ['', forms_1.Validators.required],
            'direccionE': [''],
            'fechaInicio': ['', forms_1.Validators.required],
            'fechaFin': ['', forms_1.Validators.required],
            'costoE': [''],
            'categoriaE': ['']
        });
    }
    CrearEventoComponent.prototype.ngOnInit = function () {
    };
    CrearEventoComponent.prototype.guardarEvento = function () {
        var frm = this.frmGuardarEvento.value;
        var evento = new event_1.Event();
        evento.nombreEvento = frm.nombreE;
        evento.descripcion = frm.descripcionE;
        evento.direccionEvento = frm.direccionE;
        evento.fechaInicio = frm.fechaInicio;
        evento.fechaFin = frm.fechaFin;
        evento.costoEvento = frm.costoE;
        evento.categoria = frm.categoriaE;
        this.eventoSrv.guardarEvento(evento).then();
    };
    CrearEventoComponent = __decorate([
        core_1.Component({
            selector: 'app-crear-evento',
            templateUrl: './crear-evento.component.html',
            styleUrls: ['./crear-evento.component.css']
        }),
        __metadata("design:paramtypes", [evento_service_1.EventoService, forms_1.FormBuilder])
    ], CrearEventoComponent);
    return CrearEventoComponent;
}());
exports.CrearEventoComponent = CrearEventoComponent;
//# sourceMappingURL=crear-evento.component.js.map