using System;
using Verse;
using RimWorld;

namespace Thrumbo
{
    [DefOf]
    public static class PawnKindDefOf
    {
        static PawnKindDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(PawnKindDefOf));
        }
        public static PawnKindDef BlondThrumboPawn;
        public static PawnKindDef GingerThrumboPawn;
        public static PawnKindDef BionicThrumboPawn;
        public static PawnKindDef BionicDamagedThrumboPawn;
        public static PawnKindDef TalAlarianBlackThrumboPawn;
        public static PawnKindDef TalAlarianSilverThrumboPawn;
    }
}
