namespace AspireWithSentry.ApiService;

public static class CommandHelper
{
    public static readonly string CommandText = @"
USE tempdb;
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Todo')
BEGIN
    CREATE TABLE Todo
    (
        id INT PRIMARY KEY,
        description NVARCHAR(255)
    );
END
IF NOT EXISTS (SELECT * FROM Todo WHERE id = 1)
BEGIN
    INSERT INTO Todo VALUES (1, 'Fix this crazy bug');
END";    
}