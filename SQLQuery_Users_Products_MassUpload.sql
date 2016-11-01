--create users table

CREATE TABLE [dbo].[Users] (
    [ID]           INT          IDENTITY (1, 1) NOT NULL,
    [username]     VARCHAR (50) NOT NULL,
    [password]     VARCHAR (6)  NOT NULL,
    [permission]   INT NOT NULL,
    [email]        VARCHAR (50) NOT NULL,
    [date_created] DATETIME     DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
)

--create products table

CREATE TABLE [dbo].[Products] (
    [ID]           INT          IDENTITY (1, 1) NOT NULL,
    [part_number]  VARCHAR (50) NOT NULL,
    [description]  VARCHAR (50) NOT NULL,
    [brand]        INT NOT NULL,
    [category]     INT NOT NULL,
    [market]       INT NOT NULL,
    [factory]      INT NOT NULL,
    [type]         INT NOT NULL,
    [bar_code]     INT NOT NULL,
    [width]        INT NOT NULL,
    [heigth]       INT NOT NULL,
    [length]       INT NOT NULL,
    [pieces]       INT NOT NULL,
    [temperature]  INT NOT NULL,
    [date_created] DATETIME     DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

--mass data upload (watch for destination)

BULK INSERT Products
FROM 'C:\Users\Gergo\Dropbox\CODE\SajtBazis\SajtBazis_WinForms\data_template.csv'
WITH
(
    FIRSTROW = 2,
    FIELDTERMINATOR = ';',
    TABLOCK
)
