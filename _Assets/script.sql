USE [C:\KIRA TAKIP\DATA\EMLAK.MDF]
GO
/****** Object:  Table [dbo].[CashBook]    Script Date: 22.11.2019 14:43:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CashBook](
	[TransactionId] [int] IDENTITY(1,1) NOT NULL,
	[TransactionDate] [datetime] NOT NULL,
	[TransactionType] [nvarchar](50) NOT NULL,
	[Amount] [money] NOT NULL,
	[Definition] [nvarchar](250) NULL,
	[DebtId] [int] NULL,
 CONSTRAINT [PK_CashBook] PRIMARY KEY CLUSTERED 
(
	[TransactionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[City]    Script Date: 22.11.2019 14:43:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[CityId] [int] NOT NULL,
	[CityName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contract]    Script Date: 22.11.2019 14:43:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contract](
	[ContractId] [int] IDENTITY(1,1) NOT NULL,
	[StartingDate] [date] NOT NULL,
	[EndingDate] [date] NOT NULL,
	[Tenancy] [nvarchar](100) NOT NULL,
	[Neighborhood] [nvarchar](250) NOT NULL,
	[Street] [nvarchar](250) NOT NULL,
	[Apartment] [nvarchar](250) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Town] [nvarchar](50) NOT NULL,
	[RealtyType] [nvarchar](100) NOT NULL,
	[RentMoneyInMonth] [nvarchar](50) NOT NULL,
	[RentMoneyTotal] [nvarchar](50) NOT NULL,
	[PaymentType] [nvarchar](50) NOT NULL,
	[PaymentDay] [nvarchar](2) NOT NULL,
	[CurrentSituationOfRealEstate] [nvarchar](100) NOT NULL,
	[AimOfRent] [nvarchar](100) NOT NULL,
	[InventoryList] [text] NULL,
	[ContractSpecialConditions] [text] NULL,
	[LandlordCitizenshipId] [nvarchar](11) NULL,
	[LandlordFullName] [nvarchar](50) NOT NULL,
	[LandlordPhone] [nvarchar](50) NULL,
	[LandlordAddress] [nvarchar](500) NULL,
	[LandlordBankAccountName] [nvarchar](100) NULL,
	[LandlordBankAccountNumber] [nvarchar](100) NULL,
	[LandlordIBAN] [nvarchar](100) NULL,
	[Explanation] [nvarchar](500) NULL,
	[FileNumber] [int] NOT NULL,
	[RealtyDefinition] [nvarchar](250) NOT NULL,
	[CancellationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Contract] PRIMARY KEY CLUSTERED 
(
	[ContractId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContractParties]    Script Date: 22.11.2019 14:43:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContractParties](
	[ContractId] [int] NOT NULL,
	[PersonId] [int] NOT NULL,
	[PersonType] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ContractParties_1] PRIMARY KEY CLUSTERED 
(
	[ContractId] ASC,
	[PersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Debt]    Script Date: 22.11.2019 14:43:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Debt](
	[DebtId] [int] IDENTITY(1,1) NOT NULL,
	[Definition] [nvarchar](100) NOT NULL,
	[Amount] [money] NOT NULL,
	[DueDate] [date] NOT NULL,
	[PaymentDate] [nvarchar](50) NULL,
	[PaymentType] [nvarchar](50) NULL,
	[IsPaidByTenant] [bit] NOT NULL,
	[Explanation] [nvarchar](500) NULL,
	[ContractId] [int] NOT NULL,
	[IsPaidToLandlord] [bit] NOT NULL,
	[IsCommission] [bit] NOT NULL,
	[PaymentDateToLandlord] [nvarchar](50) NULL,
 CONSTRAINT [PK_Commission] PRIMARY KEY CLUSTERED 
(
	[DebtId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 22.11.2019 14:43:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[PersonId] [int] IDENTITY(1,1) NOT NULL,
	[CitizenshipId] [nvarchar](11) NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[Explanation] [nvarchar](500) NULL,
	[Phone1] [nvarchar](50) NULL,
	[Phone2] [nvarchar](50) NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[PersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Realty]    Script Date: 22.11.2019 14:43:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Realty](
	[RealtyId] [int] IDENTITY(1,1) NOT NULL,
	[Definition] [nvarchar](500) NULL,
	[RealtyTypeId] [int] NULL,
	[Neighborhood] [nvarchar](100) NULL,
	[Street] [nvarchar](100) NULL,
	[Apartment] [nvarchar](100) NULL,
	[Town] [nvarchar](100) NULL,
	[City] [nvarchar](100) NULL,
	[Explanation] [nvarchar](500) NULL,
 CONSTRAINT [PK_Realty] PRIMARY KEY CLUSTERED 
(
	[RealtyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RealtyType]    Script Date: 22.11.2019 14:43:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RealtyType](
	[RealtyTypeId] [int] IDENTITY(1,1) NOT NULL,
	[RealtyTypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_RealtyType] PRIMARY KEY CLUSTERED 
(
	[RealtyTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Town]    Script Date: 22.11.2019 14:43:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Town](
	[TownId] [int] IDENTITY(1,1) NOT NULL,
	[TownName] [nvarchar](50) NOT NULL,
	[CityId] [int] NULL,
 CONSTRAINT [PK_Town] PRIMARY KEY CLUSTERED 
(
	[TownId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 22.11.2019 14:43:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Debt] ADD  CONSTRAINT [DF_Commission_IsPaid]  DEFAULT ((0)) FOR [IsPaidByTenant]
GO
ALTER TABLE [dbo].[Debt] ADD  CONSTRAINT [DF_Debt_ContractId]  DEFAULT ((0)) FOR [ContractId]
GO
ALTER TABLE [dbo].[Debt] ADD  CONSTRAINT [DF_Debt_IsPaidToLandlord]  DEFAULT ((0)) FOR [IsPaidToLandlord]
GO
ALTER TABLE [dbo].[Debt] ADD  CONSTRAINT [DF_Debt_IsCommission]  DEFAULT ((0)) FOR [IsCommission]
GO
ALTER TABLE [dbo].[CashBook]  WITH CHECK ADD  CONSTRAINT [FK_CashBook_Debt] FOREIGN KEY([DebtId])
REFERENCES [dbo].[Debt] ([DebtId])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[CashBook] CHECK CONSTRAINT [FK_CashBook_Debt]
GO
ALTER TABLE [dbo].[ContractParties]  WITH CHECK ADD  CONSTRAINT [FK_ContractParties_Contract] FOREIGN KEY([ContractId])
REFERENCES [dbo].[Contract] ([ContractId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ContractParties] CHECK CONSTRAINT [FK_ContractParties_Contract]
GO
ALTER TABLE [dbo].[ContractParties]  WITH CHECK ADD  CONSTRAINT [FK_ContractParties_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([PersonId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ContractParties] CHECK CONSTRAINT [FK_ContractParties_Person]
GO
ALTER TABLE [dbo].[Debt]  WITH CHECK ADD  CONSTRAINT [FK_Debt_Contract] FOREIGN KEY([ContractId])
REFERENCES [dbo].[Contract] ([ContractId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Debt] CHECK CONSTRAINT [FK_Debt_Contract]
GO
ALTER TABLE [dbo].[Realty]  WITH CHECK ADD  CONSTRAINT [FK_Realty_RealtyType] FOREIGN KEY([RealtyTypeId])
REFERENCES [dbo].[RealtyType] ([RealtyTypeId])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Realty] CHECK CONSTRAINT [FK_Realty_RealtyType]
GO
ALTER TABLE [dbo].[Town]  WITH CHECK ADD  CONSTRAINT [FK_Town_City] FOREIGN KEY([CityId])
REFERENCES [dbo].[City] ([CityId])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Town] CHECK CONSTRAINT [FK_Town_City]
GO
/****** Object:  StoredProcedure [dbo].[sp_getContracts]    Script Date: 22.11.2019 14:43:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_getContracts]
AS
BEGIN

SELECT
Contract.ContractId,
Contract.FileNumber,
(SELECT 
	ContractParties.PersonType + '=(' + Person.FullName + '=' + Person.Phone1 + ') ' FROM Person, ContractParties 
	WHERE 
		Contract.ContractId = ContractParties.ContractId AND
		ContractParties.PersonId = Person.PersonId AND 
		(ContractParties.PersonType = 'Kiracı' OR ContractParties.PersonType = 'Kefil')
	FOR XML PATH('')) [Kiracilar],
Contract.LandlordFullName,
Contract.LandlordPhone,
Contract.RealtyDefinition,
Contract.StartingDate,
Contract.EndingDate,
Contract.RentMoneyInMonth,
Contract.Tenancy,
Contract.Explanation
FROM Contract
WHERE Contract.EndingDate >= DATEADD(month, 1, getdate()) AND Contract.CancellationDate > getdate()
END

GO
/****** Object:  StoredProcedure [dbo].[sp_getDebtDetails]    Script Date: 22.11.2019 14:43:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_getDebtDetails]
	@DebtId int
AS
BEGIN
	Select
			Debt.DebtId,
			Debt.Definition, 
			Debt.Amount, 
			Debt.DueDate,
			Debt.PaymentDate,
			Debt.PaymentDateToLandlord,
			Debt.PaymentType,
			Debt.Explanation,
			Contract.LandlordFullName,
			Contract.LandlordPhone,
			Contract.RealtyDefinition,
			(SELECT 
	ContractParties.PersonType + '=(' + Person.FullName + '=' + Person.Phone1 + ') ' FROM Person, ContractParties 
	WHERE 
		Contract.ContractId = ContractParties.ContractId AND
		ContractParties.PersonId = Person.PersonId AND 
		(ContractParties.PersonType = 'Kiracı' OR ContractParties.PersonType = 'Kefil')
	FOR XML PATH('')) [Kiracilar],
			Debt.IsPaidByTenant,
			Debt.IsPaidToLandlord,
			Debt.IsCommission
	From  
		Debt 
			Inner Join Contract 
		On Debt.ContractId = Contract.ContractId 
			Inner Join ContractParties 
		On Contract.ContractId = ContractParties.ContractId 
			Inner Join Person 
		On Contractparties.PersonId = Person.PersonId
	WHERE Debt.DebtId=@DebtId
END

GO
/****** Object:  StoredProcedure [dbo].[sp_getDebtsToLandlord]    Script Date: 22.11.2019 14:43:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_getDebtsToLandlord]
AS
BEGIN
	SELECT
	Debt.DebtId,
	Contract.FileNumber,
	Debt.IsPaidToLandlord,
	Debt.DueDate,
	Debt.PaymentDate,
	substring((SELECT ', ' + Person.FullName FROM Person, ContractParties WHERE 
	ContractParties.PersonId = Person.PersonId AND Contract.ContractId = ContractParties.ContractId 
	AND ContractParties.PersonType='Kiracı' FOR XML PATH('')), 2, 1000)
	[Kiracilar],
	Contract.LandlordFullName,
	Contract.RealtyDefinition,
	Debt.Definition, 
	Debt.Amount, 
	Debt.Explanation,
	Contract.EndingDate
	FROM
	Debt INNER JOIN Contract ON Debt.ContractId = Contract.ContractId
	WHERE Debt.IsCommission=0 and Debt.IsPaidByTenant = 1 and Debt.IsPaidToLandlord = 0
END

GO
/****** Object:  StoredProcedure [dbo].[sp_getExpiredContracts]    Script Date: 22.11.2019 14:43:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_getExpiredContracts]
AS
BEGIN

SELECT
Contract.ContractId,
Contract.FileNumber,
(SELECT 
	ContractParties.PersonType + '=(' + Person.FullName + '=' + Person.Phone1 + ') ' FROM Person, ContractParties 
	WHERE 
		Contract.ContractId = ContractParties.ContractId AND
		ContractParties.PersonId = Person.PersonId AND 
		(ContractParties.PersonType = 'Kiracı' OR ContractParties.PersonType = 'Kefil')
	FOR XML PATH('')) [Kiracilar],
	
Contract.LandlordFullName,
Contract.LandlordPhone,
Contract.RealtyDefinition,
Contract.StartingDate,
Contract.EndingDate,
Contract.RentMoneyInMonth,
Contract.Tenancy,

Contract.Explanation
FROM Contract
WHERE Contract.EndingDate <= DATEADD(month, 1, getdate()) OR Contract.CancellationDate <= getdate()
END

GO
/****** Object:  StoredProcedure [dbo].[sp_getMonthlyRentalReport]    Script Date: 22.11.2019 14:43:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_getMonthlyRentalReport]
AS
BEGIN
	SELECT
	Debt.DebtId,
	Contract.FileNumber,
	Debt.IsCommission,
	Debt.DueDate,
	substring((SELECT ' - ' + Person.FullName + '=' + Person.Phone1 + '  ' FROM Person, ContractParties WHERE ContractParties.PersonId = Person.PersonId AND Contract.ContractId = ContractParties.ContractId AND ContractParties.PersonType='Kiracı' FOR XML PATH('')),3, 5000)
	[Kiracilar],
	Contract.RealtyDefinition,
	Debt.Definition, 
	Debt.Amount, 
	Debt.Explanation,
	Contract.EndingDate
	FROM
	Debt INNER JOIN Contract ON Debt.ContractId = Contract.ContractId
	WHERE (Debt.IsPaidByTenant = 0) AND Debt.DueDate<= dateadd(m, 1, getdate())  AND Debt.DueDate < Contract.CancellationDate
END


GO
/****** Object:  StoredProcedure [dbo].[sp_getMonthlyReport]    Script Date: 22.11.2019 14:43:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_getMonthlyReport]
	@Month int,
	@Year int
AS
BEGIN
	SELECT
	Debt.DebtId,
	Contract.FileNumber,
	Debt.IsPaidByTenant,
	Debt.DueDate,
	Debt.PaymentDate,
	SUBSTRING((SELECT ', ' + Person.FullName FROM Person, ContractParties WHERE 
	ContractParties.PersonId = Person.PersonId AND Contract.ContractId = ContractParties.ContractId 
	AND ContractParties.PersonType='Kiracı' FOR XML PATH('')), 2, 1000)
	[Kiracilar],
	Contract.RealtyDefinition,
	Debt.Definition, 
	Debt.Amount, 
	Debt.Explanation,
	Contract.EndingDate
	FROM
	Debt INNER JOIN Contract ON Debt.ContractId = Contract.ContractId
	WHERE MONTH(Debt.DueDate)=@Month AND YEAR(Debt.DueDate)=@Year AND Debt.DueDate < Contract.CancellationDate
END


GO
/****** Object:  StoredProcedure [dbo].[sp_getYearlyReport]    Script Date: 22.11.2019 14:43:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_getYearlyReport]
	@Year int
AS
BEGIN
	SELECT
	Debt.DebtId,
	Contract.FileNumber,
	Debt.IsPaidByTenant,
	Debt.DueDate,
	Debt.PaymentDate,
	SUBSTRING((SELECT ', ' + Person.FullName FROM Person, ContractParties WHERE 
	ContractParties.PersonId = Person.PersonId AND Contract.ContractId = ContractParties.ContractId 
	AND ContractParties.PersonType='Kiracı' FOR XML PATH('')), 2, 1000)
	[Kiracilar],
	Contract.RealtyDefinition,
	Debt.Definition, 
	Debt.Amount, 
	Debt.Explanation,
	Contract.EndingDate
	FROM
	Debt INNER JOIN Contract ON Debt.ContractId = Contract.ContractId
	WHERE YEAR(Debt.DueDate)=@Year  AND Debt.DueDate < Contract.CancellationDate
END

GO
/****** Object:  Trigger [dbo].[cashBookDelete]    Script Date: 22.11.2019 14:43:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[cashBookDelete]
ON [dbo].[Debt]
AFTER UPDATE
AS
BEGIN

	DECLARE @DebtId INT
	DECLARE @Action VARCHAR(50)


	SELECT @DebtId = inserted.DebtId FROM inserted




	DELETE FROM CashBook WHERE CashBook.DebtId = @DebtId
END
GO
ALTER TABLE [dbo].[Debt] ENABLE TRIGGER [cashBookDelete]
GO
