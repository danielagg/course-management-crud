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
                    AvailableOnTerm = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: false),
                    RequirementsFromStudents = table.Column<string>(maxLength: 1000, nullable: false),
                    TypeOfExam = table.Column<string>(type: "nvarchar(30)", nullable: false),
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
                    { new Guid("d5f07405-88ce-404a-9c61-c5f8ffed44f6"), "Macroeconomics" },
                    { new Guid("4cfe6f2d-7d16-43f9-93fc-13baa48daf84"), "Microeconomics" },
                    { new Guid("35f72a53-8af7-4dc8-ab1e-34199f034760"), "Labour Economis" },
                    { new Guid("2268dc0b-9efc-43f0-938a-2e2bb8e643b1"), "Finance" },
                    { new Guid("6cd8dd10-6564-4d40-8dc5-316c5e02637c"), "Mathematics" },
                    { new Guid("0a3e1694-b9b8-4407-87f4-328925322d17"), "Statistics" },
                    { new Guid("2f27da3b-f0a8-4ff6-a954-2818e129aecd"), "Economic Policy" },
                    { new Guid("c8fcac1e-8fa1-4745-8fa7-03f9d78feaf6"), "Mathematical Economics and Economic Analysis" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("ed0aac76-e847-4076-8be6-fcddc25a8990"), "Ethel", "Stebbins" },
                    { new Guid("5a3cb214-9e88-4e65-87be-f1d4b93fd20b"), "John", "Haas" },
                    { new Guid("1e989519-83db-46b7-99e7-fdf5e7487d88"), "Patrick", "Smith" },
                    { new Guid("1428ddec-d8f9-47b3-892b-16fa2bd0c0d3"), "Jennifer", "Spahr" },
                    { new Guid("f75c4ec9-9ad4-4a04-94d5-0237b9839f2a"), "Howard", "Clay" },
                    { new Guid("5f7c7199-7012-429d-a744-5a290a32e16b"), "Anthony", "Grayer" },
                    { new Guid("2ee707ea-0234-4ea1-9119-1c2e91f7aeeb"), "Dave", "Cuellar" },
                    { new Guid("3e037a6e-f02b-453b-baa6-c2c25e6b2ba3"), "Michelle", "Reed" },
                    { new Guid("94412180-729e-41c0-abac-b9e5df24aec8"), "Jean", "Ashford" },
                    { new Guid("7123e10a-0b9c-4225-87dd-44b67d8b17ea"), "Henry", "Arredondo" },
                    { new Guid("16dc743a-727a-4f2f-bb1e-d500f949ca8d"), "Brian", "Smith" },
                    { new Guid("08bdfec6-b2c3-4e3a-b9fa-37bb817daaf1"), "Frances", "Bouie" },
                    { new Guid("7ba3c2d6-75ab-4e66-8b92-7578ecbc07cd"), "Roseann", "Hammel" }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "AvailableOnTerm", "Credits", "DepartmentId", "Description", "Name", "NumberOfLecturesPerTerm", "NumberOfSeminarsPerTerm", "RequirementsFromStudents", "ResponsibleId", "TypeOfExam" },
                values: new object[] { new Guid("73a11a80-ba3d-4a76-ad43-9d86ffc76bf6"), "Fall", 5, new Guid("7c9d3333-5cc0-43f5-aa21-728866a2ee27"), "Lorem ipsum of desc", "Course 1", 12, 12, "Lorem ipsum of requirements", new Guid("16dc743a-727a-4f2f-bb1e-d500f949ca8d"), "WrittenExam" });

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
