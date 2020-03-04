import { Injectable, Injector } from '@angular/core';
import { BaseService } from './base.service';
import { Cliente, ClientePoliza } from '../interfaces/clientes.interface';

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

  postClientePoliza(clientePoliza: ClientePoliza) {
    clientePoliza.idPoliza = Number(clientePoliza.idPoliza);
    console.log(clientePoliza);
    return this.http.post(this.apiUrl + 'PostClientePoliza', clientePoliza, { headers: this.headers });
  }

  inicializarCliente() {
    const clientes: Cliente = {
      idCliente: 0,
      identificacion: null,
      nombre: null
    };
    return clientes;
  }

  inicializarClientePoliza() {
    const clientes: ClientePoliza = {
      idClientePoliza: 0,
      idCliente: null,
      idPoliza: null,
      activo: true
    };
    return clientes;
  }

}
