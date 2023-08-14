using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SICE.Controllers
{
    public abstract class BaseController : UserMessageController
    {
        protected Models.IUnityOfHelpers myUnityOfHelpers { get; private set; }

        protected Models.sicedbEntities idbsiceContext { get; private set; }

        public BaseController()
        {
            this.idbsiceContext = new Models.sicedbEntities();
            this.myUnityOfHelpers = new Models.UnityOfHelpers(this.idbsiceContext);
        }
    }
}