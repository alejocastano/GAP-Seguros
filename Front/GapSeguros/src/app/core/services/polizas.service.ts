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


  gestionarPoliza(poliza: Poliza) {
    poliza.idTipoCubrimiento = Number(poliza.idTipoCubrimiento);
    poliza.idTipoRiesgo = Number(poliza.idTipoRiesgo);
    if (poliza.idPoliza > 0) {
      return this.putPoliza(poliza);
    } else {
      return this.postPoliza(poliza);
    }
  }

  postPoliza(poliza: Poliza) {
    return this.http.post(this.apiUrl, JSON.stringify(poliza), { headers: this.headers });
  }

  putPoliza(poliza: Poliza) {
    return this.http.put(this.apiUrl + poliza.idPoliza, poliza, { headers: this.headers });
  }

  deletePoliza(idPoliza: number) {
    return this.http.delete(this.apiUrl + idPoliza, { headers: this.headers });
  }

  inicializarPoliza() {
    const poliza: Poliza = {
      idPoliza: 0,
      nombre: null,
      inicioVigencia: null,
      periodoCobertura: null,
      precio: null,
      cobertura: null,
      idTipoRiesgo: 0,
      idTipoCubrimiento: 0,
    };
    return poliza;
  }

}
