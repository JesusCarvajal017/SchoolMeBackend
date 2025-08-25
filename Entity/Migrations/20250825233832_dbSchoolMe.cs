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
                    Acronym = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false),
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
                name: "form",
                schema: "security",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    path = table.Column<string>(type: "text", nullable: false),
                    order = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_form", x => x.id);
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
                    icon = table.Column<string>(type: "text", nullable: false),
                    path = table.Column<string>(type: "text", nullable: false),
                    order = table.Column<int>(type: "integer", nullable: false),
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
                    phone = table.Column<long>(type: "bigint", nullable: false),
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
                        name: "FK_moduleForm_form_form_id",
                        column: x => x.form_id,
                        principalSchema: "security",
                        principalTable: "form",
                        principalColumn: "id",
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
                        name: "FK_rolFormPermission_form_form_id",
                        column: x => x.form_id,
                        principalSchema: "security",
                        principalTable: "form",
                        principalColumn: "id",
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
                    photo = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
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
                table: "departamet",
                columns: new[] { "id", "created_at", "deleted_at", "name", "status", "updated_at" },
                values: new object[,]
                {
                    { 1, null, null, "Amazonas", 0, null },
                    { 2, null, null, "Antioquia", 0, null },
                    { 3, null, null, "Arauca", 0, null },
                    { 4, null, null, "Atlántico", 0, null },
                    { 5, null, null, "Bolívar", 0, null },
                    { 6, null, null, "Boyacá", 0, null },
                    { 7, null, null, "Caldas", 0, null },
                    { 8, null, null, "Caquetá", 0, null },
                    { 9, null, null, "Casanare", 0, null },
                    { 10, null, null, "Cauca", 0, null },
                    { 11, null, null, "Cesar", 0, null },
                    { 12, null, null, "Chocó", 0, null },
                    { 13, null, null, "Córdoba", 0, null },
                    { 14, null, null, "Cundinamarca", 0, null },
                    { 15, null, null, "Guainía", 0, null },
                    { 16, null, null, "Guaviare", 0, null },
                    { 17, null, null, "Huila", 0, null },
                    { 18, null, null, "La Guajira", 0, null },
                    { 19, null, null, "Magdalena", 0, null },
                    { 20, null, null, "Meta", 0, null },
                    { 21, null, null, "Nariño", 0, null },
                    { 22, null, null, "Norte de Santander", 0, null },
                    { 23, null, null, "Putumayo", 0, null },
                    { 24, null, null, "Quindío", 0, null },
                    { 25, null, null, "Risaralda", 0, null },
                    { 26, null, null, "San Andrés y Providencia", 0, null },
                    { 27, null, null, "Santander", 0, null },
                    { 28, null, null, "Sucre", 0, null },
                    { 29, null, null, "Tolima", 0, null },
                    { 30, null, null, "Valle del Cauca", 0, null },
                    { 31, null, null, "Vaupés", 0, null },
                    { 32, null, null, "Vichada", 0, null }
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
                schema: "security",
                table: "form",
                columns: new[] { "id", "created_at", "deleted_at", "description", "name", "order", "path", "status", "updated_at" },
                values: new object[,]
                {
                    { 1, null, null, "Vista de todos los registros administrativos", "Todos", 1, "todos", 0, null },
                    { 2, null, null, "Gestión de personal administrativo", "Administrativos", 2, "administrativos", 0, null },
                    { 3, null, null, "Gestión de docentes", "Docentes", 3, "docentes", 0, null },
                    { 4, null, null, "Gestión de estudiantes", "Niños", 4, "ninos", 0, null },
                    { 5, null, null, "Gestión de acudientes", "Acudientes", 5, "acudientes", 0, null },
                    { 6, null, null, "Gestión de aulas", "Aulas", 1, "aulas", 0, null },
                    { 7, null, null, "Gestión de agrupaciones", "Agrupación", 2, "agrupación", 0, null },
                    { 8, null, null, "Asignación de directores de grupo", "Director de Grupo", 3, "directorGrupo", 0, null },
                    { 9, null, null, "Gestión de carga académica", "Carga Académica", 4, "cargaAcademica", 0, null },
                    { 10, null, null, "Gestión de composiciones", "Composición", 1, "composicion", 0, null },
                    { 11, null, null, "Gestión de agendas", "Agendas", 2, "agendas", 0, null },
                    { 12, null, null, "Asignación de agendas", "Asignación", 3, "asignacion", 0, null },
                    { 13, null, null, "Gestión de grados", "Grados", 1, "grados", 0, null },
                    { 14, null, null, "Gestión de grupos", "Grupos", 2, "grupos", 0, null },
                    { 15, null, null, "Gestión de tipos de identificación", "Tipo Identificación", 3, "tipoIdentificacion", 0, null },
                    { 16, null, null, "Gestión de EPS", "EPS", 4, "eps", 0, null },
                    { 17, null, null, "Gestión de municipios", "Municipios", 5, "municipio", 0, null },
                    { 18, null, null, "Gestión de tipos de sangre", "RH", 6, "rh", 0, null },
                    { 19, null, null, "Gestión de roles de usuario", "Roles", 1, "roles", 0, null },
                    { 20, null, null, "Gestión de permisos", "Permisos", 2, "permisos", 0, null },
                    { 21, null, null, "Gestión de módulos", "Módulos", 3, "modulos", 0, null },
                    { 22, null, null, "Gestión de formularios", "Formularios", 4, "formularios", 0, null },
                    { 23, null, null, "Asignación de roles a usuarios", "Asignación Roles", 5, "asignacionRoles", 0, null },
                    { 24, null, null, "Asignación de módulos a roles", "Asignación Módulos", 6, "asiganacionModulos", 0, null },
                    { 25, null, null, "Asignación de permisos a roles", "Asignación de Permisos", 7, "asignacionPermisos", 0, null },
                    { 26, null, null, "Gestión de usuarios", "Usuarios", 8, "usuarios", 0, null }
                });

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
                columns: new[] { "id", "created_at", "deleted_at", "description", "icon", "name", "order", "path", "status", "updated_at" },
                values: new object[,]
                {
                    { 1, null, null, "Pantalla principal del sistema", "home", "Inicio", 1, "/inicio", 0, null },
                    { 2, null, null, "Opciones administrativas del sistema", "person", "Administración", 2, "", 0, null },
                    { 3, null, null, "Módulo para gestión académica", "school", "Académico", 3, "", 0, null },
                    { 4, null, null, "Gestión de eventos y agendas", "book", "Agenda", 4, "", 0, null },
                    { 5, null, null, "Parámetros y ajustes del sistema", "settings", "Configuración", 5, "", 0, null },
                    { 6, null, null, "Todo el tema de permisos del sistema", "calendar", "Seguridad", 6, "", 0, null }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "permission",
                columns: new[] { "id", "created_at", "deleted_at", "description", "name", "status", "updated_at" },
                values: new object[,]
                {
                    { 1, null, null, "Formulario de inicio", "Todo", 0, null },
                    { 2, null, null, "Todos los permisos excepto eliminar persistentemente", "Editor", 0, null },
                    { 3, null, null, "Solo puede ver", "Lectura", 0, null }
                });

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
                values: new object[,]
                {
                    { 1, null, null, "Control sobre todo", "Administrador", 1, null },
                    { 2, null, null, "Permisos al 90%", "Administrativo", 1, null },
                    { 3, null, null, "Permisos al 30%", "Docente", 1, null },
                    { 4, null, null, "Solo interactura de forma base", "Acudiente", 1, null }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "moduleForm",
                columns: new[] { "id", "created_at", "deleted_at", "form_id", "module_id", "status", "updated_at" },
                values: new object[,]
                {
                    { 1, null, null, 1, 2, 0, null },
                    { 2, null, null, 2, 2, 0, null },
                    { 3, null, null, 3, 2, 0, null },
                    { 4, null, null, 4, 2, 0, null },
                    { 5, null, null, 5, 2, 0, null },
                    { 6, null, null, 6, 3, 0, null },
                    { 7, null, null, 7, 3, 0, null },
                    { 8, null, null, 8, 3, 0, null },
                    { 9, null, null, 9, 3, 0, null },
                    { 10, null, null, 10, 4, 0, null },
                    { 11, null, null, 11, 4, 0, null },
                    { 12, null, null, 12, 4, 0, null },
                    { 13, null, null, 13, 5, 0, null },
                    { 14, null, null, 14, 5, 0, null },
                    { 15, null, null, 15, 5, 0, null },
                    { 16, null, null, 16, 5, 0, null },
                    { 17, null, null, 17, 5, 0, null },
                    { 18, null, null, 18, 5, 0, null },
                    { 19, null, null, 19, 6, 0, null },
                    { 20, null, null, 20, 6, 0, null },
                    { 21, null, null, 21, 6, 0, null },
                    { 22, null, null, 22, 6, 0, null },
                    { 23, null, null, 23, 6, 0, null },
                    { 24, null, null, 24, 6, 0, null },
                    { 25, null, null, 25, 6, 0, null },
                    { 26, null, null, 26, 6, 0, null }
                });

            migrationBuilder.InsertData(
                schema: "parameters",
                table: "munisipality",
                columns: new[] { "id", "created_at", "deleted_at", "departametId", "name", "status", "updated_at" },
                values: new object[,]
                {
                    { 1, null, null, 1, "Leticia", 0, null },
                    { 2, null, null, 1, "Puerto Nariño", 0, null },
                    { 3, null, null, 1, "Tarapacá", 0, null },
                    { 4, null, null, 1, "La Pedrera", 0, null },
                    { 5, null, null, 1, "El Encanto", 0, null },
                    { 6, null, null, 2, "Medellín", 0, null },
                    { 7, null, null, 2, "Bello", 0, null },
                    { 8, null, null, 2, "Envigado", 0, null },
                    { 9, null, null, 2, "Itagüí", 0, null },
                    { 10, null, null, 2, "Rionegro", 0, null },
                    { 11, null, null, 3, "Arauca", 0, null },
                    { 12, null, null, 3, "Saravena", 0, null },
                    { 13, null, null, 3, "Tame", 0, null },
                    { 14, null, null, 3, "Fortul", 0, null },
                    { 15, null, null, 3, "Arauquita", 0, null },
                    { 16, null, null, 4, "Barranquilla", 0, null },
                    { 17, null, null, 4, "Soledad", 0, null },
                    { 18, null, null, 4, "Malambo", 0, null },
                    { 19, null, null, 4, "Sabanalarga", 0, null },
                    { 20, null, null, 4, "Galapa", 0, null },
                    { 21, null, null, 5, "Cartagena de Indias", 0, null },
                    { 22, null, null, 5, "Magangué", 0, null },
                    { 23, null, null, 5, "Turbaco", 0, null },
                    { 24, null, null, 5, "Arjona", 0, null },
                    { 25, null, null, 5, "El Carmen de Bolívar", 0, null },
                    { 26, null, null, 6, "Tunja", 0, null },
                    { 27, null, null, 6, "Duitama", 0, null },
                    { 28, null, null, 6, "Sogamoso", 0, null },
                    { 29, null, null, 6, "Chiquinquirá", 0, null },
                    { 30, null, null, 6, "Paipa", 0, null },
                    { 31, null, null, 7, "Manizales", 0, null },
                    { 32, null, null, 7, "Villamaría", 0, null },
                    { 33, null, null, 7, "Chinchiná", 0, null },
                    { 34, null, null, 7, "La Dorada", 0, null },
                    { 35, null, null, 7, "Riosucio", 0, null },
                    { 36, null, null, 8, "Florencia", 0, null },
                    { 37, null, null, 8, "San Vicente del Caguán", 0, null },
                    { 38, null, null, 8, "Puerto Rico", 0, null },
                    { 39, null, null, 8, "Cartagena del Chairá", 0, null },
                    { 40, null, null, 8, "El Doncello", 0, null },
                    { 41, null, null, 9, "Yopal", 0, null },
                    { 42, null, null, 9, "Aguazul", 0, null },
                    { 43, null, null, 9, "Villanueva", 0, null },
                    { 44, null, null, 9, "Monterrey", 0, null },
                    { 45, null, null, 9, "Tauramena", 0, null },
                    { 46, null, null, 10, "Popayán", 0, null },
                    { 47, null, null, 10, "Santander de Quilichao", 0, null },
                    { 48, null, null, 10, "Puerto Tejada", 0, null },
                    { 49, null, null, 10, "Patía (El Bordo)", 0, null },
                    { 50, null, null, 10, "Guapi", 0, null },
                    { 51, null, null, 11, "Valledupar", 0, null },
                    { 52, null, null, 11, "Aguachica", 0, null },
                    { 53, null, null, 11, "Bosconia", 0, null },
                    { 54, null, null, 11, "Curumaní", 0, null },
                    { 55, null, null, 11, "Chimichagua", 0, null },
                    { 56, null, null, 12, "Quibdó", 0, null },
                    { 57, null, null, 12, "Istmina", 0, null },
                    { 58, null, null, 12, "Tadó", 0, null },
                    { 59, null, null, 12, "Condoto", 0, null },
                    { 60, null, null, 12, "Bahía Solano", 0, null },
                    { 61, null, null, 13, "Montería", 0, null },
                    { 62, null, null, 13, "Cereté", 0, null },
                    { 63, null, null, 13, "Sahagún", 0, null },
                    { 64, null, null, 13, "Lorica", 0, null },
                    { 65, null, null, 13, "Planeta Rica", 0, null },
                    { 66, null, null, 14, "Bogotá D.C.", 0, null },
                    { 67, null, null, 14, "Soacha", 0, null },
                    { 68, null, null, 14, "Facatativá", 0, null },
                    { 69, null, null, 14, "Zipaquirá", 0, null },
                    { 70, null, null, 14, "Girardot", 0, null },
                    { 71, null, null, 15, "Inírida", 0, null },
                    { 72, null, null, 15, "Barranco Minas", 0, null },
                    { 73, null, null, 15, "San Felipe", 0, null },
                    { 74, null, null, 15, "Puerto Colombia", 0, null },
                    { 75, null, null, 15, "La Guadalupe", 0, null },
                    { 76, null, null, 16, "San José del Guaviare", 0, null },
                    { 77, null, null, 16, "Calamar", 0, null },
                    { 78, null, null, 16, "Miraflores", 0, null },
                    { 79, null, null, 16, "El Retorno", 0, null },
                    { 80, null, null, 16, "La Libertad", 0, null },
                    { 81, null, null, 18, "Riohacha", 0, null },
                    { 82, null, null, 18, "Maicao", 0, null },
                    { 83, null, null, 18, "Uribia", 0, null },
                    { 84, null, null, 18, "Fonseca", 0, null },
                    { 85, null, null, 18, "Manaure", 0, null },
                    { 86, null, null, 19, "Santa Marta", 0, null },
                    { 87, null, null, 19, "Ciénaga", 0, null },
                    { 88, null, null, 19, "Fundación", 0, null },
                    { 89, null, null, 19, "Plato", 0, null },
                    { 90, null, null, 19, "Pivijay", 0, null },
                    { 91, null, null, 20, "Villavicencio", 0, null },
                    { 92, null, null, 20, "Acacías", 0, null },
                    { 93, null, null, 20, "Granada", 0, null },
                    { 94, null, null, 20, "Puerto López", 0, null },
                    { 95, null, null, 20, "Cumaral", 0, null },
                    { 96, null, null, 21, "Pasto", 0, null },
                    { 97, null, null, 21, "Ipiales", 0, null },
                    { 98, null, null, 21, "Tumaco", 0, null },
                    { 99, null, null, 21, "Túquerres", 0, null },
                    { 100, null, null, 21, "La Unión", 0, null },
                    { 101, null, null, 22, "Cúcuta", 0, null },
                    { 102, null, null, 22, "Ocaña", 0, null },
                    { 103, null, null, 22, "Pamplona", 0, null },
                    { 104, null, null, 22, "Villa del Rosario", 0, null },
                    { 105, null, null, 22, "Los Patios", 0, null },
                    { 106, null, null, 23, "Mocoa", 0, null },
                    { 107, null, null, 23, "Puerto Asís", 0, null },
                    { 108, null, null, 23, "Orito", 0, null },
                    { 109, null, null, 23, "Villagarzón", 0, null },
                    { 110, null, null, 23, "Sibundoy", 0, null },
                    { 111, null, null, 24, "Armenia", 0, null },
                    { 112, null, null, 24, "Calarcá", 0, null },
                    { 113, null, null, 24, "La Tebaida", 0, null },
                    { 114, null, null, 24, "Montenegro", 0, null },
                    { 115, null, null, 24, "Quimbaya", 0, null },
                    { 116, null, null, 25, "Pereira", 0, null },
                    { 117, null, null, 25, "Dosquebradas", 0, null },
                    { 118, null, null, 25, "Santa Rosa de Cabal", 0, null },
                    { 119, null, null, 25, "La Virginia", 0, null },
                    { 120, null, null, 25, "Marsella", 0, null },
                    { 121, null, null, 26, "San Andrés", 0, null },
                    { 122, null, null, 26, "Providencia", 0, null },
                    { 123, null, null, 26, "Santa Catalina", 0, null },
                    { 124, null, null, 26, "Cove Sea Side", 0, null },
                    { 125, null, null, 26, "La Loma", 0, null },
                    { 126, null, null, 27, "Bucaramanga", 0, null },
                    { 127, null, null, 27, "Floridablanca", 0, null },
                    { 128, null, null, 27, "Girón", 0, null },
                    { 129, null, null, 27, "Piedecuesta", 0, null },
                    { 130, null, null, 27, "Barrancabermeja", 0, null },
                    { 131, null, null, 28, "Sincelejo", 0, null },
                    { 132, null, null, 28, "Corozal", 0, null },
                    { 133, null, null, 28, "Sampués", 0, null },
                    { 134, null, null, 28, "San Marcos", 0, null },
                    { 135, null, null, 28, "Tolú", 0, null },
                    { 136, null, null, 29, "Ibagué", 0, null },
                    { 137, null, null, 29, "Espinal", 0, null },
                    { 138, null, null, 29, "Melgar", 0, null },
                    { 139, null, null, 29, "Honda", 0, null },
                    { 140, null, null, 29, "Líbano", 0, null },
                    { 141, null, null, 30, "Cali", 0, null },
                    { 142, null, null, 30, "Palmira", 0, null },
                    { 143, null, null, 30, "Buenaventura", 0, null },
                    { 144, null, null, 30, "Tuluá", 0, null },
                    { 145, null, null, 30, "Buga", 0, null },
                    { 146, null, null, 31, "Mitú", 0, null },
                    { 147, null, null, 31, "Carurú", 0, null },
                    { 148, null, null, 31, "Pacoa", 0, null },
                    { 149, null, null, 31, "Taraira", 0, null },
                    { 150, null, null, 31, "Yavaraté", 0, null },
                    { 151, null, null, 32, "Puerto Carreño", 0, null },
                    { 152, null, null, 32, "La Primavera", 0, null },
                    { 153, null, null, 32, "Santa Rosalía", 0, null },
                    { 154, null, null, 32, "Cumaribo", 0, null },
                    { 155, null, null, 32, "Guarrojo", 0, null },
                    { 200, null, null, 17, "Neiva", 0, null },
                    { 201, null, null, 17, "Acevedo", 0, null },
                    { 202, null, null, 17, "Agrado", 0, null },
                    { 203, null, null, 17, "Aipe", 0, null },
                    { 204, null, null, 17, "Algeciras", 0, null },
                    { 205, null, null, 17, "Altamira", 0, null },
                    { 206, null, null, 17, "Baraya", 0, null },
                    { 207, null, null, 17, "Campoalegre", 0, null },
                    { 208, null, null, 17, "Colombia", 0, null },
                    { 209, null, null, 17, "Elías", 0, null },
                    { 210, null, null, 17, "Garzón", 0, null },
                    { 211, null, null, 17, "Gigante", 0, null },
                    { 212, null, null, 17, "Guadalupe", 0, null },
                    { 213, null, null, 17, "Hobo", 0, null },
                    { 214, null, null, 17, "Íquira", 0, null },
                    { 215, null, null, 17, "Isnos", 0, null },
                    { 216, null, null, 17, "La Argentina", 0, null },
                    { 217, null, null, 17, "La Plata", 0, null },
                    { 218, null, null, 17, "Nátaga", 0, null },
                    { 219, null, null, 17, "Oporapa", 0, null },
                    { 220, null, null, 17, "Paicol", 0, null },
                    { 221, null, null, 17, "Palermo", 0, null },
                    { 222, null, null, 17, "Palestina", 0, null },
                    { 223, null, null, 17, "Pital", 0, null },
                    { 224, null, null, 17, "Pitalito", 0, null },
                    { 225, null, null, 17, "Rivera", 0, null },
                    { 226, null, null, 17, "Saladoblanco", 0, null },
                    { 227, null, null, 17, "San Agustín", 0, null },
                    { 228, null, null, 17, "Santa María", 0, null },
                    { 229, null, null, 17, "Suaza", 0, null },
                    { 230, null, null, 17, "Tarqui", 0, null },
                    { 231, null, null, 17, "Tello", 0, null },
                    { 232, null, null, 17, "Teruel", 0, null },
                    { 233, null, null, 17, "Tesalia", 0, null },
                    { 234, null, null, 17, "Timaná", 0, null },
                    { 235, null, null, 17, "Villavieja", 0, null },
                    { 236, null, null, 17, "Yaguará", 0, null }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "person",
                columns: new[] { "id", "age", "created_at", "deleted_at", "DocumentTypeId", "fisrtName", "gender", "identification", "lastName", "nation", "phone", "secondLastName", "secondName", "status", "updated_at" },
                values: new object[,]
                {
                    { 1, 32, null, null, 1, "Carlos", 0, 100200300, "Pérez", "Colombia", 300123456L, "García", "Andrés", 0, null },
                    { 2, 25, null, null, 2, "María", 1, 500600700, "López", "Colombia", 310987654L, "Martínez", "Fernanda", 0, null },
                    { 3, 18, null, null, 3, "Juan", 0, 800900100, "Rodríguez", "Colombia", 320456789L, "Hernández", "Camilo", 0, null },
                    { 4, 29, null, null, 1, "Laura", 1, 111222333, "Moreno", "Colombia", 301654987L, "Castro", "Isabel", 0, null },
                    { 5, 21, null, null, 2, "Santiago", 2, 444555666, "Ramírez", "Colombia", 312789654L, "Torres", "Esteban", 0, null }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "rolFormPermission",
                columns: new[] { "id", "created_at", "deleted_at", "form_id", "permission_id", "rol_id", "status", "updated_at" },
                values: new object[,]
                {
                    { 1, null, null, 1, 1, 1, 1, null },
                    { 2, null, null, 2, 1, 1, 1, null },
                    { 3, null, null, 3, 1, 1, 1, null },
                    { 4, null, null, 4, 1, 1, 1, null },
                    { 5, null, null, 5, 1, 1, 1, null },
                    { 6, null, null, 6, 1, 1, 1, null },
                    { 7, null, null, 7, 1, 1, 1, null },
                    { 8, null, null, 8, 1, 1, 1, null },
                    { 9, null, null, 9, 1, 1, 1, null },
                    { 10, null, null, 10, 1, 1, 1, null },
                    { 11, null, null, 11, 1, 1, 1, null },
                    { 12, null, null, 12, 1, 1, 1, null },
                    { 13, null, null, 13, 1, 1, 1, null },
                    { 14, null, null, 14, 1, 1, 1, null },
                    { 15, null, null, 15, 1, 1, 1, null },
                    { 16, null, null, 16, 1, 1, 1, null },
                    { 17, null, null, 17, 1, 1, 1, null },
                    { 18, null, null, 18, 1, 1, 1, null },
                    { 19, null, null, 19, 1, 1, 1, null },
                    { 20, null, null, 20, 1, 1, 1, null },
                    { 21, null, null, 21, 1, 1, 1, null },
                    { 22, null, null, 22, 1, 1, 1, null },
                    { 23, null, null, 23, 1, 1, 1, null },
                    { 24, null, null, 24, 1, 1, 1, null },
                    { 25, null, null, 25, 1, 1, 1, null },
                    { 26, null, null, 26, 1, 1, 1, null }
                });

            migrationBuilder.InsertData(
                schema: "business",
                table: "dataBasic",
                columns: new[] { "id", "adress", "birthDate", "created_at", "deleted_at", "epsId", "materialStatusId", "munisipalityId", "personaId", "rhId", "status", "stratumStatus", "updated_at" },
                values: new object[,]
                {
                    { 1, "Calle 10 #15-20", new DateTime(1993, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, 1, 200, 1, 1, 0, 3, null },
                    { 2, "Carrera 25 #8-30", new DateTime(2000, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, 2, 200, 2, 2, 0, 4, null },
                    { 3, "Diagonal 45 #20-15", new DateTime(2007, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, 2, 200, 3, 3, 0, 2, null },
                    { 4, "Avenida 7 #12-45", new DateTime(1996, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, 1, 200, 4, 1, 0, 5, null },
                    { 5, "Calle 50 #25-18", new DateTime(2004, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, 2, 200, 5, 2, 0, 3, null }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "user",
                columns: new[] { "id", "created_at", "deleted_at", "email", "password", "person_id", "photo", "status", "updated_at" },
                values: new object[,]
                {
                    { 1, null, null, "ejemplo1@gmail.com", "$2a$11$6LpgqG3XuJ3xbpRp4gcJXeL/pQT79cDv6Vt063Tk5c2klWRpNgR0.", 1, "defaul.jpg", 0, null },
                    { 2, null, null, "ejemplo2@gmail.com", "$2a$11$6LpgqG3XuJ3xbpRp4gcJXeL/pQT79cDv6Vt063Tk5c2klWRpNgR0.", 2, "defaul.jpg", 0, null },
                    { 3, null, null, "ejemplo3@gmail.com", "$2a$11$6LpgqG3XuJ3xbpRp4gcJXeL/pQT79cDv6Vt063Tk5c2klWRpNgR0.", 3, "defaul.jpg", 0, null },
                    { 4, null, null, "ejemplo4@gmail.com", "$2a$11$6LpgqG3XuJ3xbpRp4gcJXeL/pQT79cDv6Vt063Tk5c2klWRpNgR0.", 4, "defaul.jpg", 0, null },
                    { 5, null, null, "ejemplo5@gmail.com", "$2a$11$6LpgqG3XuJ3xbpRp4gcJXeL/pQT79cDv6Vt063Tk5c2klWRpNgR0.", 5, "defaul.jpg", 0, null }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "userRol",
                columns: new[] { "id", "created_at", "deleted_at", "rol_id", "status", "updated_at", "user_id" },
                values: new object[,]
                {
                    { 1, null, null, 1, 1, null, 1 },
                    { 2, null, null, 2, 1, null, 2 },
                    { 3, null, null, 3, 1, null, 3 },
                    { 4, null, null, 2, 1, null, 4 },
                    { 5, null, null, 4, 1, null, 5 }
                });

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
                name: "form",
                schema: "security");

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
