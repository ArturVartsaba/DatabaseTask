using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChildAbsence",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildAbsence", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChildGroupHistory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildGroupHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Morning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MorningSnack = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lunch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DinnerSnack = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dinner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateFood = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Portions = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Queue",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Queue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PositionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Position_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Child",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChildAbsenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChildGroupHistoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    QueueId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Child", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Child_ChildAbsence_ChildAbsenceId",
                        column: x => x.ChildAbsenceId,
                        principalTable: "ChildAbsence",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Child_ChildGroupHistory_ChildGroupHistoryId",
                        column: x => x.ChildGroupHistoryId,
                        principalTable: "ChildGroupHistory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Child_Queue_QueueId",
                        column: x => x.QueueId,
                        principalTable: "Queue",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChildCount = table.Column<int>(type: "int", nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomNr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChildAbsenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChildGroupHistoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChildId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    QueueId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Group_ChildAbsence_ChildAbsenceId",
                        column: x => x.ChildAbsenceId,
                        principalTable: "ChildAbsence",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Group_ChildGroupHistory_ChildGroupHistoryId",
                        column: x => x.ChildGroupHistoryId,
                        principalTable: "ChildGroupHistory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Group_Child_ChildId",
                        column: x => x.ChildId,
                        principalTable: "Child",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Group_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Group_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Group_Queue_QueueId",
                        column: x => x.QueueId,
                        principalTable: "Queue",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Child_ChildAbsenceId",
                table: "Child",
                column: "ChildAbsenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Child_ChildGroupHistoryId",
                table: "Child",
                column: "ChildGroupHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Child_QueueId",
                table: "Child",
                column: "QueueId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_ChildAbsenceId",
                table: "Group",
                column: "ChildAbsenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_ChildGroupHistoryId",
                table: "Group",
                column: "ChildGroupHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_ChildId",
                table: "Group",
                column: "ChildId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_EmployeeId",
                table: "Group",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_MenuId",
                table: "Group",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_QueueId",
                table: "Group",
                column: "QueueId");

            migrationBuilder.CreateIndex(
                name: "IX_Position_EmployeeId",
                table: "Position",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Child");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "ChildAbsence");

            migrationBuilder.DropTable(
                name: "ChildGroupHistory");

            migrationBuilder.DropTable(
                name: "Queue");
        }
    }
}
