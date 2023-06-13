using RimWorld;
using Verse;

namespace Elemental_Boomers;

public class DeathActionWorker_BigExplosion_FireFoam : DeathActionWorker
{
    public override void PawnDied(Corpse corpse)
    {
        var radius = Alope.DeathRadius(corpse.InnerPawn.ageTracker.CurLifeStageIndex);
        var filthFireFoam = ThingDefOf.Filth_FireFoam;
        GenExplosion.DoExplosion(corpse.Position, corpse.Map, radius, DamageDefOf.Extinguish, corpse.InnerPawn, -1, -1,
            null, null, null, null, filthFireFoam, 1f, 2, null, true);
    }
}