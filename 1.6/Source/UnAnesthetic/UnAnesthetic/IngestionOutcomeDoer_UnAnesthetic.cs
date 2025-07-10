using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RimWorld;
using Verse;
using UnityEngine;

namespace UnAnesthetic
{
    public class IngestionOutcomeDoer_UnAnesthetic : IngestionOutcomeDoer
    {
        protected override void DoIngestionOutcomeSpecial(Pawn pawn, Thing ingested, int ingestedCount)
        {
            if (pawn == null) { return; }
            if (pawn.health.hediffSet.HasHediff(HediffDefOf.Anesthetic))
            {
                Hediff hb = pawn.health.hediffSet.hediffs.Where(x => x.def == HediffDefOf.Anesthetic).FirstOrDefault();
                pawn.health.RemoveHediff(hb);
            }
        }
    }
}
