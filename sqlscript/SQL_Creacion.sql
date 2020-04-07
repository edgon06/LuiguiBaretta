Create Database LuiguiBaretta
Go

Use LuiguiBaretta
Go
--///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
--Tablas
Create Table Producto(
	Id_Producto int Primary key not null,
	Codigo varchar(20),
	Referencia varchar(10),
	Descripcion varchar(50),
	Talla varchar(5),
	PrecioVenta float Default 0,
	GrupoPrimavera float Default 0,
	CasaFaska float Default 0,
	Cantidad float Default 0,
	CantidadPaquete float Default 0,
	GrupoPaquete int Default 0
)
Go

INSERT  INTO Producto(Id_producto, Codigo, Referencia, Descripcion, Talla, PrecioVenta, GrupoPrimavera, CasaFaska, Cantidad, CantidadPaquete, GrupoPaquete) VALUES (1,'7451100420015','B-100','BRIEF BLANCO','28',5.5,5.125,5.25,57,0,1),(2,'7451100420022','B-100','BRIEF BLANCO','30',5.5,5.125,5.25,96,0,1),(3,'7451100420039','B-100','BRIEF BLANCO','32',5.5,5.125,5.25,254,0,1),(4,'7451100420046','B-100','BRIEF BLANCO','34',5.5,5.125,5.25,301,0,1),(5,'7451100420053','B-100','BRIEF BLANCO','36',5.5,5.125,5.25,198.5,0,1),(6,'7451100420060','B-100','BRIEF BLANCO','38',5.5,5.125,5.25,100.9,0,1),(7,'7451100420077','B-100','BRIEF BLANCO','40',5.5,5.125,5.25,138.5,0,1),(9,'7451100420107','B-101','BRIEF COLOR','32',5.5,5.125,5.25,74,0,1),(10,'7451100420114','B-101','BRIEF COLOR','34',5.5,5.125,5.25,482,0,1),(11,'7451100420121','B-101','BRIEF COLOR','36',5.5,5.125,5.25,271,0,1),(12,'7451100420138','B-101','BRIEF COLOR','38',5.5,5.125,5.25,175,0,1),(13,'7451100420145','B-101','BRIEF COLOR','40',5.5,5.125,5.25,184,0,1),(14,'7451100420312','C-200','CAMISETA S/M','S',6,5.75,5.75,197,0,1),(15,'7451100420329','C-200','CAMISETA S/M','M',6,5.75,5.75,56,0,1),(16,'7451100420336','C-200','CAMISETA S/M','L',6,5.75,5.75,138,0,1),(17,'7451100420343','C-200','CAMISETA S/M','XL',6,5.75,5.75,101.5,0,1),(18,'7451100420428','T-300','T-SHIRT CUELLO R','S',6.5,6.25,6.25,71,0,1),(19,'7451100420435','T-300','T-SHIRT CUELLO R','M',6.5,6.25,6.25,98,0,1),(20,'7451100420442','T-300','T-SHIRT CUELLO R','L',6.5,6.25,6.25,76,0,1),(21,'7451100420459','T-300','T-SHIRT CUELLO R','XL',6.5,6.25,6.25,61,0,1),(22,'7451100420466','T-301','T-SHIRT CUELLO V','S',6.5,6.25,6.25,17,0,1),(23,'7451100420473','T-301','T-SHIRT CUELLO V','M',6.5,6.25,6.25,56,0,1),(24,'7451100420480','T-301','T-SHIRT CUELLO V','L',6.5,6.25,6.25,57,0,1),(25,'7451100420497','T-301','T-SHIRT CUELLO V','XL',6.5,6.25,6.25,26,0,1),(26,'7451100420572','BK-500','BIKINI BLANCO','S',4.18,4.18,4.18,41,0,1),(27,'7451100420589','BK-500','BIKINI BLANCO','M',4.18,4.18,4.18,122,0,1),(28,'7451100420596','BK-500','BIKINI BLANCO','L',4.18,4.18,4.18,60,0,1),(29,'7451100420602','BK-500','BIKINI BLANCO','XL',4.18,4.18,4.18,50,0,1),(30,'7451100420619','BK-510','BIKINI COLOR','S',4.18,4.18,4.18,9.25,0,1),(31,'7451100420626','BK-510','BIKINI COLOR','M',4.18,4.18,4.18,3.5,0,1),(32,'7451100420633','BK-510','BIKINI COLOR','L',4.18,4.18,4.18,7,0,1),(33,'7451100420640','BK-510','BIKINI COLOR','XL',4.18,4.18,4.18,66.9,0,1),(34,'7451100420657','B-200','POPLIN BLANCO','28',6,5.75,5.75,0,0,1),(35,'7451100420664','B-200','POPLIN BLANCO','30',6,5.75,5.75,15,0,1),(36,'7451100420671','B-200','POPLIN BLANCO','32',6,5.75,5.75,42,0,1),(37,'7451100420688','B-200','POPLIN BLANCO','34',6,5.75,5.75,0,0,1),(38,'7451100420695','B-200','POPLIN BLANCO','36',6,5.75,5.75,17,0,1),(39,'7451100420701','B-200','POPLIN BLANCO','38',6,5.75,5.75,20,0,1),(40,'7451100420718','B-200','POPLIN BLANCO','40',6,5.75,5.75,7,0,1),(41,'7451100420725','BX-700','BOXER ALGODON','S',2.5,2.5,2.5,0,0,12),(42,'7451100420726','BX-700','BOXER ALGODON','M',2.5,2.5,2.5,0,0,12),(43,'7451100420727','BX-700','BOXER ALGODON','L',2.5,2.5,2.5,0,0,12),(44,'7451100420728','BX-700','BOXER ALGODON','XL',2.5,2.5,2.5,0,0,12),(45,'7451100420763','B-201','POPLIN COLOR','28',6,5.75,5.75,20,0,1),(46,'7451100420770','B-201','POPLIN COLOR','30',6,5.75,5.75,40,0,1),(47,'7451100420787','B-201','POPLIN COLOR','32',6,5.75,5.75,48,0,1),(48,'7451100420794','B-201','POPLIN COLOR','34',6,5.75,5.75,77,0,1),(49,'7451100420800','B-201','POPLIN COLOR','36',6,5.75,5.75,185,0,1),(50,'7451100420817','B-201','POPLIN COLOR','38',6,5.75,5.75,101,0,1),(51,'7451100420824','B-201','POPLIN COLOR','40',6,5.75,5.75,69,0,1),(52,'7451100420107','B-101','BRIEF COLOR','30',5.5,5.125,5.25,144,0,1);
Go

