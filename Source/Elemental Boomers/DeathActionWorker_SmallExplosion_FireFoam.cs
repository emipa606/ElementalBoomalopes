using RimWorld;
using Verse;

namespace Elemental_Boomers;

public class DeathActionWorker_SmallExplosion_FireFoam : DeathActionWorker
{
    public override void PawnDied(Corpse corpse)
    {
        var filthFireFoam = ThingDefOf.Filth_FireFoam;
        GenExplosion.DoExplosion(corpse.Position, corpse.Map, Erat.DeathRadius, DamageDefOf.Extinguish,
            corpse.InnerPawn, -1, -1, null, null, null, null, filthFireFoam, 1f, 2, null, true);
    }
}