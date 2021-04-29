using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace report1
{
    public partial class report1Context : DbContext
    {
        public report1Context()
        {
        }

        public report1Context(DbContextOptions<report1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<IncidentReport> IncidentReport { get; set; }
        public virtual DbSet<IrdeptsRelated> IrdeptsRelated { get; set; }
        public virtual DbSet<Irform> Irform { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localDB)\\MsSqlLocalDb;Database=report1;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasKey(e => e.DeptId);

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.DeptMng)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.DeptMngId)
                    .HasConstraintName("FK_DeptManager");
            });

            modelBuilder.Entity<IncidentReport>(entity =>
            {
                entity.HasKey(e => e.Irid)
                    .HasName("PK_IRdetails");

                entity.Property(e => e.Irid).HasColumnName("IRid");

                entity.Property(e => e.IrcompleteDate)
                    .HasColumnName("IRCompleteDate")
                    .HasColumnType("date");

                entity.Property(e => e.IrcreaterId).HasColumnName("IRCreaterId");

                entity.Property(e => e.IrrelatedDept).HasColumnName("IRRelatedDept");

                entity.Property(e => e.IrstartDate)
                    .HasColumnName("IRStartDate")
                    .HasColumnType("date");





                entity.HasOne(d => d.Ircreater)
                    .WithMany(p => p.IncidentReport)
                    .HasForeignKey(d => d.IrcreaterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IRCreater");

                entity.HasOne(d => d.Irform)
                    .WithMany(p => p.IncidentReport)
                    .HasForeignKey(d => d.IrformId)
                    .HasConstraintName("FK_IncidentReport_IncidentReport");
            });

            modelBuilder.Entity<IrdeptsRelated>(entity =>
            {
                entity.HasKey(e => e.IrdeptsRelated1)
                    .HasName("PK__IRDeptsR__727F69A6CF1F2D32");

                entity.ToTable("IRDeptsRelated");

                entity.Property(e => e.IrdeptsRelated1).HasColumnName("IRDeptsRelated");

                entity.Property(e => e.Irdetails).HasColumnName("IRDetails");

                entity.HasOne(d => d.DeptRelatedNavigation)
                    .WithMany(p => p.IrdeptsRelated)
                    .HasForeignKey(d => d.DeptRelated)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeptRelated");

                entity.HasOne(d => d.IrdetailsNavigation)
                    .WithMany(p => p.IrdeptsRelated)
                    .HasForeignKey(d => d.Irdetails)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IRDeptsRelated_IncidentReport");
            });

            modelBuilder.Entity<Irform>(entity =>
            {
                entity.ToTable("IRForm");

                //
                // entity.Property(e => e.IrformId).HasColumnName("IRFormId");
                //

                entity.Property(e => e.IrformId)
                    .HasColumnName("IRFormId");
                //   .ValueGeneratedNever();


                entity.Property(e => e.IncidentTime)
                   .HasColumnName("incidentTime")
                   .HasColumnType("date");



                entity.Property(e => e.ActionFourCompletionDate)
                    .HasColumnName("actionFourCompletionDate")
                    .HasColumnType("date");

                entity.Property(e => e.ActionFourResponsibility)
                    .HasColumnName("actionFourResponsibility")
                    .HasMaxLength(250);

                entity.Property(e => e.ActionFourTargtDate)
                    .HasColumnName("actionFourTargtDate")
                    .HasColumnType("date");

                entity.Property(e => e.ActionOneCompletionDate)
                    .HasColumnName("actionOneCompletionDate")
                    .HasColumnType("date");

                entity.Property(e => e.ActionOneResponsibility)
                    .HasColumnName("actionOneResponsibility")
                    .HasMaxLength(250);

                entity.Property(e => e.ActionOneTargtDate)
                    .HasColumnName("actionOneTargtDate")
                    .HasColumnType("date");

                entity.Property(e => e.ActionThreeCompletionDate)
                    .HasColumnName("actionThreeCompletionDate")
                    .HasColumnType("date");

                entity.Property(e => e.ActionThreeResponsibility)
                    .HasColumnName("actionThreeResponsibility")
                    .HasMaxLength(250);

                entity.Property(e => e.ActionThreeTargtDate)
                    .HasColumnName("actionThreeTargtDate")
                    .HasColumnType("date");

                entity.Property(e => e.ActionTwoCompletionDate)
                    .HasColumnName("actionTwoCompletionDate")
                    .HasColumnType("date");

                entity.Property(e => e.ActionTwoResponsibility)
                    .HasColumnName("actionTwoResponsibility")
                    .HasMaxLength(250);

                entity.Property(e => e.ActionTwoTargtDate)
                    .HasColumnName("actionTwoTargtDate")
                    .HasColumnType("date");

                entity.Property(e => e.AllWitnsSttmntsAttched).HasColumnName("allWitnsSttmntsAttched");

                entity.Property(e => e.CBxAltModEqui).HasColumnName("cBxAltModEqui");

                entity.Property(e => e.CBxBackInjury).HasColumnName("cBxBackInjury");

                entity.Property(e => e.CBxBumpBruise).HasColumnName("cBxBumpBruise");

                entity.Property(e => e.CBxBurn).HasColumnName("cBxBurn");

                entity.Property(e => e.CBxChest).HasColumnName("cBxChest");

                entity.Property(e => e.CBxCongestion).HasColumnName("cBxCongestion");

                entity.Property(e => e.CBxCongestion2).HasColumnName("cBxCongestion2");

                entity.Property(e => e.CBxCut).HasColumnName("cBxCut");

                entity.Property(e => e.CBxDefEquipmnt).HasColumnName("cBxDefEquipmnt");

                entity.Property(e => e.CBxDsgEqpWrksttn).HasColumnName("cBxDsgEqpWrksttn");

                entity.Property(e => e.CBxEye).HasColumnName("cBxEye");

                entity.Property(e => e.CBxFace).HasColumnName("cBxFace");

                entity.Property(e => e.CBxHandScoordntrSgnd).HasColumnName("cBxHandSCoordntrSgnd");

                entity.Property(e => e.CBxHead).HasColumnName("cBxHead");

                entity.Property(e => e.CBxHrmsign).HasColumnName("cBxHRMSign");

                entity.Property(e => e.CBxImpEngDsgWsttn).HasColumnName("cBxImpEngDsgWsttn");

                entity.Property(e => e.CBxImpHsKeeping).HasColumnName("cBxImpHsKeeping");

                entity.Property(e => e.CBxImpInspPrcdr).HasColumnName("cBxImpInspPrcdr");

                entity.Property(e => e.CBxImpWrkProcedure).HasColumnName("cBxImpWrkProcedure");

                entity.Property(e => e.CBxImplmntPrvMntnc).HasColumnName("cBxImplmntPrvMntnc");

                entity.Property(e => e.CBxImpropPosLift).HasColumnName("cBxImpropPosLift");

                entity.Property(e => e.CBxImprvPpe).HasColumnName("cBxImprvPPE");

                entity.Property(e => e.CBxInEdqtPrtEqui).HasColumnName("cBxInEdqtPrtEqui");

                entity.Property(e => e.CBxInadqtSftySys).HasColumnName("cBxInadqtSftySys");

                entity.Property(e => e.CBxInappCndct).HasColumnName("cBxInappCndct");

                entity.Property(e => e.CBxInjuryReported).HasColumnName("cBxInjuryReported");

                entity.Property(e => e.CBxInprprUseOfEqui).HasColumnName("cBxInprprUseOfEqui");

                entity.Property(e => e.CBxInstSftyDev).HasColumnName("cBxInstSftyDev");

                entity.Property(e => e.CBxLacOfkAttn).HasColumnName("cBxLacOfkAttn");

                entity.Property(e => e.CBxLeftAnkle).HasColumnName("cBxLeftAnkle");

                entity.Property(e => e.CBxLeftButtocks).HasColumnName("cBxLeftButtocks");

                entity.Property(e => e.CBxLeftElbow).HasColumnName("cBxLeftElbow");

                entity.Property(e => e.CBxLeftFinder).HasColumnName("cBxLeftFinder");

                entity.Property(e => e.CBxLeftFoot).HasColumnName("cBxLeftFoot");

                entity.Property(e => e.CBxLeftForeArm).HasColumnName("cBxLeftForeArm");

                entity.Property(e => e.CBxLeftGroin).HasColumnName("cBxLeftGroin");

                entity.Property(e => e.CBxLeftHand).HasColumnName("cBxLeftHand");

                entity.Property(e => e.CBxLeftHip).HasColumnName("cBxLeftHip");

                entity.Property(e => e.CBxLeftKnee).HasColumnName("cBxLeftKnee");

                entity.Property(e => e.CBxLeftLowerLeg).HasColumnName("cBxLeftLowerLeg");

                entity.Property(e => e.CBxLeftShoulder).HasColumnName("cBxLeftShoulder");

                entity.Property(e => e.CBxLeftThigh).HasColumnName("cBxLeftThigh");

                entity.Property(e => e.CBxLeftToes).HasColumnName("cBxLeftToes");

                entity.Property(e => e.CBxLeftUpperArm).HasColumnName("cBxLeftUpperArm");

                entity.Property(e => e.CBxLeftWrist).HasColumnName("cBxLeftWrist");

                entity.Property(e => e.CBxLowerBack).HasColumnName("cBxLowerBack");

                entity.Property(e => e.CBxNearMiss).HasColumnName("cBxNearMiss");

                entity.Property(e => e.CBxNeck).HasColumnName("cBxNeck");

                entity.Property(e => e.CBxNtFllwProcdr).HasColumnName("cBxNtFllwProcdr");

                entity.Property(e => e.CBxNtUsePpe).HasColumnName("cBxNtUsePPE");

                entity.Property(e => e.CBxOther).HasColumnName("cBxOther");

                entity.Property(e => e.CBxOverexertion).HasColumnName("cBxOverexertion");

                entity.Property(e => e.CBxPelvis).HasColumnName("cBxPelvis");

                entity.Property(e => e.CBxPoorHsKeeping).HasColumnName("cBxPoorHsKeeping");

                entity.Property(e => e.CBxPracticeOthrExp).HasColumnName("cBxPracticeOthrExp");

                entity.Property(e => e.CBxPrcsChgImprv).HasColumnName("cBxPrcsChgImprv");

                entity.Property(e => e.CBxProdctMngSignd).HasColumnName("cBxProdctMngSignd");

                entity.Property(e => e.CBxPropertyDamage).HasColumnName("cBxPropertyDamage");

                entity.Property(e => e.CBxReAsgnPrsn).HasColumnName("cBxReAsgnPrsn");

                entity.Property(e => e.CBxRepettitiveStrain).HasColumnName("cBxRepettitiveStrain");

                entity.Property(e => e.CBxRightAnkle).HasColumnName("cBxRightAnkle");

                entity.Property(e => e.CBxRightButtock).HasColumnName("cBxRightButtock");

                entity.Property(e => e.CBxRightElbow).HasColumnName("cBxRightElbow");

                entity.Property(e => e.CBxRightFinder).HasColumnName("cBxRightFinder");

                entity.Property(e => e.CBxRightFoot).HasColumnName("cBxRightFoot");

                entity.Property(e => e.CBxRightForeArm).HasColumnName("cBxRightForeArm");

                entity.Property(e => e.CBxRightGroin).HasColumnName("cBxRightGroin");

                entity.Property(e => e.CBxRightHand).HasColumnName("cBxRightHand");

                entity.Property(e => e.CBxRightHip).HasColumnName("cBxRightHip");

                entity.Property(e => e.CBxRightKnee).HasColumnName("cBxRightKnee");

                entity.Property(e => e.CBxRightLowerLeg).HasColumnName("cBxRightLowerLeg");

                entity.Property(e => e.CBxRightShoulder).HasColumnName("cBxRightShoulder");

                entity.Property(e => e.CBxRightThigh).HasColumnName("cBxRightThigh");

                entity.Property(e => e.CBxRightToes).HasColumnName("cBxRightToes");

                entity.Property(e => e.CBxRightUpperArm).HasColumnName("cBxRightUpperArm");

                entity.Property(e => e.CBxRightWrist).HasColumnName("cBxRightWrist");

                entity.Property(e => e.CBxRmvlSaftyDev).HasColumnName("cBxRmvlSaftyDev");

                entity.Property(e => e.CBxRqErgAssmnt).HasColumnName("cBxRqErgAssmnt");

                entity.Property(e => e.CBxRushing).HasColumnName("cBxRushing");

                entity.Property(e => e.CBxSlipFall).HasColumnName("cBxSlipFall");

                entity.Property(e => e.CBxSlpTripHzrd).HasColumnName("cBxSlpTripHzrd");

                entity.Property(e => e.CBxSupervisorSign).HasColumnName("cBxSupervisorSign");

                entity.Property(e => e.CBxTheeth).HasColumnName("cBxTheeth");

                entity.Property(e => e.CBxToolsEquiRprRplc).HasColumnName("cBxToolsEquiRprRplc");

                entity.Property(e => e.CBxTrnInstInvolved).HasColumnName("cBxTrnInstInvolved");

                entity.Property(e => e.CBxTrnInstOther).HasColumnName("cBxTrnInstOther");

                entity.Property(e => e.CBxUpperBack).HasColumnName("cBxUpperBack");

                entity.Property(e => e.DatOfIncident)
                    .HasColumnName("datOfIncident")
                    .HasColumnType("date");

                entity.Property(e => e.DateLearnedOutsideHc)
                    .HasColumnName("dateLearnedOutsideHC")
                    .HasColumnType("date");

                entity.Property(e => e.DateLostTime)
                    .HasColumnName("dateLostTime")
                    .HasColumnType("date");

                entity.Property(e => e.DateModDutyOffered)
                    .HasColumnName("dateModDutyOffered")
                    .HasColumnType("date");

                entity.Property(e => e.DateOfmedAttention)
                    .HasColumnName("dateOfmedAttention")
                    .HasColumnType("date");

                entity.Property(e => e.DateReported)
                    .HasColumnName("dateReported")
                    .HasColumnType("date");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasMaxLength(50);

                entity.Property(e => e.DptMngrSgnd).HasColumnName("dptMngrSgnd");

                entity.Property(e => e.DptMngrSignDate)
                    .HasColumnName("dptMngrSignDate")
                    .HasColumnType("date");

                entity.Property(e => e.ExactLocation)
                    .HasColumnName("exactLocation")
                    .HasMaxLength(100);

                entity.Property(e => e.FafReturned).HasColumnName("fafReturned");

                entity.Property(e => e.FifthWhy)
                    .HasColumnName("fifthWhy")
                    .HasMaxLength(500);

                entity.Property(e => e.FirstAidOnsite).HasColumnName("firstAidOnsite");

                entity.Property(e => e.FirstName)
                    .HasColumnName("firstName")
                    .HasMaxLength(50);

                entity.Property(e => e.FirstWhy)
                    .HasColumnName("firstWhy")
                    .HasMaxLength(500);

                entity.Property(e => e.FourthWhy)
                    .HasColumnName("fourthWhy")
                    .HasMaxLength(500);

                entity.Property(e => e.FullyTrainedNo).HasColumnName("fullyTrainedNo");

                entity.Property(e => e.FullyTrainedYes).HasColumnName("fullyTrainedYes");

                entity.Property(e => e.HandScoordntrSgndSignDate)
                    .HasColumnName("HandSCoordntrSgndSignDate")
                    .HasColumnType("date");

                entity.Property(e => e.HaveLostTime).HasColumnName("haveLostTime");

                entity.Property(e => e.HealthCareProvider)
                    .HasColumnName("healthCareProvider")
                    .HasMaxLength(100);

                entity.Property(e => e.HrmsignDate)
                    .HasColumnName("HRMSignDate")
                    .HasColumnType("date");

                entity.Property(e => e.IncidentReportedTo)
                    .HasColumnName("incidentReportedTo")
                    .HasMaxLength(50);

                //entity.Property(e => e.Irid)
                //    .HasColumnName("IRid")
                //    .ValueGeneratedOnAdd();

                entity.Property(e => e.JhscrepName)
                    .HasColumnName("JHSCrepName")
                    .HasMaxLength(50);

                entity.Property(e => e.JhscsignDate)
                    .HasColumnName("JHSCsignDate")
                    .HasColumnType("date");

                entity.Property(e => e.Jhscsignature)
                    .HasColumnName("JHSCsignature")
                    .HasMaxLength(50);

                entity.Property(e => e.LastHourWorked)
                    .HasColumnName("lastHourWorked")
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .HasColumnName("lastName")
                    .HasMaxLength(50);

                entity.Property(e => e.LengthOfTimeInPosition)
                    .HasColumnName("lengthOfTimeInPosition")
                    .HasMaxLength(50);

                entity.Property(e => e.ModDutyAccepted).HasColumnName("modDutyAccepted");

                entity.Property(e => e.ModDutyDeclined).HasColumnName("modDutyDeclined");

                entity.Property(e => e.ModDutyNoRestriction).HasColumnName("modDutyNoRestriction");

                entity.Property(e => e.ModiedDutiesOffered).HasMaxLength(250);

                entity.Property(e => e.NoMedAttentionRequired).HasColumnName("noMedAttentionRequired");

                entity.Property(e => e.NoWitnesses).HasColumnName("noWitnesses");

                entity.Property(e => e.NotHaveLostTime).HasColumnName("notHaveLostTime");

                entity.Property(e => e.NotProvidedFaf).HasColumnName("notProvidedFAF");

                entity.Property(e => e.NotSentOutforMedicalAttn).HasColumnName("notSentOutforMedicalAttn");

                entity.Property(e => e.NotfafReturned).HasColumnName("notfafReturned");

                entity.Property(e => e.OutsideMedAttention).HasColumnName("outsideMedAttention");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasMaxLength(50);

                entity.Property(e => e.PotentialWitnesses)
                    .HasColumnName("potentialWitnesses")
                    .HasMaxLength(100);

                entity.Property(e => e.PrdcMngrSignDate).HasColumnType("date");

                entity.Property(e => e.ProvidedFaf).HasColumnName("providedFAF");

                entity.Property(e => e.RBtnFatality).HasColumnName("rBtnFatality");

                entity.Property(e => e.RBtnGradually).HasColumnName("rBtnGradually");

                entity.Property(e => e.RBtnOccupational).HasColumnName("rBtnOccupational");

                entity.Property(e => e.RBtnSuddenSpecific).HasColumnName("rBtnSuddenSpecific");

                entity.Property(e => e.RecomdActionFour)
                    .HasColumnName("recomdActionFour")
                    .HasMaxLength(1000);

                entity.Property(e => e.RecomdActionOne)
                    .HasColumnName("recomdActionOne")
                    .HasMaxLength(1000);

                entity.Property(e => e.RecomdActionThree)
                    .HasColumnName("recomdActionThree")
                    .HasMaxLength(1000);

                entity.Property(e => e.RecomdActionTwo)
                    .HasColumnName("recomdActionTwo")
                    .HasMaxLength(1000);

                entity.Property(e => e.SecSevenReport)
                    .HasColumnName("secSevenReport")
                    .HasMaxLength(1000);

                entity.Property(e => e.SecondWhy)
                    .HasColumnName("secondWhy")
                    .HasMaxLength(500);

                entity.Property(e => e.SentOutforMedicalAttn).HasColumnName("sentOutforMedicalAttn");

                entity.Property(e => e.SpecifyPpe)
                    .HasColumnName("SpecifyPPE")
                    .HasMaxLength(100);

                entity.Property(e => e.StateInjury)
                    .HasColumnName("stateInjury")
                    .HasMaxLength(500);

                entity.Property(e => e.SupervisorSignDate).HasColumnType("date");

                entity.Property(e => e.ThirdWhy)
                    .HasColumnName("thirdWhy")
                    .HasMaxLength(500);

                entity.Property(e => e.TimeOfIncident).HasColumnName("timeOfIncident");

                entity.Property(e => e.TxAdescribeIncident)
                    .HasColumnName("txAdescribeIncident")
                    .HasMaxLength(500);

                entity.Property(e => e.TxAhowToPrevent)
                    .HasColumnName("txAhowToPrevent")
                    .HasMaxLength(500);

                entity.Property(e => e.TxApracticeOthrExp)
                    .HasColumnName("txAPracticeOthrExp")
                    .HasMaxLength(500);

                entity.Property(e => e.TxJhscrecomend)
                    .HasColumnName("txJHSCrecomend")
                    .HasMaxLength(500);

                entity.Property(e => e.TxtAsec6Desc)
                    .HasColumnName("txtAsec6Desc")
                    .HasMaxLength(1000);

                entity.Property(e => e.TypeOfAccidentOther).HasMaxLength(150);

                entity.Property(e => e.WearingPpeno).HasColumnName("wearingPPEno");

                entity.Property(e => e.WearingPpeyes).HasColumnName("wearingPPEyes");

                entity.Property(e => e.WhyModiedDutyDeclined).HasMaxLength(250);

                entity.Property(e => e.WitnessSatetements)
                    .HasColumnName("witnessSatetements")
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__Roles__8AFACE1A666CA621");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Users__1788CC4CA4A4B307");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.DepartmentNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Department)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Dpt");

                entity.HasOne(d => d.RoleNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Role)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRole");
            });
        }
    }
}
