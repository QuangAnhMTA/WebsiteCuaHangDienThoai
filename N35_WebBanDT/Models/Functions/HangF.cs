using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using N35_WebBanDT.Models.Entities;
namespace N35_WebBanDT.Models.Functions
{
    public class HangF
    {
        private MyDBContext context;
        public HangF()
        {
            context = new MyDBContext();
        }
        public IQueryable<Hang> Hangs
        {
            get { return context.Hangs; }
        }
    }
}