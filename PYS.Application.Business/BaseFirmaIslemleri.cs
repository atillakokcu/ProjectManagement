using PYS.Application.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYS.Application.Business
{
    public class BaseFirmaIslemleri
    {
        public DbPYSEntities Db;
        public BaseFirmaIslemleri()
        {
            Db = new DbPYSEntities();
        }

        internal TResult DoAddFirm(TblFirmalar Firma)
        {
            TResult result = new TResult();

            try
            {
                Db.TblFirmalar.Add(Firma);
                Db.SaveChanges();
                result.Success = true;
                result.StatusCode = 200;
            }
            catch (Exception ex)
            {
                result.StatusCode = -1001;
                result.Message = ex.Message;
                throw;
            }
            return result;

        }

        internal TResult DoUpdateFirm(Guid FirmGuid, TblFirmalar Firma)
        {
            TResult result = new TResult();


            try
            {
                TblFirmalar Firm = (from data in Db.TblFirmalar where data.FirmaGuid == FirmGuid select data).FirstOrDefault();

                if (Firm == null)
                {
                    result.Message = "firma bulunamadı";
                }
                else
                {
                    Firm = Firma;
                    Db.TblFirmalar.Add(Firm);
                    Db.SaveChanges();
                    result.Success = true;
                    result.StatusCode = 200;

                }

            }
            catch (Exception ex)
            {
                result.StatusCode = -1001;
                result.Message = ex.Message;
                throw;
            }
            return result;

        }

        internal TResult DoDeleteFirm(Guid FirmGuid)
        {
            TResult result = new TResult();


            try
            {
                TblFirmalar Firm = (from data in Db.TblFirmalar where data.FirmaGuid == FirmGuid select data).FirstOrDefault();

                if (Firm == null)
                {
                    result.Message = "firma bulunamadı";
                }
                else
                {
                    Db.Database.ExecuteSqlCommand("update TblFirma set Silik=1 where FirmaGuid='" + FirmGuid + "'");

                }

            }
            catch (Exception ex)
            {
                result.StatusCode = -1001;
                result.Message = ex.Message;
                throw;
            }
            return result;

        }
        internal TResult DoFirmList()
        {
            TResult result = new TResult();


            try
            {
                List<VwFirmalar> FirmListt = (from data in Db.VwFirmalar orderby data.FirmaUnvan select data).ToList();

                if (FirmListt == null)
                {
                    result.Message = "firma bulunamadı";
                }
                else
                {
                    result.Data.AddRange(FirmListt);
                    result.Success = true;
                    result.StatusCode = 200;


                }

            }
            catch (Exception ex)
            {
                result.StatusCode = -1001;
                result.Message = ex.Message;
                throw;
            }
            return result;

        }

        //public TResult DoFirmList(string FirmaIsmi)
        //{
        //    TResult result = new TResult();


        //    try
        //    {
        //        List<VwFirmalar> FirmList = (from data in Db.VwFirmalar where data.FirmaUnvan.Contains() select data).ToList();

        //        if (FirmList == null)
        //        {
        //            result.Message = "firma bulunamadı";
        //        }
        //        else
        //        {
        //            result.Data.AddRange(FirmList);

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        result.StatusCode = -1001;
        //        result.Message = ex.Message;
        //        throw;
        //    }
        //    return result;

        //}


        internal TResult DoFirmDetail(Guid FirmGuid)
        {
            TResult result = new TResult();


            try
            {
                VwFirmalar FirmDetay = (from data in Db.VwFirmalar where data.FirmaGuid == FirmGuid select data).FirstOrDefault();

                if (FirmDetay == null)
                {
                    result.Message = "firma bulunamadı";
                }
                else
                {
                    result.Data.Add(FirmDetay);
                    result.Success = true;
                    result.StatusCode = 200;


                }

            }
            catch (Exception ex)
            {
                result.StatusCode = -1001;
                result.Message = ex.Message;
                throw;
            }
            return result;

        }

    }
}
