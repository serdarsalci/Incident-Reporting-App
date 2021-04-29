using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using report1;

namespace report1.Controllers
{
    public class IrformsController : Controller
    {
        private readonly report1Context _context;

        public IrformsController(report1Context context)
        {
            _context = context;
        }

        // GET: Irforms
        public async Task<IActionResult> Index()
        {
            //  Include(i => i.Irform) kismini ben ekledim
            return View(await _context.Irform.Include(i => i.IncidentReport).ToListAsync());
        }

        // GET: Irforms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var irform = await _context.Irform
                .FirstOrDefaultAsync(m => m.IrformId == id);
            if (irform == null)
            {
                return NotFound();
            }

            return View(irform);
        }

        // GET: Irforms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Irforms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IrformId,Irid,CBxNearMiss,CBxInjuryReported,CBxPropertyDamage,LastName,FirstName,Position,DatOfIncident,TimeOfIncident,Department,ExactLocation,LastHourWorked,PotentialWitnesses,IncidentReportedTo,DateReported,LengthOfTimeInPosition,RBtnSuddenSpecific,RBtnGradually,RBtnOccupational,RBtnFatality,LeftHand,RightHand,FullyTrainedYes,FullyTrainedNo,WearingPpeyes,WearingPpeno,SpecifyPpe,CBxCut,CBxBurn,CBxBumpBruise,CBxSlipFall,CBxRepettitiveStrain,CBxBackInjury,CBxOverexertion,CBxOther,TypeOfAccidentOther,CBxHead,CBxFace,CBxEye,CBxTheeth,CBxNeck,CBxPelvis,CBxUpperBack,CBxLowerBack,CBxChest,CBxLeftShoulder,CBxLeftElbow,CBxLeftUpperArm,CBxLeftForeArm,CBxLeftHand,CBxLeftWrist,CBxLeftFinder,CBxLeftHip,CBxRightShoulder,CBxRightElbow,CBxRightUpperArm,CBxRightForeArm,CBxRightHand,CBxRightWrist,CBxRightFinder,CBxRightHip,CBxLeftButtocks,CBxLeftGroin,CBxLeftThigh,CBxLeftKnee,CBxLeftLowerLeg,CBxLeftAnkle,CBxLeftFoot,CBxLeftToes,CBxRightButtock,CBxRightGroin,CBxRightThigh,CBxRightKnee,CBxRightLowerLeg,CBxRightAnkle,CBxRightFoot,CBxRightToes,NoMedAttentionRequired,FirstAidOnsite,OutsideMedAttention,DateOfmedAttention,SentOutforMedicalAttn,NotSentOutforMedicalAttn,DateLearnedOutsideHc,HealthCareProvider,HaveLostTime,NotHaveLostTime,DateLostTime,ProvidedFaf,NotProvidedFaf,FafReturned,NotfafReturned,ModDutyNoRestriction,ModDutyAccepted,ModDutyDeclined,WhyModiedDutyDeclined,DateModDutyOffered,ModiedDutiesOffered,TxAdescribeIncident,TxAhowToPrevent,TxJhscrecomend,JhscrepName,Jhscsignature,JhscsignDate,NoWitnesses,AllWitnsSttmntsAttched,WitnsSttmntsToFllw,WitnessSatetements,CBxCongestion,CBxDefEquipmnt,CBxCongestion2,CBxPoorHsKeeping,CBxSlpTripHzrd,CBxInadqtSftySys,CBxDsgEqpWrksttn,CBxInEdqtPrtEqui,CBxImpropPosLift,CBxRushing,CBxInappCndct,CBxNtFllwProcdr,CBxInprprUseOfEqui,CBxAltModEqui,CBxNtUsePpe,CBxRmvlSaftyDev,CBxLacOfkAttn,CBxPracticeOthrExp,TxApracticeOthrExp,CBxTrnInstInvolved,CBxTrnInstOther,CBxImpWrkProcedure,CBxPrcsChgImprv,CBxImpEngDsgWsttn,CBxImprvPpe,CBxImplmntPrvMntnc,CBxImpInspPrcdr,CBxToolsEquiRprRplc,CBxRqErgAssmnt,CBxReAsgnPrsn,CBxImpHsKeeping,CBxInstSftyDev,TxtAsec6Desc,NoFurtherReport,ReportAttached,ReportToFollow,SecSevenReport,StateInjury,ThirdWhy,FirstWhy,FourthWhy,SecondWhy,FifthWhy,RecomdActionOne,ActionOneResponsibility,ActionOneTargtDate,ActionOneCompletionDate,RecomdActionTwo,ActionTwoResponsibility,ActionTwoTargtDate,ActionTwoCompletionDate,RecomdActionThree,ActionThreeResponsibility,ActionThreeTargtDate,ActionThreeCompletionDate,RecomdActionFour,ActionFourResponsibility,ActionFourTargtDate,ActionFourCompletionDate,CBxSupervisorSign,SupervisorSignDate,CBxHrmsign,HrmsignDate,CBxProdctMngSignd,PrdcMngrSignDate,CBxHandScoordntrSgnd,HandScoordntrSgndSignDate,DptMngrSgnd,DptMngrSignDate")] Irform irform)
        {
            if (ModelState.IsValid)
            {
                _context.Add(irform);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(irform);
        }

        // GET: Irforms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var irform = await _context.Irform.FindAsync(id);
            if (irform == null)
            {
                return NotFound();
            }
            return View(irform);
        }

