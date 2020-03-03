import { Injectable, Injector } from '@angular/core';
import { BaseService } from './base.service';
import { Poliza } from '../interfaces/poliza.interface';

@Injectable({
  providedIn: 'root'
})
export class PolizasService extends BaseService {
  private apiUrl: string = this.constants.API_POLIZAS_CONTROLLER;
  constructor(private injector: Injector) {
    super(injector);
  }

  getPolizas() {
    return this.http.get(this.apiUrl, { headers: this.headers });
  }

  getPoliza(idPoliza: number) {
    return this.http.get(this.apiUrl + idPoliza, { headers: this.headers });
  }

  postPoliza(poliza: Poliza) {
    return this.http.post(this.apiUrl, poliza, { headers: this.headers });
  }

  putPoliza(poliza: Poliza) {
    return this.http.post(this.apiUrl + poliza.idPoliza, poliza, { headers: this.headers });
  }

  inicializarPoliza() {
    const poliza: Poliza = {
      idPoliza: 0,
      nombre: null,
      inicioVigencia: null,
      periodoCobertura: null,
      precio: null,
      cobertura: null,
      idTipoRiesgo: null,
      IdTipoCubrimiento: null,
    };
    return poliza;
  }

}
