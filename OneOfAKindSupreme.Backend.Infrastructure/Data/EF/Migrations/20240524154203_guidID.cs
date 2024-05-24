using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneOfAKindSupreme.Backend.Infrastructure.Data.EF.Migrations
{
    /// <inheritdoc />
    public partial class guidID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey("PK_Projects", "Projects");
            migrationBuilder.DropColumn("Id", "Projects");            
            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Projects",
                type: "uniqueidentifier",
                nullable: false
                );
            migrationBuilder.AddPrimaryKey("PK_Projects", "Projects", "Id");
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey("PK_Projects", "Projects");
            migrationBuilder.DropColumn("Id", "Projects");
        }
    }
}
