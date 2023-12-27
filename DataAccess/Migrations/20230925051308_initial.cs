using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeDetails",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeePhone = table.Column<long>(type: "bigint", nullable: false),
                    EmployeeCompany = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeJoinDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeExperience = table.Column<decimal>(type: "numeric(4,2)", nullable: false),
                    EmployeeCareerLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeSkill = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OffShoreStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OffShoreEndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDetails", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.UserID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeDetails");

            migrationBuilder.DropTable(
                name: "UserDetails");
        }
    }
}
