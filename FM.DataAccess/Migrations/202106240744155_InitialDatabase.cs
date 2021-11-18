namespace FM.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BusinessSectors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Discription = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        DistrictId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Districts", t => t.DistrictId, cascadeDelete: true)
                .Index(t => t.DistrictId);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        ProvinceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Provinces", t => t.ProvinceId, cascadeDelete: true)
                .Index(t => t.ProvinceId);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CitizenDetailInfoes",
                c => new
                    {
                        CitizenId = c.Int(nullable: false),
                        Sex = c.String(nullable: false, maxLength: 100),
                        CityId = c.Int(nullable: false),
                        Street = c.String(maxLength: 100),
                        Building = c.String(maxLength: 100),
                        Floor = c.Int(nullable: false),
                        HomeTypeId = c.Int(nullable: false),
                        Phone = c.String(maxLength: 50),
                        Mobile = c.String(maxLength: 50),
                        Email = c.String(maxLength: 100),
                        MaritalStatusId = c.Int(nullable: false),
                        IsDisabled = c.Boolean(nullable: false),
                        Nationality = c.String(nullable: false, maxLength: 100),
                        EducationalLevelId = c.Int(nullable: false),
                        BusinessSectorId = c.Int(nullable: false),
                        PartyDivisionId = c.Int(nullable: false),
                        PartyPositionId = c.Int(nullable: false),
                        ElectionRoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CitizenId)
                .ForeignKey("dbo.BusinessSectors", t => t.BusinessSectorId, cascadeDelete: true)
                .ForeignKey("dbo.Citizens", t => t.CitizenId)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.EducationalLevels", t => t.EducationalLevelId, cascadeDelete: true)
                .ForeignKey("dbo.ElectionRoles", t => t.ElectionRoleId, cascadeDelete: true)
                .ForeignKey("dbo.HomeTypes", t => t.HomeTypeId, cascadeDelete: true)
                .ForeignKey("dbo.MaritalStatus", t => t.MaritalStatusId, cascadeDelete: true)
                .ForeignKey("dbo.PartyDivisions", t => t.PartyDivisionId, cascadeDelete: true)
                .ForeignKey("dbo.PartyPositions", t => t.PartyPositionId, cascadeDelete: true)
                .Index(t => t.CitizenId)
                .Index(t => t.CityId)
                .Index(t => t.HomeTypeId)
                .Index(t => t.MaritalStatusId)
                .Index(t => t.EducationalLevelId)
                .Index(t => t.BusinessSectorId)
                .Index(t => t.PartyDivisionId)
                .Index(t => t.PartyPositionId)
                .Index(t => t.ElectionRoleId);
            
            CreateTable(
                "dbo.Citizens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        FatherName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        MotherFullName = c.String(nullable: false, maxLength: 150),
                        DateOfBirth = c.DateTime(nullable: false),
                        Province = c.String(nullable: false, maxLength: 100),
                        District = c.String(nullable: false, maxLength: 100),
                        RegisterPlace = c.String(nullable: false, maxLength: 100),
                        RegisterNumber = c.Int(nullable: false),
                        Religion = c.String(nullable: false),
                        ReligionSect = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EducationalLevels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Discription = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ElectionRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Discription = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HomeTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Discription = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MaritalStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Discription = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PartyDivisions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Discription = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PartyPositions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Discription = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FamilyMemberInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CitizenId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Sex = c.String(nullable: false),
                        MemberRelationTypeId = c.Int(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MemberRelationTypes", t => t.MemberRelationTypeId, cascadeDelete: true)
                .Index(t => t.MemberRelationTypeId);
            
            CreateTable(
                "dbo.MemberRelationTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Discription = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReferenceInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CitizenId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 200),
                        ContactNumber = c.String(maxLength: 50),
                        PartyPositionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PartyPositions", t => t.PartyPositionId, cascadeDelete: true)
                .Index(t => t.PartyPositionId);
            
            CreateTable(
                "dbo.ResultTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Discription = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ServiceInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CitizenId = c.Int(nullable: false),
                        ServiceTypeId = c.Int(nullable: false),
                        ContactName = c.String(nullable: false, maxLength: 150),
                        ContactNumber = c.String(nullable: false, maxLength: 50),
                        ResultTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ResultTypes", t => t.ResultTypeId, cascadeDelete: true)
                .ForeignKey("dbo.ServiceTypes", t => t.ServiceTypeId, cascadeDelete: true)
                .Index(t => t.ServiceTypeId)
                .Index(t => t.ResultTypeId);
            
            CreateTable(
                "dbo.ServiceTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Discription = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceInfoes", "ServiceTypeId", "dbo.ServiceTypes");
            DropForeignKey("dbo.ServiceInfoes", "ResultTypeId", "dbo.ResultTypes");
            DropForeignKey("dbo.ReferenceInfoes", "PartyPositionId", "dbo.PartyPositions");
            DropForeignKey("dbo.FamilyMemberInfoes", "MemberRelationTypeId", "dbo.MemberRelationTypes");
            DropForeignKey("dbo.CitizenDetailInfoes", "PartyPositionId", "dbo.PartyPositions");
            DropForeignKey("dbo.CitizenDetailInfoes", "PartyDivisionId", "dbo.PartyDivisions");
            DropForeignKey("dbo.CitizenDetailInfoes", "MaritalStatusId", "dbo.MaritalStatus");
            DropForeignKey("dbo.CitizenDetailInfoes", "HomeTypeId", "dbo.HomeTypes");
            DropForeignKey("dbo.CitizenDetailInfoes", "ElectionRoleId", "dbo.ElectionRoles");
            DropForeignKey("dbo.CitizenDetailInfoes", "EducationalLevelId", "dbo.EducationalLevels");
            DropForeignKey("dbo.CitizenDetailInfoes", "CityId", "dbo.Cities");
            DropForeignKey("dbo.CitizenDetailInfoes", "CitizenId", "dbo.Citizens");
            DropForeignKey("dbo.CitizenDetailInfoes", "BusinessSectorId", "dbo.BusinessSectors");
            DropForeignKey("dbo.Cities", "DistrictId", "dbo.Districts");
            DropForeignKey("dbo.Districts", "ProvinceId", "dbo.Provinces");
            DropIndex("dbo.ServiceInfoes", new[] { "ResultTypeId" });
            DropIndex("dbo.ServiceInfoes", new[] { "ServiceTypeId" });
            DropIndex("dbo.ReferenceInfoes", new[] { "PartyPositionId" });
            DropIndex("dbo.FamilyMemberInfoes", new[] { "MemberRelationTypeId" });
            DropIndex("dbo.CitizenDetailInfoes", new[] { "ElectionRoleId" });
            DropIndex("dbo.CitizenDetailInfoes", new[] { "PartyPositionId" });
            DropIndex("dbo.CitizenDetailInfoes", new[] { "PartyDivisionId" });
            DropIndex("dbo.CitizenDetailInfoes", new[] { "BusinessSectorId" });
            DropIndex("dbo.CitizenDetailInfoes", new[] { "EducationalLevelId" });
            DropIndex("dbo.CitizenDetailInfoes", new[] { "MaritalStatusId" });
            DropIndex("dbo.CitizenDetailInfoes", new[] { "HomeTypeId" });
            DropIndex("dbo.CitizenDetailInfoes", new[] { "CityId" });
            DropIndex("dbo.CitizenDetailInfoes", new[] { "CitizenId" });
            DropIndex("dbo.Districts", new[] { "ProvinceId" });
            DropIndex("dbo.Cities", new[] { "DistrictId" });
            DropTable("dbo.ServiceTypes");
            DropTable("dbo.ServiceInfoes");
            DropTable("dbo.ResultTypes");
            DropTable("dbo.ReferenceInfoes");
            DropTable("dbo.MemberRelationTypes");
            DropTable("dbo.FamilyMemberInfoes");
            DropTable("dbo.PartyPositions");
            DropTable("dbo.PartyDivisions");
            DropTable("dbo.MaritalStatus");
            DropTable("dbo.HomeTypes");
            DropTable("dbo.ElectionRoles");
            DropTable("dbo.EducationalLevels");
            DropTable("dbo.Citizens");
            DropTable("dbo.CitizenDetailInfoes");
            DropTable("dbo.Provinces");
            DropTable("dbo.Districts");
            DropTable("dbo.Cities");
            DropTable("dbo.BusinessSectors");
        }
    }
}
