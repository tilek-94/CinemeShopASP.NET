using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemeShop.Migrations
{
    public partial class RenemeActorIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorMovies_Actors_ActerId",
                table: "ActorMovies");

            migrationBuilder.RenameColumn(
                name: "ActerId",
                table: "ActorMovies",
                newName: "ActorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActorMovies_Actors_ActorId",
                table: "ActorMovies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorMovies_Actors_ActorId",
                table: "ActorMovies");

            migrationBuilder.RenameColumn(
                name: "ActorId",
                table: "ActorMovies",
                newName: "ActerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActorMovies_Actors_ActerId",
                table: "ActorMovies",
                column: "ActerId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
