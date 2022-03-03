using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Rest_recibos.Migrations
{
    public partial class recibo_agregar_migracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "recibo",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    proveedor_recibo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    monto_recibo = table.Column<double>(type: "float", nullable: false),
                    moneda_recibo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    comentario_recibo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_usuario = table.Column<long>(type: "bigint", nullable: false),
                    fecha_recibo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recibo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    correo_usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre_usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido_usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contrasenia_usuario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "recibo");

            migrationBuilder.DropTable(
                name: "usuario");
        }
    }
}
