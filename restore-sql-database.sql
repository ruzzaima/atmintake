RESTORE FILELISTONLY
FROM DISK = 'F:\temp\DBHRMISINTAKE_backup_2015_10_21_000001_5315832.bak'
GO

-- Step 2: Use the values in the LogicalName Column in following Step.
----Make Database to single user Mode
ALTER DATABASE DB_996412_intake2
SET SINGLE_USER WITH
ROLLBACK IMMEDIATE

----Restore Database
RESTORE DATABASE DB_996412_intake2
FROM DISK = 'F:\temp\DBHRMISINTAKE_backup_2015_10_21_000001_5315832.bak'
WITH MOVE 'DB_996412_intake_Data' TO 'H:\data\DBHRMISINTAKE.mdf',
MOVE 'DB_996412_intake_Log' TO 'H:\data\DBHRMISINTAKE.ldf'

/*If there is no error in statement before database will be in multiuser
mode.
If error occurs please execute following command it will convert
database in multi user.*/
ALTER DATABASE DB_996412_intake2 SET MULTI_USER
GO