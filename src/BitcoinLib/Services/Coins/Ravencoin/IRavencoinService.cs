using BitcoinLib.CoinParameters.Ravencoin;
using BitcoinLib.Responses.Ravencoin;
using BitcoinLib.Services.Coins.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinLib.Services.Coins.Ravencoin
{
    public interface IRavencoinService : ICoinService, IRavencoinConstants
    {
        GetAsssetDataResponse GetAssetData(string s);
        string GetListOfMyAssets(string asset_name, bool verbose=false, int count=1, int start=0);
    }
}
