import { Component, OnInit } from '@angular/core';
import { Poliza } from '../core/interfaces/poliza.interface';
import { TipoRiesgo, TipoCubrimiento } from '../core/interfaces/maestros.interface';
import { PolizasService } from '../core/services/polizas.service';
import { MaestrosService } from '../core/services/maestros.service';
import Swal from 'sweetalert2';


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
    this.llenarListadoPolizas();
    this.llenarListadoTipoRiesgo();
    this.llenarListadoTipoCubrimiento();
  }

  ngOnInit(): void {
  }


  llenarListadoTipoRiesgo() {
    this.maestrosService.getTipoRiesgo().subscribe((res: TipoRiesgo[]) => {
      this.listaTipoRiesgo = res;
    });
  }

  llenarListadoTipoCubrimiento() {
    this.maestrosService.getTipoCubrimiento().subscribe((res: TipoCubrimiento[]) => {
      this.listaTipoCubrimiento = res;
    });
  }

  llenarListadoPolizas() {
    this.polizaService.getPolizas().subscribe((res: Poliza[]) => {
      this.listadoPolizas = res;
    });
  }


  editarPoliza(poliza: Poliza) {
    this.poliza = { ...poliza };
  }
  eliminarPoliza(idPoliza: number) {
    Swal.fire({
      title: 'Esta seguro de eliminar la poliza?',
      text: "Una vez eliminada esta información no podra ser recuperada!",
      icon: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#3085d6',
      cancelButtonColor: '#d33',
      cancelButtonText: "Cancelar",
      confirmButtonText: 'Si, deseo eliminar la poliza!'
    }).then((result) => {
      if (result.value) {
        this.polizaService.deletePoliza(idPoliza).subscribe(() => {
          this.llenarListadoPolizas();
          this.mensajeExito("Poliza eliminada exitosamente");
        });
      }
    });


  }

  guardarPoliza() {
    this.polizaService.gestionarPoliza(this.poliza).subscribe(() => {
      this.llenarListadoPolizas();
      this.mensajeExito('Registro guardado exitosamente');
      this.poliza = this.polizaService.inicializarPoliza();
    });
  }



  mensajeExito(mensaje: string) {
    Swal.fire({
      title: '',
      text: mensaje,
      icon: 'success'
    });
  }
}


