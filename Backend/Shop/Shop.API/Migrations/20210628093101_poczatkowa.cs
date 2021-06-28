using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.API.Migrations
{
    public partial class poczatkowa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderDbSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<double>(type: "float", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipmentPrice = table.Column<double>(type: "float", nullable: false),
                    ShipmentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDbSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserDbSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDbSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductDbSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDbSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDbSet_OrderDbSet_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrderDbSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TapeBasesDbSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Width = table.Column<double>(type: "float", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lenght = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    FixturesColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Handle = table.Column<bool>(type: "bit", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NeckCircuit = table.Column<double>(type: "float", nullable: true),
                    Collar_PetIdRing = table.Column<bool>(type: "bit", nullable: true),
                    Collar_ClaspType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StandardCirclePosition = table.Column<bool>(type: "bit", nullable: true),
                    CirclePositionLength = table.Column<double>(type: "float", nullable: true),
                    ShoulderCircuit = table.Column<double>(type: "float", nullable: true),
                    ChestCircuit = table.Column<double>(type: "float", nullable: true),
                    ChestShoulderDistanceUp = table.Column<double>(type: "float", nullable: true),
                    ChestShoulderDistanceDown = table.Column<double>(type: "float", nullable: true),
                    ClaspType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SemiRing = table.Column<bool>(type: "bit", nullable: true),
                    PetIdRing = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TapeBasesDbSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TapeBasesDbSet_ProductDbSet_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductDbSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductDbSet_OrderId",
                table: "ProductDbSet",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TapeBasesDbSet_ProductId",
                table: "TapeBasesDbSet",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TapeBasesDbSet");

            migrationBuilder.DropTable(
                name: "UserDbSet");

            migrationBuilder.DropTable(
                name: "ProductDbSet");

            migrationBuilder.DropTable(
                name: "OrderDbSet");
        }
    }
}
