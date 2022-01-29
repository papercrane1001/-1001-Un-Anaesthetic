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
        protected override void DoIngestionOutcomeSpecial(Pawn pawn, Thing ingested)
        {
            //throw new NotImplementedException();
            if (pawn == null) { return; }
            if (pawn.health.hediffSet.HasHediff(HediffDefOf.Anesthetic))
            {
                //var set = pawn.health.hediffSet.hediffs;
                //Log.Message(set.Count.ToString());
                //for (int i = 0; i < set.Count; ++i)
                //{
                //    Log.Message(set[i].def.ToString());
                //}
                Hediff hb = pawn.health.hediffSet.hediffs.Where(x => x.def == HediffDefOf.Anesthetic).FirstOrDefault();
                pawn.health.RemoveHediff(hb);
            }
            
        }
    }
}
