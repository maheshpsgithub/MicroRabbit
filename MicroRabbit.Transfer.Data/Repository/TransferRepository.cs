using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDbContext _ctx;
        public TransferRepository(TransferDbContext ctx)
        {
            _ctx = ctx;
        }

        public bool Add(TransferLog transferLog)
        {
            if (!_ctx.TransferLogs.Any(tl => tl.Id == transferLog.Id))
            {
                _ctx.Add(transferLog);
                _ctx.SaveChanges();
                return true;
            }

            return false;

        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _ctx.TransferLogs;
        }

    }
}