Create Table ProveerProducto(
	ID_Recarga int Primary key not null,
	ID_Producto int,
	Cantidad float Default 0,
	Fecha Date
	Foreign key (ID_Producto) references Producto(ID_Producto)
)
Go

INSERT  INTO ProveerProducto(ID_Recarga, Id_Producto, Cantidad, Fecha) VALUES (1,1,1,'2019-09-05'),(2,1,1,'2019-09-05'),(3,1,1,'2019-09-05'),(4,1,0,'2019-09-05'),(5,1,1,'2019-09-06'),(6,1,1,'2019-09-06'),(7,24,2,'2019-09-06'),(8,1,2,'2019-09-06'),(9,1,1,'2019-09-06'),(10,1,2,'2019-09-06');
Go

Create table Cliente(
	ID_Cliente int Primary key not null,
	Almacen Varchar(50),
	Direccion Varchar(50),
	Telefono Varchar(50),
	RUC text,
	Razon_Social text
)
Go

INSERT INTO Cliente(Id_cliente, Almacen, Direccion, Telefono, RUC, Razon_Social) VALUES (1,'SAKS','MEGAMALL','207-3760','2357-1-364165 D.V. 93','GRUPO PRIMAVERA HOLDING S.A'),(2,'OCA LOCA','MEGAMALL','','','INVERSIONES POCAHONTAS S.A'),(3,'PICADILLY','MEGAMALL','830-7589','312291.1.411723 D.V. 07','BEKER S.A'),(4,'EXTRA 24','24 DE DICIEMBRE','295-0323','782153.262316 D.V. 35','SUPERMERCADO XTRA S.A'),(5,'MACHETAZO 24','25 DE DICIEMBRE','291-1612','652.212.129962 D.V. 35','CIA GOLY S.A'),(6,'MACHETAZO','METROMALL','217-7550','652.212.129962 D.V. 35','CIA GOLY S.A'),(7,'El COSTO','COSTA DEL ESTE','304-3633','5837.0093.70420 D.V. 35','KADIMA S.A'),(8,'SAKS','LOS PUEBLOS','217-8604','2357-1-364165 D.V. 93','GRUPO PRIMAVERA HOLDING S.A'),(9,'GRAFITIS','LOS PUEBLOS','217-8413','360199.1.418810 D.V. 31','SILVER MODAS S.A'),(10,'CONWAY','LOS PUEBLOS','217-7400','62137.36.351360 D.V. 54','TARGET SA.A'),(11,'OCA LOCA','LOS PUEBLOS','217-7035, 217-8750','',''),(12,'EXTRA','LOS PUEBLOS','','',''),(13,'CAPITOLIO','PLAZA CAROLINA','233-2000','','ALDA PANAMA S.A'),(14,'DORIANS','LOS ANDES','237-9300','2357-1-364165 D.V. 93','GRUPO PRIMAVERA HOLDING S.A'),(15,'PICADILLY','LOS ANDES','237-6105','',''),(16,'XTRA','OJO DE AGUA','237-9612, 290-9077','',''),(17,'XTRA','GAMBIA','2909022','',''),(18,'SAKS','SAN MIGUELITO','2293850','',''),(19,'MACHETAZO','SAN MIGUELITO','2670566, 2290504','652.212.129962 D.V.35','CIA GLOTY S.A'),(20,'SAKS','EL DORADO','2363249','2357-1-364165 D.V.93','GRUPO PRIMAVERA HOLDING S.A'),(21,'MACHETAZO','CALIDONIA','2273014, 2273154','652.212.129962 D.V.35','CIA GLOTY S.A'),(22,'EL RITMO','CENTRAL','2620468','',''),(23,'EL COSTO','CENTRAL','2620468','',''),(24,'PANTERA ROSA','CENTRAL','2121877','',''),(25,'GRAFITIS','CENTRAL','2120306','',''),(26,'CASA FASKA','CENTRAL','2625311','',''),(27,'SUN WAH','AV.B','2620804','',''),(28,'CIA ASIA','AV.B','2627005','',''),(29,'SAKS','SANTA ANA','2286767','2357-364165 D.V-93','GRUPO PRIMAVERA HOLDING S.A'),(30,'MACHETAZO','SANTA ANA','2287891','572-395-119290 DV 30','EL MACHETAZO S.A'),(31,'EL COSTO','ALBROOK','3146680','',''),(32,'DORIANS','ALBROOK','3146714','2357-1-364165 D.V.93','GRUPO PRIMAERA HOLDING S.A'),(33,'OCA LOCA','ALBROOK','3036051','',''),(34,'CONWAY','ALBROOK','3146714','',''),(35,'SAKS','WESTLAND','2515512','2357-1-364165 D.V.93','GRUPO PRIMAVERA HOLDING S.A'),(36,'CONWAY','WESTLAND','','',''),(37,'XTRA','ARRAIJAN','2909076','',''),(38,'XTRA','VISTA ALEGRE','2909020','',''),(39,'MACHETAZO','HATO MONTA�A','2572057','652.212.129962 D.V.35','CIA GLORY S.A'),(40,'MULTIOFERTA','CHORRERA','2518083','',''),(41,'ECOMODA','CHORRERA','2540735','',''),(42,'EL GOLPE','CHORRERA','2540735','',''),(43,'CAPRICHOS','CHORRERA','2543286, 2541214','',''),(44,'MILLAN','CHORRERA','2543323','',''),(45,'HELLEN','CHORRERA','2540997','',''),(46,'LA NOVEDAD','CHORRERA','2544157','',''),(47,'XTRA','CHORRERA','2445267','',''),(48,'EL PRINCIPE','COLON','4414781','',''),(49,'CELINDA','COLON','4413642','',''),(50,'EL EMPRENDEDOR','COLON','4419392','',''),(51,'MACHETAZO','CORONADO','2402040','652.212.129962 D.V 35','CIA GLORY S.A'),(52,'MACHETAZO','PENONOME','9911070','652.212.129962 D.V 35','CIA GLORY S.A'),(53,'GLAMOUR STORE','PENONOME','9979874','',''),(54,'RUTH FASHION','PENONOME','9978482','',''),(55,'PALESTINA','PENONOME','9979511','',''),(56,'NUEVO FAMOSO','PENONOME','9979894','',''),(57,'EL COLON','PENONOME','9972975','',''),(58,'EL COMBATE','PENONOME','9979822','',''),(59,'FLASH','PENONOME','9910465','',''),(60,'LATINO STORE','PENONOME','9911531','',''),(61,'MUEBLERIA Y REGAL','AGUA DULCE','9974711','',''),(62,'JORDANIA','AGUA DULCE','9976472','',''),(63,'LAS PERLAS','AGUA DULCE','9976472','',''),(64,'LATINO STORE','AGUA DULCE','66790307','',''),(65,'BAYAN STORE','AGUA DULCE','9970177','',''),(66,'MACHETAZO','SANTIAGO','9585340','6.213.129962 D.V.35','CIA GLORY S.A'),(67,'STYLOS','SANTIAGO','9887727','',''),(68,'IMAN PODEROSO','SANTIAGO','9983371','',''),(69,'HANNA','SANTIAGO','9981977','',''),(70,'ALADIN','SANTIAGO','9987622','',''),(71,'PASMA STORE','SANTIAGO','9985063','',''),(72,'SAKS','SANTIAGO','','2357-1-364165 D.V.93','GRUPO PRIMAVERA HOLDING S.A'),(73,'JACKIE','CHIRIQUI','7750212','',''),(74,'RICO BAZAR','CHIRIQUI','2040','',''),(75,'DAISY','CHIRIQUI','7743880','',''),(76,'MACHETAZO','CHITRE','9965634','652.212.129962 D.V.35','CIA GLORY S.A'),(77,'JORDANIA 2','CHITRE','9963584','',''),(78,'HH STORE','CHITRE','9700586','',''),(79,'STATUS','LAS TABLAS','9948113','',''),(80,'ESTEFALAY ZAFIRO','LAS TABLAS','9948878','',''),(81,'EL REGALON','LAS TABLAS','9948658','',''),(82,'DUCASA','LAS TABLAS','9946349','','')
Go

