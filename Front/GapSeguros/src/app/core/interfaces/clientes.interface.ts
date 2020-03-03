export interface Cliente
{
		idCliente: number ;
		identificacion: string ;
		nombre: string ;
}

export interface ClientePoliza
{
		idClientePoliza: number ;
		idCliente: number ;
		idPoliza: number ;
		activo: boolean ;
}
