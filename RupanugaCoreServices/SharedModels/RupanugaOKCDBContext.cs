using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RupanugaCoreServices.SharedModels
{
    public partial class RupanugaOKCDBContext : DbContext
    {
        public RupanugaOKCDBContext()
        {
        }

        public RupanugaOKCDBContext(DbContextOptions<RupanugaOKCDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<CommitteeMembers> CommitteeMembers { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Donations> Donations { get; set; }
        public virtual DbSet<DonationType> DonationType { get; set; }
        public virtual DbSet<Emails> Emails { get; set; }
        public virtual DbSet<Enquiry> Enquiry { get; set; }
        public virtual DbSet<EnquiryType> EnquiryType { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Expense> Expense { get; set; }
        public virtual DbSet<ExpenseType> ExpenseType { get; set; }
        public virtual DbSet<Faq> Faq { get; set; }
        public virtual DbSet<GuestInfo> GuestInfo { get; set; }
        public virtual DbSet<GuestInfoServiceType> GuestInfoServiceType { get; set; }
        public virtual DbSet<Media> Media { get; set; }
        public virtual DbSet<MediaType> MediaType { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<MessageType> MessageType { get; set; }
        public virtual DbSet<ServiceType> ServiceType { get; set; }
        public virtual DbSet<Title> Title { get; set; }
        public virtual DbSet<Vaishnavas> Vaishnavas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("data source=INV6316;initial catalog=ISKCON_OKC;integrated security=True;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ZipPlus4)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<CommitteeMembers>(entity =>
            {
                entity.HasKey(e => e.CommitteeMemberId);

                entity.Property(e => e.EffectiveEndDate).HasColumnType("datetime");

                entity.Property(e => e.EffectiveFromDate).HasColumnType("datetime");

                entity.HasOne(d => d.GuestInfo)
                    .WithMany(p => p.CommitteeMembers)
                    .HasForeignKey(d => d.GuestInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommitteeMembers_GuestInfo");

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.CommitteeMembers)
                    .HasForeignKey(d => d.TitleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommitteeMembers_Title");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasIndex(e => e.IdentityId);

                entity.HasOne(d => d.Identity)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.IdentityId);
            });

            modelBuilder.Entity<Donations>(entity =>
            {
                entity.HasKey(e => e.DonationId);

                entity.Property(e => e.Comments)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsAnonymus).HasColumnName("isAnonymus");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransRefNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Donations)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_Donations_Address");

                entity.HasOne(d => d.DonationType)
                    .WithMany(p => p.Donations)
                    .HasForeignKey(d => d.DonationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Donations_DonationType");

                entity.HasOne(d => d.GuestInfo)
                    .WithMany(p => p.Donations)
                    .HasForeignKey(d => d.GuestInfoId)
                    .HasConstraintName("FK_Donations_GuestInfo");
            });

            modelBuilder.Entity<DonationType>(entity =>
            {
                entity.Property(e => e.DonationTypeId).HasColumnName("DonationTypeID");

                entity.Property(e => e.DonationTypeDescription)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Emails>(entity =>
            {
                entity.HasKey(e => e.EmaiIid);

                entity.Property(e => e.EmaiIid).HasColumnName("EmaiIId");

                entity.Property(e => e.Bcc)
                    .HasColumnName("BCC")
                    .IsUnicode(false);

                entity.Property(e => e.Cc)
                    .HasColumnName("CC")
                    .IsUnicode(false);

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.Emailbody)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Enquiry>(entity =>
            {
                entity.Property(e => e.EnquiryDate).HasColumnType("datetime");

                entity.Property(e => e.EnquiryDesc)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FromEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsReplied).HasColumnName("isReplied");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.EnquiryType)
                    .WithMany(p => p.Enquiry)
                    .HasForeignKey(d => d.EnquiryTypeId)
                    .HasConstraintName("FK_Enquiry_EnquiryType");

                entity.HasOne(d => d.RepliedEmail)
                    .WithMany(p => p.Enquiry)
                    .HasForeignKey(d => d.RepliedEmailId)
                    .HasConstraintName("FK_Enquiry_Emails");
            });

            modelBuilder.Entity<EnquiryType>(entity =>
            {
                entity.Property(e => e.EnquiryType1)
                    .IsRequired()
                    .HasColumnName("EnquiryType")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.HasKey(e => e.Eventd);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Topic)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Vaishnava)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.VaishnavaId)
                    .HasConstraintName("FK_Events_Vaishnavas");
            });

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Comments)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.SpentBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.ExpenseType)
                    .WithMany(p => p.Expense)
                    .HasForeignKey(d => d.ExpenseTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Expense_ExpenseType");

                entity.HasOne(d => d.Guest)
                    .WithMany(p => p.Expense)
                    .HasForeignKey(d => d.GuestId)
                    .HasConstraintName("FK_Expense_GuestInfo");
            });

            modelBuilder.Entity<ExpenseType>(entity =>
            {
                entity.Property(e => e.ExpenseName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Faq>(entity =>
            {
                entity.ToTable("FAQ");

                entity.Property(e => e.Faqid).HasColumnName("FAQId");

                entity.Property(e => e.Answer)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GuestInfo>(entity =>
            {
                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.GuestInfo)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_GuestInfo_Address");
            });

            modelBuilder.Entity<GuestInfoServiceType>(entity =>
            {
                entity.HasKey(e => new { e.GuestInfoId, e.ServiceTypeId });

                entity.Property(e => e.GuestInfoServiceTypeId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Media>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.MediaLoc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MediaType)
                    .WithMany(p => p.MediaNavigation)
                    .HasForeignKey(d => d.MediaTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Media_MediaType");
            });

            modelBuilder.Entity<MediaType>(entity =>
            {
                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Media)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Messages>(entity =>
            {
                entity.HasKey(e => e.MessageId);

                entity.Property(e => e.MessageEndDate).HasColumnType("datetime");

                entity.Property(e => e.MessageStartDate).HasColumnType("datetime");

                entity.Property(e => e.MessageText)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MessageType>(entity =>
            {
                entity.Property(e => e.MessageTypeText)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ServiceType>(entity =>
            {
                entity.Property(e => e.ServiceDescription)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ServiceTypeName)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Title>(entity =>
            {
                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TitleName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vaishnavas>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLoc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