Create Table Venta(
	ID_Venta int IDENTITY(0,1) Primary key not null,
	Cliente int,
	Fecha date,
	Total float Default 0,
	Pago float Default 0
	Foreign key (Cliente) references Cliente(ID_Cliente)
)
Go

Create Table VentaProducto(
	ID_Venta int,
	ID_Producto int,drt+  5  9o
	Cantidad int Default 0
	Foreign key (ID_Producto) references Producto(ID_Producto),
	Foreign key (ID_Venta) references Venta(ID_Venta)
)
Go
--///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
--Procedimientos
create or alter procedure RegistrarCliente
	@Nombre varchar(50),
	@Direccion varchar(50),
	@Telefono varchar(50),
	@RUC varchar(50),
	@Razon_Social text
As
begin
	declare @ID_Cliente int
	set @ID_Cliente = (Select MAX(ID_Cliente) from Cliente) + 1
	Insert into Cliente Values(@ID_Cliente, @Nombre, @Direccion, @Telefono, @RUC, @Razon_Social)
end
Go

create or alter procedure EditarCliente
	@Id_Cliente int,
	@Nombre varchar(50),
	@Direccion varchar(50),
	@Telefono varchar(50),
	@RUC varchar(50),
	@Razon_Social text
As
begin
	Update Cliente set Almacen = @Nombre, Direccion = @Direccion, Telefono = @Telefono, RUC = @RUC, Razon_Social = @Razon_Social where ID_Cliente = @Id_Cliente
