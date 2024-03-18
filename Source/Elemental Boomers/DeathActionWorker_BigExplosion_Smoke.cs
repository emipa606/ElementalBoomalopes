using RimWorld;
using Verse;
using Verse.AI.Group;

namespace Elemental_Boomers;

public class DeathActionWorker_BigExplosion_Smoke : DeathActionWorker
{
    public override void PawnDied(Corpse corpse, Lord prevLord)
    {
        var radius = Alope.DeathRadius(corpse.InnerPawn.ageTracker.CurLifeStageIndex);
        GenExplosion.DoExplosion(corpse.Position, corpse.Map, radius, DamageDefOf.Smoke, corpse.InnerPawn, -1, -1, null,
            null, null, null, null, 1f, 1, GasType.BlindSmoke);
    }
}