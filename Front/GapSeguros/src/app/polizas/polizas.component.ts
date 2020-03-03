import { Component, OnInit } from '@angular/core';
import { Poliza } from '../core/interfaces/poliza.interface';
import { TipoRiesgo, TipoCubrimiento } from '../core/interfaces/maestros.interface';
import { PolizasService } from '../core/services/polizas.service';
import { MaestrosService } from '../core/services/maestros.service';

@Component({
  selector: 'app-polizas',
  templateUrl: './polizas.component.html',
  styleUrls: ['./polizas.component.css']
})
export class PolizasComponent implements OnInit {
  listadoPolizas: Poliza[] = [];
  poliza: Poliza;
  listaTipoRiesgo: TipoRiesgo[] = [];
  listaTipoCubrimiento: TipoCubrimiento[] = [];

  constructor(private polizaService: PolizasService,
              private maestrosService: MaestrosService) {
    this.poliza = this.polizaService.inicializarPoliza();
    this.llenarListadoPoliza();
  }

  ngOnInit(): void {
  }


  llenarListadoPoliza() {
    this.maestrosService.getTipoRiesgo().subscribe((res: TipoRiesgo[]) => {
      this.listaTipoRiesgo = res;
    });
  }


  editarPoliza(idPoliza: number) {


  }
  eliminarPoliza(idPoliza: number) { }

  guardarPoliza() {

  }
}