end
Go

create or alter procedure RegistrarProducto
	@Codigo varchar(20),
	@Referencia varchar(10),
	@Descripcion varchar(50),
	@Talla varchar(5),
	@PrecioDeVenta float,
	@GrupoPrimavera float,
	@CasaFaska float,
	@Cantidad float,
	@CantidadPaquete float,
	@GrupoPaquete int
As
begin
	declare @ID int
	Set @ID = (Select Max(Id_Producto) from Producto) + 1
	Insert into Producto values(@ID, @Codigo,@Referencia, @Descripcion, @Talla, @PrecioDeVenta, @GrupoPrimavera, @CasaFaska, @Cantidad, @CantidadPaquete, @GrupoPaquete)
end
Go

create or alter procedure EditarProducto
	@ID int,
	@Codigo varchar(50),
	@Referencia varchar(50),
	@Descripcion varchar(50),
	@Talla varchar(50),
	@PrecioDeVenta float,
	@GrupoPrimavera float,
	@CasaFaska float,
	@Cantidad float,
	@CantidadPaquete float,
	@GrupoPaquete int
As
begin
	Update Producto set Codigo = @Codigo, Referencia = @Referencia,Descripcion = @Descripcion, Talla = @Talla, PrecioVenta = @PrecioDeVenta, GrupoPrimavera = @GrupoPrimavera, CasaFaska = @CasaFaska, Cantidad = @Cantidad, CantidadPaquete = @CantidadPaquete, GrupoPaquete = @GrupoPaquete where Id_Producto = @ID
end
Go

create or alter procedure RegistrarVenta
	@Cliente Varchar(50),
	@Direccion Varchar (50),
	@Fecha date,
	@Total float,
	@Pago float
