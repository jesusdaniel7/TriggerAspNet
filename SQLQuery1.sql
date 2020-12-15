create trigger TR_Vehiculos_insert
on Vehiculos
for delete
as 
begin
insert into Historico 
select Chasis, Marca, Modelo, Color, Placa,
Year, FechaRetencion, getDate(), Lugar, Lat, Long, NombreConductor, Cedula, Comentarios
from deleted
end
go