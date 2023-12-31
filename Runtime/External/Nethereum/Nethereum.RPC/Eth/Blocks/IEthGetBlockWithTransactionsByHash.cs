﻿using System.Threading.Tasks;
using Nethereum.JsonRpc.Client;
using Nethereum.RPC.Eth.DTOs;

namespace Nethereum.RPC.Eth.Blocks
{
    public interface IEthGetBlockWithTransactionsByHash
    {
        RpcRequest BuildRequest(string blockHash, object id = null);
        Task<BlockWithTransactions> SendRequestAsync(string blockHash, object id = null);
    }
}