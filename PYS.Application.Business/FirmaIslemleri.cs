using PYS.Application.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYS.Application.Business
{
    public class FirmaIslemleri :BaseFirmaIslemleri
    {
        internal TResult AddFirm(TblFirmalar Firma)
        {
            return base.DoAddFirm(Firma);

        }

        internal TResult UpdateFirm(Guid FirmGuid, TblFirmalar Firma)
        {
            return base.DoUpdateFirm(FirmGuid, Firma);

        }

        internal TResult DeleteFirm(Guid FirmGuid)
        {
            return base.DoDeleteFirm(FirmGuid);

        }
        internal TResult FirmList()
        {
            return base.DoFirmList();

        }

    }
}