        // POST: Irforms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IrformId,Irid,CBxNearMiss,CBxInjuryReported,CBxPropertyDamage,LastName,FirstName,Position,DatOfIncident,TimeOfIncident,Department,ExactLocation,LastHourWorked,PotentialWitnesses,IncidentReportedTo,DateReported,LengthOfTimeInPosition,RBtnSuddenSpecific,RBtnGradually,RBtnOccupational,RBtnFatality,LeftHand,RightHand,FullyTrainedYes,FullyTrainedNo,WearingPpeyes,WearingPpeno,SpecifyPpe,CBxCut,CBxBurn,CBxBumpBruise,CBxSlipFall,CBxRepettitiveStrain,CBxBackInjury,CBxOverexertion,CBxOther,TypeOfAccidentOther,CBxHead,CBxFace,CBxEye,CBxTheeth,CBxNeck,CBxPelvis,CBxUpperBack,CBxLowerBack,CBxChest,CBxLeftShoulder,CBxLeftElbow,CBxLeftUpperArm,CBxLeftForeArm,CBxLeftHand,CBxLeftWrist,CBxLeftFinder,CBxLeftHip,CBxRightShoulder,CBxRightElbow,CBxRightUpperArm,CBxRightForeArm,CBxRightHand,CBxRightWrist,CBxRightFinder,CBxRightHip,CBxLeftButtocks,CBxLeftGroin,CBxLeftThigh,CBxLeftKnee,CBxLeftLowerLeg,CBxLeftAnkle,CBxLeftFoot,CBxLeftToes,CBxRightButtock,CBxRightGroin,CBxRightThigh,CBxRightKnee,CBxRightLowerLeg,CBxRightAnkle,CBxRightFoot,CBxRightToes,NoMedAttentionRequired,FirstAidOnsite,OutsideMedAttention,DateOfmedAttention,SentOutforMedicalAttn,NotSentOutforMedicalAttn,DateLearnedOutsideHc,HealthCareProvider,HaveLostTime,NotHaveLostTime,DateLostTime,ProvidedFaf,NotProvidedFaf,FafReturned,NotfafReturned,ModDutyNoRestriction,ModDutyAccepted,ModDutyDeclined,WhyModiedDutyDeclined,DateModDutyOffered,ModiedDutiesOffered,TxAdescribeIncident,TxAhowToPrevent,TxJhscrecomend,JhscrepName,Jhscsignature,JhscsignDate,NoWitnesses,AllWitnsSttmntsAttched,WitnsSttmntsToFllw,WitnessSatetements,CBxCongestion,CBxDefEquipmnt,CBxCongestion2,CBxPoorHsKeeping,CBxSlpTripHzrd,CBxInadqtSftySys,CBxDsgEqpWrksttn,CBxInEdqtPrtEqui,CBxImpropPosLift,CBxRushing,CBxInappCndct,CBxNtFllwProcdr,CBxInprprUseOfEqui,CBxAltModEqui,CBxNtUsePpe,CBxRmvlSaftyDev,CBxLacOfkAttn,CBxPracticeOthrExp,TxApracticeOthrExp,CBxTrnInstInvolved,CBxTrnInstOther,CBxImpWrkProcedure,CBxPrcsChgImprv,CBxImpEngDsgWsttn,CBxImprvPpe,CBxImplmntPrvMntnc,CBxImpInspPrcdr,CBxToolsEquiRprRplc,CBxRqErgAssmnt,CBxReAsgnPrsn,CBxImpHsKeeping,CBxInstSftyDev,TxtAsec6Desc,NoFurtherReport,ReportAttached,ReportToFollow,SecSevenReport,StateInjury,ThirdWhy,FirstWhy,FourthWhy,SecondWhy,FifthWhy,RecomdActionOne,ActionOneResponsibility,ActionOneTargtDate,ActionOneCompletionDate,RecomdActionTwo,ActionTwoResponsibility,ActionTwoTargtDate,ActionTwoCompletionDate,RecomdActionThree,ActionThreeResponsibility,ActionThreeTargtDate,ActionThreeCompletionDate,RecomdActionFour,ActionFourResponsibility,ActionFourTargtDate,ActionFourCompletionDate,CBxSupervisorSign,SupervisorSignDate,CBxHrmsign,HrmsignDate,CBxProdctMngSignd,PrdcMngrSignDate,CBxHandScoordntrSgnd,HandScoordntrSgndSignDate,DptMngrSgnd,DptMngrSignDate")] Irform irform)
        {
            if (id != irform.IrformId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(irform);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IrformExists(irform.IrformId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(irform);
        }

        // GET: Irforms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var irform = await _context.Irform
                .FirstOrDefaultAsync(m => m.IrformId == id);
            if (irform == null)
            {
                return NotFound();
            }

            return View(irform);
        }

        // POST: Irforms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var irform = await _context.Irform.FindAsync(id);
            _context.Irform.Remove(irform);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IrformExists(int id)
        {
            return _context.Irform.Any(e => e.IrformId == id);
        }
    }
}
