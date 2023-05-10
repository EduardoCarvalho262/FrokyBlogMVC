using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FrokyBlog.Migrations
{
    /// <inheritdoc />
    public partial class ReformulandoModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Post",
                newName: "Content");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Post",
                newName: "Rating");
        }
    }
}
