using BitcoinLib.CoinParameters.Base;

namespace BitcoinLib.CoinParameters.Ravencoin
{
    public static class RavencoinConstants
    {
        public sealed class Constants : CoinConstants<Constants>
        {
            public readonly ushort CoinReleaseHalfsEveryXInYears = 3;
            public readonly uint DifficultyIncreasesEveryXInBlocks = 2100000;
            public readonly uint OneRavencoinInSatoshis = 2720000;
            //public readonly decimal OneSmartoshisInSmart = 0.00000001M;
            //public readonly decimal OneMicrosmartInSmart = 0.000001M;
            //public readonly decimal OneMillismartInSmart = 0.001M;
            public readonly string Symbol = "RVN";
        }
    }
}