using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Modul4HW5.Migrations
{
    public partial class SetData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DataOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "Office",
                columns: table => new
                {
                    OfficeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Office", x => x.OfficeId);
                });

            migrationBuilder.CreateTable(
                name: "Title",
                columns: table => new
                {
                    TitleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Title", x => x.TitleId);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Project = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BudGet = table.Column<decimal>(type: "money", nullable: false),
                    StartedDate = table.Column<DateTime>(type: "datetime2", maxLength: 7, nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Project);
                    table.ForeignKey(
                        name: "FK_Project_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HiredData = table.Column<DateTime>(type: "datetime2", maxLength: 7, nullable: false),
                    DataOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OfficeId = table.Column<int>(type: "int", nullable: false),
                    TitleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employee_Office_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Office",
                        principalColumn: "OfficeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Title_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Title",
                        principalColumn: "TitleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProject",
                columns: table => new
                {
                    EmployeeProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rate = table.Column<decimal>(type: "money", nullable: false),
                    StartedDate = table.Column<DateTime>(type: "datetime2", maxLength: 7, nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProject", x => x.EmployeeProjectId);
                    table.ForeignKey(
                        name: "FK_EmployeeProject_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProject_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Project",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientId", "DataOfBirth", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(1998, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan", "Ivanov", "+380669785233" },
                    { 2, new DateTime(1999, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Max", "Lisov", "+380986399555" },
                    { 3, new DateTime(1988, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Den", "Frolov", "+380669558636" },
                    { 4, new DateTime(1960, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Egor", "Demchuk", "+380988884659" },
                    { 5, new DateTime(1996, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vovan", "Romashov", "+380998696369" }
                });

            migrationBuilder.InsertData(
                table: "Office",
                columns: new[] { "OfficeId", "Location", "Title" },
                values: new object[,]
                {
                    { 1, "London", "nz" },
                    { 2, "Germany", "nz" },
                    { 3, "Ukraine", "nz" },
                    { 4, "Poland", "nz" },
                    { 5, "Uganda", "nz" }
                });

            migrationBuilder.InsertData(
                table: "Title",
                columns: new[] { "TitleId", "Name" },
                values: new object[,]
                {
                    { 1, "name1" },
                    { 2, "name2" },
                    { 3, "name3" },
                    { 4, "name4" },
                    { 5, "name5" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "DataOfBirth", "FirstName", "HiredData", "LastName", "OfficeId", "TitleId" },
                values: new object[,]
                {
                    { 1, new DateTime(1998, 10, 5, 5, 5, 5, 0, DateTimeKind.Unspecified), "Karl", new DateTime(2005, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Demidovich", 1, 1 },
                    { 5, new DateTime(2003, 10, 5, 5, 5, 5, 0, DateTimeKind.Unspecified), "Lutik", new DateTime(2005, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yatcuk", 3, 1 },
                    { 4, new DateTime(1998, 10, 5, 5, 5, 5, 0, DateTimeKind.Unspecified), "Boria", new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pirogov", 5, 2 },
                    { 2, new DateTime(2007, 10, 5, 5, 5, 5, 0, DateTimeKind.Unspecified), "Max", new DateTime(2005, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perkov", 2, 3 },
                    { 3, new DateTime(1998, 8, 1, 5, 5, 5, 0, DateTimeKind.Unspecified), "Olha", new DateTime(2035, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Applovna", 4, 5 }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Project", "BudGet", "ClientId", "Name", "StartedDate" },
                values: new object[,]
                {
                    { 1, 1998.5m, 1, "text1", new DateTime(2005, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 100.12m, 2, "text2", new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2005.8m, 3, "text3", new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 15.3m, 4, "text4", new DateTime(2032, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 200.0m, 5, "text5", new DateTime(2005, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "EmployeeProject",
                columns: new[] { "EmployeeProjectId", "EmployeeId", "ProjectId", "Rate", "StartedDate" },
                values: new object[,]
                {
                    { 1, 1, 1, 5m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, 5, 5m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, 4, 4m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 2, 2m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 3, 3m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_OfficeId",
                table: "Employee",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_TitleId",
                table: "Employee",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProject_EmployeeId",
                table: "EmployeeProject",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProject_ProjectId",
                table: "EmployeeProject",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ClientId",
                table: "Project",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeProject");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Office");

            migrationBuilder.DropTable(
                name: "Title");

            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
