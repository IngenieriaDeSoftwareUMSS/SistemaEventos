"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var evento_service_1 = require("./evento.service");
describe('EventoService', function () {
    beforeEach(function () {
        testing_1.TestBed.configureTestingModule({
            providers: [evento_service_1.EventoService]
        });
    });
    it('should be created', testing_1.inject([evento_service_1.EventoService], function (service) {
        expect(service).toBeTruthy();
    }));
});
//# sourceMappingURL=evento.service.spec.js.map