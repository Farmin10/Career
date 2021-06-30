using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace career.DAL.Migrations
{
    public partial class sEEdATA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departmants",
                columns: table => new
                {
                    DepartmantId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ParentDepartmantId = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmants", x => x.DepartmantId);
                    table.ForeignKey(
                        name: "FK_Departmants_Departmants_ParentDepartmantId",
                        column: x => x.ParentDepartmantId,
                        principalTable: "Departmants",
                        principalColumn: "DepartmantId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "VacancyTypes",
                columns: table => new
                {
                    VacancyTypeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Key = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacancyTypes", x => x.VacancyTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    PositionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DepartmantId = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.PositionId);
                    table.ForeignKey(
                        name: "FK_Positions_Departmants_DepartmantId",
                        column: x => x.DepartmantId,
                        principalTable: "Departmants",
                        principalColumn: "DepartmantId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vacancies",
                columns: table => new
                {
                    VacancyId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VacancyTypeId = table.Column<int>(type: "integer", nullable: false),
                    VacancyHeader = table.Column<string>(type: "text", nullable: true),
                    WorkLocation = table.Column<string>(type: "text", nullable: true),
                    RequiredExperience = table.Column<string>(type: "text", nullable: true),
                    Education = table.Column<string>(type: "text", nullable: true),
                    RelativePerson = table.Column<string>(type: "text", nullable: true),
                    MinimumAgeLimit = table.Column<int>(type: "integer", nullable: false),
                    MaximumAgeLimit = table.Column<int>(type: "integer", nullable: false),
                    VacancyStartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    VacancyEndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacancies", x => x.VacancyId);
                    table.ForeignKey(
                        name: "FK_Vacancies_VacancyTypes_VacancyTypeId",
                        column: x => x.VacancyTypeId,
                        principalTable: "VacancyTypes",
                        principalColumn: "VacancyTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SurName = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    DepartmantId = table.Column<int>(type: "integer", nullable: true),
                    PositionId = table.Column<int>(type: "integer", nullable: false),
                    Pin = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Departmants_DepartmantId",
                        column: x => x.DepartmantId,
                        principalTable: "Departmants",
                        principalColumn: "DepartmantId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "PositionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VacancyInformation",
                columns: table => new
                {
                    VacancyInfoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VacancyId = table.Column<int>(type: "integer", nullable: false),
                    VacancyInfoLabel = table.Column<string>(type: "text", nullable: true),
                    VacancyInfoValue = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacancyInformation", x => x.VacancyInfoId);
                    table.ForeignKey(
                        name: "FK_VacancyInformation_Vacancies_VacancyId",
                        column: x => x.VacancyId,
                        principalTable: "Vacancies",
                        principalColumn: "VacancyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VacancyRequirements",
                columns: table => new
                {
                    VacancyRequirementId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VacancyId = table.Column<int>(type: "integer", nullable: false),
                    RequirementPunct = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacancyRequirements", x => x.VacancyRequirementId);
                    table.ForeignKey(
                        name: "FK_VacancyRequirements_Vacancies_VacancyId",
                        column: x => x.VacancyId,
                        principalTable: "Vacancies",
                        principalColumn: "VacancyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departmants",
                columns: new[] { "DepartmantId", "IsDeleted", "Name", "ParentDepartmantId" },
                values: new object[,]
                {
                    { 10, false, "Layihələndirmə", null },
                    { 11, false, "Proqram təminatının hazırlanması", null },
                    { 12, false, "Ümumi ", null },
                    { 13, false, "Verilənlər bazasının idarə edilməsi və şəbəkə inzibatçılığı", null },
                    { 14, false, "Maliyyə", null }
                });

            migrationBuilder.InsertData(
                table: "VacancyTypes",
                columns: new[] { "VacancyTypeId", "IsDeleted", "Key", "Name" },
                values: new object[,]
                {
                    { 1, false, "intern", "Təcrübə proqramı" },
                    { 2, false, "work", "İş vakansiyası" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "PositionId", "DepartmantId", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 15, 10, false, "Şöbə müdiri" },
                    { 10, 11, false, "Kiçik mütəxəssis" },
                    { 11, 12, false, "Mütəxəssis" },
                    { 13, 12, false, "Baş mütəxəssis" },
                    { 12, 13, false, "Apararıcı mütəxəssis" },
                    { 17, 13, false, "Direktor" },
                    { 14, 14, false, "Sektor müdiri" },
                    { 16, 14, false, "Direktor müavini" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departmants_ParentDepartmantId",
                table: "Departmants",
                column: "ParentDepartmantId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmantId",
                table: "Employees",
                column: "DepartmantId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PositionId",
                table: "Employees",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_DepartmantId",
                table: "Positions",
                column: "DepartmantId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_VacancyTypeId",
                table: "Vacancies",
                column: "VacancyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VacancyInformation_VacancyId",
                table: "VacancyInformation",
                column: "VacancyId");

            migrationBuilder.CreateIndex(
                name: "IX_VacancyRequirements_VacancyId",
                table: "VacancyRequirements",
                column: "VacancyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "VacancyInformation");

            migrationBuilder.DropTable(
                name: "VacancyRequirements");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Vacancies");

            migrationBuilder.DropTable(
                name: "Departmants");

            migrationBuilder.DropTable(
                name: "VacancyTypes");
        }
    }
}
