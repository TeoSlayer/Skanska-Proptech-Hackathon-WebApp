using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SPHackathon.Data.Migrations
{
    public partial class AddedDocumentsModelsAndContainers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Container",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    ApprovedUsers = table.Column<string>(nullable: true),
                    ContainerName = table.Column<string>(nullable: true),
                    LeadReviewer = table.Column<string>(nullable: true),
                    ProjectLead = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Container", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LandBookRegistration",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateIssued = table.Column<DateTime>(nullable: false),
                    Issuer = table.Column<string>(nullable: true),
                    IssuerSpecialty = table.Column<string>(nullable: true),
                    LandBookNumber = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PhysicalPath = table.Column<string>(nullable: true),
                    RequestNumber = table.Column<int>(nullable: false),
                    ContainerID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandBookRegistration", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LandBookRegistration_Container_ContainerID",
                        column: x => x.ContainerID,
                        principalTable: "Container",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Letter",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    InAttentionOf = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PhysicalPath = table.Column<string>(nullable: true),
                    Recipient = table.Column<string>(nullable: true),
                    RecipientAddress = table.Column<string>(nullable: true),
                    Sender = table.Column<string>(nullable: true),
                    ContainerID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Letter", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Letter_Container_ContainerID",
                        column: x => x.ContainerID,
                        principalTable: "Container",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LandBookRegistration_ContainerID",
                table: "LandBookRegistration",
                column: "ContainerID");

            migrationBuilder.CreateIndex(
                name: "IX_Letter_ContainerID",
                table: "Letter",
                column: "ContainerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LandBookRegistration");

            migrationBuilder.DropTable(
                name: "Letter");

            migrationBuilder.DropTable(
                name: "Container");
        }
    }
}
