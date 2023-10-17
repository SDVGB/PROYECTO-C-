use APLICACION
go

CREATE  proc ModificarRequerimiento(@Id int)
as begin
 
	update Requerimiento set Estado ='R' where Id_requerimiento = @Id
    select	0 as CodigoRet, 
			'El requerimiento ' + convert(varchar(5),@Id ) + ' cambió de estado.' as MensajeRet 
end
