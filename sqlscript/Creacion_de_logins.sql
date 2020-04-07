use master
Create login SECRETARIA_LOGIN WITH Password ='1234'
Create login ADMINISTRADOR_LOGIN WITH Password ='123'
Go
Use LuiguiBaretta
Create user Secretaria for Login SECRETARIA_LOGIN
Create user Administrador for Login ADMINISTRADOR_LOGIN

go
Grant select, update,insert, delete to Secretaria
grant exec to Secretaria

GRANT select, update,insert, delete on ProveerProducto to Administrador
GRANT select, update,insert, delete on Producto to Administrador