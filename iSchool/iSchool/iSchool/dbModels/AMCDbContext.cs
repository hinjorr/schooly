using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace iSchool.dbModels
{
    public partial class AMCDbContext : DbContext
    {
        public AMCDbContext()
        {
        }

        public AMCDbContext(DbContextOptions<AMCDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAssignclass> TblAssignclass { get; set; }
        public virtual DbSet<TblClass> TblClass { get; set; }
        public virtual DbSet<TblCountries> TblCountries { get; set; }
        public virtual DbSet<TblReligion> TblReligion { get; set; }
        public virtual DbSet<TblStudents> TblStudents { get; set; }
        public virtual DbSet<TblSubject> TblSubject { get; set; }
        public virtual DbSet<Tblregistration> Tblregistration { get; set; }
        public virtual DbSet<Tblschoolconfig> Tblschoolconfig { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=1234;database=schooly", x => x.ServerVersion("10.5.8-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAssignclass>(entity =>
            {
                entity.HasKey(e => e.AssignclassId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_assignclass");

                entity.HasIndex(e => e.CId)
                    .HasName("C_Id");

                entity.HasIndex(e => e.SubjectId)
                    .HasName("Subject_id");

                entity.Property(e => e.AssignclassId)
                    .HasColumnName("assignclass_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CId)
                    .HasColumnName("C_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MarksWeightage)
                    .HasColumnName("Marks_Weightage")
                    .HasColumnType("int(25)");

                entity.Property(e => e.SubjectId)
                    .HasColumnName("Subject_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.C)
                    .WithMany(p => p.TblAssignclass)
                    .HasForeignKey(d => d.CId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("tbl_assignclass_ibfk_2");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.TblAssignclass)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("tbl_assignclass_ibfk_1");
            });

            modelBuilder.Entity<TblClass>(entity =>
            {
                entity.HasKey(e => e.CId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_class");

                entity.Property(e => e.CId)
                    .HasColumnName("C_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CFees)
                    .HasColumnName("C_fees")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasColumnName("C_name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<TblCountries>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_countries");

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnName("country_name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TblReligion>(entity =>
            {
                entity.HasKey(e => e.ReligionId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_religion");

                entity.HasIndex(e => e.ReligionId)
                    .HasName("Id");

                entity.Property(e => e.ReligionId)
                    .HasColumnName("ReligionID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Religion)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<TblStudents>(entity =>
            {
                entity.ToTable("tbl_students");

                entity.HasIndex(e => e.Class)
                    .HasName("tbl_students_ibfk_3");

                entity.HasIndex(e => e.CountryId)
                    .HasName("CountryID");

                entity.HasIndex(e => e.ReligionId)
                    .HasName("ReligionID");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.AdmissionDate)
                    .HasColumnName("admission_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Class).HasColumnType("int(11)");

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FatherCnic)
                    .HasColumnName("father_cnic")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FatherIncome)
                    .HasColumnName("father_Income")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FatherName)
                    .HasColumnName("father_name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FatherNumber)
                    .HasColumnName("father_number")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FatherOccupation)
                    .HasColumnName("father_occupation")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Gender)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.MotherCnic)
                    .HasColumnName("mother_cnic")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.MotherIncome)
                    .HasColumnName("mother_income")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.MotherName)
                    .HasColumnName("mother_name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.MotherOccupation)
                    .HasColumnName("mother_occupation")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.MotherPhone)
                    .HasColumnName("mother_phone")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ReligionId)
                    .HasColumnName("ReligionID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StdBform)
                    .HasColumnName("Std_Bform")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.StdName)
                    .IsRequired()
                    .HasColumnName("std_name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.StdNumber)
                    .HasColumnName("std_number")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.StdPic)
                    .HasColumnName("std_pic")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.ClassNavigation)
                    .WithMany(p => p.TblStudents)
                    .HasForeignKey(d => d.Class)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("tbl_students_ibfk_3");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblStudents)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("tbl_students_ibfk_2");

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.TblStudents)
                    .HasForeignKey(d => d.ReligionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("tbl_students_ibfk_1");
            });

            modelBuilder.Entity<TblSubject>(entity =>
            {
                entity.HasKey(e => e.SubjectId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_subject");

                entity.Property(e => e.SubjectId)
                    .HasColumnName("Subject_id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SubjectName)
                    .IsRequired()
                    .HasColumnName("Subject_name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Tblregistration>(entity =>
            {
                entity.ToTable("tblregistration");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Tblschoolconfig>(entity =>
            {
                entity.ToTable("tblschoolconfig");

                entity.HasIndex(e => e.CountryId)
                    .HasName("CountryID");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.AdmissionFee)
                    .HasColumnName("admission_fee")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BooksFee)
                    .HasColumnName("books_fee")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FineFee)
                    .HasColumnName("Fine_fee")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Logo)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Moto)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.RegistrationFee)
                    .HasColumnName("registration_fee")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RulesRegulations)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.TransportFee)
                    .HasColumnName("transport_fee")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Website)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Tblschoolconfig)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("tblschoolconfig_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
