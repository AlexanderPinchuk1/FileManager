using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FileManager.Migrations
{
    /// <inheritdoc />
    public partial class AddSqlFunction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var getIntegerNumbersSumAndFloatNumbersMedianaFunction =
            @"CREATE FUNCTION [dbo].[GetIntegerNumbersSumAndFloatNumbersMediana]()
             RETURNS @returntable TABLE
             (
                 Result NVARCHAR(50)
             )
             AS
             BEGIN
                INSERT @returntable
                SELECT 
		            CAST(SUM(CAST([IntegerNumber] AS bigint)) AS NVARCHAR(50)) AS IntegerNumbersSum
	            FROM [dbo].[Data]
	            UNION
	            SELECT  
		            CAST(ROUND(PERCENTILE_CONT(0.5) 
		            WITHIN GROUP (ORDER BY [FloatNumber]) 
		            OVER (), 6) AS NVARCHAR(50)) AS FloatNumbersMediana
	            FROM [dbo].[Data] 
                AS RESULT
                RETURN
             END";

            migrationBuilder.Sql(getIntegerNumbersSumAndFloatNumbersMedianaFunction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
