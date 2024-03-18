using RimWorld;
using Verse;
using Verse.AI.Group;

namespace Elemental_Boomers;

public class DeathActionWorker_SmallExplosion_Smoke : DeathActionWorker
{
    public override void PawnDied(Corpse corpse, Lord prevLord)
    {
        GenExplosion.DoExplosion(corpse.Position, corpse.Map, Erat.DeathRadius, DamageDefOf.Smoke, corpse.InnerPawn, -1,
            -1, null, null, null, null, null, 1f, 1, GasType.BlindSmoke);
    }
}