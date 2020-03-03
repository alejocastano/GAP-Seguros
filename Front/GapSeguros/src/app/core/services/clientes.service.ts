import { Injectable, Injector } from '@angular/core';
import { BaseService } from './base.service';

@Injectable({
  providedIn: 'root'
})
export class ClientesService extends BaseService {
  private apiUrl: string = this.constants.API_CLIENTES_CONTROLLER;
  constructor(private injector: Injector) {
    super(injector);
  }

  getClientes() {
    return this.http.get(this.apiUrl, { headers: this.headers });
  }

  getCliente(idCliente: number) {
    return this.http.get(this.apiUrl + idCliente, { headers: this.headers });
  }


}
