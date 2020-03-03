import { Injectable } from '@angular/core';

Injectable();

export class Constants {
  public API_ROOT = 'https://localhost:5001/api/';
  public API_POLIZAS_CONTROLLER = this.API_ROOT + 'security/';

  public CONTENT_TYPE_JSON = 'application/json';

  constructor() {
  }
}
