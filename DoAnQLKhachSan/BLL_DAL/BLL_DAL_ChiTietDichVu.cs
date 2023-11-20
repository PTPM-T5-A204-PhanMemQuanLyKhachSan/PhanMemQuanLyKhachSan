using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_ChiTietDichVu
    {
        QLKhachSanDataContext db = new QLKhachSanDataContext();
        public BLL_DAL_ChiTietDichVu()
        {
            
        }

        public List<Object> layDichVuTheoId(int id)
        {
            var dsChiTietDV = from ctdv in db.ChiTietDichVus join dv in db.DichVus on ctdv.MaDV equals dv.MaDV where ctdv.MaDP == id
                              select new
                              {
                                  TenDV = dv.TenDV,
                                  SoLuong = ctdv.SoLuong,
                              };
            List<Object> list = dsChiTietDV.ToList<Object>();
            return list;
        }

        public bool themCTDV(ChiTietDichVu ctdv) {
            try
            {
                db.ChiTietDichVus.InsertOnSubmit(ctdv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
