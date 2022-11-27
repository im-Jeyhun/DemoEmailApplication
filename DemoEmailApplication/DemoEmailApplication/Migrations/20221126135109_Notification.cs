using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoEmailApplication.Migrations
{
    /// <inheritdoc />
    public partial class Notification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
              name: "Notifactions",
              columns: table => new
              {
                  Id = table.Column<int>(type: "int", nullable: false)
                      .Annotation("SqlServer:Identity", "1, 1"),
                  From = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                  EmailId = table.Column<int>(type: "int", nullable: false)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_Notifactions", x => x.Id);
                  table.ForeignKey(
                      name: "FK_Notifactions_Emails_EmailId",
                      column: x => x.EmailId,
                      principalTable: "Emails",
                      principalColumn: "Id",
                      onDelete: ReferentialAction.Cascade);
              });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
              name: "Notifactions");
        }
    }
}
