import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PolizasComponent } from './polizas/polizas.component';
import { ClientesComponent } from './clientes/clientes.component';


const routes: Routes = [
  { path: 'polizas', component: PolizasComponent },
  { path: 'clientes', component: ClientesComponent  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
