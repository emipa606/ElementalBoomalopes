﻿using RimWorld;
using Verse;
using Verse.AI.Group;

namespace Elemental_Boomers;

public class DeathActionWorker_BigExplosion_ToxGas : DeathActionWorker
{
    public override void PawnDied(Corpse corpse, Lord prevLord)
    {
        var radius = Alope.DeathRadius(corpse.InnerPawn.ageTracker.CurLifeStageIndex);
        GenExplosion.DoExplosion(corpse.Position, corpse.Map, radius, DamageDefOf.ToxGas, corpse.InnerPawn, -1, -1,
            null,
            null, null, null, null, 1f, 1, GasType.ToxGas);
    }
}