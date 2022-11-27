using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoEmailApplication.Migrations
{
    /// <inheritdoc />
    public partial class EmailNotificationRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
               name: "IX_Notifactions_EmailId",
               table: "Notifactions",
               column: "EmailId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
