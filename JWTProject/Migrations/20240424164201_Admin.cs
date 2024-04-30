using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JWTProject.Migrations
{
    /// <inheritdoc />
    public partial class Admin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Role", "Username" },
                values: new object[] { 9999, new byte[] { 194, 95, 197, 191, 132, 192, 0, 168, 62, 255, 87, 141, 53, 147, 12, 244, 104, 135, 220, 2, 134, 21, 71, 226, 63, 87, 207, 137, 52, 156, 45, 67, 168, 2, 175, 18, 65, 117, 71, 167, 30, 113, 74, 93, 57, 61, 19, 236, 138, 65, 203, 252, 193, 66, 27, 122, 63, 158, 242, 244, 157, 248, 95, 9 }, new byte[] { 135, 171, 12, 160, 54, 181, 240, 33, 15, 49, 33, 119, 168, 107, 206, 124, 111, 40, 36, 87, 151, 211, 176, 150, 156, 106, 138, 223, 168, 234, 192, 244, 165, 127, 35, 17, 110, 207, 103, 107, 39, 20, 161, 6, 202, 180, 174, 55, 177, 139, 141, 215, 107, 32, 233, 153, 152, 202, 70, 73, 182, 201, 48, 218, 162, 128, 37, 120, 195, 70, 10, 3, 79, 217, 134, 126, 70, 254, 199, 100, 245, 200, 104, 116, 137, 141, 9, 171, 202, 103, 81, 89, 197, 107, 58, 118, 113, 66, 201, 2, 242, 245, 62, 34, 246, 169, 199, 154, 141, 107, 214, 56, 234, 232, 8, 177, 34, 150, 174, 219, 191, 239, 99, 107, 74, 178, 104, 166 }, "Admin", "Admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9999);
        }
    }
}
