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
            var dsChiTietDV = from ctdv in db.ChiTietDichVus
                              join dv in db.DichVus on ctdv.MaDV equals dv.MaDV
                              where ctdv.MaDP == id
                              select new
                              {
                                  MaDV = dv.MaDV,
                                  TenDV = dv.TenDV,
                                  SoLuong = ctdv.SoLuong,
                                  GiaDV = dv.GiaDV
                              };
            List<Object> list = dsChiTietDV.ToList<Object>();
            return list;
        }

        public List<Object> layDSInHD(int id)
        {
            var l = from hoaDon in db.HoaDons
                    join datPhong in db.DatPhongs on hoaDon.MaHD equals datPhong.MaHD
                    join chiTietDichVu in db.ChiTietDichVus on datPhong.MaDP equals chiTietDichVu.MaDP
                    join dichVu in db.DichVus on chiTietDichVu.MaDV equals dichVu.MaDV
                    join phong in db.Phongs on datPhong.MaPhong equals phong.MaPhong
                    where hoaDon.MaHD == id
                    select new
                    {
                        TenP = phong.TenPhong,
                        TenDV = dichVu.TenDV,
                        GiaDV = dichVu.GiaDV,
                        SoLuong = chiTietDichVu.SoLuong,
                        ThanhTien = chiTietDichVu.SoLuong * dichVu.GiaDV
                    };
            return l.ToList<Object>();
        }

        public ChiTietDichVu layCTDVByKey(int madp, int madv)
        {
            return db.ChiTietDichVus.FirstOrDefault(t => t.MaDP == madp && t.MaDV == madv);
        }

        public bool themCTDV(ChiTietDichVu ctdv)
        {
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

        public bool suaCTDV(ChiTietDichVu ct)
        {
            try
            {
                ChiTietDichVu ctdv = db.ChiTietDichVus.FirstOrDefault(t => t.MaDP == ct.MaDP && t.MaDV == ct.MaDV);
                if (ctdv == null)
                {
                    return false;
                }
                ctdv.SoLuong = ct.SoLuong;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaCTDV(int madp, int madv)
        {
            try
            {
                ChiTietDichVu ctdv = db.ChiTietDichVus.FirstOrDefault(t => t.MaDP == madp && t.MaDV == madv);
                if (ctdv == null)
                {
                    return false;
                }
                db.ChiTietDichVus.DeleteOnSubmit(ctdv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaAllCTDV(int madp)
        {
            try
            {
                List<ChiTietDichVu> l = db.ChiTietDichVus.Where(t => t.MaDP == madp).ToList();
                if (l.Count > 0)
                {
                    db.ChiTietDichVus.DeleteAllOnSubmit(l);
                    db.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
