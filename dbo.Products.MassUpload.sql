BULK INSERT Products
FROM 'C:\Users\Kiss Gergely\Dropbox\CODE\SajtBazis\data_template.csv'
WITH
(
    FIRSTROW = 2,
    FIELDTERMINATOR = ';',  --CSV field delimiter
    --ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
)