As
begin
	declare @ID_cliente int
	set @ID_cliente = (Select ID_Cliente from Cliente where Almacen = @Cliente and Direccion = @Direccion)
	IF @Total > @Pago
	begin
		Insert into Venta Values(@ID_cliente, @Fecha, @Total, @Pago)
	end
	Else
	begin
		Insert into Venta Values(@ID_cliente, @Fecha, @Total, @Total)
	end
	end
Go

create or alter procedure RegistrarVentaProducto
	@ID_Venta int,
	@Producto varchar(50),
	@Talla varchar(5),
	@Cantidad int
As
Begin
	declare @ID_Producto int
	set @ID_Producto = (Select ID_Producto from Producto where Descripcion like @Producto and Talla like @Talla)
	Insert into VentaProducto Values (@ID_Venta, @ID_Producto, @Cantidad)
End
Go

create or alter procedure pago_opc1
	@Monto float,
	@ID_venta int,
	@Deuda float
	as
	begin
		if @Monto>=@Deuda
			UPDATE venta SET pago = pago + @Deuda WHERE Id_venta = @ID_venta
		else
			UPDATE venta SET pago = pago + @Monto WHERE Id_venta = @ID_venta
	end
go

create or alter procedure pago_opc2
	@Monto float,
	@ID_cliente int
	as
	begin
		declare @Id_venta int,@deuda float
		declare deuda_idventa cursor
		for  SELECT Id_venta, (Total - pago) As Deuda FROM Venta WHERE pago < Total and Cliente=@ID_cliente
		open deuda_idventa
		fetch next from deuda_idventa into 
			@Id_venta,@deuda

		while @@FETCH_STATUS=0
		begin
			if @Monto>=@Deuda
			begin
				UPDATE venta SET pago = pago + @deuda WHERE Id_venta = @Id_venta
				set @Monto=@Monto-@Deuda
			end
			if @Deuda>@Monto
			begin
				UPDATE venta SET pago = pago + @Monto WHERE Id_venta = @Id_venta
				set @Monto=0.0
			end
			fetch next from deuda_idventa into 
				@Id_venta,@deuda
		end
		close deuda_idventa
	end
go


--///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
--Vistas
create or alter view Factura AS
SELECT        TOP (100) PERCENT dbo.Cliente.Direccion, dbo.Cliente.Almacen, dbo.Producto.Descripcion, dbo.Producto.Talla, dbo.VentaProducto.Cantidad, dbo.Venta.Fecha, dbo.Venta.Total, dbo.Venta.Pago, dbo.Producto.PrecioVenta, 
                         dbo.VentaProducto.ID_Producto
FROM            dbo.Cliente INNER JOIN
                         dbo.Venta ON dbo.Cliente.ID_Cliente = dbo.Venta.Cliente INNER JOIN
                         dbo.VentaProducto ON dbo.Venta.ID_Venta = dbo.VentaProducto.ID_Venta INNER JOIN
                         dbo.Producto ON dbo.VentaProducto.ID_Producto = dbo.Producto.Id_Producto
ORDER BY dbo.Venta.ID_Venta DESC
Go

create or alter view VistaVenta As
SELECT        dbo.Venta.ID_Venta, dbo.Cliente.Almacen, dbo.Cliente.Direccion, dbo.Venta.Fecha, dbo.Venta.Total, dbo.Venta.Pago
FROM            dbo.Venta INNER JOIN
                         dbo.Cliente ON dbo.Venta.Cliente = dbo.Cliente.ID_Cliente

--///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
--trigger
Go

--///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
--trigger
Create or alter trigger resta_inventario On VentaProducto after insert as
Begin
	declare @ID_Producto int
	declare @Cantidad int
	set @ID_Producto= (select inserted.Id_Producto from inserted)
	set @Cantidad= (select Inserted.cantidad from inserted)
	Update Producto set Cantidad = Cantidad - @Cantidad where Id_Producto = @ID_Producto
End
--///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
--login/User
USE master
CREATE login SECRETARIA_LOGIN WITH Password ='1234'
CREATE login ADMINISTRADOR_LOGIN WITH Password ='123'
GO
USE LuiguiBaretta
CREATE user Secretaria for Login SECRETARIA_LOGIN
CREATE user Administrador for Login ADMINISTRADOR_LOGIN

GO
Grant select, update,insert, delete to Secretaria
GRANT exec to Secretaria

GRANT select, update,insert, delete on ProveerProducto to Administrador
GRANT select, update,insert, delete on Producto to Administrador

