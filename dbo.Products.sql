CREATE TABLE [dbo].[Products] (
    [ID]          INT          IDENTITY (1, 1) NOT NULL,
    [part_number] INT          NOT NULL,
    [description] VARCHAR (50) NOT NULL,
    [brand]       VARCHAR (50) NOT NULL,
    [category]    VARCHAR (50) NOT NULL,
    [market]      VARCHAR (50) NOT NULL,
    [factory]     VARCHAR (50) NOT NULL,
    [type]        VARCHAR (50) NOT NULL,
    [bar_code]    INT          NOT NULL,
    [width]       INT          NOT NULL,
    [heigth]      INT          NOT NULL,
    [length]      INT          NOT NULL,
    [pieces]      INT          NOT NULL,
    [temperature] TINYINT      NOT NULL,
    [date_created]DATETIME     NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

