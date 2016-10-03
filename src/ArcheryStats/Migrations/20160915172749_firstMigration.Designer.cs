using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ArcheryStats;

namespace ArcheryStats.Migrations
{
    [DbContext(typeof(ArcheryStatsContext))]
    [Migration("20160915172749_firstMigration")]
    partial class firstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArcheryStats.Models.PracticeStatistics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlackHits");

                    b.Property<int>("BlueHits");

                    b.Property<DateTime>("Created");

                    b.Property<int>("NumberOfShots");

                    b.Property<DateTime>("PracticeDate");

                    b.Property<int>("RedHits");

                    b.Property<DateTime>("Updated");

                    b.Property<int>("WhiteHits");

                    b.Property<int>("YellowHits");

                    b.HasKey("Id");

                    b.ToTable("PracticeStatistics");
                });
        }
    }
}
