using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Entity.Migrations
{
    /// <inheritdoc />
    public partial class dbSchoolMe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "business");

            migrationBuilder.EnsureSchema(
                name: "parameters");

            migrationBuilder.EnsureSchema(
                name: "security");

            migrationBuilder.CreateTable(
                name: "departamet",
                schema: "parameters",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departamet", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "documentType",
                schema: "parameters",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Acronym = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_documentType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "eps",
                schema: "parameters",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eps", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Form",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "materialStatus",
                schema: "parameters",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materialStatus", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "module",
                schema: "security",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_module", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "permission",
                schema: "security",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permission", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "rh",
                schema: "parameters",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rh", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "rol",
                schema: "security",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rol", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "munisipality",
                schema: "parameters",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    departametId = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_munisipality", x => x.id);
                    table.ForeignKey(
                        name: "FK_munisipality_departamet_departametId",
                        column: x => x.departametId,
                        principalSchema: "parameters",
                        principalTable: "departamet",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "person",
                schema: "security",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DocumentTypeId = table.Column<int>(type: "integer", nullable: false),
                    identification = table.Column<int>(type: "integer", nullable: false),
                    fisrtName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    secondName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    lastName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    secondLastName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    nation = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    phone = table.Column<int>(type: "integer", nullable: false),
                    gender = table.Column<int>(type: "integer", nullable: false),
                    age = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person", x => x.id);
                    table.ForeignKey(
                        name: "FK_person_documentType_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalSchema: "parameters",
                        principalTable: "documentType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "moduleForm",
                schema: "security",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    module_id = table.Column<int>(type: "integer", nullable: false),
                    form_id = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_moduleForm", x => x.id);
                    table.ForeignKey(
                        name: "FK_moduleForm_Form_form_id",
                        column: x => x.form_id,
                        principalTable: "Form",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_moduleForm_module_module_id",
                        column: x => x.module_id,
                        principalSchema: "security",
                        principalTable: "module",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "rolFormPermission",
                schema: "security",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    rol_id = table.Column<int>(type: "integer", nullable: false),
                    form_id = table.Column<int>(type: "integer", nullable: false),
                    permission_id = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rolFormPermission", x => x.id);
                    table.ForeignKey(
                        name: "FK_rolFormPermission_Form_form_id",
                        column: x => x.form_id,
                        principalTable: "Form",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_rolFormPermission_permission_permission_id",
                        column: x => x.permission_id,
                        principalSchema: "security",
                        principalTable: "permission",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_rolFormPermission_rol_rol_id",
                        column: x => x.rol_id,
                        principalSchema: "security",
                        principalTable: "rol",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "dataBasic",
                schema: "business",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    personaId = table.Column<int>(type: "integer", nullable: false),
                    rhId = table.Column<int>(type: "integer", nullable: false),
                    adress = table.Column<string>(type: "varchar", maxLength: 100, nullable: false),
                    birthDate = table.Column<DateTime>(type: "timestamp", nullable: false),
                    stratumStatus = table.Column<int>(type: "integer", nullable: false),
                    materialStatusId = table.Column<int>(type: "integer", nullable: false),
                    epsId = table.Column<int>(type: "integer", nullable: false),
                    munisipalityId = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dataBasic", x => x.id);
                    table.ForeignKey(
                        name: "FK_dataBasic_eps_epsId",
                        column: x => x.epsId,
                        principalSchema: "parameters",
                        principalTable: "eps",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dataBasic_materialStatus_materialStatusId",
                        column: x => x.materialStatusId,
                        principalSchema: "parameters",
                        principalTable: "materialStatus",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dataBasic_munisipality_munisipalityId",
                        column: x => x.munisipalityId,
                        principalSchema: "parameters",
                        principalTable: "munisipality",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dataBasic_person_personaId",
                        column: x => x.personaId,
                        principalSchema: "security",
                        principalTable: "person",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dataBasic_rh_rhId",
                        column: x => x.rhId,
                        principalSchema: "parameters",
                        principalTable: "rh",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "user",
                schema: "security",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    person_id = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id);
                    table.ForeignKey(
                        name: "FK_user_person_person_id",
                        column: x => x.person_id,
                        principalSchema: "security",
                        principalTable: "person",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "userRol",
                schema: "security",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    rol_id = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userRol", x => x.id);
                    table.ForeignKey(
                        name: "FK_userRol_rol_rol_id",
                        column: x => x.rol_id,
                        principalSchema: "security",
                        principalTable: "rol",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_userRol_user_user_id",
                        column: x => x.user_id,
                        principalSchema: "security",
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "parameters",
                table: "documentType",
                columns: new[] { "id", "Acronym", "created_at", "deleted_at", "name", "status", "updated_at" },
                values: new object[,]
                {
                    { 1, "C.C", null, null, "Cedula Ciudadana", 0, null },
                    { 2, "T.I", null, null, "Targeta de identidad", 0, null },
                    { 3, "R.C", null, null, "Registro civil", 0, null }
                });

            migrationBuilder.InsertData(
                schema: "parameters",
                table: "eps",
                columns: new[] { "id", "created_at", "deleted_at", "name", "status", "updated_at" },
                values: new object[] { 1, null, null, "Nueva eps", 0, null });

            migrationBuilder.InsertData(
                schema: "parameters",
                table: "materialStatus",
                columns: new[] { "id", "created_at", "deleted_at", "name", "status", "updated_at" },
                values: new object[,]
                {
                    { 1, null, null, "Casado", 0, null },
                    { 2, null, null, "Soltero", 0, null }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "module",
                columns: new[] { "id", "created_at", "deleted_at", "description", "name", "status", "updated_at" },
                values: new object[] { 1, null, null, "Todo el tema de permisos del sistema", "Seguridad", 0, null });

            migrationBuilder.InsertData(
                schema: "security",
                table: "permission",
                columns: new[] { "id", "created_at", "deleted_at", "description", "name", "status", "updated_at" },
                values: new object[] { 1, null, null, "Formulario de inicio", "system complete", 0, null });

            migrationBuilder.InsertData(
                schema: "parameters",
                table: "rh",
                columns: new[] { "id", "created_at", "deleted_at", "name", "status", "updated_at" },
                values: new object[,]
                {
                    { 1, null, null, "O+", 0, null },
                    { 2, null, null, "O-", 0, null },
                    { 3, null, null, "A+", 0, null }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "rol",
                columns: new[] { "id", "created_at", "deleted_at", "description", "name", "status", "updated_at" },
                values: new object[] { 1, null, null, "Control sobre todo", "Admin", 1, null });

            migrationBuilder.CreateIndex(
                name: "IX_dataBasic_epsId",
                schema: "business",
                table: "dataBasic",
                column: "epsId");

            migrationBuilder.CreateIndex(
                name: "IX_dataBasic_materialStatusId",
                schema: "business",
                table: "dataBasic",
                column: "materialStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_dataBasic_munisipalityId",
                schema: "business",
                table: "dataBasic",
                column: "munisipalityId");

            migrationBuilder.CreateIndex(
                name: "IX_dataBasic_personaId",
                schema: "business",
                table: "dataBasic",
                column: "personaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_dataBasic_rhId",
                schema: "business",
                table: "dataBasic",
                column: "rhId");

            migrationBuilder.CreateIndex(
                name: "IX_moduleForm_form_id",
                schema: "security",
                table: "moduleForm",
                column: "form_id");

            migrationBuilder.CreateIndex(
                name: "IX_moduleForm_module_id",
                schema: "security",
                table: "moduleForm",
                column: "module_id");

            migrationBuilder.CreateIndex(
                name: "IX_munisipality_departametId",
                schema: "parameters",
                table: "munisipality",
                column: "departametId");

            migrationBuilder.CreateIndex(
                name: "IX_person_DocumentTypeId",
                schema: "security",
                table: "person",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_rolFormPermission_form_id",
                schema: "security",
                table: "rolFormPermission",
                column: "form_id");

            migrationBuilder.CreateIndex(
                name: "IX_rolFormPermission_permission_id",
                schema: "security",
                table: "rolFormPermission",
                column: "permission_id");

            migrationBuilder.CreateIndex(
                name: "IX_rolFormPermission_rol_id",
                schema: "security",
                table: "rolFormPermission",
                column: "rol_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_person_id",
                schema: "security",
                table: "user",
                column: "person_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_userRol_rol_id",
                schema: "security",
                table: "userRol",
                column: "rol_id");

            migrationBuilder.CreateIndex(
                name: "IX_userRol_user_id",
                schema: "security",
                table: "userRol",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dataBasic",
                schema: "business");

            migrationBuilder.DropTable(
                name: "moduleForm",
                schema: "security");

            migrationBuilder.DropTable(
                name: "rolFormPermission",
                schema: "security");

            migrationBuilder.DropTable(
                name: "userRol",
                schema: "security");

            migrationBuilder.DropTable(
                name: "eps",
                schema: "parameters");

            migrationBuilder.DropTable(
                name: "materialStatus",
                schema: "parameters");

            migrationBuilder.DropTable(
                name: "munisipality",
                schema: "parameters");

            migrationBuilder.DropTable(
                name: "rh",
                schema: "parameters");

            migrationBuilder.DropTable(
                name: "module",
                schema: "security");

            migrationBuilder.DropTable(
                name: "Form");

            migrationBuilder.DropTable(
                name: "permission",
                schema: "security");

            migrationBuilder.DropTable(
                name: "rol",
                schema: "security");

            migrationBuilder.DropTable(
                name: "user",
                schema: "security");

            migrationBuilder.DropTable(
                name: "departamet",
                schema: "parameters");

            migrationBuilder.DropTable(
                name: "person",
                schema: "security");

            migrationBuilder.DropTable(
                name: "documentType",
                schema: "parameters");
        }
    }
}
