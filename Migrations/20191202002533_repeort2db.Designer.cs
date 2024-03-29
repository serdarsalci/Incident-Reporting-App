﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using report1;

namespace report1.Migrations
{
    [DbContext(typeof(report1Context))]
    [Migration("20191202002533_repeort2db")]
    partial class repeort2db
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("report1.Departments", b =>
                {
                    b.Property<int>("DeptId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DeptMngId");

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("DeptId");

                    b.HasIndex("DeptMngId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("report1.IncidentReport", b =>
                {
                    b.Property<int>("Irid")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IRid")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("IrcompleteDate")
                        .HasColumnName("IRCompleteDate")
                        .HasColumnType("date");

                    b.Property<int>("IrcreaterId")
                        .HasColumnName("IRCreaterId");

                    b.Property<int?>("IrformId");

                    b.Property<int?>("IrrelatedDept")
                        .HasColumnName("IRRelatedDept");

                    b.Property<DateTime?>("IrstartDate")
                        .HasColumnName("IRStartDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsComplete");

                    b.HasKey("Irid")
                        .HasName("PK_IRdetails");

                    b.HasIndex("IrcreaterId");

                    b.HasIndex("IrformId");

                    b.ToTable("IncidentReport");
                });

            modelBuilder.Entity("report1.IrdeptsRelated", b =>
                {
                    b.Property<int>("IrdeptsRelated1")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IRDeptsRelated")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeptRelated");

                    b.Property<int>("Irdetails")
                        .HasColumnName("IRDetails");

                    b.HasKey("IrdeptsRelated1")
                        .HasName("PK__IRDeptsR__727F69A6CF1F2D32");

                    b.HasIndex("DeptRelated");

                    b.HasIndex("Irdetails");

                    b.ToTable("IRDeptsRelated");
                });

            modelBuilder.Entity("report1.Irform", b =>
                {
                    b.Property<int>("IrformId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IRFormId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ActionFourCompletionDate")
                        .HasColumnName("actionFourCompletionDate")
                        .HasColumnType("date");

                    b.Property<string>("ActionFourResponsibility")
                        .HasColumnName("actionFourResponsibility")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("ActionFourTargtDate")
                        .HasColumnName("actionFourTargtDate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("ActionOneCompletionDate")
                        .HasColumnName("actionOneCompletionDate")
                        .HasColumnType("date");

                    b.Property<string>("ActionOneResponsibility")
                        .HasColumnName("actionOneResponsibility")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("ActionOneTargtDate")
                        .HasColumnName("actionOneTargtDate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("ActionThreeCompletionDate")
                        .HasColumnName("actionThreeCompletionDate")
                        .HasColumnType("date");

                    b.Property<string>("ActionThreeResponsibility")
                        .HasColumnName("actionThreeResponsibility")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("ActionThreeTargtDate")
                        .HasColumnName("actionThreeTargtDate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("ActionTwoCompletionDate")
                        .HasColumnName("actionTwoCompletionDate")
                        .HasColumnType("date");

                    b.Property<string>("ActionTwoResponsibility")
                        .HasColumnName("actionTwoResponsibility")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("ActionTwoTargtDate")
                        .HasColumnName("actionTwoTargtDate")
                        .HasColumnType("date");

                    b.Property<bool>("AllWitnsSttmntsAttched")
                        .HasColumnName("allWitnsSttmntsAttched");

                    b.Property<bool>("CBxAltModEqui")
                        .HasColumnName("cBxAltModEqui");

                    b.Property<bool>("CBxBackInjury")
                        .HasColumnName("cBxBackInjury");

                    b.Property<bool>("CBxBumpBruise")
                        .HasColumnName("cBxBumpBruise");

                    b.Property<bool>("CBxBurn")
                        .HasColumnName("cBxBurn");

                    b.Property<bool>("CBxChest")
                        .HasColumnName("cBxChest");

                    b.Property<bool>("CBxCongestion")
                        .HasColumnName("cBxCongestion");

                    b.Property<bool>("CBxCongestion2")
                        .HasColumnName("cBxCongestion2");

                    b.Property<bool>("CBxCut")
                        .HasColumnName("cBxCut");

                    b.Property<bool>("CBxDefEquipmnt")
                        .HasColumnName("cBxDefEquipmnt");

                    b.Property<bool>("CBxDsgEqpWrksttn")
                        .HasColumnName("cBxDsgEqpWrksttn");

                    b.Property<bool>("CBxEye")
                        .HasColumnName("cBxEye");

                    b.Property<bool>("CBxFace")
                        .HasColumnName("cBxFace");

                    b.Property<bool>("CBxHandScoordntrSgnd")
                        .HasColumnName("cBxHandSCoordntrSgnd");

                    b.Property<bool>("CBxHead")
                        .HasColumnName("cBxHead");

                    b.Property<bool>("CBxHrmsign")
                        .HasColumnName("cBxHRMSign");

                    b.Property<bool>("CBxImpEngDsgWsttn")
                        .HasColumnName("cBxImpEngDsgWsttn");

                    b.Property<bool>("CBxImpHsKeeping")
                        .HasColumnName("cBxImpHsKeeping");

                    b.Property<bool>("CBxImpInspPrcdr")
                        .HasColumnName("cBxImpInspPrcdr");

                    b.Property<bool>("CBxImpWrkProcedure")
                        .HasColumnName("cBxImpWrkProcedure");

                    b.Property<bool>("CBxImplmntPrvMntnc")
                        .HasColumnName("cBxImplmntPrvMntnc");

                    b.Property<bool>("CBxImpropPosLift")
                        .HasColumnName("cBxImpropPosLift");

                    b.Property<bool>("CBxImprvPpe")
                        .HasColumnName("cBxImprvPPE");

                    b.Property<bool>("CBxInEdqtPrtEqui")
                        .HasColumnName("cBxInEdqtPrtEqui");

                    b.Property<bool>("CBxInadqtSftySys")
                        .HasColumnName("cBxInadqtSftySys");

                    b.Property<bool>("CBxInappCndct")
                        .HasColumnName("cBxInappCndct");

                    b.Property<bool>("CBxInjuryReported")
                        .HasColumnName("cBxInjuryReported");

                    b.Property<bool>("CBxInprprUseOfEqui")
                        .HasColumnName("cBxInprprUseOfEqui");

                    b.Property<bool>("CBxInstSftyDev")
                        .HasColumnName("cBxInstSftyDev");

                    b.Property<bool>("CBxLacOfkAttn")
                        .HasColumnName("cBxLacOfkAttn");

                    b.Property<bool>("CBxLeftAnkle")
                        .HasColumnName("cBxLeftAnkle");

                    b.Property<bool>("CBxLeftButtocks")
                        .HasColumnName("cBxLeftButtocks");

                    b.Property<bool>("CBxLeftElbow")
                        .HasColumnName("cBxLeftElbow");

                    b.Property<bool>("CBxLeftFinder")
                        .HasColumnName("cBxLeftFinder");

                    b.Property<bool>("CBxLeftFoot")
                        .HasColumnName("cBxLeftFoot");

                    b.Property<bool>("CBxLeftForeArm")
                        .HasColumnName("cBxLeftForeArm");

                    b.Property<bool>("CBxLeftGroin")
                        .HasColumnName("cBxLeftGroin");

                    b.Property<bool>("CBxLeftHand")
                        .HasColumnName("cBxLeftHand");

                    b.Property<bool>("CBxLeftHip")
                        .HasColumnName("cBxLeftHip");

                    b.Property<bool>("CBxLeftKnee")
                        .HasColumnName("cBxLeftKnee");

                    b.Property<bool>("CBxLeftLowerLeg")
                        .HasColumnName("cBxLeftLowerLeg");

                    b.Property<bool>("CBxLeftShoulder")
                        .HasColumnName("cBxLeftShoulder");

                    b.Property<bool>("CBxLeftThigh")
                        .HasColumnName("cBxLeftThigh");

                    b.Property<bool>("CBxLeftToes")
                        .HasColumnName("cBxLeftToes");

                    b.Property<bool>("CBxLeftUpperArm")
                        .HasColumnName("cBxLeftUpperArm");

                    b.Property<bool>("CBxLeftWrist")
                        .HasColumnName("cBxLeftWrist");

                    b.Property<bool>("CBxLowerBack")
                        .HasColumnName("cBxLowerBack");

                    b.Property<bool>("CBxNearMiss")
                        .HasColumnName("cBxNearMiss");

                    b.Property<bool>("CBxNeck")
                        .HasColumnName("cBxNeck");

                    b.Property<bool>("CBxNtFllwProcdr")
                        .HasColumnName("cBxNtFllwProcdr");

                    b.Property<bool>("CBxNtUsePpe")
                        .HasColumnName("cBxNtUsePPE");

                    b.Property<bool>("CBxOther")
                        .HasColumnName("cBxOther");

                    b.Property<bool>("CBxOverexertion")
                        .HasColumnName("cBxOverexertion");

                    b.Property<bool>("CBxPelvis")
                        .HasColumnName("cBxPelvis");

                    b.Property<bool>("CBxPoorHsKeeping")
                        .HasColumnName("cBxPoorHsKeeping");

                    b.Property<bool>("CBxPracticeOthrExp")
                        .HasColumnName("cBxPracticeOthrExp");

                    b.Property<bool>("CBxPrcsChgImprv")
                        .HasColumnName("cBxPrcsChgImprv");

                    b.Property<bool>("CBxProdctMngSignd")
                        .HasColumnName("cBxProdctMngSignd");

                    b.Property<bool>("CBxPropertyDamage")
                        .HasColumnName("cBxPropertyDamage");

                    b.Property<bool>("CBxReAsgnPrsn")
                        .HasColumnName("cBxReAsgnPrsn");

                    b.Property<bool>("CBxRepettitiveStrain")
                        .HasColumnName("cBxRepettitiveStrain");

                    b.Property<bool>("CBxRightAnkle")
                        .HasColumnName("cBxRightAnkle");

                    b.Property<bool>("CBxRightButtock")
                        .HasColumnName("cBxRightButtock");

                    b.Property<bool>("CBxRightElbow")
                        .HasColumnName("cBxRightElbow");

                    b.Property<bool>("CBxRightFinder")
                        .HasColumnName("cBxRightFinder");

                    b.Property<bool>("CBxRightFoot")
                        .HasColumnName("cBxRightFoot");

                    b.Property<bool>("CBxRightForeArm")
                        .HasColumnName("cBxRightForeArm");

                    b.Property<bool>("CBxRightGroin")
                        .HasColumnName("cBxRightGroin");

                    b.Property<bool>("CBxRightHand")
                        .HasColumnName("cBxRightHand");

                    b.Property<bool>("CBxRightHip")
                        .HasColumnName("cBxRightHip");

                    b.Property<bool>("CBxRightKnee")
                        .HasColumnName("cBxRightKnee");

                    b.Property<bool>("CBxRightLowerLeg")
                        .HasColumnName("cBxRightLowerLeg");

                    b.Property<bool>("CBxRightShoulder")
                        .HasColumnName("cBxRightShoulder");

                    b.Property<bool>("CBxRightThigh")
                        .HasColumnName("cBxRightThigh");

                    b.Property<bool>("CBxRightToes")
                        .HasColumnName("cBxRightToes");

                    b.Property<bool>("CBxRightUpperArm")
                        .HasColumnName("cBxRightUpperArm");

                    b.Property<bool>("CBxRightWrist")
                        .HasColumnName("cBxRightWrist");

                    b.Property<bool>("CBxRmvlSaftyDev")
                        .HasColumnName("cBxRmvlSaftyDev");

                    b.Property<bool>("CBxRqErgAssmnt")
                        .HasColumnName("cBxRqErgAssmnt");

                    b.Property<bool>("CBxRushing")
                        .HasColumnName("cBxRushing");

                    b.Property<bool>("CBxSlipFall")
                        .HasColumnName("cBxSlipFall");

                    b.Property<bool>("CBxSlpTripHzrd")
                        .HasColumnName("cBxSlpTripHzrd");

                    b.Property<bool>("CBxSupervisorSign")
                        .HasColumnName("cBxSupervisorSign");

                    b.Property<bool>("CBxTheeth")
                        .HasColumnName("cBxTheeth");

                    b.Property<bool>("CBxToolsEquiRprRplc")
                        .HasColumnName("cBxToolsEquiRprRplc");

                    b.Property<bool>("CBxTrnInstInvolved")
                        .HasColumnName("cBxTrnInstInvolved");

                    b.Property<bool>("CBxTrnInstOther")
                        .HasColumnName("cBxTrnInstOther");

                    b.Property<bool>("CBxUpperBack")
                        .HasColumnName("cBxUpperBack");

                    b.Property<DateTime?>("DatOfIncident")
                        .HasColumnName("datOfIncident")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateLearnedOutsideHc")
                        .HasColumnName("dateLearnedOutsideHC")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateLostTime")
                        .HasColumnName("dateLostTime")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateModDutyOffered")
                        .HasColumnName("dateModDutyOffered")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateOfmedAttention")
                        .HasColumnName("dateOfmedAttention")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateReported")
                        .HasColumnName("dateReported")
                        .HasColumnType("date");

                    b.Property<string>("Department")
                        .HasColumnName("department")
                        .HasMaxLength(50);

                    b.Property<bool>("DptMngrSgnd")
                        .HasColumnName("dptMngrSgnd");

                    b.Property<DateTime?>("DptMngrSignDate")
                        .HasColumnName("dptMngrSignDate")
                        .HasColumnType("date");

                    b.Property<string>("ExactLocation")
                        .HasColumnName("exactLocation")
                        .HasMaxLength(100);

                    b.Property<bool>("FafReturned")
                        .HasColumnName("fafReturned");

                    b.Property<string>("FifthWhy")
                        .HasColumnName("fifthWhy")
                        .HasMaxLength(500);

                    b.Property<bool>("FirstAidOnsite")
                        .HasColumnName("firstAidOnsite");

                    b.Property<string>("FirstName")
                        .HasColumnName("firstName")
                        .HasMaxLength(50);

                    b.Property<string>("FirstWhy")
                        .HasColumnName("firstWhy")
                        .HasMaxLength(500);

                    b.Property<string>("FourthWhy")
                        .HasColumnName("fourthWhy")
                        .HasMaxLength(500);

                    b.Property<bool>("FullyTrainedNo")
                        .HasColumnName("fullyTrainedNo");

                    b.Property<bool>("FullyTrainedYes")
                        .HasColumnName("fullyTrainedYes");

                    b.Property<DateTime?>("HandScoordntrSgndSignDate")
                        .HasColumnName("HandSCoordntrSgndSignDate")
                        .HasColumnType("date");

                    b.Property<bool>("HaveLostTime")
                        .HasColumnName("haveLostTime");

                    b.Property<string>("HealthCareProvider")
                        .HasColumnName("healthCareProvider")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("HrmsignDate")
                        .HasColumnName("HRMSignDate")
                        .HasColumnType("date");

                    b.Property<string>("IncidentReportedTo")
                        .HasColumnName("incidentReportedTo")
                        .HasMaxLength(50);

                    b.Property<string>("JhscrepName")
                        .HasColumnName("JHSCrepName")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("JhscsignDate")
                        .HasColumnName("JHSCsignDate")
                        .HasColumnType("date");

                    b.Property<string>("Jhscsignature")
                        .HasColumnName("JHSCsignature")
                        .HasMaxLength(50);

                    b.Property<string>("LastHourWorked")
                        .HasColumnName("lastHourWorked")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .HasColumnName("lastName")
                        .HasMaxLength(50);

                    b.Property<bool>("LeftHand");

                    b.Property<string>("LengthOfTimeInPosition")
                        .HasColumnName("lengthOfTimeInPosition")
                        .HasMaxLength(50);

                    b.Property<bool>("ModDutyAccepted")
                        .HasColumnName("modDutyAccepted");

                    b.Property<bool>("ModDutyDeclined")
                        .HasColumnName("modDutyDeclined");

                    b.Property<bool>("ModDutyNoRestriction")
                        .HasColumnName("modDutyNoRestriction");

                    b.Property<string>("ModiedDutiesOffered")
                        .HasMaxLength(250);

                    b.Property<bool>("NoFurtherReport");

                    b.Property<bool>("NoMedAttentionRequired")
                        .HasColumnName("noMedAttentionRequired");

                    b.Property<bool>("NoWitnesses")
                        .HasColumnName("noWitnesses");

                    b.Property<bool>("NotHaveLostTime")
                        .HasColumnName("notHaveLostTime");

                    b.Property<bool>("NotProvidedFaf")
                        .HasColumnName("notProvidedFAF");

                    b.Property<bool>("NotSentOutforMedicalAttn")
                        .HasColumnName("notSentOutforMedicalAttn");

                    b.Property<bool>("NotfafReturned")
                        .HasColumnName("notfafReturned");

                    b.Property<bool>("OutsideMedAttention")
                        .HasColumnName("outsideMedAttention");

                    b.Property<string>("Position")
                        .HasColumnName("position")
                        .HasMaxLength(50);

                    b.Property<string>("PotentialWitnesses")
                        .HasColumnName("potentialWitnesses")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("PrdcMngrSignDate")
                        .HasColumnType("date");

                    b.Property<bool>("ProvidedFaf")
                        .HasColumnName("providedFAF");

                    b.Property<bool>("RBtnFatality")
                        .HasColumnName("rBtnFatality");

                    b.Property<bool>("RBtnGradually")
                        .HasColumnName("rBtnGradually");

                    b.Property<bool>("RBtnOccupational")
                        .HasColumnName("rBtnOccupational");

                    b.Property<bool>("RBtnSuddenSpecific")
                        .HasColumnName("rBtnSuddenSpecific");

                    b.Property<string>("RecomdActionFour")
                        .HasColumnName("recomdActionFour")
                        .HasMaxLength(1000);

                    b.Property<string>("RecomdActionOne")
                        .HasColumnName("recomdActionOne")
                        .HasMaxLength(1000);

                    b.Property<string>("RecomdActionThree")
                        .HasColumnName("recomdActionThree")
                        .HasMaxLength(1000);

                    b.Property<string>("RecomdActionTwo")
                        .HasColumnName("recomdActionTwo")
                        .HasMaxLength(1000);

                    b.Property<bool>("ReportAttached");

                    b.Property<bool>("ReportToFollow");

                    b.Property<bool>("RightHand");

                    b.Property<string>("SecSevenReport")
                        .HasColumnName("secSevenReport")
                        .HasMaxLength(1000);

                    b.Property<string>("SecondWhy")
                        .HasColumnName("secondWhy")
                        .HasMaxLength(500);

                    b.Property<bool>("SentOutforMedicalAttn")
                        .HasColumnName("sentOutforMedicalAttn");

                    b.Property<string>("SpecifyPpe")
                        .HasColumnName("SpecifyPPE")
                        .HasMaxLength(100);

                    b.Property<string>("StateInjury")
                        .HasColumnName("stateInjury")
                        .HasMaxLength(500);

                    b.Property<DateTime?>("SupervisorSignDate")
                        .HasColumnType("date");

                    b.Property<string>("ThirdWhy")
                        .HasColumnName("thirdWhy")
                        .HasMaxLength(500);

                    b.Property<TimeSpan?>("TimeOfIncident")
                        .HasColumnName("timeOfIncident");

                    b.Property<string>("TxAdescribeIncident")
                        .HasColumnName("txAdescribeIncident")
                        .HasMaxLength(500);

                    b.Property<string>("TxAhowToPrevent")
                        .HasColumnName("txAhowToPrevent")
                        .HasMaxLength(500);

                    b.Property<string>("TxApracticeOthrExp")
                        .HasColumnName("txAPracticeOthrExp")
                        .HasMaxLength(500);

                    b.Property<string>("TxJhscrecomend")
                        .HasColumnName("txJHSCrecomend")
                        .HasMaxLength(500);

                    b.Property<string>("TxtAsec6Desc")
                        .HasColumnName("txtAsec6Desc")
                        .HasMaxLength(1000);

                    b.Property<string>("TypeOfAccidentOther")
                        .HasMaxLength(150);

                    b.Property<bool>("WearingPpeno")
                        .HasColumnName("wearingPPEno");

                    b.Property<bool>("WearingPpeyes")
                        .HasColumnName("wearingPPEyes");

                    b.Property<string>("WhyModiedDutyDeclined")
                        .HasMaxLength(250);

                    b.Property<string>("WitnessSatetements")
                        .HasColumnName("witnessSatetements")
                        .HasMaxLength(1000);

                    b.Property<bool>("WitnsSttmntsToFllw");

                    b.HasKey("IrformId");

                    b.ToTable("IRForm");
                });

            modelBuilder.Entity("report1.Roles", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("RoleId")
                        .HasName("PK__Roles__8AFACE1A666CA621");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("report1.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Department");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("Role");

                    b.HasKey("UserId")
                        .HasName("PK__Users__1788CC4CA4A4B307");

                    b.HasIndex("Department");

                    b.HasIndex("Role");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("report1.Departments", b =>
                {
                    b.HasOne("report1.Users", "DeptMng")
                        .WithMany("Departments")
                        .HasForeignKey("DeptMngId")
                        .HasConstraintName("FK_DeptManager");
                });

            modelBuilder.Entity("report1.IncidentReport", b =>
                {
                    b.HasOne("report1.Users", "Ircreater")
                        .WithMany("IncidentReport")
                        .HasForeignKey("IrcreaterId")
                        .HasConstraintName("FK_IRCreater");

                    b.HasOne("report1.Irform", "Irform")
                        .WithMany("IncidentReport")
                        .HasForeignKey("IrformId")
                        .HasConstraintName("FK_IncidentReport_IncidentReport");
                });

            modelBuilder.Entity("report1.IrdeptsRelated", b =>
                {
                    b.HasOne("report1.Departments", "DeptRelatedNavigation")
                        .WithMany("IrdeptsRelated")
                        .HasForeignKey("DeptRelated")
                        .HasConstraintName("FK_DeptRelated");

                    b.HasOne("report1.IncidentReport", "IrdetailsNavigation")
                        .WithMany("IrdeptsRelated")
                        .HasForeignKey("Irdetails")
                        .HasConstraintName("FK_IRDeptsRelated_IncidentReport");
                });

            modelBuilder.Entity("report1.Users", b =>
                {
                    b.HasOne("report1.Departments", "DepartmentNavigation")
                        .WithMany("Users")
                        .HasForeignKey("Department")
                        .HasConstraintName("FK_Users_Dpt");

                    b.HasOne("report1.Roles", "RoleNavigation")
                        .WithMany("Users")
                        .HasForeignKey("Role")
                        .HasConstraintName("FK_UserRole");
                });
#pragma warning restore 612, 618
        }
    }
}
