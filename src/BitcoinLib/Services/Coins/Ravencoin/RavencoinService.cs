using BitcoinLib.CoinParameters.Ravencoin;
using BitcoinLib.Responses.Ravencoin;
using BitcoinLib.RPC.Specifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinLib.Services.Coins.Ravencoin
{
    public class RavencoinService  : CoinService, IRavencoinService
    {
        public RavencoinService(bool useTestnet = false) : base(useTestnet)
        {

        }

        public RavencoinService(string daemonUrl, string rpcUsername, string rpcPassword, string walletPassword = null)
            : base(daemonUrl, rpcUsername, rpcPassword, walletPassword)
        {
        }

        public RavencoinService(string daemonUrl, string rpcUsername, string rpcPassword, string walletPassword, short rpcRequestTimeoutInSeconds)
            : base(daemonUrl, rpcUsername, rpcPassword, walletPassword, rpcRequestTimeoutInSeconds)
        {
        }

        public RavencoinConstants.Constants Constants => RavencoinConstants.Constants.Instance;
        
        public GetAsssetDataResponse GetAssetData(string asset_name)
        {
            return _rpcConnector.MakeRequest<GetAsssetDataResponse>(RpcMethods.getassetdata, asset_name);
        }

        public string GetListOfMyAssets(string asset_name = "*", bool verbose = false, int count=1, int start = 0)
        {
            return _rpcConnector.MakeRequest<string>(RpcMethods.listmyassets, asset_name, verbose, count, start);
        }
    }
}
