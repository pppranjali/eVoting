using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CS_EF_FirstCode.Migrations
{
    public partial class tphMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Nurses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wardboys",
                table: "Wardboys");

            migrationBuilder.DeleteData(
                table: "Wardboys",
                keyColumn: "StaffId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Wardboys",
                keyColumn: "StaffId",
                keyValue: 6);

            migrationBuilder.RenameTable(
                name: "Wardboys",
                newName: "Staffs");

            migrationBuilder.AlterColumn<int>(
                name: "floor",
                table: "Staffs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RoomAllocated",
                table: "Staffs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Specialiazation",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs",
                column: "StaffId");

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "StaffId", "Discriminator", "Name", "Salary", "Specialiazation" },
                values: new object[,]
                {
                    { 1, "Doctor", "Suresh", 9000, "Heart" },
                    { 2, "Doctor", "Om", 90, "Cancer" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "StaffId", "Discriminator", "Name", "RoomAllocated", "Salary" },
                values: new object[,]
                {
                    { 3, "Nurse", "deepika", 201, 988 },
                    { 4, "Nurse", "Alia", 403, 8766 }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "StaffId", "Discriminator", "Name", "Salary", "floor" },
                values: new object[,]
                {
                    { 5, "WardBoy", "Shree", 455, 201 },
                    { 6, "WardBoy", "Rakesh", 974, 403 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Staffs",
                table: "Staffs");

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "StaffId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "StaffId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "StaffId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "StaffId",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "RoomAllocated",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "Specialiazation",
                table: "Staffs");

            migrationBuilder.RenameTable(
                name: "Staffs",
                newName: "Wardboys");

            migrationBuilder.AlterColumn<int>(
                name: "floor",
                table: "Wardboys",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wardboys",
                table: "Wardboys",
                column: "StaffId");

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    Specialiazation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.StaffId);
                });

            migrationBuilder.CreateTable(
                name: "Nurses",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomAllocated = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurses", x => x.StaffId);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "StaffId", "Name", "Salary", "Specialiazation" },
                values: new object[,]
                {
                    { 1, "Suresh", 9000, "Heart" },
                    { 2, "Om", 90, "Cancer" }
                });

            migrationBuilder.InsertData(
                table: "Nurses",
                columns: new[] { "StaffId", "Name", "RoomAllocated", "Salary" },
                values: new object[,]
                {
                    { 3, "deepika", 201, 988 },
                    { 4, "Alia", 403, 8766 }
                });
        }
    }
}
