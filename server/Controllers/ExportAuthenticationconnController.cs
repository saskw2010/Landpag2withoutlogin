using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Landpag2.Data;

namespace Landpag2
{
    public partial class ExportAuthenticationconnController : ExportController
    {
        private readonly AuthenticationconnContext context;
        private readonly AuthenticationconnService service;
        public ExportAuthenticationconnController(AuthenticationconnContext context, AuthenticationconnService service)
        {
            this.service = service;
            this.context = context;
        }

        [HttpGet("/export/Authenticationconn/softwaremodulescatlists/csv")]
        [HttpGet("/export/Authenticationconn/softwaremodulescatlists/csv(fileName='{fileName}')")]
        public async System.Threading.Tasks.Task<FileStreamResult> ExportSoftwareModulescatlistsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(await service.GetSoftwareModulescatlists(), Request.Query), fileName);
        }

        [HttpGet("/export/Authenticationconn/softwaremodulescatlists/excel")]
        [HttpGet("/export/Authenticationconn/softwaremodulescatlists/excel(fileName='{fileName}')")]
        public async System.Threading.Tasks.Task<FileStreamResult> ExportSoftwareModulescatlistsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(await service.GetSoftwareModulescatlists(), Request.Query), fileName);
        }
    }
}
