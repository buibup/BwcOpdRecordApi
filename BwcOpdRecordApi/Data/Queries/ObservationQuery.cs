using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Queries
{
    public class ObservationQuery
    {
        public static string GetVitalSignsByEpiNo()
        {
            return @"
            SELECT 
	            MR_Observations->OBS_Date, 
	            MR_Observations->OBS_Time,
	            MR_Observations->OBS_Item_DR->ITM_Code,
	            MR_Observations->OBS_Item_DR->ITM_Desc,
	            MR_Observations->OBS_Value
            FROM MR_Adm
            WHERE MRADM_ADM_DR->PAADM_ADMNo = ?
            ";
        }

        public static string GetVitalSignsByEpiRowId()
        {
            return @"
            SELECT 
                MRADM_ADM_DR->PAADM_ADMNo, 
            	MRADM_ADM_DR->PAADM_PAPMI_DR->PAPMI_No,
	            MR_Observations->OBS_Entry_DR->OBSENTRY_Childsub,
	            MR_Observations->OBS_Date, 
	            MR_Observations->OBS_Time,
	            MR_Observations->OBS_Item_DR->ITM_Code,
	            MR_Observations->OBS_Item_DR->ITM_Desc,
	            MR_Observations->OBS_Value,
	            MR_Observations->OBS_User_DR,
	 			MR_Observations->OBS_User_DR->SSUSR_Initials, 
				MR_Observations->OBS_User_DR->SSUSR_Name,
                MR_Observations->OBS_ParRef
            FROM MR_Adm
            WHERE MRADM_ADM_DR->PAADM_RowID = ?
            ";
        }
    }
}
