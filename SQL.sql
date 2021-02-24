/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[FromAccount]
      ,[ToAccount]
      ,[TransferAmount]
  FROM [TransferDB].[dbo].[TransferLogs]


  USE [TransferDB]
GO

--INSERT INTO [dbo].[TransferLogs]
--           ([FromAccount]
--           ,[ToAccount]
--           ,[TransferAmount])
--     VALUES
--           (1
--           ,2,
--           '5.10')

--	INSERT INTO [dbo].[TransferLogs]
--           ([FromAccount]
--           ,[ToAccount]
--           ,[TransferAmount])
--     VALUES
--           (2
--           ,1,
--           '15.20')
--GO

