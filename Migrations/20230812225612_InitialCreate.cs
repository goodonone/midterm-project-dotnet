using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace midterm_project.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    PetId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PetSpecies = table.Column<string>(type: "TEXT", nullable: false),
                    PhotoUrl = table.Column<string>(type: "TEXT", nullable: false),
                    PetDescription = table.Column<string>(type: "TEXT", nullable: false),
                    Spayed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PetAge = table.Column<int>(type: "INTEGER", nullable: false),
                    ShotsAndVaccinations = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.PetId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pet");
        }
    }
}
