using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Queries
{
    public class MedicalRecordQuery
    {
        public static string GetDocumentsByPapmiRowId()
        {
            return @"
                SELECT 
                    MRADM_ADM_DR->PAADM_PAPMI_DR->PAPMI_No,
                    MRADM_ADM_DR->PAADM_RowID,
                    MRADM_ADM_DR->PAADM_ADMNo,
	                MR_Pictures->PIC_DateCreated, 
	                MR_Pictures->PIC_TimeCreated,
	                MR_Pictures->PIC_DocSubType_DR->SADST_Code, 
	                MR_Pictures->PIC_DocSubType_DR->SADST_Desc,	
	                MR_Pictures->PIC_Path,
	                MR_Pictures->PIC_Desc,
	                MR_Pictures->PIC_DocType_DR->DOCTYPE_Desc,
                    MR_Pictures->PIC_websysDocument->docType DocType
                FROM MR_Adm
                WHERE MRADM_ADM_DR->PAADM_PAPMI_DR->PAPMI_RowId1 = ?
                AND MR_Pictures->PIC_RowId <> ''
                ORDER BY MR_Pictures->PIC_DateCreated DESC, MR_Pictures->PIC_TimeCreated DESC";
        }

        public static string GetDocumentsByEpiRowId()
        {
            return @"
                SELECT 
                    MRADM_ADM_DR->PAADM_PAPMI_DR->PAPMI_No,
                    MRADM_ADM_DR->PAADM_RowID,
                    MRADM_ADM_DR->PAADM_ADMNo,
	                MR_Pictures->PIC_DateCreated, 
	                MR_Pictures->PIC_TimeCreated,
	                MR_Pictures->PIC_DocSubType_DR->SADST_Code, 
	                MR_Pictures->PIC_DocSubType_DR->SADST_Desc,	
	                MR_Pictures->PIC_Path,
	                MR_Pictures->PIC_Desc,
	                MR_Pictures->PIC_DocType_DR->DOCTYPE_Desc,
                    MR_Pictures->PIC_websysDocument->docType DocType
                FROM MR_Adm
                WHERE MRADM_ADM_DR->PAADM_RowID = ?
                AND MR_Pictures->PIC_RowId <> ''
                ORDER BY MR_Pictures->PIC_DateCreated DESC, MR_Pictures->PIC_TimeCreated DESC";
        }

        public static string GetDocumentByPapmiNoAndPath()
        {
            return @"
                SELECT
	                MR_Pictures->PIC_websysDocument->docData DocData,
	                MR_Pictures->PIC_websysDocument->docType DocType
                FROM MR_Adm
                WHERE MRADM_ADM_DR->PAADM_PAPMI_DR->PAPMI_No = ?
                AND MR_Pictures->PIC_Path = ? ";
        }

        public static string GetDocumentTypeByPapmiNoAndPath()
        {
            return @"
                SELECT
	                MR_Pictures->PIC_websysDocument->docType DocType
                FROM MR_Adm
                WHERE MRADM_ADM_DR->PAADM_PAPMI_DR->PAPMI_No = ?
                AND MR_Pictures->PIC_Path = ? ";
        }
    }
}
