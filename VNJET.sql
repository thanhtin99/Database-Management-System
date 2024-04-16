CREATE DATABASE VNJET
GO 

USE VNJET
GO

-- Tạo table
CREATE TABLE Customers(
	idCus CHAR(10) CONSTRAINT PK_idCus PRIMARY KEY,
	nameCus NVARCHAR(50) NOT NULL,
	identitycardCus VARCHAR(12) NOT NULL,
	phoneCus VARCHAR(10) NOT NULL
)
GO

CREATE TABLE Staffs(
	idStaffs CHAR(10) CONSTRAINT PK_idStaffs PRIMARY KEY,
	nameStaffs NVARCHAR(50) NOT NULL,
	addressStaffs NVARCHAR(50) NOT NULL,
	phoneStaffs VARCHAR(10) NOT NULL
)
GO

CREATE TABLE Accounts(
	userAcc CHAR(100) CONSTRAINT PK_userAcc PRIMARY KEY,
	passAcc CHAR(100) NOT NULL,
	idStaffs CHAR(10) NOT NULL,
	typeAcc INT NOT NULL -- 1 là quản ly, 0 là nhân viên
)
GO

CREATE TABLE Planes(
	idPlane CHAR(10) CONSTRAINT PK_idPlane PRIMARY KEY,
	namePlane NVARCHAR(50) NOT NULL,
	seatsPlane INT NOT NULL 
)
GO

