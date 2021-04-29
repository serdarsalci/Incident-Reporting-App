using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace report1
{
    public partial class Irform
    {
        public Irform()
        {
            IncidentReport = new HashSet<IncidentReport>();
        }


      //    public int Irid { get; set; }

        public int IrformId { get; set; }
        [DisplayName("Near Miss")]
        public bool CBxNearMiss { get; set; }
        public bool CBxInjuryReported { get; set; }
        public bool CBxPropertyDamage { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        public string Position { get; set; }
        [DisplayName("Date of Incident")]

      //  [DataType(DataType.Date)]
      //  [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DatOfIncident { get; set; }
        public DateTime? TimeOfIncident { get; set; }



        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? IncidentTime { get; set; }
        public string Department { get; set; }
        public string ExactLocation { get; set; }
        public string LastHourWorked { get; set; }
        public string PotentialWitnesses { get; set; }
        public string IncidentReportedTo { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateReported { get; set; }
        public string LengthOfTimeInPosition { get; set; }
        public bool RBtnSuddenSpecific { get; set; }
        public bool RBtnGradually { get; set; }
        public bool RBtnOccupational { get; set; }
        public bool RBtnFatality { get; set; }
        public bool LeftHand { get; set; }
        public bool RightHand { get; set; }
        public bool FullyTrainedYes { get; set; }
        public bool FullyTrainedNo { get; set; }
        public bool WearingPpeyes { get; set; }
        public bool WearingPpeno { get; set; }
        public string SpecifyPpe { get; set; }
        public bool CBxCut { get; set; }
        public bool CBxBurn { get; set; }
        public bool CBxBumpBruise { get; set; }
        public bool CBxSlipFall { get; set; }
        public bool CBxRepettitiveStrain { get; set; }
        public bool CBxBackInjury { get; set; }
        public bool CBxOverexertion { get; set; }
        public bool CBxOther { get; set; }
        public string TypeOfAccidentOther { get; set; }
        [DisplayName("Head")]
        public bool CBxHead { get; set; }
        [DisplayName("Face")]
        public bool CBxFace { get; set; }
        [DisplayName("Eye(s)")]
        public bool CBxEye { get; set; }
        [DisplayName("Theeth")]
        public bool CBxTheeth { get; set; }
        [DisplayName("Neck")]
        public bool CBxNeck { get; set; }
        [DisplayName("Pelvis")]
        public bool CBxPelvis { get; set; }
        [DisplayName("Upper Back")]
        public bool CBxUpperBack { get; set; }
        [DisplayName("Lower Back")]
        public bool CBxLowerBack { get; set; }
        [DisplayName("Chest")]
        public bool CBxChest { get; set; }
        [DisplayName("Left Shoulder")]
        public bool CBxLeftShoulder { get; set; }
        [DisplayName("Left Elbow")]
        public bool CBxLeftElbow { get; set; }
        [DisplayName("Left Upper Arm")]
        public bool CBxLeftUpperArm { get; set; }
        [DisplayName("Left Forearm")]
        public bool CBxLeftForeArm { get; set; }
        public bool CBxLeftHand { get; set; }
        public bool CBxLeftWrist { get; set; }
        public bool CBxLeftFinder { get; set; }
        public bool CBxLeftHip { get; set; }
        public bool CBxRightShoulder { get; set; }
        public bool CBxRightElbow { get; set; }
        public bool CBxRightUpperArm { get; set; }
        public bool CBxRightForeArm { get; set; }
        public bool CBxRightHand { get; set; }
        public bool CBxRightWrist { get; set; }
        public bool CBxRightFinder { get; set; }
        public bool CBxRightHip { get; set; }
        public bool CBxLeftButtocks { get; set; }
        public bool CBxLeftGroin { get; set; }
        public bool CBxLeftThigh { get; set; }
        public bool CBxLeftKnee { get; set; }
        public bool CBxLeftLowerLeg { get; set; }
        public bool CBxLeftAnkle { get; set; }
        public bool CBxLeftFoot { get; set; }
        public bool CBxLeftToes { get; set; }
        public bool CBxRightButtock { get; set; }
        public bool CBxRightGroin { get; set; }
        public bool CBxRightThigh { get; set; }
        public bool CBxRightKnee { get; set; }
        public bool CBxRightLowerLeg { get; set; }
        public bool CBxRightAnkle { get; set; }
        public bool CBxRightFoot { get; set; }
        public bool CBxRightToes { get; set; }
        public bool NoMedAttentionRequired { get; set; }
        public bool FirstAidOnsite { get; set; }
        public bool OutsideMedAttention { get; set; }
        public DateTime? DateOfmedAttention { get; set; }
        public bool SentOutforMedicalAttn { get; set; }
        public bool NotSentOutforMedicalAttn { get; set; }
        public DateTime? DateLearnedOutsideHc { get; set; }
        public string HealthCareProvider { get; set; }
        public bool HaveLostTime { get; set; }
        public bool NotHaveLostTime { get; set; }
        public DateTime? DateLostTime { get; set; }
        public bool ProvidedFaf { get; set; }
        public bool NotProvidedFaf { get; set; }
        public bool FafReturned { get; set; }
        public bool NotfafReturned { get; set; }
        public bool ModDutyNoRestriction { get; set; }
        public bool ModDutyAccepted { get; set; }
        public bool ModDutyDeclined { get; set; }
        public string WhyModiedDutyDeclined { get; set; }
        public DateTime? DateModDutyOffered { get; set; }
        public string ModiedDutiesOffered { get; set; }
        public string TxAdescribeIncident { get; set; }
        public string TxAhowToPrevent { get; set; }
        public string TxJhscrecomend { get; set; }
        public string JhscrepName { get; set; }
        public string Jhscsignature { get; set; }
        public DateTime? JhscsignDate { get; set; }
        public bool NoWitnesses { get; set; }
        public bool AllWitnsSttmntsAttched { get; set; }
        public bool WitnsSttmntsToFllw { get; set; }
        public string WitnessSatetements { get; set; }
        public bool CBxCongestion { get; set; }
        public bool CBxDefEquipmnt { get; set; }
        public bool CBxCongestion2 { get; set; }
        public bool CBxPoorHsKeeping { get; set; }
        public bool CBxSlpTripHzrd { get; set; }
        public bool CBxInadqtSftySys { get; set; }
        public bool CBxDsgEqpWrksttn { get; set; }
        public bool CBxInEdqtPrtEqui { get; set; }
        public bool CBxImpropPosLift { get; set; }
        public bool CBxRushing { get; set; }
        public bool CBxInappCndct { get; set; }
        public bool CBxNtFllwProcdr { get; set; }
        public bool CBxInprprUseOfEqui { get; set; }
        public bool CBxAltModEqui { get; set; }
        public bool CBxNtUsePpe { get; set; }
        public bool CBxRmvlSaftyDev { get; set; }
        public bool CBxLacOfkAttn { get; set; }
        public bool CBxPracticeOthrExp { get; set; }
        public string TxApracticeOthrExp { get; set; }
        public bool CBxTrnInstInvolved { get; set; }
        public bool CBxTrnInstOther { get; set; }
        public bool CBxImpWrkProcedure { get; set; }
        public bool CBxPrcsChgImprv { get; set; }
        public bool CBxImpEngDsgWsttn { get; set; }
        public bool CBxImprvPpe { get; set; }
        public bool CBxImplmntPrvMntnc { get; set; }
        public bool CBxImpInspPrcdr { get; set; }
        public bool CBxToolsEquiRprRplc { get; set; }
        public bool CBxRqErgAssmnt { get; set; }
        public bool CBxReAsgnPrsn { get; set; }
        public bool CBxImpHsKeeping { get; set; }
        public bool CBxInstSftyDev { get; set; }
        public string TxtAsec6Desc { get; set; }
        public bool NoFurtherReport { get; set; }
        public bool ReportAttached { get; set; }
        public bool ReportToFollow { get; set; }
        public string SecSevenReport { get; set; }
        public string StateInjury { get; set; }
        public string ThirdWhy { get; set; }
        public string FirstWhy { get; set; }
        public string FourthWhy { get; set; }
        public string SecondWhy { get; set; }
        public string FifthWhy { get; set; }
        public string RecomdActionOne { get; set; }
        public string ActionOneResponsibility { get; set; }
        public DateTime? ActionOneTargtDate { get; set; }
        public DateTime? ActionOneCompletionDate { get; set; }
        public string RecomdActionTwo { get; set; }
        public string ActionTwoResponsibility { get; set; }
        public DateTime? ActionTwoTargtDate { get; set; }
        public DateTime? ActionTwoCompletionDate { get; set; }
        public string RecomdActionThree { get; set; }
        public string ActionThreeResponsibility { get; set; }
        public DateTime? ActionThreeTargtDate { get; set; }
        public DateTime? ActionThreeCompletionDate { get; set; }
        public string RecomdActionFour { get; set; }
        public string ActionFourResponsibility { get; set; }
        public DateTime? ActionFourTargtDate { get; set; }
        public DateTime? ActionFourCompletionDate { get; set; }
        public bool CBxSupervisorSign { get; set; }
        public DateTime? SupervisorSignDate { get; set; }
        public bool CBxHrmsign { get; set; }
        public DateTime? HrmsignDate { get; set; }
        public bool CBxProdctMngSignd { get; set; }
        public DateTime? PrdcMngrSignDate { get; set; }
        public bool CBxHandScoordntrSgnd { get; set; }
        public DateTime? HandScoordntrSgndSignDate { get; set; }
        public bool DptMngrSgnd { get; set; }
        public DateTime? DptMngrSignDate { get; set; }

        public virtual ICollection<IncidentReport> IncidentReport { get; set; }
    }
}
