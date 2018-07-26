using BwcOpdRecordApi.Data.ViewModels.EPR.DoctorPanel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BwcOpdRecordApi.Data.Interfaces.Services
{
    public interface IEprService
    {
        Task<DoctorPanelViewModel> GetDoctorPanelByEpiRowIdAsync(long epiRowId);
    }
}
