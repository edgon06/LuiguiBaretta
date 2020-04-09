USE master
CREATE login SECRETARIA_LOGIN WITH Password ='1234'
CREATE login ADMINISTRADOR_LOGIN WITH Password ='123'
GO
Use LuiguiBaretta
CREATE user Secretaria for LOGIN SECRETARIA_LOGIN
CREATE user Administrador for LOGIN ADMINISTRADOR_LOGIN
GO
GRANT select, update,insert, delete to Secretaria
GRANT exec to Secretaria
GRANT select, update,insert, delete on ProveerProducto to Administrador
GRANT select, update,insert, delete on Producto to Administrador
GO
