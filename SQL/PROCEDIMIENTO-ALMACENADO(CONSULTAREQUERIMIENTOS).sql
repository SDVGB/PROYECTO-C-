use APLICACION
go
alter proc ConsultarRequerimientos(@NickUsuario  varchar(10),
                                   @estado char(1),
								   @tipoReq int,
								   @tipoPrioridad int)
as begin
   select
   R.Id_requerimiento as 'Id',
   TR.NOMBRE_R AS 'Requerimiento',
			P.NOMBRE_P  AS 'Prioridad',
			R.Descripcion AS 'Descripcion',
			P.plazo AS 'Dias de Plazo',
			U.NICK_U  AS 'Responsable',
			R.ESTADO AS 'Estado'
   from REQUERIMIENTO R
   inner join TIPO_DE_PRIORIDAD P
   ON r.Id_Prioridad = p.Id_Prioridad
   inner join TIPO_DE_REQUERIMIENTO tr
   ON tr.Id_Tipo = r.Id_Tipo
   inner join Usuario u
   ON r.Id_Usuario = u.Id_Usuario
   where U.NICK_U = @NickUsuario
   and R.ESTADO=@estado
   and R.ID_TIPO= @tipoReq
   and R.ID_PRIORIDAD= @tipoPrioridad
end

