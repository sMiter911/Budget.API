﻿// <auto-generated />
using System;
using Budget.API.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Budget.API.Migrations
{
    [DbContext(typeof(BudgetApiDBContext))]
    [Migration("20240907132741_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Budget.API.Repository.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Budget.API.Repository.Models.Data_Models.FinancialTransaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<Guid>("CategoryId1")
                        .HasColumnType("uuid");

                    b.Property<string>("CurrencyCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("IncomeType")
                        .HasColumnType("text");

                    b.Property<bool>("IsRecurring")
                        .HasColumnType("boolean");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<string>("PaymentMethod")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Source")
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId1");

                    b.ToTable("FinancialTransactions");
                });

            modelBuilder.Entity("Budget.API.Repository.Models.Data_Models.FinancialTransactionAudit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Action")
                        .HasColumnType("integer");

                    b.Property<string>("Changes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("FinancialTransactionId")
                        .HasColumnType("uuid");

                    b.Property<string>("NewState")
                        .HasColumnType("text");

                    b.Property<string>("PreviousState")
                        .HasColumnType("text");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FinancialTransactionId");

                    b.ToTable("FinancialTransactionAudits");
                });

            modelBuilder.Entity("Budget.API.Repository.Models.Data_Models.FinancialTransactionSummary", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("CurrencyCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<Guid>("FinancialTransactionId")
                        .HasColumnType("uuid");

                    b.Property<string>("RequestPayload")
                        .HasColumnType("text");

                    b.Property<string>("ResponsePayload")
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("FinancialTransactionId")
                        .IsUnique();

                    b.ToTable("FinancialTransactionSummaries");
                });

            modelBuilder.Entity("Budget.API.Repository.Models.Data_Models.FinancialTransaction", b =>
                {
                    b.HasOne("Budget.API.Repository.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Budget.API.Repository.Models.Data_Models.FinancialTransactionAudit", b =>
                {
                    b.HasOne("Budget.API.Repository.Models.Data_Models.FinancialTransaction", "FinancialTransaction")
                        .WithMany()
                        .HasForeignKey("FinancialTransactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FinancialTransaction");
                });

            modelBuilder.Entity("Budget.API.Repository.Models.Data_Models.FinancialTransactionSummary", b =>
                {
                    b.HasOne("Budget.API.Repository.Models.Data_Models.FinancialTransaction", "FinancialTransaction")
                        .WithOne("Summary")
                        .HasForeignKey("Budget.API.Repository.Models.Data_Models.FinancialTransactionSummary", "FinancialTransactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FinancialTransaction");
                });

            modelBuilder.Entity("Budget.API.Repository.Models.Data_Models.FinancialTransaction", b =>
                {
                    b.Navigation("Summary")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
