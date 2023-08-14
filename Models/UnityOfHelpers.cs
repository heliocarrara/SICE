using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SICE.Models
{
    public class UnityOfHelpers : IUnityOfHelpers
    {
        public sicedbEntities idbsiceContext { get { return this._db; } }

        private sicedbEntities _db;

        public UnityOfHelpers(sicedbEntities _db)
        {
            this._db = _db;
        }
    }
}