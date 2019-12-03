create database facebook
go
use facebook
go

create table persona(
	idpersona int primary key identity(1,1),
	nombre nvarchar(100) not null,
	apellido nvarchar(100) not null,
	correo nvarchar(100) not null,
	contras nvarchar(50) not null,
	dia int not null,
	mes nvarchar(10) not null,
	año int not null,
	sexo bit not null); -- 0 para mujer, 1 para hombre
go

create procedure addPersona
(
	@nombre nvarchar(100),
	@apellido nvarchar(100),
	@correo nvarchar(100),
	@contras nvarchar(50),
	@dia int,
	@mes nvarchar(10),
	@año int,
	@sexo bit,
	@haserror bit out
)
as
begin try
	set @haserror = 0;
	if exists(select top 1 1 from persona where correo = @correo)
	begin
		set @haserror = 1
	end
	else
	begin
		insert into persona
		values
		(@nombre,@apellido,@correo,@contras,@dia,@mes,@año,@sexo)
	end
end try
begin catch
	set @haserror = 1;
end catch
go

create procedure UpdatePerfil
(
	@idpersona int,
	@nombre nvarchar(100),
	@correo nvarchar(100),
	@contras nvarchar(50),
	@haserror bit out
)
as
begin try
	set @haserror = 0;
	if exists(select top 1 1 from persona where correo = @correo)
	begin
		set @haserror = 1
	end
	else
	begin
		update persona
		set 
		nombre = @nombre,
		correo = @correo,
		contras = @contras
		where idpersona = @idpersona
	end
end try
begin catch
	set @haserror = 1;
end catch
go

create table post(
	idpost int primary key identity(1,1),
	idpersona int not null,
	post nvarchar(150) not null,
	urlimg nvarchar(100),
	likes int,
	comentarios int);
go

create procedure Postear
(
	@idpersona int,
	@post nvarchar(150),
	@urlimg nvarchar(100),
	@haserror bit out
)
as
begin try
	set @haserror = 0;
	insert into post values (@idpersona,@post,@urlimg,0,0);
end try
begin catch
	set @haserror = 1;
end catch
go

create table amigos(
	idamigo int not null,
	idpersona int not null);
go

create procedure AddAmigo1
(
	@idamigo int,
	@idpersona int,
	@haserror bit out
)
as
begin try
	set @haserror = 0;
	insert into amigos values(@idamigo,@idpersona)
end try
begin catch
	set @haserror = 1;
end catch
go

create procedure AmigosCount
(
	@idpersona int,
	@haserror bit out
)
as
begin try
	set @haserror = 0;
	select COUNT(*) from amigos where idamigo = @idpersona
end try
begin catch
	set @haserror = 1;
end catch
go
create procedure DeleteAmigo
(
	@idamigo int,
	@idpersona int,
	@haserror bit out
)
as
begin try
	set @haserror = 0;
	delete from amigos where idamigo = @idamigo and idpersona = @idpersona
end try
begin catch
	set @haserror = 1;
end catch
go

create procedure DarLike1
(
	@post nvarchar(150),
	@haserror bit out
)
as
begin try
	set @haserror = 0;
	update post set likes = likes + 1 where post = @post
end try
begin catch
	set @haserror = 1;
end catch
go