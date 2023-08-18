using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.LeaveManagement.Identity.Migrations
{
    /// <inheritdoc />
    public partial class ChangedColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fcda1006-ea96-4ff8-862d-366a893156bb", "AQAAAAIAAYagAAAAEOVEfZVvj6COeDrfhJa8zx6ChZlTEnVSRk++LGj8fZAtKZOlgnGHnz2T+tAZGcAgNw==", "97feca6b-3b59-4a66-a9e8-31ffee3adaa8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b11d5d8f-0c80-4a5d-a420-8b90af1e3afa", "AQAAAAIAAYagAAAAEJxpzSRoa9WLeE/rXoKnsGwh2mV2ofP7HtSaVht5lfhtrXtAWn3I0CHVoSBI1Jsbcg==", "f8dbf97d-2689-4037-a804-152979a84592" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e7d9eaf-f7fc-4837-9672-e71801865497", "AQAAAAIAAYagAAAAEES5QKqRhr0PKwvHtcf9Xp2PkKqN0jVS0mevLzJP0hgkrE7Mian7stQCfN5tOlhk9A==", "017c7492-9182-4a95-b4cd-4e3972c27b68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9699b300-8006-4c03-9c94-2895bb230033", "AQAAAAIAAYagAAAAENZXitLk8vFPoIL0Ai+0z+0XADORmRa84mlRIv6LIqiHv5v1HdfPZOYhO75KQP2o1Q==", "1bcbfce1-e63b-4fb8-87a3-4d7a00730c60" });
        }
    }
}
