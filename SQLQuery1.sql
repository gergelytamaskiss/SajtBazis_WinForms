--create users table

CREATE TABLE [dbo].[Users] (
    [ID]           INT          IDENTITY (1, 1) NOT NULL,
    [username]     VARCHAR (50) NOT NULL,
    [password]     VARCHAR (6)  NOT NULL,
    [permission]   VARCHAR (20) NOT NULL,
    [email]        VARCHAR (50) NOT NULL,
    [date_created] DATETIME     DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

--create products table

CREATE TABLE [dbo].[Products] (
    [ID]          INT          IDENTITY (1, 1) NOT NULL,
    [part_number] VARCHAR (50) NOT NULL,
    [description] VARCHAR (50) NOT NULL,
    [brand]       VARCHAR (50) NOT NULL,
    [category]    VARCHAR (50) NOT NULL,
    [market]      VARCHAR (50) NOT NULL,
    [factory]     VARCHAR (50) NOT NULL,
    [type]        VARCHAR (50) NOT NULL,
    [bar_code]    BIGINT       NOT NULL,
    [width]       INT          NOT NULL,
    [heigth]      INT          NOT NULL,
    [length]      INT          NOT NULL,
    [pieces]      INT          NULL,
    [temperature] TINYINT      NOT NULL,
    [date_created]DATETIME     DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

--mass data upload (watch for destination)

BULK INSERT Products
FROM 'C:\Users\Kiss Gergely\Dropbox\CODE\SajtBazis\SajtBazis_Winfors\mdata_template.csv'
WITH
(
    FIRSTROW = 2,
    FIELDTERMINATOR = ';',
    --ROWTERMINATOR = '\n',
    TABLOCK
)