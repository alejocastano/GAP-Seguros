import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PolizasComponent } from './polizas/polizas.component';


const routes: Routes = [
  { path: 'polizas', component: PolizasComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
