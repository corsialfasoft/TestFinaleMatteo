create procedure AggiungiGiorno
@Giorno nvarchar(50),
@Orario nvarchar(50)
as
	insert into Giornata values(@Giorno,@Orario,null);
go
exec AggiungiGiorno 'mock', 'mock';

create procedure AggiungiMenu
@Primo nvarchar(50),
@Secondo nvarchar(50),
@Contorno nvarchar(50),
@Dolce nvarchar(50),
@Giorno nvarchar(50),
@Orario nvarchar(50)
as
	insert into Menu values (@Primo,@Secondo,@Contorno,@Dolce);
	declare @corrente int;
	set @corrente = ident_current('Menu');
	update Giornata set FkMenu=@corrente where Giorno=@Giorno and Orario=@Orario;
go

exec AggiungiMenu 'Mock','Mock','Mock','Mock','Mock','Mock'