CREATE DATABASE CotizacionDb
GO
USE CotizacionDb
GO
CREATE TABLE Cotizacion
(
	ArticulosID int primary key identity,
	FechaVencimiento date,
	Descripcion varchar(max),
	Precio float,
	Existencia float,
	CantidadCotizada float

);