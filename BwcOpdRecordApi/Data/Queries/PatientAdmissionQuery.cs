using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Queries
{
    public class PatientAdmissionQuery
    {
        public static string GetPatientHnByEpiRowId()
        {
            return @"
            SELECT 
	            PAADM_RowID, PAADM_ADMNo, PAADM_PAPMI_DR,
	            PAADM_PAPMI_DR->PAPMI_No
            FROM PA_Adm
            WHERE PAADM_RowID = ?";
        }

        public static string GetEpisodeTreeByPapmiRowId()
        {
            return @"
            SELECT 
                PAADM_RowID, 
                PAADM_ADMNo, 
                PAADM_AdmDate,
                PAADM_AdmTime, 
                PAADM_DepCode_DR->CTLOC_Code,
                PAADM_DepCode_DR->CTLOC_Desc,
                PAADM_AdmDocCodeDR->CTPCP_Code, 
                PAADM_AdmDocCodeDR->CTPCP_Desc, 
                PAADM_Type,
                PAADM_VisitStatus,
                PAADM_DischgDate,
                PAADM_DischgTime,
                PAADM_Remark
            FROM PA_Adm
            WHERE PAADM_PAPMI_DR = ? 
            AND PAADM_VisitStatus <> 'C' ";
        }

        public static string GetPersonByPapmiRowId()
        {
            return @"
            SELECT 
	            PAPER_RowId, PAPER_ID,
	            PAPER_PAPMI_DR->PAPMI_No,
	            PAPER_Title_DR->TTL_Desc, PAPER_Name, PAPER_Name2, 
	            PAPER_Sex_DR->CTSEX_Desc, PAPER_PAPMI_DR->PAPMI_DOB,
	            PAPER_AgeYr, PAPER_AgeMth, PAPER_AgeDay
            FROM PA_Person
            WHERE PAPER_PAPMI_DR = ?";
        }

        public static string GetPatientMasterByPapmiNo()
        {
            return @"
            SELECT 
	            PAPMI_RowId1, PAPMI_No
            FROM PA_PatMas
            WHERE PAPMI_No = ? ";
        }
    }
}
