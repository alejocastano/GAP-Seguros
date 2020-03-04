import { Component, OnInit } from '@angular/core';
import { ClientesService } from '../core/services/clientes.service';
import { Cliente, ClientePoliza } from '../core/interfaces/clientes.interface';
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

  AsignarPolizaCliente(data: any) {
    this.clientesService.postClientePoliza(this.clientePoliza).subscribe(()=>{

    });
  }
  inicializarObjetos() {
    this.clientePoliza = this.clientesService.inicializarClientePoliza();
  }

}
