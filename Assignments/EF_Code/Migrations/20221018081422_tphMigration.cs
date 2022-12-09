using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Code.Migrations
{
    public partial class tphMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialiazation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomAllocated = table.Column<int>(type: "int", nullable: true),
                    floor = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.StaffId);
                });

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
            migrationBuilder.DropTable(
                name: "Staffs");
        }
    }
}
