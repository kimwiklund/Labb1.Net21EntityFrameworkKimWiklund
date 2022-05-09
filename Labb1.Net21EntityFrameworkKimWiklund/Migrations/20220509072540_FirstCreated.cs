using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb1.Net21EntityFrameworkKimWiklund.Migrations
{
    public partial class FirstCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 25, nullable: false),
                    LastName = table.Column<string>(maxLength: 25, nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Leaves",
                columns: table => new
                {
                    LeaveId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reason = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    FEmployeeId = table.Column<int>(nullable: false),
                    RegistrationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leaves", x => x.LeaveId);
                    table.ForeignKey(
                        name: "FK_Leaves_Employees_FEmployeeId",
                        column: x => x.FEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "FirstName", "Gender", "LastName" },
                values: new object[,]
                {
                    { 1, 22, "Amanda", "F", "Westman" },
                    { 2, 28, "Sebastian", "M", "Skalare" },
                    { 3, 30, "Kim", "M", "Wiklund" },
                    { 4, 49, "Pelle", "M", "Westman" },
                    { 5, 27, "Sara", "F", "Bodin" },
                    { 6, 42, "Helene", "F", "Andersson" },
                    { 7, 32, "Linnea", "F", "Häggkvist" }
                });

            migrationBuilder.InsertData(
                table: "Leaves",
                columns: new[] { "LeaveId", "EndDate", "FEmployeeId", "Reason", "RegistrationTime", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Sick", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vacation", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2022, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Sick", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Vacation", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Vab", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2022, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Unpaid", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Vacation", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2022, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Vab", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2022, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "sick", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Leaves_FEmployeeId",
                table: "Leaves",
                column: "FEmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leaves");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
