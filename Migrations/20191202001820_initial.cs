using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace report1.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IRForm",
                columns: table => new
                {
                    IRFormId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cBxNearMiss = table.Column<bool>(nullable: false),
                    cBxInjuryReported = table.Column<bool>(nullable: false),
                    cBxPropertyDamage = table.Column<bool>(nullable: false),
                    lastName = table.Column<string>(maxLength: 50, nullable: true),
                    firstName = table.Column<string>(maxLength: 50, nullable: true),
                    position = table.Column<string>(maxLength: 50, nullable: true),
                    datOfIncident = table.Column<DateTime>(type: "date", nullable: true),
                    timeOfIncident = table.Column<TimeSpan>(nullable: true),
                    department = table.Column<string>(maxLength: 50, nullable: true),
                    exactLocation = table.Column<string>(maxLength: 100, nullable: true),
                    lastHourWorked = table.Column<string>(maxLength: 50, nullable: true),
                    potentialWitnesses = table.Column<string>(maxLength: 100, nullable: true),
                    incidentReportedTo = table.Column<string>(maxLength: 50, nullable: true),
                    dateReported = table.Column<DateTime>(type: "date", nullable: true),
                    lengthOfTimeInPosition = table.Column<string>(maxLength: 50, nullable: true),
                    rBtnSuddenSpecific = table.Column<bool>(nullable: false),
                    rBtnGradually = table.Column<bool>(nullable: false),
                    rBtnOccupational = table.Column<bool>(nullable: false),
                    rBtnFatality = table.Column<bool>(nullable: false),
                    LeftHand = table.Column<bool>(nullable: false),
                    RightHand = table.Column<bool>(nullable: false),
                    fullyTrainedYes = table.Column<bool>(nullable: false),
                    fullyTrainedNo = table.Column<bool>(nullable: false),
                    wearingPPEyes = table.Column<bool>(nullable: false),
                    wearingPPEno = table.Column<bool>(nullable: false),
                    SpecifyPPE = table.Column<string>(maxLength: 100, nullable: true),
                    cBxCut = table.Column<bool>(nullable: false),
                    cBxBurn = table.Column<bool>(nullable: false),
                    cBxBumpBruise = table.Column<bool>(nullable: false),
                    cBxSlipFall = table.Column<bool>(nullable: false),
                    cBxRepettitiveStrain = table.Column<bool>(nullable: false),
                    cBxBackInjury = table.Column<bool>(nullable: false),
                    cBxOverexertion = table.Column<bool>(nullable: false),
                    cBxOther = table.Column<bool>(nullable: false),
                    TypeOfAccidentOther = table.Column<string>(maxLength: 150, nullable: true),
                    cBxHead = table.Column<bool>(nullable: false),
                    cBxFace = table.Column<bool>(nullable: false),
                    cBxEye = table.Column<bool>(nullable: false),
                    cBxTheeth = table.Column<bool>(nullable: false),
                    cBxNeck = table.Column<bool>(nullable: false),
                    cBxPelvis = table.Column<bool>(nullable: false),
                    cBxUpperBack = table.Column<bool>(nullable: false),
                    cBxLowerBack = table.Column<bool>(nullable: false),
                    cBxChest = table.Column<bool>(nullable: false),
                    cBxLeftShoulder = table.Column<bool>(nullable: false),
                    cBxLeftElbow = table.Column<bool>(nullable: false),
                    cBxLeftUpperArm = table.Column<bool>(nullable: false),
                    cBxLeftForeArm = table.Column<bool>(nullable: false),
                    cBxLeftHand = table.Column<bool>(nullable: false),
                    cBxLeftWrist = table.Column<bool>(nullable: false),
                    cBxLeftFinder = table.Column<bool>(nullable: false),
                    cBxLeftHip = table.Column<bool>(nullable: false),
                    cBxRightShoulder = table.Column<bool>(nullable: false),
                    cBxRightElbow = table.Column<bool>(nullable: false),
                    cBxRightUpperArm = table.Column<bool>(nullable: false),
                    cBxRightForeArm = table.Column<bool>(nullable: false),
                    cBxRightHand = table.Column<bool>(nullable: false),
                    cBxRightWrist = table.Column<bool>(nullable: false),
                    cBxRightFinder = table.Column<bool>(nullable: false),
                    cBxRightHip = table.Column<bool>(nullable: false),
                    cBxLeftButtocks = table.Column<bool>(nullable: false),
                    cBxLeftGroin = table.Column<bool>(nullable: false),
                    cBxLeftThigh = table.Column<bool>(nullable: false),
                    cBxLeftKnee = table.Column<bool>(nullable: false),
                    cBxLeftLowerLeg = table.Column<bool>(nullable: false),
                    cBxLeftAnkle = table.Column<bool>(nullable: false),
                    cBxLeftFoot = table.Column<bool>(nullable: false),
                    cBxLeftToes = table.Column<bool>(nullable: false),
                    cBxRightButtock = table.Column<bool>(nullable: false),
                    cBxRightGroin = table.Column<bool>(nullable: false),
                    cBxRightThigh = table.Column<bool>(nullable: false),
                    cBxRightKnee = table.Column<bool>(nullable: false),
                    cBxRightLowerLeg = table.Column<bool>(nullable: false),
                    cBxRightAnkle = table.Column<bool>(nullable: false),
                    cBxRightFoot = table.Column<bool>(nullable: false),
                    cBxRightToes = table.Column<bool>(nullable: false),
                    noMedAttentionRequired = table.Column<bool>(nullable: false),
                    firstAidOnsite = table.Column<bool>(nullable: false),
                    outsideMedAttention = table.Column<bool>(nullable: false),
                    dateOfmedAttention = table.Column<DateTime>(type: "date", nullable: true),
                    sentOutforMedicalAttn = table.Column<bool>(nullable: false),
                    notSentOutforMedicalAttn = table.Column<bool>(nullable: false),
                    dateLearnedOutsideHC = table.Column<DateTime>(type: "date", nullable: true),
                    healthCareProvider = table.Column<string>(maxLength: 100, nullable: true),
                    haveLostTime = table.Column<bool>(nullable: false),
                    notHaveLostTime = table.Column<bool>(nullable: false),
                    dateLostTime = table.Column<DateTime>(type: "date", nullable: true),
                    providedFAF = table.Column<bool>(nullable: false),
                    notProvidedFAF = table.Column<bool>(nullable: false),
                    fafReturned = table.Column<bool>(nullable: false),
                    notfafReturned = table.Column<bool>(nullable: false),
                    modDutyNoRestriction = table.Column<bool>(nullable: false),
                    modDutyAccepted = table.Column<bool>(nullable: false),
                    modDutyDeclined = table.Column<bool>(nullable: false),
                    WhyModiedDutyDeclined = table.Column<string>(maxLength: 250, nullable: true),
                    dateModDutyOffered = table.Column<DateTime>(type: "date", nullable: true),
                    ModiedDutiesOffered = table.Column<string>(maxLength: 250, nullable: true),
                    txAdescribeIncident = table.Column<string>(maxLength: 500, nullable: true),
                    txAhowToPrevent = table.Column<string>(maxLength: 500, nullable: true),
                    txJHSCrecomend = table.Column<string>(maxLength: 500, nullable: true),
                    JHSCrepName = table.Column<string>(maxLength: 50, nullable: true),
                    JHSCsignature = table.Column<string>(maxLength: 50, nullable: true),
                    JHSCsignDate = table.Column<DateTime>(type: "date", nullable: true),
                    noWitnesses = table.Column<bool>(nullable: false),
                    allWitnsSttmntsAttched = table.Column<bool>(nullable: false),
                    WitnsSttmntsToFllw = table.Column<bool>(nullable: false),
                    witnessSatetements = table.Column<string>(maxLength: 1000, nullable: true),
                    cBxCongestion = table.Column<bool>(nullable: false),
                    cBxDefEquipmnt = table.Column<bool>(nullable: false),
                    cBxCongestion2 = table.Column<bool>(nullable: false),
                    cBxPoorHsKeeping = table.Column<bool>(nullable: false),
                    cBxSlpTripHzrd = table.Column<bool>(nullable: false),
                    cBxInadqtSftySys = table.Column<bool>(nullable: false),
                    cBxDsgEqpWrksttn = table.Column<bool>(nullable: false),
                    cBxInEdqtPrtEqui = table.Column<bool>(nullable: false),
                    cBxImpropPosLift = table.Column<bool>(nullable: false),
                    cBxRushing = table.Column<bool>(nullable: false),
                    cBxInappCndct = table.Column<bool>(nullable: false),
                    cBxNtFllwProcdr = table.Column<bool>(nullable: false),
                    cBxInprprUseOfEqui = table.Column<bool>(nullable: false),
                    cBxAltModEqui = table.Column<bool>(nullable: false),
                    cBxNtUsePPE = table.Column<bool>(nullable: false),
                    cBxRmvlSaftyDev = table.Column<bool>(nullable: false),
                    cBxLacOfkAttn = table.Column<bool>(nullable: false),
                    cBxPracticeOthrExp = table.Column<bool>(nullable: false),
                    txAPracticeOthrExp = table.Column<string>(maxLength: 500, nullable: true),
                    cBxTrnInstInvolved = table.Column<bool>(nullable: false),
                    cBxTrnInstOther = table.Column<bool>(nullable: false),
                    cBxImpWrkProcedure = table.Column<bool>(nullable: false),
                    cBxPrcsChgImprv = table.Column<bool>(nullable: false),
                    cBxImpEngDsgWsttn = table.Column<bool>(nullable: false),
                    cBxImprvPPE = table.Column<bool>(nullable: false),
                    cBxImplmntPrvMntnc = table.Column<bool>(nullable: false),
                    cBxImpInspPrcdr = table.Column<bool>(nullable: false),
                    cBxToolsEquiRprRplc = table.Column<bool>(nullable: false),
                    cBxRqErgAssmnt = table.Column<bool>(nullable: false),
                    cBxReAsgnPrsn = table.Column<bool>(nullable: false),
                    cBxImpHsKeeping = table.Column<bool>(nullable: false),
                    cBxInstSftyDev = table.Column<bool>(nullable: false),
                    txtAsec6Desc = table.Column<string>(maxLength: 1000, nullable: true),
                    NoFurtherReport = table.Column<bool>(nullable: false),
                    ReportAttached = table.Column<bool>(nullable: false),
                    ReportToFollow = table.Column<bool>(nullable: false),
                    secSevenReport = table.Column<string>(maxLength: 1000, nullable: true),
                    stateInjury = table.Column<string>(maxLength: 500, nullable: true),
                    thirdWhy = table.Column<string>(maxLength: 500, nullable: true),
                    firstWhy = table.Column<string>(maxLength: 500, nullable: true),
                    fourthWhy = table.Column<string>(maxLength: 500, nullable: true),
                    secondWhy = table.Column<string>(maxLength: 500, nullable: true),
                    fifthWhy = table.Column<string>(maxLength: 500, nullable: true),
                    recomdActionOne = table.Column<string>(maxLength: 1000, nullable: true),
                    actionOneResponsibility = table.Column<string>(maxLength: 250, nullable: true),
                    actionOneTargtDate = table.Column<DateTime>(type: "date", nullable: true),
                    actionOneCompletionDate = table.Column<DateTime>(type: "date", nullable: true),
                    recomdActionTwo = table.Column<string>(maxLength: 1000, nullable: true),
                    actionTwoResponsibility = table.Column<string>(maxLength: 250, nullable: true),
                    actionTwoTargtDate = table.Column<DateTime>(type: "date", nullable: true),
                    actionTwoCompletionDate = table.Column<DateTime>(type: "date", nullable: true),
                    recomdActionThree = table.Column<string>(maxLength: 1000, nullable: true),
                    actionThreeResponsibility = table.Column<string>(maxLength: 250, nullable: true),
                    actionThreeTargtDate = table.Column<DateTime>(type: "date", nullable: true),
                    actionThreeCompletionDate = table.Column<DateTime>(type: "date", nullable: true),
                    recomdActionFour = table.Column<string>(maxLength: 1000, nullable: true),
                    actionFourResponsibility = table.Column<string>(maxLength: 250, nullable: true),
                    actionFourTargtDate = table.Column<DateTime>(type: "date", nullable: true),
                    actionFourCompletionDate = table.Column<DateTime>(type: "date", nullable: true),
                    cBxSupervisorSign = table.Column<bool>(nullable: false),
                    SupervisorSignDate = table.Column<DateTime>(type: "date", nullable: true),
                    cBxHRMSign = table.Column<bool>(nullable: false),
                    HRMSignDate = table.Column<DateTime>(type: "date", nullable: true),
                    cBxProdctMngSignd = table.Column<bool>(nullable: false),
                    PrdcMngrSignDate = table.Column<DateTime>(type: "date", nullable: true),
                    cBxHandSCoordntrSgnd = table.Column<bool>(nullable: false),
                    HandSCoordntrSgndSignDate = table.Column<DateTime>(type: "date", nullable: true),
                    dptMngrSgnd = table.Column<bool>(nullable: false),
                    dptMngrSignDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IRForm", x => x.IRFormId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleName = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Roles__8AFACE1A666CA621", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "IRDeptsRelated",
                columns: table => new
                {
                    IRDeptsRelated = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IRDetails = table.Column<int>(nullable: false),
                    DeptRelated = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__IRDeptsR__727F69A6CF1F2D32", x => x.IRDeptsRelated);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(maxLength: 30, nullable: false),
                    Department = table.Column<int>(nullable: false),
                    Role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__1788CC4CA4A4B307", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserRole",
                        column: x => x.Role,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DeptId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeptName = table.Column<string>(maxLength: 50, nullable: false),
                    DeptMngId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DeptId);
                    table.ForeignKey(
                        name: "FK_DeptManager",
                        column: x => x.DeptMngId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IncidentReport",
                columns: table => new
                {
                    IRid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IRCreaterId = table.Column<int>(nullable: false),
                    IsComplete = table.Column<bool>(nullable: false),
                    IRRelatedDept = table.Column<int>(nullable: true),
                    IRStartDate = table.Column<DateTime>(type: "date", nullable: true),
                    IRCompleteDate = table.Column<DateTime>(type: "date", nullable: true),
                    IrformId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IRdetails", x => x.IRid);
                    table.ForeignKey(
                        name: "FK_IRCreater",
                        column: x => x.IRCreaterId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IncidentReport_IncidentReport",
                        column: x => x.IrformId,
                        principalTable: "IRForm",
                        principalColumn: "IRFormId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_DeptMngId",
                table: "Departments",
                column: "DeptMngId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentReport_IRCreaterId",
                table: "IncidentReport",
                column: "IRCreaterId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentReport_IrformId",
                table: "IncidentReport",
                column: "IrformId");

            migrationBuilder.CreateIndex(
                name: "IX_IRDeptsRelated_DeptRelated",
                table: "IRDeptsRelated",
                column: "DeptRelated");

            migrationBuilder.CreateIndex(
                name: "IX_IRDeptsRelated_IRDetails",
                table: "IRDeptsRelated",
                column: "IRDetails");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Department",
                table: "Users",
                column: "Department");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Role",
                table: "Users",
                column: "Role");

            migrationBuilder.AddForeignKey(
                name: "FK_DeptRelated",
                table: "IRDeptsRelated",
                column: "DeptRelated",
                principalTable: "Departments",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IRDeptsRelated_IncidentReport",
                table: "IRDeptsRelated",
                column: "IRDetails",
                principalTable: "IncidentReport",
                principalColumn: "IRid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Dpt",
                table: "Users",
                column: "Department",
                principalTable: "Departments",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeptManager",
                table: "Departments");

            migrationBuilder.DropTable(
                name: "IRDeptsRelated");

            migrationBuilder.DropTable(
                name: "IncidentReport");

            migrationBuilder.DropTable(
                name: "IRForm");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
