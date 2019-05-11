using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace course_management_backend.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 255, nullable: false),
                    LastName = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Credits = table.Column<int>(nullable: false),
                    NumberOfLecturesPerTerm = table.Column<int>(nullable: true),
                    NumberOfSeminarsPerTerm = table.Column<int>(nullable: true),
                    AvailableOnTerm = table.Column<int>(nullable: true),
                    Description = table.Column<string>(maxLength: 1000, nullable: false),
                    RequirementsFromStudents = table.Column<string>(maxLength: 1000, nullable: false),
                    TypeOfExam = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<Guid>(nullable: false),
                    ResponsibleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Course_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Course_User_ResponsibleId",
                        column: x => x.ResponsibleId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("7c9d3333-5cc0-43f5-aa21-728866a2ee27"), "Comparative and Institutional Economics" },
                    { new Guid("68e51555-e380-4480-a5dc-6a2e02a7dcdd"), "Macroeconomics" },
                    { new Guid("8ab9328e-8907-468e-b645-216e2a022ee7"), "Microeconomics" },
                    { new Guid("6c37a919-2594-46a0-be86-846335a29cc1"), "Labour Economis" },
                    { new Guid("daf07f8b-99ce-42ee-a1d5-b04d67ddebcc"), "Finance" },
                    { new Guid("3dee701c-1b3f-4c7f-8bb1-61bd5e0eb4c9"), "Mathematics" },
                    { new Guid("a8e1df92-033e-4982-8d22-868a16639fb8"), "Statistics" },
                    { new Guid("c1822dd1-1e85-4aa0-ae2b-ec7c21333fe5"), "Economic Policy" },
                    { new Guid("bb8e5865-ef25-429e-b3ae-d722b0578387"), "Mathematical Economics and Economic Analysis" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("bed2bdfc-4178-44df-af46-48130ea87ae8"), "Ethel", "Stebbins" },
                    { new Guid("d9e10ed8-39ef-4af5-a634-6ed947e57c86"), "John", "Haas" },
                    { new Guid("c9a4875b-1683-421b-9368-02a62a74794a"), "Patrick", "Smith" },
                    { new Guid("5e8d97f6-d9f6-46e7-970c-4e3b34e60d40"), "Jennifer", "Spahr" },
                    { new Guid("16d3ffe1-fda0-4cb4-840a-ed3995b3c5f5"), "Howard", "Clay" },
                    { new Guid("6dbc0233-38d4-448b-94c8-11cc1fd4f06b"), "Anthony", "Grayer" },
                    { new Guid("cea5bd97-667a-427b-8199-60bf6f9518a6"), "Dave", "Cuellar" },
                    { new Guid("54874529-e36d-495c-8735-87d1c7cdf7a4"), "Michelle", "Reed" },
                    { new Guid("70afba3f-a19f-45b6-b121-356472de7efb"), "Jean", "Ashford" },
                    { new Guid("4972a9da-f532-4e6b-9b36-e845f63f6cd1"), "Henry", "Arredondo" },
                    { new Guid("16dc743a-727a-4f2f-bb1e-d500f949ca8d"), "Brian", "Smith" },
                    { new Guid("5dc84764-ed2e-4426-8296-2445948dc8ee"), "Frances", "Bouie" },
                    { new Guid("9ee180e4-ee42-40c1-8f8b-dd6f95136108"), "Roseann", "Hammel" }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "AvailableOnTerm", "Credits", "DepartmentId", "Description", "Name", "NumberOfLecturesPerTerm", "NumberOfSeminarsPerTerm", "RequirementsFromStudents", "ResponsibleId", "TypeOfExam" },
                values: new object[] { new Guid("46be3c38-b724-4839-b2bf-f09546964bad"), 1, 5, new Guid("7c9d3333-5cc0-43f5-aa21-728866a2ee27"), "Lorem ipsum of desc", "Course 1", 12, 12, "Lorem ipsum of requirements", new Guid("16dc743a-727a-4f2f-bb1e-d500f949ca8d"), 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Course_DepartmentId",
                table: "Course",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_ResponsibleId",
                table: "Course",
                column: "ResponsibleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
