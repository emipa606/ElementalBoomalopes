using RimWorld;
using Verse;
using Verse.AI.Group;

namespace Elemental_Boomers;

public class DeathActionWorker_SmallExplosion_Stun : DeathActionWorker
{
    public override void PawnDied(Corpse corpse, Lord prevLord)
    {
        GenExplosion.DoExplosion(corpse.Position, corpse.Map, Erat.DeathRadius, DamageDefOf.Stun, corpse.InnerPawn);
    }
}