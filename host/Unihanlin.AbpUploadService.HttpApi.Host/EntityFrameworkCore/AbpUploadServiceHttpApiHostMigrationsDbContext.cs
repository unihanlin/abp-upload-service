﻿using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;

namespace Unihanlin.AbpUploadService.EntityFrameworkCore;

public class AbpUploadServiceHttpApiHostMigrationsDbContext : AbpDbContext<AbpUploadServiceHttpApiHostMigrationsDbContext>
{
    public AbpUploadServiceHttpApiHostMigrationsDbContext(DbContextOptions<AbpUploadServiceHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureAbpUploadService();
        modelBuilder.ConfigureAuditLogging();
        modelBuilder.ConfigurePermissionManagement();
        modelBuilder.ConfigureSettingManagement();
    }
}
