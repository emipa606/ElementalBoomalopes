using RimWorld;
using Verse;

namespace Elemental_Boomers;

public class DeathActionWorker_BigExplosion_Stun : DeathActionWorker
{
    public override void PawnDied(Corpse corpse)
    {
        var radius = Alope.DeathRadius(corpse.InnerPawn.ageTracker.CurLifeStageIndex);
        GenExplosion.DoExplosion(corpse.Position, corpse.Map, radius, DamageDefOf.Stun, corpse.InnerPawn);
    }
}