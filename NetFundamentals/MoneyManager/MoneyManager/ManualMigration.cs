using Microsoft.EntityFrameworkCore.Migrations;

namespace MoneyManager;

public class ManualMigration : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<int>(
            name: "Color",
            table: "Categories",
            type: "int",
            nullable: false,
            defaultValue: 0x233D4D); 
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "Color",
            table: "Categories");
    }
}
