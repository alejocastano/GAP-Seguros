import { Injectable, Injector } from '@angular/core';
import { BaseService } from './base.service';

@Injectable({
  providedIn: 'root'
})
export class MaestrosService extends BaseService {
  private apiUrlRiesgos: string = this.constants.API_TIPORIESGO_CONTROLLER;
  private apiUrlCubrimientos: string = this.constants.API_TIPOCUBRIMIENTO_CONTROLLER;

  constructor(private injector: Injector) {
    super(injector);
  }

  getTipoRiesgo() {
    return this.http.get(this.apiUrlRiesgos, { headers: this.headers });
  }

  getTipoCubrimiento() {
    return this.http.get(this.apiUrlCubrimientos, { headers: this.headers });
  }


}
