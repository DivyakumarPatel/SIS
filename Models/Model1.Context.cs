﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace S1G6_SISAPP.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class Entities : DbContext
{
    public Entities()
        : base("name=Entities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Cours> Courses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudyTerm> StudyTerms { get; set; }

    public virtual DbSet<TeachingAssignment> TeachingAssignment { get; set; }

    public virtual DbSet<tblAttribute> tblAttributes { get; set; }

    public virtual DbSet<tblAttributeGroup> tblAttributeGroups { get; set; }

    public virtual DbSet<tblAttributeGroupDetail> tblAttributeGroupDetails { get; set; }

    public virtual DbSet<tblBRBusinessRule> tblBRBusinessRules { get; set; }

    public virtual DbSet<tblBRItem> tblBRItems { get; set; }

    public virtual DbSet<tblBRItemProperty> tblBRItemProperties { get; set; }

    public virtual DbSet<tblBRItemTypeAppliesTo> tblBRItemTypeAppliesToes { get; set; }

    public virtual DbSet<tblBRLogicalOperatorGroup> tblBRLogicalOperatorGroups { get; set; }

    public virtual DbSet<tblBRStatusTransition> tblBRStatusTransitions { get; set; }

    public virtual DbSet<tblCodeGenInfo> tblCodeGenInfoes { get; set; }

    public virtual DbSet<tblDBError> tblDBErrors { get; set; }

    public virtual DbSet<tblDBUpgradeHistory> tblDBUpgradeHistories { get; set; }

    public virtual DbSet<tblDerivedHierarchy> tblDerivedHierarchies { get; set; }

    public virtual DbSet<tblDerivedHierarchyDetail> tblDerivedHierarchyDetails { get; set; }

    public virtual DbSet<tblEntity> tblEntities { get; set; }

    public virtual DbSet<tblErrorCodesMapping> tblErrorCodesMappings { get; set; }

    public virtual DbSet<tblEvent> tblEvents { get; set; }

    public virtual DbSet<tblExternalSystem> tblExternalSystems { get; set; }

    public virtual DbSet<tblFile> tblFiles { get; set; }

    public virtual DbSet<tblHierarchy> tblHierarchies { get; set; }

    public virtual DbSet<tblIndex> tblIndexes { get; set; }

    public virtual DbSet<tblList> tblLists { get; set; }

    public virtual DbSet<tblListRelationship> tblListRelationships { get; set; }

    public virtual DbSet<tblListRelationshipType> tblListRelationshipTypes { get; set; }

    public virtual DbSet<tblLocalizedString> tblLocalizedStrings { get; set; }

    public virtual DbSet<tblModel> tblModels { get; set; }

    public virtual DbSet<tblModelVersion> tblModelVersions { get; set; }

    public virtual DbSet<tblModelVersionFlag> tblModelVersionFlags { get; set; }

    public virtual DbSet<tblNotificationQueue> tblNotificationQueues { get; set; }

    public virtual DbSet<tblNotificationUser> tblNotificationUsers { get; set; }

    public virtual DbSet<tblSecurityAccessControl> tblSecurityAccessControls { get; set; }

    public virtual DbSet<tblSecurityObject> tblSecurityObjects { get; set; }

    public virtual DbSet<tblSecurityPrivilege> tblSecurityPrivileges { get; set; }

    public virtual DbSet<tblSecurityPrivilegeFunctional> tblSecurityPrivilegeFunctionals { get; set; }

    public virtual DbSet<tblSecurityRole> tblSecurityRoles { get; set; }

    public virtual DbSet<tblSecurityRoleAccess> tblSecurityRoleAccesses { get; set; }

    public virtual DbSet<tblSecurityRoleAccessFunctional> tblSecurityRoleAccessFunctionals { get; set; }

    public virtual DbSet<tblSecurityRoleAccessMember> tblSecurityRoleAccessMembers { get; set; }

    public virtual DbSet<tblStgBatch> tblStgBatches { get; set; }

    public virtual DbSet<tblStgErrorDetail> tblStgErrorDetails { get; set; }

    public virtual DbSet<tblSubscriptionView> tblSubscriptionViews { get; set; }

    public virtual DbSet<tblSyncRelationship> tblSyncRelationships { get; set; }

    public virtual DbSet<tblSystem> tblSystems { get; set; }

    public virtual DbSet<tblSystemSetting> tblSystemSettings { get; set; }

    public virtual DbSet<tblSystemSettingGroup> tblSystemSettingGroups { get; set; }

    public virtual DbSet<tblUser> tblUsers { get; set; }

    public virtual DbSet<tblUserGroup> tblUserGroups { get; set; }

    public virtual DbSet<tblUserGroupAssignment> tblUserGroupAssignments { get; set; }

    public virtual DbSet<tblUserPreference> tblUserPreferences { get; set; }

    public virtual DbSet<tblDataQualityOperationsState> tblDataQualityOperationsStates { get; set; }

    public virtual DbSet<Registration1> Registration1 { get; set; }

}

}
