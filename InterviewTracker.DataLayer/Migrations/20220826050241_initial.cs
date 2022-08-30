using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewTracker.DataLayer.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    ReportingTo = table.Column<string>(nullable: false),
                    UserTypes = table.Column<int>(nullable: false),
                    Stat = table.Column<int>(nullable: false),
                    MobileNumber = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Interviews",
                columns: table => new
                {
                    InterviewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterviewName = table.Column<string>(maxLength: 50, nullable: false),
                    Interviewer = table.Column<string>(nullable: false),
                    InterviewUser = table.Column<string>(nullable: false),
                    UserSkills = table.Column<string>(nullable: false),
                    InterviewDate = table.Column<DateTime>(nullable: false),
                    InterviewTime = table.Column<DateTime>(nullable: false),
                    InterViewsStatus = table.Column<int>(nullable: false),
                    TInterViews = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    ApplicationUsersUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interviews", x => x.InterviewId);
                    table.ForeignKey(
                        name: "FK_Interviews_ApplicationUsers_ApplicationUsersUserId",
                        column: x => x.ApplicationUsersUserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_ApplicationUsersUserId",
                table: "Interviews",
                column: "ApplicationUsersUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Interviews");

            migrationBuilder.DropTable(
                name: "ApplicationUsers");
        }
    }
}
