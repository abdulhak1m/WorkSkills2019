CREATE DATABASE my_maraphone

USE my_maraphone
GO
-- Testing
-- —Œ«ƒ¿Õ»≈ “¿¡À»÷€ –ŒÀ≈…
CREATE TABLE [Role]
(
	[RoleId]		NCHAR(1)		NOT NULL,
	[RoleName]		NVARCHAR(50)	NOT NULL,
	CONSTRAINT pk_Role	PRIMARY KEY ([RoleId])
)
GO

-- —Œ«ƒ¿Õ»≈ “¿¡À»÷€ œŒÀ‹«Œ¬¿“≈À≈…
CREATE TABLE [User]
(
	[Email]		NVARCHAR(100)		NOT NULL,
	[Password]	NVARCHAR(100)		NOT NULL,
	[FirstName]	NVARCHAR(100)		NOT NULL,
	[LastName]	NVARCHAR(100)		NOT NULL,
	[RoleId]	NCHAR(1)			NOT NULL,
	CONSTRAINT pk_User		PRIMARY KEY ([Email])
)
GO

-- —Œ«ƒ¿Õ»≈ “¿¡À»÷€ œŒÀŒ¬
CREATE TABLE [Gender]
(
	[Gender]	NVARCHAR(10)	NOT NULL
	CONSTRAINT pk_Gender	PRIMARY KEY([Gender])
)
GO

-- —Œ«ƒ¿Õ»≈ “¿¡À»÷€ ¡Â„ÛÌÓ‚
CREATE TABLE Runner
(
	[RunnerId]		INT IDENTITY (1,1)		NOT NULL,
	[Email]			NVARCHAR(100)			NOT NULL,
	[Gender]		NVARCHAR(10)			NOT NULL,
	[NamePic]		NVARCHAR(100)			NOT NULL,
	[Picture]		IMAGE					NOT NULL,
	[DateOfBirth]	DATETIME				NOT NULL,
	[CountryCode]	NCHAR(3)				NOT NULL,
)
GO

-- —Œ«ƒ¿Õ»≈ “¿¡À»÷€ ¬ŒÀŒÕ“–Œ¬
CREATE TABLE [Volunteer]
(
	[VolunteerId]		INT IDENTITY(0,1)		NOT NULL,
	[FirstName]			NVARCHAR(80)			NULL,
	[LastName]			NVARCHAR(80)			NOT NULL,
	[CountryCode]		NCHAR(3)				NOT NULL,
	[Gender]			NVARCHAR(10)			NOT NULL,
	CONSTRAINT pk_Volunteer PRIMARY KEY([VolunteerId])
)
GO
--—Œ«ƒ¿Õ»≈ “¿¡À»÷€ —“–¿Õ Ã»–¿
CREATE TABLE Country
(
	[CountryCode]		NCHAR(3)			NOT NULL,
	[CountryName]		NVARCHAR(100)		NOT NULL,
	[CountryFlag]		NVARCHAR(100)		NOT NULL,
	CONSTRAINT pk_Country	PRIMARY KEY ([CountryCode])
)
GO

-- Œ“ÕŒÿ≈Õ»ﬂ “¿¡À»÷
-- Runner table
ALTER TABLE [Runner] WITH CHECK ADD FOREIGN KEY ([Email]) REFERENCES [User] ([Email]);
ALTER TABLE [Runner] WITH CHECK ADD FOREIGN KEY ([Gender]) REFERENCES [Gender] ([Gender]);
ALTER TABLE [Runner] WITH CHECK ADD FOREIGN KEY ([CountryCode]) REFERENCES [Country] ([CountryCode]);

-- Gender table

-- Country table

-- Volunteer table
ALTER TABLE [Volunteer] WITH CHECK ADD FOREIGN KEY ([Gender]) REFERENCES [Gender] ([Gender]);
ALTER TABLE [Volunteer] WITH CHECK ADD FOREIGN KEY ([CountryCode]) REFERENCES [Country] ([CountryCode]);