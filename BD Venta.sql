CREATE DATABASE VENTABD;

CREATE TABLE VENTA (
IDVENTA INT IDENTITY (1,1) NOT NULL,
FECHAVENTA DATETIME NOT NULL,
TOTALVENTA MONEY NOT NULL,
PRIMARY KEY (IDVENTA),
);

CREATE TABLE PRODUCTO (
IDPRODUCTO INT IDENTITY (1,1) NOT NULL,
NOMBREPRODUCTO NVARCHAR (50) NOT NULL,
PRECIOUNITARIO MONEY NOT NULL,
PRIMARY KEY (IDPRODUCTO),
);

CREATE TABLE DETALLEVENTA (
IDDETALLEVENTA INT IDENTITY (1,1) NOT NULL,
IDVENTA INT NOT NULL,
IDPRODUCTO INT NOT NULL,
CANTIDAD INT NOT NULL,
PRECIOUNITARIO MONEY NOT NULL,
TOTALDETALLE MONEY NOT NULL,
PRIMARY KEY (IDDETALLEVENTA),
FOREIGN KEY (IDVENTA) REFERENCES VENTA (IDVENTA),
FOREIGN KEY (IDPRODUCTO) REFERENCES PRODUCTO (IDPRODUCTO),
);


insert into venta values ('2022-02-01 14:00:00', 125);
insert into venta values ('2022-03-01 14:00:00', 30);
insert into venta values ('2022-04-01 14:00:00', 30);
insert into venta values ('2022-05-01 14:00:00', 60);

insert into producto values ('Galleta Maria', 20);
insert into producto values ('Coca Cola', 10);
insert into producto values ('Helado Vaquita', 25);
insert into producto values ('Jugo Fresh', 15);

insert into detalleventa values (1 ,1 ,5 , 25, 125);
insert into detalleventa values (2 ,2 ,2 , 15, 30);
insert into detalleventa values (3 ,3 ,1 , 30, 30);
insert into detalleventa values (4 ,4 ,3 , 20, 60);