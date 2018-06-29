declare @Scheme sysname = '%Scheme%'
declare @TableName sysname = '%TableName%'
declare @TableNameMap varchar(max)
set @TableNameMap = @TableName + 'Map'
declare @Result varchar(max) = 'public class ' + UPPER(LEFT(@TableName,1))+LOWER(SUBSTRING(@TableName,2,LEN(@TableName))) + ' : ClassMap<' + UPPER(LEFT(@TableName,1))+LOWER(SUBSTRING(@TableName,2,LEN(@TableName))) +  '>' + '
{'

+ ' 
public ' + UPPER(LEFT(@TableName,1))+LOWER(SUBSTRING(@TableName,2,LEN(@TableName))) + '() {' +

''

select @Result = @Result + '
    Map(x => x.' + ColumnName + ').Column("' + ColumnName + '");
'
from
(
    select 
        replace(col.name, ' ', '_') ColumnName,
        column_id ColumnId,
        case typ.name 
            when 'bigint' then 'long'
            when 'binary' then 'byte[]'
            when 'bit' then 'bool'
            when 'char' then 'string'
            when 'date' then 'DateTime'
            when 'datetime' then 'DateTime'
            when 'datetime2' then 'DateTime'
            when 'datetimeoffset' then 'DateTimeOffset'
            when 'decimal' then 'decimal'
            when 'float' then 'float'
            when 'image' then 'byte[]'
            when 'int' then 'int'
            when 'money' then 'decimal'
            when 'nchar' then 'string'
            when 'ntext' then 'string'
            when 'numeric' then 'decimal'
            when 'nvarchar' then 'string'
            when 'real' then 'double'
            when 'smalldatetime' then 'DateTime'
            when 'smallint' then 'short'
            when 'smallmoney' then 'decimal'
            when 'text' then 'string'
            when 'time' then 'TimeSpan'
            when 'timestamp' then 'DateTime'
            when 'tinyint' then 'byte'
            when 'uniqueidentifier' then 'Guid'
            when 'varbinary' then 'byte[]'
            when 'varchar' then 'string'
            else 'UNKNOWN_' + typ.name
        end ColumnType,
        case 
            when col.is_nullable = 1 and typ.name in ('bigint', 'bit', 'date', 'datetime', 'datetime2', 'datetimeoffset', 'decimal', 'float', 'int', 'money', 'numeric', 'real', 'smalldatetime', 'smallint', 'smallmoney', 'time', 'tinyint', 'uniqueidentifier') 
            then '?' 
            else '' 
        end NullableSign
    from sys.columns col
        join sys.types typ on
            col.system_type_id = typ.system_type_id AND col.user_type_id = typ.user_type_id
    where object_id = object_id(@Scheme+'.'+@TableName)
) t
--order by ColumnId

set @Result = @Result + '    Table("' + @TableName + '");
'
set @Result = @Result + '    Schema("' + @Scheme + '");'

set @Result = @Result  + '
}' +
'
}
/*Id(x => x.Id)
				.Column("carddetailid")
				.GeneratedBy.Identity();*/
'

select @Result