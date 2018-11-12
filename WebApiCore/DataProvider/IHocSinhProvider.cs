using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCore.Models;

namespace WebApiCore.DataProvider
{
    public interface IHocSinhProvider
    {
        IEnumerable<HocSinh> getAllHocSinh();
        HocSinh getHocSinh(int id);
        void CreateHocSinh(HocSinh hs);
        void UpdateHocSinh(HocSinh hs);
        void DeleteHocSinh(int id);
    }
}
