import { Constants } from './../constants/Constants';
import { Injectable, Injector } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})

export class BaseService {
  public http: HttpClient;
  public headers: HttpHeaders;
  public constants: Constants;

    constructor(private inject: Injector ) {
        this.http = inject.get(HttpClient);
        this.constants = inject.get(Constants);
        this.headers = new HttpHeaders({ 'Content-Type': 'application/json;' });
    }
}
