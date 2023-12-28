using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServicesManagement.Infrastructure.Migrations
{
    public partial class addpicturetoservice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Service",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Service");
        }
    }
}
