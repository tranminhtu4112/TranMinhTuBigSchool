﻿using System.Web.Mvc;

namespace TranMinhTu_BIgSchool
{
    internal class ChallengeResult : ActionResult
    {
        private string provider;
        private string v1;
        private string v2;

        public ChallengeResult(string provider, string v1, string v2)
        {
            this.provider = provider;
            this.v1 = v1;
            this.v2 = v2;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}