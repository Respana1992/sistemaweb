using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sistemaweb.Migrations
{
    public partial class UpdateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categoria",
                columns: table => new
                {
                    idcategoria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    descripcion = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    estado = table.Column<bool>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__categori__140587C70A4A298F", x => x.idcategoria);
                });

            migrationBuilder.CreateTable(
                name: "producto",
                columns: table => new
                {
                    idproducto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    idcategoria = table.Column<int>(nullable: false),
                    codigo = table.Column<string>(unicode: false, maxLength: 64, nullable: true),
                    nombre = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    precio_venta = table.Column<decimal>(type: "decimal(11, 2)", nullable: false),
                    stock = table.Column<int>(nullable: false),
                    descripcion = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    estado = table.Column<bool>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__producto__DC53BE3C723C9D7B", x => x.idproducto);
                    table.ForeignKey(
                        name: "FK__producto__idcate__164452B1",
                        column: x => x.idcategoria,
                        principalTable: "categoria",
                        principalColumn: "idcategoria",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "UQ__categori__72AFBCC60D2B5D59",
                table: "categoria",
                column: "nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_producto_idcategoria",
                table: "producto",
                column: "idcategoria");

            migrationBuilder.CreateIndex(
                name: "UQ__producto__72AFBCC60BBD3E86",
                table: "producto",
                column: "nombre",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "producto");

            migrationBuilder.DropTable(
                name: "categoria");
        }
    }
}
