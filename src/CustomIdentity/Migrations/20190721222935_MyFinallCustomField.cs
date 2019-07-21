using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomIdentity.Migrations
{
    public partial class MyFinallCustomField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordTip",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "PasswordTip",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "User");
        }
    }
}
