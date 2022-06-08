using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Excitel.Data.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Lead",
                table: "Lead");

            migrationBuilder.RenameTable(
                name: "Lead",
                newName: "Leads");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Leads",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SubareaId",
                table: "Leads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Leads",
                table: "Leads",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Subareas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PINCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subareas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Subareas",
                columns: new[] { "Id", "Name", "PINCode" },
                values: new object[,]
                {
                    { 1, "Subarea name 1", 100000 },
                    { 2, "Subarea name 2", 200000 },
                    { 3, "Subarea name 3", 300000 },
                    { 4, "Subarea name 4", 400000 },
                    { 5, "Subarea name 5", 500000 },
                    { 6, "Subarea name 6", 600000 },
                    { 7, "Subarea name 7", 700000 },
                    { 8, "Subarea name 8", 800000 },
                    { 9, "Subarea name 9", 900000 },
                    { 10, "Subarea name 10", 1000000 },
                    { 11, "Subarea name 11", 1100000 },
                    { 12, "Subarea name 12", 1200000 },
                    { 13, "Subarea name 13", 1300000 },
                    { 14, "Subarea name 14", 1400000 },
                    { 15, "Subarea name 15", 1500000 },
                    { 16, "Subarea name 16", 1600000 },
                    { 17, "Subarea name 17", 1700000 },
                    { 18, "Subarea name 18", 1800000 },
                    { 19, "Subarea name 19", 1900000 },
                    { 20, "Subarea name 20", 2000000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Leads_SubareaId",
                table: "Leads",
                column: "SubareaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_Subareas_SubareaId",
                table: "Leads",
                column: "SubareaId",
                principalTable: "Subareas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leads_Subareas_SubareaId",
                table: "Leads");

            migrationBuilder.DropTable(
                name: "Subareas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Leads",
                table: "Leads");

            migrationBuilder.DropIndex(
                name: "IX_Leads_SubareaId",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "SubareaId",
                table: "Leads");

            migrationBuilder.RenameTable(
                name: "Leads",
                newName: "Lead");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lead",
                table: "Lead",
                column: "Id");
        }
    }
}
