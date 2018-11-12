using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCore.Models;

namespace WebApiCore.DataProvider
{
    public class HocSinhProvider : IHocSinhProvider
    {
        private readonly schoolDBContext db;

        public HocSinhProvider(schoolDBContext context)
        {
            db = context;
        }

        public void CreateHocSinh(HocSinh hs)
        {
            db.Add(hs);
            db.SaveChangesAsync();
        }

        public void DeleteHocSinh(int id)
        {
            var hs = db.HocSinh.SingleOrDefault(m => m.Id == id);
            if(hs!= null)
            {
                db.HocSinh.Remove(hs);
                db.SaveChangesAsync();
            }
        }

        public IEnumerable<HocSinh> getAllHocSinh()
        {
            var lstAllHocSinh = db.HocSinh.ToList();
            return lstAllHocSinh;
        }

        public HocSinh getHocSinh(int id)
        {
            var hs = db.HocSinh.SingleOrDefault(x => x.Id == id);
            return hs;
        }

        public void UpdateHocSinh(HocSinh hs)
        {
            db.Update(hs);
            db.SaveChangesAsync();
        }


    }
}
