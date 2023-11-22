using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_DichVu
    {
        QLKhachSanDataContext db = new QLKhachSanDataContext();
        public BLL_DAL_DichVu()
        {
                
        }
        public bool themDichVu(DichVu dv)
        {
            try
            {
                db.DichVus.InsertOnSubmit(dv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaDichVu(int id)
        {
            try
            {
                DichVu dv = db.DichVus.FirstOrDefault(t => t.MaDV == id);
                if (dv == null)
                {
                    return false;
                }
                db.DichVus.DeleteOnSubmit(dv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaDichVu(DichVu temp)
        {
            try
            {
                DichVu dv = db.DichVus.FirstOrDefault(t => t.MaDV == temp.MaDV);
                if (dv == null)
                {
                    return false;
                }
                dv.TenDV = temp.TenDV;
                dv.GiaDV = temp.GiaDV;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<DichVu> loadDichVu()
        {
            return db.DichVus.ToList();
        }
    }
}
