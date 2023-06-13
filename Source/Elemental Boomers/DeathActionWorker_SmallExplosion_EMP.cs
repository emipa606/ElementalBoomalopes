using RimWorld;
using Verse;

namespace Elemental_Boomers;

public class DeathActionWorker_SmallExplosion_EMP : DeathActionWorker
{
    public override void PawnDied(Corpse corpse)
    {
        GenExplosion.DoExplosion(corpse.Position, corpse.Map, Erat.DeathRadius, DamageDefOf.EMP, corpse.InnerPawn);
    }
}