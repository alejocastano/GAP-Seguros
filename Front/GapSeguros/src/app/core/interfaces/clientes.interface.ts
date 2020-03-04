export interface Cliente {
  idCliente: number;
  identificacion: string;
  nombre: string;
}

export interface ClientePoliza {
  idClientePoliza: number;
  idCliente: number;
  idPoliza: number;
  activo: boolean;
}
export interface PolizasCliente {
  idClientePoliza: number;
  idCliente: number;
  identificacion: string;
  nombre: string;
  idPoliza: number;
  nombrePoliza: string;
  activo: boolean;
}
