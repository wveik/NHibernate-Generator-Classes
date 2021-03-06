declare @Scheme sysname = '%Scheme%'
declare @TableName sysname = '%TableName%'

SELECT
COL.COLUMN_NAME,
ORDINAL_POSITION,
DATA_TYPE,
CHARACTER_MAXIMUM_LENGTH,
NUMERIC_PRECISION,
NUMERIC_PRECISION_RADIX,
NUMERIC_SCALE,
DATETIME_PRECISION,
IS_NULLABLE,
CONSTRAINT_TYPE,
COLUMNPROPERTY(object_id(COL.TABLE_NAME), COL.COLUMN_NAME, 'IsIdentity') IS_IDENTITY,
COLUMNPROPERTY(object_id(COL.TABLE_NAME), COL.COLUMN_NAME, 'IsComputed') IS_COMPUTED,
COL.TABLE_NAME, 
COL.TABLE_SCHEMA
FROM INFORMATION_SCHEMA.COLUMNS COL 
LEFT OUTER JOIN 
(
    SELECT COLUMN_NAME, CONSTRAINT_TYPE , A.TABLE_NAME, A.TABLE_SCHEMA
    FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE A
    INNER JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS B 
    ON A.CONSTRAINT_NAME = B.CONSTRAINT_NAME
    WHERE A.TABLE_NAME = @TableName
	AND A.TABLE_SCHEMA= @Scheme
) CONS
ON COL.COLUMN_NAME = CONS.COLUMN_NAME
WHERE COL.TABLE_NAME = @TableName
AND COL.TABLE_SCHEMA= @Scheme
ORDER BY ORDINAL_POSITION