import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { Constants } from './constants/Constants';
import { ClientesService } from './services/clientes.service';
import { MaestrosService } from './services/maestros.service';
import { PolizasService } from './services/polizas.service';

@NgModule({
  declarations: [],
  imports: [HttpClientModule],
  providers: [Constants, ClientesService, MaestrosService, PolizasService]
})

export class CoreModule { }
