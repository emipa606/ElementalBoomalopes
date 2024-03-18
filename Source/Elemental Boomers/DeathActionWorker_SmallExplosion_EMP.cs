﻿using RimWorld;
using Verse;
using Verse.AI.Group;

namespace Elemental_Boomers;

public class DeathActionWorker_SmallExplosion_EMP : DeathActionWorker
{
    public override void PawnDied(Corpse corpse, Lord prevLord)
    {
        GenExplosion.DoExplosion(corpse.Position, corpse.Map, Erat.DeathRadius, DamageDefOf.EMP, corpse.InnerPawn);
    }
}