using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MudBlazorWASM.Server.Migrations
{
    public partial class NewInitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthdate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FathersName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MothersName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Religion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LecUnits = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LabUnits = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotUnits = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreRequisite = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SummaryGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    DEPTNO = table.Column<int>(type: "int", nullable: true),
                    OFFERNO = table.Column<int>(type: "int", nullable: false),
                    COURSENO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    STUDNO = table.Column<int>(type: "int", nullable: false),
                    LAST = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    FIRST = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    MI = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TERM1 = table.Column<double>(type: "float", nullable: true),
                    TERM2 = table.Column<double>(type: "float", nullable: true),
                    TERM3 = table.Column<double>(type: "float", nullable: true),
                    TERM4 = table.Column<double>(type: "float", nullable: true),
                    AVERAGE = table.Column<double>(type: "float", nullable: true),
                    SUBJECT = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SummaryGrades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubjectCodeId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfferNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotUnits = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Semester = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EGrades_Subjects_SubjectCodeId",
                        column: x => x.SubjectCodeId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EGrades_DepartmentsId",
                table: "EGrades",
                column: "DepartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_EGrades_SubjectCodeId",
                table: "EGrades",
                column: "SubjectCodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EGrades");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "SummaryGrades");

            migrationBuilder.DropTable(
                name: "Subjects");
        }
    }
}
