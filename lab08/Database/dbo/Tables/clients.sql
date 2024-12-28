CREATE TABLE [dbo].[clients] (
    [id]                INT            IDENTITY (1, 1) NOT NULL,
    [First_name]        NVARCHAR (255) NULL,
    [Last_name]         NVARCHAR (255) NULL,
    [Email]             NVARCHAR (255) NULL,
    [Phone]             NVARCHAR (255) NULL,
    [Registration_date] DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

