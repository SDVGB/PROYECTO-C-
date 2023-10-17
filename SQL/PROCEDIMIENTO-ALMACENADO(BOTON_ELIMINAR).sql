use APLICACION
go

create  proc EliminarRequerimiento(@Id int)
as begin
	delete Requerimiento where Id_requerimiento = @Id 
    select	0 as CodigoRet, 
			'El requerimiento ' + convert(varchar(5),@Id ) + ' fue eliminado.' as MensajeRet 
end