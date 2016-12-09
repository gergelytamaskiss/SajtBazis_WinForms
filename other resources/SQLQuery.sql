--create users table

CREATE TABLE [dbo].[Users] (
    [username]   VARCHAR (30) NOT NULL,
    [password]   VARCHAR (6)  NOT NULL,
    [name]       VARCHAR (50) NOT NULL,
    [permission] INT          NOT NULL,
    [email]      VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([username] ASC)
);

--create products table

CREATE TABLE [dbo].[Products] (
    [part_number] INT          NOT NULL,
    [description] VARCHAR (50) NOT NULL,
    [brand]       INT          NOT NULL,
    [market]      INT          NOT NULL,
    [factory]     INT          NOT NULL,
    [type]        INT          NOT NULL,
    [bar_code]    INT          NOT NULL,
    [width]       INT          NOT NULL,
    [heigth]      INT          NOT NULL,
    [length]      INT          NOT NULL,
    [pieces]      INT          NOT NULL,
    [temperature] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([part_number] ASC)
);



--mass data upload (watch for destination)

BULK INSERT Products
FROM '(...)\products_template.csv'
WITH
(
    FIRSTROW = 1,
    FIELDTERMINATOR = ';',
    TABLOCK
)
