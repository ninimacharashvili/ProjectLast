using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectLast.Migrations
{
    /// <inheritdoc />
    public partial class Newmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookedDates_Rooms_RoomId",
                table: "BookedDates");

            migrationBuilder.DropColumn(
                name: "Available",
                table: "Rooms");

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "BookedDates",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "RoomTypeId",
                table: "BookedDates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_BookedDates_Rooms_RoomId",
                table: "BookedDates",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookedDates_Rooms_RoomId",
                table: "BookedDates");

            migrationBuilder.DropColumn(
                name: "RoomTypeId",
                table: "BookedDates");

            migrationBuilder.AddColumn<bool>(
                name: "Available",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "BookedDates",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BookedDates_Rooms_RoomId",
                table: "BookedDates",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
