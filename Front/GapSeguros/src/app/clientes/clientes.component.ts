import { Component, OnInit } from '@angular/core';
import { ClientesService } from '../core/services/clientes.service';
import { Cliente, ClientePoliza, PolizasCliente } from '../core/interfaces/clientes.interface';
import { Poliza } from '../core/interfaces/poliza.interface';
import { PolizasService } from '../core/services/polizas.service';

@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html',
  styleUrls: ['./clientes.component.css']
})
export class ClientesComponent implements OnInit {

  listadoClientes: Cliente[] = [];
  listadoPolizas: Poliza[] = [];
  clientePoliza: ClientePoliza;
  listadoPolizasCliente: PolizasCliente[] = [];

  constructor(private clientesService: ClientesService,
    private polizaService: PolizasService
  ) {
    this.inicializarObjetos();
    this.llenarListadoClientes();
    this.llenarListadoPolizas();

  }

  ngOnInit(): void {
  }

  llenarListadoClientes() {
    this.clientesService.getClientes().subscribe((res: Cliente[]) => {
      this.listadoClientes = res;
    });
  }
  llenarListadoPolizas() {
    this.polizaService.getPolizas().subscribe((res: Poliza[]) => {
      this.listadoPolizas = res;
    });
  }

  asignarPolizaCliente() {
    this.clientesService.postClientePoliza(this.clientePoliza).subscribe(() => {
      this.buscarPolizasCliente(this.clientePoliza.idCliente);
    });
  }

  buscarPolizasCliente(idCliente: number) {
    this.clientePoliza.idCliente = idCliente;
    this.clientesService.getPolizasByCliente(idCliente).subscribe((res: PolizasCliente[]) => {
      this.listadoPolizasCliente = res;
    });
  }

  cambiarEstadoPoliza(cp: PolizasCliente) {
    const polizaActualizar: ClientePoliza = { idClientePoliza: cp.idClientePoliza,
    idCliente: cp.idCliente, idPoliza: cp.idPoliza, activo: !cp.activo };

    this.clientesService.putClientePoliza(polizaActualizar).subscribe(() => {
      this.buscarPolizasCliente(polizaActualizar.idCliente);
    });
  }

  inicializarObjetos() {
    this.clientePoliza = this.clientesService.inicializarClientePoliza();
  }

}
