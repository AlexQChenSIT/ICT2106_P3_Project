﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YouthActionDotNet.Data;

#nullable disable

namespace YouthActionDotNet.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("YouthActionDotNet.Models.Donations", b =>
                {
                    b.Property<string>("DonationsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("DonationAmount")
                        .HasColumnType("TEXT");

                    b.Property<string>("DonationConstraint")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DonationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("DonationType")
                        .HasColumnType("TEXT");

                    b.Property<string>("DonorId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectId")
                        .HasColumnType("TEXT");

                    b.HasKey("DonationsId");

                    b.HasIndex("DonorId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Donations", (string)null);
                });

            modelBuilder.Entity("YouthActionDotNet.Models.Expense", b =>
                {
                    b.Property<string>("ExpenseId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ApprovalId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfExpense")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfReimbursement")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfSubmission")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExpenseAmount")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExpenseDesc")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExpenseReceipt")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.HasKey("ExpenseId");

                    b.HasIndex("ApprovalId");

                    b.HasIndex("ExpenseReceipt");

                    b.HasIndex("ProjectId");

                    b.ToTable("Expense", (string)null);
                });

            modelBuilder.Entity("YouthActionDotNet.Models.File", b =>
                {
                    b.Property<string>("FileId")
                        .HasColumnType("TEXT");

                    b.Property<string>("FileExt")
                        .HasColumnType("TEXT");

                    b.Property<string>("FileMIME")
                        .HasColumnType("TEXT");

                    b.Property<string>("FileName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FileUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("FileId");

                    b.ToTable("File", (string)null);
                });

            modelBuilder.Entity("YouthActionDotNet.Models.Permissions", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Permission")
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Permissions", (string)null);
                });

            modelBuilder.Entity("YouthActionDotNet.Models.Project", b =>
                {
                    b.Property<string>("ProjectId")
                        .HasColumnType("TEXT");

                    b.Property<double>("ProjectBudget")
                        .HasColumnType("REAL");

                    b.Property<string>("ProjectCompletionDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectEndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectStartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectStatus")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ServiceCenterId")
                        .HasColumnType("TEXT");

                    b.HasKey("ProjectId");

                    b.HasIndex("ServiceCenterId");

                    b.ToTable("Project", (string)null);
                });

            modelBuilder.Entity("YouthActionDotNet.Models.ServiceCenter", b =>
                {
                    b.Property<string>("ServiceCenterId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RegionalDirectorId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RegionalDirectorName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ServiceCenterAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("ServiceCenterName")
                        .HasColumnType("TEXT");

                    b.HasKey("ServiceCenterId");

                    b.HasIndex("RegionalDirectorId");

                    b.ToTable("ServiceCenter", (string)null);
                });

            modelBuilder.Entity("YouthActionDotNet.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT");

                    b.Property<string>("address")
                        .HasColumnType("TEXT");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("username")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("YouthActionDotNet.Models.VolunteerWork", b =>
                {
                    b.Property<string>("VolunteerWorkId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ShiftEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("ShiftStart")
                        .HasColumnType("TEXT");

                    b.Property<string>("SupervisingEmployee")
                        .HasColumnType("TEXT");

                    b.Property<string>("VolunteerId")
                        .HasColumnType("TEXT");

                    b.Property<string>("projectId")
                        .HasColumnType("TEXT");

                    b.HasKey("VolunteerWorkId");

                    b.HasIndex("SupervisingEmployee");

                    b.HasIndex("VolunteerId");

                    b.HasIndex("projectId");

                    b.ToTable("VolunteerWork", (string)null);
                });

            modelBuilder.Entity("YouthActionDotNet.Models.Donor", b =>
                {
                    b.HasBaseType("YouthActionDotNet.Models.User");

                    b.Property<string>("donorName")
                        .HasColumnType("TEXT");

                    b.Property<string>("donorType")
                        .HasColumnType("TEXT");

                    b.ToTable("Donor", (string)null);
                });

            modelBuilder.Entity("YouthActionDotNet.Models.Employee", b =>
                {
                    b.HasBaseType("YouthActionDotNet.Models.User");

                    b.Property<string>("BankAccountNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("BankName")
                        .HasColumnType("TEXT");

                    b.Property<string>("DateJoined")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeNationalId")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeRole")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeType")
                        .HasColumnType("TEXT");

                    b.Property<string>("PAYE")
                        .HasColumnType("TEXT");

                    b.ToTable("Employee", (string)null);
                });

            modelBuilder.Entity("YouthActionDotNet.Models.Volunteer", b =>
                {
                    b.HasBaseType("YouthActionDotNet.Models.User");

                    b.Property<string>("ApprovalStatus")
                        .HasColumnType("TEXT");

                    b.Property<string>("ApprovedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("CriminalHistory")
                        .HasColumnType("TEXT");

                    b.Property<string>("CriminalHistoryDesc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Qualifications")
                        .HasColumnType("TEXT");

                    b.Property<string>("VolunteerDateBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("VolunteerDateJoined")
                        .HasColumnType("TEXT");

                    b.Property<string>("VolunteerNationalId")
                        .HasColumnType("TEXT");

                    b.HasIndex("ApprovedBy");

                    b.ToTable("Volunteer", (string)null);
                });

            modelBuilder.Entity("YouthActionDotNet.Models.Donations", b =>
                {
                    b.HasOne("YouthActionDotNet.Models.Donor", "donor")
                        .WithMany()
                        .HasForeignKey("DonorId");

                    b.HasOne("YouthActionDotNet.Models.Project", "project")
                        .WithMany()
                        .HasForeignKey("ProjectId");

                    b.Navigation("donor");

                    b.Navigation("project");
                });

            modelBuilder.Entity("YouthActionDotNet.Models.Expense", b =>
                {
                    b.HasOne("YouthActionDotNet.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("ApprovalId");

                    b.HasOne("YouthActionDotNet.Models.File", "ExpenseReceiptFile")
                        .WithMany()
                        .HasForeignKey("ExpenseReceipt");

                    b.HasOne("YouthActionDotNet.Models.Project", "project")
                        .WithMany()
                        .HasForeignKey("ProjectId");

                    b.Navigation("ExpenseReceiptFile");

                    b.Navigation("project");

                    b.Navigation("user");
                });

            modelBuilder.Entity("YouthActionDotNet.Models.Project", b =>
                {
                    b.HasOne("YouthActionDotNet.Models.ServiceCenter", "ServiceCenter")
                        .WithMany()
                        .HasForeignKey("ServiceCenterId");

                    b.Navigation("ServiceCenter");
                });

            modelBuilder.Entity("YouthActionDotNet.Models.ServiceCenter", b =>
                {
                    b.HasOne("YouthActionDotNet.Models.Employee", "RegionalDirector")
                        .WithMany()
                        .HasForeignKey("RegionalDirectorId");

                    b.Navigation("RegionalDirector");
                });

            modelBuilder.Entity("YouthActionDotNet.Models.VolunteerWork", b =>
                {
                    b.HasOne("YouthActionDotNet.Models.Employee", "employee")
                        .WithMany()
                        .HasForeignKey("SupervisingEmployee");

                    b.HasOne("YouthActionDotNet.Models.Volunteer", "volunteer")
                        .WithMany()
                        .HasForeignKey("VolunteerId");

                    b.HasOne("YouthActionDotNet.Models.Project", "project")
                        .WithMany()
                        .HasForeignKey("projectId");

                    b.Navigation("employee");

                    b.Navigation("project");

                    b.Navigation("volunteer");
                });

            modelBuilder.Entity("YouthActionDotNet.Models.Donor", b =>
                {
                    b.HasOne("YouthActionDotNet.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("YouthActionDotNet.Models.Employee", b =>
                {
                    b.HasOne("YouthActionDotNet.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("YouthActionDotNet.Models.Volunteer", b =>
                {
                    b.HasOne("YouthActionDotNet.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("ApprovedBy");

                    b.HasOne("YouthActionDotNet.Models.User", null)
                        .WithOne()
                        .HasForeignKey("YouthActionDotNet.Models.Volunteer", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
