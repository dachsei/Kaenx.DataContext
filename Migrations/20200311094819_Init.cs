﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kaenx.DataContext.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppSegments",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 255, nullable: false),
                    ApplicationId = table.Column<string>(nullable: true),
                    Address = table.Column<int>(nullable: false),
                    Size = table.Column<int>(nullable: false),
                    Data = table.Column<string>(nullable: true),
                    Mask = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSegments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAdditionals",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 255, nullable: false),
                    LoadProcedures = table.Column<byte[]>(nullable: true),
                    Dynamic = table.Column<byte[]>(nullable: true),
                    ParameterAll = table.Column<byte[]>(nullable: true),
                    ParameterDefault = table.Column<byte[]>(nullable: true),
                    ComsAll = table.Column<byte[]>(nullable: true),
                    ComsDefault = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAdditionals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppComObjects",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 255, nullable: false),
                    ApplicationId = table.Column<string>(maxLength: 100, nullable: true),
                    Text = table.Column<string>(maxLength: 100, nullable: false),
                    FunctionText = table.Column<string>(maxLength: 100, nullable: false),
                    Flag_Read = table.Column<bool>(nullable: false),
                    Flag_Write = table.Column<bool>(nullable: false),
                    Flag_Communicate = table.Column<bool>(nullable: false),
                    Flag_Transmit = table.Column<bool>(nullable: false),
                    Flag_Update = table.Column<bool>(nullable: false),
                    Flag_ReadOnInit = table.Column<bool>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Size = table.Column<int>(nullable: false),
                    Datapoint = table.Column<int>(nullable: false),
                    DatapointSub = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppComObjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 255, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Version = table.Column<int>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Mask = table.Column<string>(maxLength: 7, nullable: true),
                    Manufacturer = table.Column<int>(nullable: false),
                    Table_Object = table.Column<string>(maxLength: 40, nullable: true),
                    Table_Object_Offset = table.Column<int>(nullable: false),
                    Table_Group = table.Column<string>(maxLength: 40, nullable: true),
                    Table_Group_Offset = table.Column<int>(nullable: false),
                    Table_Group_Max = table.Column<int>(nullable: false),
                    Table_Assosiations = table.Column<string>(maxLength: 40, nullable: true),
                    Table_Assosiations_Offset = table.Column<int>(nullable: false),
                    Table_Assosiations_Max = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppParameters",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 255, nullable: false),
                    ParameterTypeId = table.Column<string>(maxLength: 100, nullable: true),
                    ApplicationId = table.Column<string>(maxLength: 100, nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    SegmentId = table.Column<string>(maxLength: 100, nullable: true),
                    SegmentType = table.Column<int>(nullable: false),
                    Offset = table.Column<int>(nullable: false),
                    OffsetBit = table.Column<int>(nullable: false),
                    Access = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppParameters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppParameterTypeEnums",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 255, nullable: false),
                    ParameterId = table.Column<string>(maxLength: 100, nullable: true),
                    Text = table.Column<string>(maxLength: 100, nullable: true),
                    Value = table.Column<string>(maxLength: 100, nullable: true),
                    Order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppParameterTypeEnums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppParameterTypes",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 255, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Size = table.Column<int>(nullable: false),
                    Tag1 = table.Column<string>(maxLength: 100, nullable: true),
                    Tag2 = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppParameterTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 255, nullable: false),
                    ManufacturerId = table.Column<string>(maxLength: 7, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    VisibleDescription = table.Column<string>(maxLength: 300, nullable: true),
                    OrderNumber = table.Column<string>(maxLength: 100, nullable: true),
                    HasIndividualAddress = table.Column<bool>(nullable: false),
                    HasApplicationProgram = table.Column<bool>(nullable: false),
                    IsPowerSupply = table.Column<bool>(nullable: false),
                    IsRailMounted = table.Column<bool>(nullable: false),
                    IsCoupler = table.Column<bool>(nullable: false),
                    BusCurrent = table.Column<int>(nullable: false),
                    CatalogId = table.Column<string>(maxLength: 100, nullable: true),
                    HardwareId = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hardware2App",
                columns: table => new
                {
                    Id = table.Column<int>(maxLength: 255, nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HardwareId = table.Column<string>(nullable: true),
                    ApplicationId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Version = table.Column<int>(nullable: false),
                    Number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hardware2App", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 255, nullable: false),
                    ParentId = table.Column<string>(maxLength: 100, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppSegments");

            migrationBuilder.DropTable(
                name: "AppAdditionals");

            migrationBuilder.DropTable(
                name: "AppComObjects");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "AppParameters");

            migrationBuilder.DropTable(
                name: "AppParameterTypeEnums");

            migrationBuilder.DropTable(
                name: "AppParameterTypes");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "Hardware2App");

            migrationBuilder.DropTable(
                name: "Sections");
        }
    }
}
