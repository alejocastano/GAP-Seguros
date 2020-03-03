import { Injectable } from '@angular/core';

Injectable();

export class Constants {
  public API_ROOT = 'https://localhost:5001/api/';
  public API_POLIZAS_CONTROLLER = this.API_ROOT + 'poliza/';
  public API_CLIENTES_CONTROLLER = this.API_ROOT + 'cliente/';
  public API_TIPORIESGO_CONTROLLER = this.API_ROOT + 'tiporiesgo/';
  public API_TIPOCUBRIMIENTO_CONTROLLER = this.API_ROOT + 'tipocubrimiento/';

  public CONTENT_TYPE_JSON = 'application/json';

  constructor() {
  }
}
