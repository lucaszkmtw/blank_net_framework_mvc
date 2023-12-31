﻿using NHibernate;
using Oracle.DataAccess.Client;

namespace ECO.RCF.DataAccess.Infrastructure
{
    public class OracleInterceptor : EmptyInterceptor
    {
        private string sClientId;

        public OracleInterceptor(string clientId)
        {
            sClientId = clientId;
        }

        public override void SetSession(ISession session)
        {
            ((OracleConnection)session.Connection).ClientId = sClientId;
        }
    }
}
