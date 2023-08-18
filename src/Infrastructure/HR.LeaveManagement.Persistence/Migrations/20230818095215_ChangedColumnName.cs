using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.LeaveManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ChangedColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateActioned",
                table: "LeaveRequests");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "LeaveTypes",
                newName: "DateModified");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "LeaveRequests",
                newName: "DateModified");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "LeaveAllocations",
                newName: "DateModified");

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 8, 18, 14, 52, 15, 250, DateTimeKind.Local).AddTicks(8552), new DateTime(2023, 8, 18, 14, 52, 15, 250, DateTimeKind.Local).AddTicks(8600) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateModified",
                table: "LeaveTypes",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "DateModified",
                table: "LeaveRequests",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "DateModified",
                table: "LeaveAllocations",
                newName: "LastModifiedDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateActioned",
                table: "LeaveRequests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 15, 17, 32, 2, 423, DateTimeKind.Local).AddTicks(778), new DateTime(2023, 8, 15, 17, 32, 2, 423, DateTimeKind.Local).AddTicks(829) });
        }
    }
}