CREATE TABLE Airports(
	idAirport CHAR(10) CONSTRAINT PK_idAirport PRIMARY KEY,
	nameAirport NVARCHAR(50) NOT NULL,
	cityAirport NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE FlightRoutes(
	idFlightRoutes CHAR(10) CONSTRAINT PK_idFlightRoutes PRIMARY KEY,
	idAirportToGo CHAR(10) NOT NULL,
	idAirportToCome CHAR(10) NOT NULL,
)
GO

CREATE TABLE TicketClasses(
	idTicketClass CHAR(10) CONSTRAINT PK_idTicketClass PRIMARY KEY,
	nameTicketClass NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE Prices(
	idFlightRoutes CHAR(10),
	idTicketClass CHAR(10),
	unitPrice DECIMAL(18, 0) NOT NULL,
	CONSTRAINT PK_Prices PRIMARY KEY (idFlightRoutes, idTicketClass)
)
GO

CREATE TABLE Flights(
	idFlights CHAR(10) CONSTRAINT PK_idFlight PRIMARY KEY,
	idFlightRoutes CHAR(10) NOT NULL,
	idPlane CHAR(10) NOT NULL,
	timeToGo DATETIME NOT NULL,
	timeToCome DATETIME NOT NULL
)
GO

CREATE TABLE TicketFlights(
	idTicket CHAR(10) CONSTRAINT PK_idTicket PRIMARY KEY,
	idCus CHAR(10) NOT NULL,
	idFlights CHAR(10) NOT NULL,
	idTicketClass CHAR(10) NOT NULL,
	idStaffs CHAR(10) NOT NULL
)
GO

CREATE TABLE TicketStatus(
	idFlights CHAR(10),
	idTicketClass CHAR(10),
	totalSeats INT NOT NULL,
	emptySeats INT NOT NULL,
	CONSTRAINT PK_TicketStatus PRIMARY KEY (idFlights, idTicketClass)
)
GO

CREATE TABLE Sales(
	monthSales INT,
	yearSales INT,
	idFlights CHAR(10) NOT NULL,
	countTicket INT NOT NULL,
	sale DECIMAL(18, 0) NOT NULL,
	CONSTRAINT PK_Sales PRIMARY KEY (monthSales, yearSales, idFlights)
)
GO

-- Ràng buộc khóa ngoại và khóa chính
ALTER TABLE dbo.Accounts ADD CONSTRAINT FK_Accounts_idStaffs FOREIGN KEY(idStaffs) REFERENCES dbo.Staffs(idStaffs)

ALTER TABLE dbo.FlightRoutes ADD CONSTRAINT FK_FlightRoutes_idAirportToGo FOREIGN KEY(idAirportToGo) REFERENCES dbo.Airports(idAirport)
ALTER TABLE dbo.FlightRoutes ADD CONSTRAINT FK_FlightRoutes_idAirportToCome FOREIGN KEY(idAirportToCome) REFERENCES dbo.Airports(idAirport)

ALTER TABLE dbo.Prices ADD CONSTRAINT FK_Prices_idTicketClass FOREIGN KEY(idTicketClass) REFERENCES dbo.TicketClasses(idTicketClass)
ALTER TABLE dbo.Prices ADD CONSTRAINT FK_Prices_idFlightRoutes FOREIGN KEY(idFlightRoutes) REFERENCES dbo.FlightRoutes(idFlightRoutes)

ALTER TABLE dbo.Flights ADD CONSTRAINT FK_Flights_idFlightRoutes FOREIGN KEY(idFlightRoutes) REFERENCES dbo.FlightRoutes(idFlightRoutes)
ALTER TABLE dbo.Flights ADD CONSTRAINT FK_Flights_idPlane FOREIGN KEY(idPlane) REFERENCES dbo.Planes(idPlane)

ALTER TABLE dbo.TicketStatus ADD CONSTRAINT FK_TicketStatus_idFlights FOREIGN KEY(idFlights) REFERENCES dbo.Flights(idFlights)
ALTER TABLE dbo.TicketStatus ADD CONSTRAINT FK_TicketStatus_idTicketClass FOREIGN KEY(idTicketClass) REFERENCES dbo.TicketClasses(idTicketClass)

ALTER TABLE dbo.TicketFlights ADD CONSTRAINT FK_TicketFlights_idCus FOREIGN KEY(idCus) REFERENCES dbo.Customers(idCus)
ALTER TABLE dbo.TicketFlights ADD CONSTRAINT FK_TicketFlights_idFlights FOREIGN KEY(idFlights) REFERENCES dbo.Flights(idFlights)
ALTER TABLE dbo.TicketFlights ADD CONSTRAINT FK_TicketFlights_idTicketClass FOREIGN KEY(idTicketClass) REFERENCES dbo.TicketClasses(idTicketClass)
ALTER TABLE dbo.TicketFlights ADD CONSTRAINT FK_TicketFlights_idStaffs FOREIGN KEY(idStaffs) REFERENCES dbo.Staffs(idStaffs)

ALTER TABLE dbo.Sales ADD CONSTRAINT FK_Sales_idFlights FOREIGN KEY(idFlights) REFERENCES dbo.Flights(idFlights)
GO 

-- Insert Data
INSERT dbo.Staffs (idStaffs, nameStaffs, addressStaffs, phoneStaffs) VALUES('NV0000',  N'Minh Lê',  N'Đăk Lăk',  '0832647823')
INSERT dbo.Staffs (idStaffs, nameStaffs, addressStaffs, phoneStaffs) VALUES('NV0001',  N'Nguyễn Ngọc Hoài',  N'Phú Yên',  '0284931343')
INSERT dbo.Staffs (idStaffs, nameStaffs, addressStaffs, phoneStaffs) VALUES('NV0002',  N'Dương Quốc Tuấn',  N'Đăk Lăk',  '0748193482')
INSERT dbo.Staffs (idStaffs, nameStaffs, addressStaffs, phoneStaffs) VALUES('NV0003',  N'Văn Hoàng Lương',  N'Bình Thuận',  '0638145823')
INSERT dbo.Staffs (idStaffs, nameStaffs, addressStaffs, phoneStaffs) VALUES('NV0004',  N'Đặng Xuân Bách',  N'Đồng Nai',  '0827283921')
GO

INSERT dbo.Accounts (userAcc, passAcc, idStaffs, typeAcc) VALUES('1', '1',  'NV0000', 1)
INSERT dbo.Accounts (userAcc, passAcc, idStaffs, typeAcc) VALUES('nnhoai', '1',  'NV0001', 1)
INSERT dbo.Accounts (userAcc, passAcc, idStaffs, typeAcc) VALUES('dqtuan', '1',  'NV0002', 1)
INSERT dbo.Accounts (userAcc, passAcc, idStaffs, typeAcc) VALUES('vhluong', '1',  'NV0003', 1)
INSERT dbo.Accounts (userAcc, passAcc, idStaffs, typeAcc) VALUES('dxbach', '1',  'NV0004', 0)
GO

INSERT dbo.Planes (idPlane, namePlane, seatsPlane) VALUES('MB0000',  N'Boeing 787', 200) 
INSERT dbo.Planes (idPlane, namePlane, seatsPlane) VALUES('MB0001',  N'Airbus A350', 300) 
INSERT dbo.Planes (idPlane, namePlane, seatsPlane) VALUES('MB0002',  N'Airbus A330', 250) 
INSERT dbo.Planes (idPlane, namePlane, seatsPlane) VALUES('MB0003',  N'Airbus A321', 150) 
GO

INSERT dbo.Airports (idAirport, nameAirport, cityAirport) VALUES ('SB0000', N'Nội Bài', N'Hà Nội')
INSERT dbo.Airports (idAirport, nameAirport, cityAirport) VALUES ('SB0001', N'Tân Sơn Nhất', N'Hồ Chí Minh')
INSERT dbo.Airports (idAirport, nameAirport, cityAirport) VALUES ('SB0002', N'Đà Nẵng', N'Đà Nẵng')
INSERT dbo.Airports (idAirport, nameAirport, cityAirport) VALUES ('SB0003', N'Buôn Mê Thuột', N'Đăk Lăk')
GO

INSERT dbo.FlightRoutes (idFlightRoutes, idAirportToGo, idAirportToCome) VALUES ('TB0000', 'SB0000', 'SB0001')
INSERT dbo.FlightRoutes (idFlightRoutes, idAirportToGo, idAirportToCome) VALUES ('TB0001', 'SB0001', 'SB0002')
INSERT dbo.FlightRoutes (idFlightRoutes, idAirportToGo, idAirportToCome) VALUES ('TB0002', 'SB0001', 'SB0003')
INSERT dbo.FlightRoutes (idFlightRoutes, idAirportToGo, idAirportToCome) VALUES ('TB0003', 'SB0003', 'SB0000')
GO

INSERT dbo.TicketClasses (idTicketClass, nameTicketClass) VALUES ('HV0000', N'Thương gia')
INSERT dbo.TicketClasses (idTicketClass, nameTicketClass) VALUES ('HV0001', N'Phổ thông đặc biệt')
INSERT dbo.TicketClasses (idTicketClass, nameTicketClass) VALUES ('HV0002', N'Phổ thông')
GO

INSERT dbo.Prices (idFlightRoutes, idTicketClass, unitPrice) VALUES ('TB0000', 'HV0000', CAST(6000000 AS Decimal(18, 0)))
INSERT dbo.Prices (idFlightRoutes, idTicketClass, unitPrice) VALUES ('TB0000', 'HV0001', CAST(3000000 AS Decimal(18, 0)))
INSERT dbo.Prices (idFlightRoutes, idTicketClass, unitPrice) VALUES ('TB0000', 'HV0002', CAST(1500000 AS Decimal(18, 0)))
INSERT dbo.Prices (idFlightRoutes, idTicketClass, unitPrice) VALUES ('TB0001', 'HV0000', CAST(3000000 AS Decimal(18, 0)))
INSERT dbo.Prices (idFlightRoutes, idTicketClass, unitPrice) VALUES ('TB0001', 'HV0001', CAST(1500000 AS Decimal(18, 0)))
INSERT dbo.Prices (idFlightRoutes, idTicketClass, unitPrice) VALUES ('TB0001', 'HV0002', CAST(1000000 AS Decimal(18, 0)))
INSERT dbo.Prices (idFlightRoutes, idTicketClass, unitPrice) VALUES ('TB0002', 'HV0000', CAST(6000000 AS Decimal(18, 0)))
INSERT dbo.Prices (idFlightRoutes, idTicketClass, unitPrice) VALUES ('TB0002', 'HV0001', CAST(3000000 AS Decimal(18, 0)))
INSERT dbo.Prices (idFlightRoutes, idTicketClass, unitPrice) VALUES ('TB0002', 'HV0002', CAST(1500000 AS Decimal(18, 0)))
INSERT dbo.Prices (idFlightRoutes, idTicketClass, unitPrice) VALUES ('TB0003', 'HV0000', CAST(3000000 AS Decimal(18, 0)))
INSERT dbo.Prices (idFlightRoutes, idTicketClass, unitPrice) VALUES ('TB0003', 'HV0001', CAST(1500000 AS Decimal(18, 0)))
INSERT dbo.Prices (idFlightRoutes, idTicketClass, unitPrice) VALUES ('TB0003', 'HV0002', CAST(1000000 AS Decimal(18, 0)))
GO

INSERT dbo.Flights (idFlights, idFlightRoutes, idPlane, timeToGo, timeToCome) VALUES ('CB0000', 'TB0000', 'MB0000', CAST(N'2023-12-01T06:00:00.000' AS DateTime), CAST(N'2023-12-01T09:00:00.000' AS DateTime))
INSERT dbo.Flights (idFlights, idFlightRoutes, idPlane, timeToGo, timeToCome) VALUES ('CB0001', 'TB0001', 'MB0001', CAST(N'2023-12-01T14:00:00.000' AS DateTime), CAST(N'2023-12-01T15:30:00.000' AS DateTime))
INSERT dbo.Flights (idFlights, idFlightRoutes, idPlane, timeToGo, timeToCome) VALUES ('CB0002', 'TB0002', 'MB0002', CAST(N'2023-12-01T10:00:00.000' AS DateTime), CAST(N'2023-12-01T12:00:00.000' AS DateTime))
INSERT dbo.Flights (idFlights, idFlightRoutes, idPlane, timeToGo, timeToCome) VALUES ('CB0003', 'TB0003', 'MB0003', CAST(N'2023-12-01T10:00:00.000' AS DateTime), CAST(N'2023-12-01T12:00:00.000' AS DateTime))
GO

INSERT dbo.Customers (idCus, nameCus, identitycardCus, phoneCus) VALUES ('KH0000', N'Lê Hoàng Minh',  '738192391023',  '0738133431')
INSERT dbo.Customers (idCus, nameCus, identitycardCus, phoneCus) VALUES ('KH0001', N'Cao Trọng Nghĩa',  '829132742831',  '0728399012')
INSERT dbo.Customers (idCus, nameCus, identitycardCus, phoneCus) VALUES ('KH0002', N'Nguyễn Tuấn Kiệt',  '829139102731',  '0738911739')
INSERT dbo.Customers (idCus, nameCus, identitycardCus, phoneCus) VALUES ('KH0003', N'Hồ Quỳnh Nhi',  '672313902731',  '0738517779')
INSERT dbo.Customers (idCus, nameCus, identitycardCus, phoneCus) VALUES ('KH0004', N'Mai Hà Hoàng Yến',  '737139102121',  '0736732739')
GO

INSERT dbo.TicketFlights (idTicket, idCus, idFlights, idTicketClass, idStaffs) VALUES ('VE0000', 'KH0000', 'CB0000', 'HV0001', 'NV0001')
INSERT dbo.TicketFlights (idTicket, idCus, idFlights, idTicketClass, idStaffs) VALUES ('VE0001', 'KH0001', 'CB0001', 'HV0002', 'NV0002')
INSERT dbo.TicketFlights (idTicket, idCus, idFlights, idTicketClass, idStaffs) VALUES ('VE0002', 'KH0002', 'CB0002', 'HV0000', 'NV0003')
INSERT dbo.TicketFlights (idTicket, idCus, idFlights, idTicketClass, idStaffs) VALUES ('VE0003', 'KH0003', 'CB0003', 'HV0002', 'NV0001')
INSERT dbo.TicketFlights (idTicket, idCus, idFlights, idTicketClass, idStaffs) VALUES ('VE0004', 'KH0004', 'CB0000', 'HV0001', 'NV0000')
INSERT dbo.TicketFlights (idTicket, idCus, idFlights, idTicketClass, idStaffs) VALUES ('VE0005', 'KH0003', 'CB0000', 'HV0000', 'NV0000')
GO

INSERT dbo.TicketStatus (idFlights, idTicketClass, totalSeats, emptySeats) VALUES ('CB0000', 'HV0000', 30, 30)
INSERT dbo.TicketStatus (idFlights, idTicketClass, totalSeats, emptySeats) VALUES ('CB0000', 'HV0001', 70, 69)
INSERT dbo.TicketStatus (idFlights, idTicketClass, totalSeats, emptySeats) VALUES ('CB0000', 'HV0002', 100, 100)
INSERT dbo.TicketStatus (idFlights, idTicketClass, totalSeats, emptySeats) VALUES ('CB0001', 'HV0000', 15, 14)
INSERT dbo.TicketStatus (idFlights, idTicketClass, totalSeats, emptySeats) VALUES ('CB0001', 'HV0001', 60, 60)
INSERT dbo.TicketStatus (idFlights, idTicketClass, totalSeats, emptySeats) VALUES ('CB0001', 'HV0002', 75, 74)
INSERT dbo.TicketStatus (idFlights, idTicketClass, totalSeats, emptySeats) VALUES ('CB0002', 'HV0000', 15, 14)
INSERT dbo.TicketStatus (idFlights, idTicketClass, totalSeats, emptySeats) VALUES ('CB0002', 'HV0001', 60, 60)
INSERT dbo.TicketStatus (idFlights, idTicketClass, totalSeats, emptySeats) VALUES ('CB0002', 'HV0002', 75, 74)
INSERT dbo.TicketStatus (idFlights, idTicketClass, totalSeats, emptySeats) VALUES ('CB0003', 'HV0000', 15, 14)
INSERT dbo.TicketStatus (idFlights, idTicketClass, totalSeats, emptySeats) VALUES ('CB0003', 'HV0001', 60, 60)
INSERT dbo.TicketStatus (idFlights, idTicketClass, totalSeats, emptySeats) VALUES ('CB0003', 'HV0002', 75, 74)
GO

INSERT dbo.Sales (monthSales, yearSales, idFlights, countTicket, sale) VALUES (12, 2023, 'CB0000', 1, CAST(3000000 AS Decimal(18, 0)))
INSERT dbo.Sales (monthSales, yearSales, idFlights, countTicket, sale) VALUES (12, 2023, 'CB0001', 2, CAST(6300000 AS Decimal(18, 0)))
INSERT dbo.Sales (monthSales, yearSales, idFlights, countTicket, sale) VALUES (12, 2023, 'CB0002', 1, CAST(8100000 AS Decimal(18, 0)))
INSERT dbo.Sales (monthSales, yearSales, idFlights, countTicket, sale) VALUES (12, 2023, 'CB0003', 1, CAST(3100000 AS Decimal(18, 0)))
GO

-- FUNCTION
-- Function tạo mã khách hàng
CREATE FUNCTION UF_CreateIdCustomer()
RETURNS CHAR(10)
AS
BEGIN
	DECLARE @IdCus CHAR(10)
	DECLARE @count INT = (SELECT COUNT(*) FROM dbo.Customers)
	IF @count = 0
		RETURN 'KH0000'
	SET @count = (SELECT CAST((SELECT SUBSTRING((SELECT TOP(1) idCus FROM dbo.Customers ORDER BY idCus DESC), 3, 5)) AS INT) + 1)
	SET @IdCus = 'KH' + CAST(@count AS CHAR(10))
	DECLARE @temp INT = @count
	DECLARE @strSoKhong CHAR(4) = ''
	DECLARE @dem INT = 0 
	WHILE @temp > 0
	BEGIN
	    SET @temp = @temp / 10
		SET @dem = @dem + 1
	END
	DECLARE @i INT = 0
	WHILE @i < (4 - @dem)
	BEGIN
		SET @IdCus = (SELECT STUFF(@IdCus, 3, 0, '0'))
		SET @i = @i + 1
	END
	RETURN @IdCus
END
GO
-- Function tạo mã nhân viên
CREATE FUNCTION UF_CreateIdStaff()
RETURNS CHAR(10)
AS
BEGIN
	DECLARE @IdStaff CHAR(10)
	DECLARE @count INT = (SELECT COUNT(*) FROM dbo.Staffs)
	IF @count = 0
		RETURN 'NV0000'
	SET @count = (SELECT CAST((SELECT SUBSTRING((SELECT TOP(1) idStaffs FROM dbo.Staffs ORDER BY idStaffs DESC), 3, 5)) AS INT) + 1)
	SET @IdStaff = 'NV' + CAST(@count AS CHAR(10))
	DECLARE @temp INT = @count
	DECLARE @strSoKhong CHAR(4) = ''
	DECLARE @dem INT = 0 
	WHILE @temp > 0
	BEGIN
	    SET @temp = @temp / 10
		SET @dem = @dem + 1
	END
	DECLARE @i INT = 0
	WHILE @i < (4 - @dem)
	BEGIN
		SET @IdStaff = (SELECT STUFF(@IdStaff, 3, 0, '0'))
		SET @i = @i + 1
	END
	RETURN @IdStaff
END
GO
-- Function tạo mã máy bay
CREATE FUNCTION UF_CreateIdPlane()
RETURNS CHAR(10)
AS
BEGIN
	DECLARE @IdPlane CHAR(10)
	DECLARE @count INT = (SELECT COUNT(*) FROM dbo.Planes)
	IF @count = 0
		RETURN 'MB0000'
	SET @count = (SELECT CAST((SELECT SUBSTRING((SELECT TOP(1) idPlane FROM dbo.Planes ORDER BY idPlane DESC), 3, 5)) AS INT) + 1)
	SET @IdPlane = 'MB' + CAST(@count AS CHAR(10))
	DECLARE @temp INT = @count
	DECLARE @strSoKhong CHAR(4) = ''
	DECLARE @dem INT = 0 
	WHILE @temp > 0
	BEGIN
	    SET @temp = @temp / 10
		SET @dem = @dem + 1
	END
	DECLARE @i INT = 0
	WHILE @i < (4 - @dem)
	BEGIN
		SET @IdPlane = (SELECT STUFF(@IdPlane, 3, 0, '0'))
		SET @i = @i + 1
	END
	RETURN @IdPlane
END
GO
-- Function tạo mã sân bay
CREATE FUNCTION UF_CreateIdAirport()
RETURNS CHAR(10)
AS
BEGIN
	DECLARE @IdAirport CHAR(10)
	DECLARE @count INT = (SELECT COUNT(*) FROM dbo.Airports)
	IF @count = 0
		RETURN 'SB0000'
	SET @count = (SELECT CAST((SELECT SUBSTRING((SELECT TOP(1) idAirport FROM dbo.Airports ORDER BY idAirport DESC), 3, 5)) AS INT) + 1)
	SET @IdAirport = 'SB' + CAST(@count AS CHAR(10))
	DECLARE @temp INT = @count
	DECLARE @strSoKhong CHAR(4) = ''
	DECLARE @dem INT = 0 
	WHILE @temp > 0
	BEGIN
	    SET @temp = @temp / 10
		SET @dem = @dem + 1
	END
	DECLARE @i INT = 0
	WHILE @i < (4 - @dem)
	BEGIN
		SET @IdAirport = (SELECT STUFF(@IdAirport, 3, 0, '0'))
		SET @i = @i + 1
	END
	RETURN @IdAirport
END
GO

-- Function tạo mã tuyến bay
CREATE FUNCTION UF_CreateIdFlightRoute()
RETURNS CHAR(10)
AS
BEGIN
	DECLARE @IdFR CHAR(10)
	DECLARE @count INT = (SELECT COUNT(*) FROM dbo.FlightRoutes)
	IF @count = 0
		RETURN 'TB0000'
	SET @count = (SELECT CAST((SELECT SUBSTRING((SELECT TOP(1) idFlightRoutes FROM dbo.FlightRoutes ORDER BY idFlightRoutes DESC), 3, 5)) AS INT) + 1)
	SET @IdFR = 'TB' + CAST(@count AS CHAR(10))
	DECLARE @temp INT = @count
	DECLARE @strSoKhong CHAR(4) = ''
	DECLARE @dem INT = 0 
	WHILE @temp > 0
	BEGIN
	    SET @temp = @temp / 10
		SET @dem = @dem + 1
	END
	DECLARE @i INT = 0
	WHILE @i < (4 - @dem)
	BEGIN
		SET @IdFR = (SELECT STUFF(@IdFR, 3, 0, '0'))
		SET @i = @i + 1
	END
	RETURN @IdFR
END
GO
-- Function tạo mã hạng vé
CREATE FUNCTION UF_CreateIdTicketClass()
RETURNS CHAR(10)
AS
BEGIN
	DECLARE @IdTC CHAR(10)
	DECLARE @count INT = (SELECT COUNT(*) FROM dbo.TicketClasses)
	IF @count = 0
		RETURN 'HV0000'
	SET @count = (SELECT CAST((SELECT SUBSTRING((SELECT TOP(1) idTicketClass FROM dbo.TicketClasses ORDER BY idTicketClass DESC), 3, 5)) AS INT) + 1)
	SET @IdTC = 'HV' + CAST(@count AS CHAR(10))
	DECLARE @temp INT = @count
	DECLARE @strSoKhong CHAR(4) = ''
	DECLARE @dem INT = 0 
	WHILE @temp > 0
	BEGIN
	    SET @temp = @temp / 10
		SET @dem = @dem + 1
	END
	DECLARE @i INT = 0
	WHILE @i < (4 - @dem)
	BEGIN
		SET @IdTC = (SELECT STUFF(@IdTC, 3, 0, '0'))
		SET @i = @i + 1
	END
	RETURN @IdTC
END
GO
-- Function tạo mã chuyến bay
CREATE FUNCTION UF_CreateIdFlight()
RETURNS CHAR(10)
AS
BEGIN
	DECLARE @IdFlight CHAR(10)
	DECLARE @count INT = (SELECT COUNT(*) FROM dbo.Flights)
	IF @count = 0
		RETURN 'CB0000'
	SET @count = (SELECT CAST((SELECT SUBSTRING((SELECT TOP(1) idFlights FROM dbo.Flights ORDER BY idFlights DESC), 3, 5)) AS INT) + 1)
	SET @IdFlight = 'CB' + CAST(@count AS CHAR(10))
	DECLARE @temp INT = @count
	DECLARE @strSoKhong CHAR(4) = ''
	DECLARE @dem INT = 0 
	WHILE @temp > 0
	BEGIN
	    SET @temp = @temp / 10
		SET @dem = @dem + 1
	END
	DECLARE @i INT = 0
	WHILE @i < (4 - @dem)
	BEGIN
		SET @IdFlight = (SELECT STUFF(@IdFlight, 3, 0, '0'))
		SET @i = @i + 1
	END
	RETURN @IdFlight
END
GO
-- Function tạo mã vé máy bay
CREATE FUNCTION UF_CreateIdTicketFlight()
RETURNS CHAR(10)
AS
BEGIN
	DECLARE @IdTF CHAR(10)
	DECLARE @count INT = (SELECT COUNT(*) FROM dbo.TicketFlights)
	IF @count = 0
		RETURN 'VE0000'
	SET @count = (SELECT CAST((SELECT SUBSTRING((SELECT TOP(1) idTicket FROM dbo.TicketFlights ORDER BY idTicket DESC), 3, 5)) AS INT) + 1)
	SET @IdTF = 'VE' + CAST(@count AS CHAR(10))
	DECLARE @temp INT = @count
	DECLARE @strSoKhong CHAR(4) = ''
	DECLARE @dem INT = 0 
	WHILE @temp > 0
	BEGIN
	    SET @temp = @temp / 10
		SET @dem = @dem + 1
	END
	DECLARE @i INT = 0
	WHILE @i < (4 - @dem)
	BEGIN
		SET @IdTF = (SELECT STUFF(@IdTF, 3, 0, '0'))
		SET @i = @i + 1
	END
	RETURN @IdTF
END
GO
-- Function lấy giá vé của chuyến bay
CREATE FUNCTION UF_GetPriceByIdFlightAndIdTicketClass(@idFlight CHAR(10), @idTicketClass CHAR(10))
RETURNS DECIMAL(18, 0)
AS
BEGIN
	DECLARE @price DECIMAL(18, 0)
	SELECT @price = unitPrice 
	FROM dbo.Flights 
	INNER JOIN dbo.Prices 
	ON Prices.idFlightRoutes = Flights.idFlightRoutes
	WHERE idFlights = @idFlight AND idTicketClass = @idTicketClass
	RETURN @price
END
GO

-- Function lấy số ghế trống từ mã chuyến bay và hạng vé
CREATE FUNCTION UF_GetEmptySeatsByIdFlightAndIdTicketClass(@idFlight CHAR(10), @idTicketClass CHAR(10))
RETURNS INT
AS	
BEGIN
	DECLARE @empty INT
	SELECT @empty = emptySeats
	FROM dbo.TicketStatus
	WHERE idFlights = @idFlight AND idTicketClass = @idTicketClass
	IF @empty > 0 
		RETURN @empty
	RETURN 0
END
GO
-- Function lấy số ghế còn lại của máy bay từ mã chuyến bay 
CREATE FUNCTION UF_GetSeatsOfPlaneByIdFlight(@idFlight CHAR(10))
RETURNS INT
AS	
BEGIN
	DECLARE @totalseats INT = (SELECT seatsPlane FROM dbo.Planes 
								WHERE idPlane = (SELECT idPlane FROM dbo.Flights WHERE idFlights = @idFlight))
	DECLARE @insertseats INT = (SELECT SUM(totalSeats) FROM dbo.TicketStatus WHERE idFlights = @idFlight)
	RETURN @totalseats - @insertseats
END
GO

-- Function kiểm tra đăng nhập
create function UF_Login(@username char(100), @password char(100))
returns int
as
begin
	Declare @checkUser INT = (SELECT count(*) FROM dbo.Accounts WHERE userAcc=@username)
	Declare @checkPass INT = (SELECT count(*) FROM dbo.Accounts WHERE userAcc=@username and passAcc=@password)
	DECLARE @check INT = 1
	IF (@checkUser != 1)
		SET @check = 0
	IF (@checkPass != 1)
		SET @check = -1
	return @check
end
GO

---------------------------------------------------------------------------------------------------

-- STORE PROCEDURE
-- Stored Procedure tìm kiếm thông tin nhân viên bằng tên
CREATE PROC USP_SearchStaffByName
@name NVARCHAR(50)
AS
	SELECT Accounts.idStaffs, nameStaffs, addressStaffs, phoneStaffs, userAcc, typeAcc 
	FROM dbo.Accounts INNER JOIN dbo.Staffs ON Staffs.idStaffs = Accounts.idStaffs
	WHERE nameStaffs LIKE '%'+@name+'%'
	ORDER BY Accounts.idStaffs
GO
-- Stored Procedure lấy danh sách chuyến bay theo mã chuyến bay
CREATE PROC USP_GetFlightByIdFlight
@idFlight CHAR(10)
AS
	SELECT idFlights, Flights.idFlightRoutes, idPlane, timeToGo, timeToCome, 
	AirportToGo.nameAirport AS AirportToGo,  AirportToCome.nameAirport AS AirportToCome
	FROM dbo.Flights 
	INNER JOIN dbo.FlightRoutes
	ON FlightRoutes.idFlightRoutes = Flights.idFlightRoutes
	INNER JOIN dbo.Airports AS AirportToGo
	ON AirportToGo.idAirport = FlightRoutes.idAirportToGo
	INNER JOIN dbo.Airports AS AirportToCome
	ON AirportToCome.idAirport = FlightRoutes.idAirportToCome
	WHERE idFlights = @idFlight
GO
-- Stored Procedure lấy danh sách chuyến bay theo sân bay và thời gian
CREATE PROC USP_GetFlightByAirportAndTime
@idAirportToGo CHAR(10), @idAirportToCome CHAR(10),
@timeToGo DATETIME, @timeToCome DATETIME
AS
	SELECT idFlights, timeToGo, timeToCome
	FROM dbo.Flights 
	INNER JOIN dbo.FlightRoutes
	ON FlightRoutes.idFlightRoutes = Flights.idFlightRoutes
	WHERE idAirportToGo = @idAirportToGo AND idAirportToCome = @idAirportToCome AND
	(timeToGo >= @timeToGo AND timeToGo <= @timeToCome)
GO
-- Stored Procedure tìm kiếm thông tin vé của khách hàng từ số điện thoại
CREATE PROC USP_SearchTicketFlightByPhone
@phone VARCHAR(10)
AS
	SELECT  TicketFlights.idTicket, nameCus, identitycardCus, phoneCus, idFlights, nameTicketClass, Prices.Price
	FROM dbo.TicketFlights 
	INNER JOIN dbo.Customers
	ON Customers.idCus = TicketFlights.idCus
	INNER JOIN dbo.TicketClasses
	ON TicketClasses.idTicketClass = TicketFlights.idTicketClass
	INNER JOIN (SELECT dbo.UF_GetPriceByIdFlightAndIdTicketClass(idFlights, idTicketClass) AS Price, idTicket FROM dbo.TicketFlights) AS Prices
	ON Prices.idTicket = TicketFlights.idTicket
	WHERE phoneCus LIKE '%'+@phone+'%'
GO
-- Stored Procedure lấy danh sách hạng vé của chuyến bay từ mã chuyến bay
CREATE PROC USP_GetTicketClassForFlight
@idFlight CHAR(10)
AS
	SELECT idFlights, nameTicketClass, totalSeats, emptySeats 
	FROM dbo.TicketStatus INNER JOIN dbo.TicketClasses
	ON TicketClasses.idTicketClass = TicketStatus.idTicketClass
	WHERE idFlights = @idFlight
GO
-- Stored Procedure lấy danh sách tình trạng vé từ mã máy bay
CREATE PROC USP_GetTicketStatusByIdFlight
@idFlight CHAR(10)
AS
	SELECT nameTicketClass, totalSeats, emptySeats
	FROM dbo.TicketStatus 
	INNER JOIN dbo.TicketClasses
	ON TicketClasses.idTicketClass = TicketStatus.idTicketClass
	WHERE idFlights = @idFlight
GO

---------------------------------------------------------------------------------------------------

-- TRIGGER
-- Trigger xóa tài khoản khi xóa nhân viên
CREATE TRIGGER UTG_DeleteAccount
ON dbo.Accounts AFTER DELETE
AS
BEGIN
	DECLARE @id CHAR(10)
	SELECT @id = Deleted.idStaffs FROM Deleted
	DELETE dbo.Staffs WHERE idStaffs = @id
END
GO
-- Trigger kiểm tra trùng lặp tên sân bay
CREATE TRIGGER UTG_CheckAirport
ON dbo.Airports AFTER INSERT, UPDATE
AS
BEGIN
	DECLARE @nameAirport NVARCHAR(50), @count INT
	SELECT @nameAirport = Inserted.nameAirport FROM Inserted
	SELECT @count = COUNT(*) FROM dbo.Airports WHERE nameAirport = @nameAirport
	IF (@count > 1)
		ROLLBACK TRAN	
END
GO
-- Trigger kiểm tra trùng lặp tên máy bay
CREATE TRIGGER UTG_CheckNamePlane
ON dbo.Planes AFTER INSERT, UPDATE
AS
BEGIN
	DECLARE @namePlane NVARCHAR(50), @count INT
	SELECT @namePlane = Inserted.namePlane FROM Inserted
	SELECT @count = COUNT(*) FROM dbo.Planes WHERE namePlane = @namePlane
	IF (@count > 1)
		ROLLBACK TRAN	
END
GO
-- Trigger kiểm tra trùng lặp tên hạng vé
CREATE TRIGGER UTG_CheckNameTịcketClass
ON dbo.TicketClasses AFTER INSERT, UPDATE
AS
BEGIN
	DECLARE @nameTC NVARCHAR(50), @count INT
	SELECT @nameTC = Inserted.nameTicketClass FROM Inserted
	SELECT @count = COUNT(*) FROM dbo.TicketClasses WHERE nameTicketClass = @nameTC
	IF (@count > 1)
		ROLLBACK TRAN	
END
GO
-- Trigger thêm danh sách doanh thu khi thêm, sửa chuyến bay
CREATE TRIGGER UTG_AddSaleFromFlight
ON dbo.Flights AFTER INSERT, UPDATE
AS
BEGIN
	DECLARE @timetogonew DATETIME, @timetocomenew DATETIME, @monthnew INT, @yearnew INT, @timetogoold DATETIME, @timetocomeold DATETIME, @monthold INT, @yearold INT, @idFlightnew CHAR(10), @idFlightold CHAR(10)
	SELECT @timetogonew = Inserted.timeToGo, @timetocomenew = Inserted.timeToCome, @idFlightnew = Inserted.idFlights FROM Inserted
	SELECT @timetogoold = Deleted.timeToGo, @timetocomeold = Deleted.timeToCome, @idFlightold = Deleted.idFlights FROM Deleted
	SET @monthnew = (SELECT MONTH(@timetogonew))
	SET @yearnew = (SELECT YEAR(@timetogonew))
	SET @monthold = (SELECT MONTH(@timetogoold))
	SET @yearold = (SELECT YEAR(@timetogoold))
	BEGIN TRAN
	IF (@timetogonew < (SELECT GETDATE()))
	BEGIN
	    ROLLBACK
		RETURN
	END
	IF (@timetogonew >= @timetocomenew)
	BEGIN
	    ROLLBACK
		RETURN
	END	
	INSERT dbo.Sales(monthSales, yearSales, idFlights, countTicket, sale) VALUES (@monthnew, @yearnew, @idFlightnew, 0, 0)
	DELETE dbo.Sales WHERE monthSales = @monthold AND yearSales = @yearold AND idFlights = @idFlightold
	IF (@@ERROR <> 0)
	BEGIN
	    ROLLBACK
		RETURN
	END
	COMMIT TRAN
END
GO
-- Trigger xóa danh sách doanh thu khi thêm, sửa chuyến bay
CREATE TRIGGER UTG_DeleteSaleFromFlight
ON dbo.Flights INSTEAD OF DELETE
AS
BEGIN
	DECLARE @timetogoold DATETIME, @timetocomeold DATETIME, @monthold INT, @yearold INT, @idFlight CHAR(10)
	SELECT @timetogoold = Deleted.timeToGo, @timetocomeold = Deleted.timeToCome, @idFlight = Deleted.idFlights FROM Deleted
	SET @monthold = (SELECT MONTH(@timetogoold))
	SET @yearold = (SELECT YEAR(@timetogoold))
	BEGIN TRAN
	DELETE dbo.Sales WHERE monthSales = @monthold AND yearSales = @yearold AND @idFlight = @idFlight
	DELETE dbo.Flights WHERE idFlights = @idFlight
	IF (@@ERROR <> 0)
	BEGIN
	    ROLLBACK
		RETURN
	END
	COMMIT TRAN
END
GO
--Triger sửa doanh thu và sửa tình trạng vé khi bán vé
CREATE TRIGGER UTG_SaleAndTicketStatusBookingTicket
ON dbo.TicketFlights AFTER INSERT
AS
BEGIN
	DECLARE @idFlight CHAR(10), @idTC CHAR(10), @timetogo DATETIME, @month INT, @year INT, @price DECIMAL(18, 0)
	SELECT @idFlight = Inserted.idFlights, @idTC = Inserted.idTicketClass
	FROM Inserted
	SELECT @timetogo = timeToGo FROM dbo.Flights WHERE idFlights = @idFlight
	SET @month = (SELECT MONTH(@timetogo))
	SET @year = (SELECT YEAR(@timetogo))
	SET @price = (SELECT dbo.UF_GetPriceByIdFlightAndIdTicketClass(@idFlight, @idTC))
	BEGIN TRAN
	UPDATE dbo.TicketStatus SET emptySeats = emptySeats - 1 
	WHERE idFlights = @idFlight AND idTicketClass = @idTC
	UPDATE dbo.Sales SET sale = sale + @price, countTicket = countTicket + 1
	WHERE monthSales = @month AND yearSales = @year AND idFlights = @idFlight
	IF (@@ERROR <> 0)
	BEGIN
	    ROLLBACK
		RETURN
	END
	COMMIT TRAN
END
GO
-- Trigger sửa doanh thu và sửa tình trạng vé khi hủy vé
CREATE TRIGGER UTG_SaleAndTicketStatusCancelTicket
ON dbo.TicketFlights INSTEAD OF DELETE
AS
BEGIN
	DECLARE @idFlight CHAR(10), @idTC CHAR(10), @idTicket CHAR(10),
			@timetogo DATETIME, @month INT, @year INT, @price DECIMAL(18, 0)
	SELECT @idFlight = Deleted.idFlights, @idTC = Deleted.idTicketClass, @idTicket = Deleted.idTicket
	FROM Deleted
	SELECT @timetogo = timeToGo FROM dbo.Flights WHERE idFlights = @idFlight
	SET @month = (SELECT MONTH(@timetogo))
	SET @year = (SELECT YEAR(@timetogo))
	SET @price = (SELECT dbo.UF_GetPriceByIdFlightAndIdTicketClass(@idFlight, @idTC))
	BEGIN TRAN
	UPDATE dbo.TicketStatus SET emptySeats = emptySeats + 1 
	WHERE idFlights = @idFlight AND idTicketClass = @idTC
	UPDATE dbo.Sales SET sale = sale - @price, countTicket = countTicket - 1
	WHERE monthSales = @month AND yearSales = @year AND idFlights = @idFlight
	DELETE dbo.TicketFlights WHERE idTicket = @idTicket
	IF (@@ERROR <> 0)
	BEGIN
	    ROLLBACK
		RETURN
	END
	COMMIT TRAN
END
GO

---------------------------------------------------------------------------------------------------

-- VIEW
-- View danh sách vé chuyến bay
CREATE VIEW UV_TicketFlightForDisplay
AS
	SELECT  TicketFlights.idTicket, nameCus, identitycardCus, phoneCus, idFlights, nameTicketClass, Prices.Price
	FROM dbo.TicketFlights 
	INNER JOIN dbo.Customers
	ON Customers.idCus = TicketFlights.idCus
	INNER JOIN dbo.TicketClasses
	ON TicketClasses.idTicketClass = TicketFlights.idTicketClass
	INNER JOIN (SELECT dbo.UF_GetPriceByIdFlightAndIdTicketClass(idFlights, idTicketClass) AS Price, idTicket FROM dbo.TicketFlights) AS Prices
	ON Prices.idTicket = TicketFlights.idTicket
GO
-- View danh sách nhân viên
CREATE VIEW UV_StaffForDisplay
AS
	SELECT Accounts.idStaffs, nameStaffs, addressStaffs, phoneStaffs, userAcc, typeAcc 
	FROM dbo.Accounts INNER JOIN dbo.Staffs ON Staffs.idStaffs = Accounts.idStaffs
GO
-- View danh sách tuyến bay
CREATE VIEW UV_FlightRouteForDisplay
AS
	SELECT idFlightRoutes, AirportToGo.idAirport AS idAirportToGo, AirportToGo.nameAirport AS nameAirportToGo, 
	 AirportToCome.idAirport AS idAirportToCome, AirportToCome.nameAirport AS nameAirportToCome
	FROM dbo.FlightRoutes
	INNER JOIN dbo.Airports AS AirportToGo
	ON AirportToGo.idAirport = FlightRoutes.idAirportToGo
	INNER JOIN dbo.Airports AS AirportToCome
	ON AirportToCome.idAirport = FlightRoutes.idAirportToCome
GO
-- View danh sách doanh thu theo cá nhân nhân viên
CREATE VIEW UV_SaleByStaff
AS
	SELECT TicketFlights.idStaffs, nameStaffs, phoneStaffs, COUNT(*) AS countTicket, SUM(GetPrice.totalPrice) AS totalSale
	FROM dbo.TicketFlights INNER JOIN 
	(SELECT idTicket, dbo.UF_GetPriceByIdFlightAndIdTicketClass(idFlights, idTicketClass) AS totalPrice, idStaffs
	FROM dbo.TicketFlights) AS GetPrice
	ON GetPrice.idTicket = TicketFlights.idTicket
	INNER JOIN dbo.Staffs 
	ON Staffs.idStaffs = GetPrice.idStaffs
	GROUP BY TicketFlights.idStaffs, nameStaffs, phoneStaffs
GO

---------------------------------------------------------------------------------------------------

-- TRANSACTION
-- Transaction thêm nhân viên
CREATE PROC USP_InsertStaff
@name NVARCHAR(50), @address NVARCHAR(50), @phone VARCHAR(20), 
@user CHAR(100), @type INT
AS
	DECLARE @id CHAR(10) = (SELECT dbo.UF_CreateIdStaff())
	DECLARE @len INT = (SELECT LEN(@phone))
	BEGIN TRAN
	IF (@len <> 10)
	BEGIN
	    ROLLBACK
		RETURN
	END
	INSERT dbo.Staffs(idStaffs, nameStaffs, addressStaffs, phoneStaffs) VALUES (@id, @name, @address, @phone)
	IF (@@ERROR <> 0)
	BEGIN
	    ROLLBACK
		RETURN
	END
	INSERT dbo.Accounts(userAcc, passAcc, idStaffs, typeAcc) VALUES (@user, '1', @id, @type)
	IF (@@ERROR <> 0)
	BEGIN
	    ROLLBACK
		RETURN
	END
	COMMIT TRAN
GO
-- Transaction sửa thông tin nhân viên
CREATE PROC USP_UpdateStaff
@id CHAR(10), @name NVARCHAR(50), @address NVARCHAR(50), @phone VARCHAR(20), 
@user CHAR(100), @type INT
AS
	DECLARE @len INT = (SELECT LEN(@phone))
	BEGIN TRAN
	IF (@len <> 10)
	BEGIN
	    ROLLBACK
		RETURN
	END
	UPDATE dbo.Staffs SET nameStaffs = @name, addressStaffs = @address, phoneStaffs = @phone
	WHERE idStaffs = @id
	IF (@@ERROR <> 0)
	BEGIN
	    ROLLBACK
		RETURN
	END
	UPDATE dbo.Accounts SET userAcc = @user,  typeAcc = @type 
	WHERE idStaffs = @id
	IF (@@ERROR <> 0)
	BEGIN
	    ROLLBACK
		RETURN
	END
	COMMIT TRAN
GO
-- Transaction bán vé máy bay
CREATE PROC USP_BookingTicket
@nameCus NVARCHAR(50), @identityCus VARCHAR(12), @phoneCus VARCHAR(10),
@idFlight CHAR(10), @idTicketClass CHAR(10), @idStaff CHAR(10)
AS
	DECLARE @count INT, @idCus CHAR(10)
	SELECT @count = COUNT(*) FROM dbo.Customers WHERE identitycardCus = @identityCus
	BEGIN TRAN
	IF (@count > 0)
		SET @idCus = (SELECT idCus FROM dbo.Customers WHERE identitycardCus = @identityCus)	
	ELSE
		BEGIN
			SET @idCus = (SELECT dbo.UF_CreateIdCustomer())
			INSERT dbo.Customers( idCus, nameCus, identitycardCus, phoneCus)
			VALUES(@idCus, @nameCus, @identityCus, @phoneCus)
		END
	INSERT dbo.TicketFlights (idTicket, idCus, idFlights, idTicketClass, idStaffs) 
	VALUES ((SELECT dbo.UF_CreateIdTicketFlight()), @idCus, @idFlight, @idTicketClass, @idStaff)
	IF (@@ERROR <> 0)
	BEGIN
	    ROLLBACK
		RETURN
	END
	COMMIT TRAN
GO


-- Security and Authorization
-- Tạo user và phân quyền cho quản lý

CREATE LOGIN Manager WITH PASSWORD = 'Manager'
CREATE ROLE manager
GO

GRANT SELECT, INSERT, DELETE, UPDATE ON dbo.Customers TO manager WITH GRANT OPTION
GRANT SELECT, INSERT, DELETE, UPDATE ON dbo.Staffs TO manager WITH GRANT OPTION
GRANT SELECT, INSERT, DELETE, UPDATE ON dbo.Accounts TO manager WITH GRANT OPTION
GRANT SELECT, INSERT, DELETE, UPDATE ON dbo.Planes TO manager WITH GRANT OPTION
GRANT SELECT, INSERT, DELETE, UPDATE ON dbo.Airports TO manager WITH GRANT OPTION
GRANT SELECT, INSERT, DELETE, UPDATE ON dbo.FlightRoutes TO manager WITH GRANT OPTION
GRANT SELECT, INSERT, DELETE, UPDATE ON dbo.TicketClasses TO manager WITH GRANT OPTION
GRANT SELECT, INSERT, DELETE, UPDATE ON dbo.Prices TO manager WITH GRANT OPTION
GRANT SELECT, INSERT, DELETE, UPDATE ON dbo.Flights TO manager WITH GRANT OPTION
GRANT SELECT, INSERT, DELETE, UPDATE ON dbo.TicketFlights TO manager WITH GRANT OPTION
GRANT SELECT, INSERT, DELETE, UPDATE ON dbo.TicketStatus TO manager WITH GRANT OPTION
GRANT SELECT, INSERT, DELETE, UPDATE ON dbo.Sales TO manager WITH GRANT OPTION
GO

GRANT EXECUTE ON dbo.UF_CreateIdCustomer TO manager
GRANT EXECUTE ON dbo.UF_CreateIdStaff TO manager
GRANT EXECUTE ON dbo.UF_CreateIdPlane TO manager
GRANT EXECUTE ON dbo.UF_CreateIdAirport TO manager
GRANT EXECUTE ON dbo.UF_CreateIdFlightRoute TO manager
GRANT EXECUTE ON dbo.UF_CreateIdTicketClass TO manager
GRANT EXECUTE ON dbo.UF_CreateIdFlight TO manager
GRANT EXECUTE ON dbo.UF_CreateIdTicketFlight TO manager
GRANT EXECUTE ON dbo.UF_GetPriceByIdFlightAndIdTicketClass TO manager
GRANT EXECUTE ON dbo.UF_GetEmptySeatsByIdFlightAndIdTicketClass TO manager
GRANT EXECUTE ON dbo.UF_GetSeatsOfPlaneByIdFlight TO manager
GO

GRANT EXECUTE ON dbo.USP_InsertStaff TO manager
GRANT EXECUTE ON dbo.USP_UpdateStaff TO manager
GRANT EXECUTE ON dbo.USP_SearchStaffByName TO manager
GRANT EXECUTE ON dbo.USP_GetTicketClassForFlight TO manager
GRANT EXECUTE ON dbo.USP_GetFlightByIdFlight TO manager
GRANT EXECUTE ON dbo.USP_GetFlightByAirportAndTime TO manager
GRANT EXECUTE ON dbo.USP_SearchTicketFlightByPhone TO manager
GRANT EXECUTE ON dbo.USP_BookingTicket TO manager
GRANT EXECUTE ON dbo.USP_GetTicketStatusByIdFlight TO manager
GO

GRANT SELECT ON dbo.UV_StaffForDisplay TO manager
GRANT SELECT ON dbo.UV_FlightRouteForDisplay TO manager
GRANT SELECT ON dbo.UV_TicketFlightForDisplay TO manager
GRANT SELECT ON dbo.UV_SaleByStaff TO manager
GO

-- Tạo user và phân quyền cho nhân viên

CREATE LOGIN Staff WITH PASSWORD = 'Staff'
CREATE ROLE staff
GO

GRANT SELECT, INSERT, DELETE, UPDATE ON dbo.Customers TO staff WITH GRANT OPTION
GRANT SELECT ON dbo.Accounts TO staff WITH GRANT OPTION
GRANT SELECT ON dbo.Planes TO staff WITH GRANT OPTION
GRANT SELECT ON dbo.Airports TO staff WITH GRANT OPTION
GRANT SELECT ON dbo.FlightRoutes TO staff WITH GRANT OPTION
GRANT SELECT ON dbo.TicketClasses TO staff WITH GRANT OPTION
GRANT SELECT ON dbo.Prices TO staff WITH GRANT OPTION
GRANT SELECT ON dbo.Flights TO staff WITH GRANT OPTION
GRANT SELECT, INSERT, DELETE, UPDATE ON dbo.TicketFlights TO staff WITH GRANT OPTION
GRANT SELECT, INSERT, DELETE, UPDATE ON dbo.TicketStatus TO staff WITH GRANT OPTION
GRANT SELECT, INSERT, DELETE, UPDATE ON dbo.Sales TO staff WITH GRANT OPTION
GO

GRANT EXECUTE ON dbo.UF_CreateIdCustomer TO staff
GRANT EXECUTE ON dbo.UF_CreateIdTicketFlight TO staff
GRANT EXECUTE ON dbo.UF_GetPriceByIdFlightAndIdTicketClass TO staff
GRANT EXECUTE ON dbo.UF_GetEmptySeatsByIdFlightAndIdTicketClass TO staff
GRANT EXECUTE ON dbo.UF_GetSeatsOfPlaneByIdFlight TO staff
GO

GRANT EXECUTE ON dbo.USP_GetTicketClassForFlight TO staff
GRANT EXECUTE ON dbo.USP_GetFlightByIdFlight TO staff
GRANT EXECUTE ON dbo.USP_GetFlightByAirportAndTime TO staff
GRANT EXECUTE ON dbo.USP_SearchTicketFlightByPhone TO staff
GRANT EXECUTE ON dbo.USP_BookingTicket TO staff
GRANT EXECUTE ON dbo.USP_GetTicketStatusByIdFlight TO staff
GO

GRANT SELECT ON dbo.UV_FlightRouteForDisplay TO staff
GRANT SELECT ON dbo.UV_TicketFlightForDisplay TO staff
GO

-- Trigger tạo tài khoản
CREATE TRIGGER [dbo].[Trigger_CreateSQLAccount] ON [dbo].[Accounts]
AFTER INSERT
AS
BEGIN
    DECLARE @userName nvarchar(100), @passWord nvarchar(100), @idStaffs nvarchar(10), @typeAcc int
    SELECT @userName = i.userAcc, @passWord = i.passAcc, @idStaffs = i.idStaffs, @typeAcc = i.typeAcc
    FROM inserted i

    DECLARE @sqlString nvarchar(2000), @macv nvarchar(10)

    SET @sqlString = 'CREATE LOGIN [' + @userName + '] WITH PASSWORD=''' + @passWord + ''', DEFAULT_DATABASE=[VNJET], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF'
    EXEC (@sqlString)

    SET @sqlString = 'CREATE USER ' + @userName + ' FOR LOGIN ' + @userName
    EXEC (@sqlString)

    IF (@typeAcc = 1)
        SET @sqlString = 'ALTER SERVER ROLE sysadmin ADD MEMBER ' + @userName;
    ELSE
        SET @sqlString = 'ALTER ROLE staff ADD MEMBER ' + @userName;

    EXEC (@sqlString)
END





