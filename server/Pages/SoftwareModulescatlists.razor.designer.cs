using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Landpag2.Models.Authenticationconn;
using Microsoft.EntityFrameworkCore;

namespace Landpag2.Pages
{
    public partial class SoftwareModulescatlistsComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected AuthenticationconnService Authenticationconn { get; set; }
        protected RadzenDataGrid<Landpag2.Models.Authenticationconn.SoftwareModulescatlist> grid0;

        string _search;
        protected string search
        {
            get
            {
                return _search;
            }
            set
            {
                if (!object.Equals(_search, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "search", NewValue = value, OldValue = _search };
                    _search = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Landpag2.Models.Authenticationconn.SoftwareModulescatlist> _getSoftwareModulescatlistsResult;
        protected IEnumerable<Landpag2.Models.Authenticationconn.SoftwareModulescatlist> getSoftwareModulescatlistsResult
        {
            get
            {
                return _getSoftwareModulescatlistsResult;
            }
            set
            {
                if (!object.Equals(_getSoftwareModulescatlistsResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getSoftwareModulescatlistsResult", NewValue = value, OldValue = _getSoftwareModulescatlistsResult };
                    _getSoftwareModulescatlistsResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            if (string.IsNullOrEmpty(search)) {
                search = "";
            }

            var authenticationconnGetSoftwareModulescatlistsResult = await Authenticationconn.GetSoftwareModulescatlists(new Query() { Filter = $@"i => i.sprModulecatDesc.Contains(@0) || i.sprModulecatDesc1.Contains(@1) || i.FuturecatDesc.Contains(@2) || i.FuturecatDesc1.Contains(@3) || i.photopath.Contains(@4)", FilterParameters = new object[] { search, search, search, search, search } });
            getSoftwareModulescatlistsResult = authenticationconnGetSoftwareModulescatlistsResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddSoftwareModulescatlist>("Add Software Modulescatlist", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Authenticationconn.ExportSoftwareModulescatlistsToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "", Select = "sprModulecatid,sprModulecatDesc,sprModulecatDesc1,FuturecatDesc,FuturecatDesc1,photopath,InstallcatModule" }, $"Software Modulescatlists");

            }

            if (args == null || args.Value == "xlsx")
            {
                await Authenticationconn.ExportSoftwareModulescatlistsToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "", Select = "sprModulecatid,sprModulecatDesc,sprModulecatDesc1,FuturecatDesc,FuturecatDesc1,photopath,InstallcatModule" }, $"Software Modulescatlists");

            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Landpag2.Models.Authenticationconn.SoftwareModulescatlist args)
        {
            var dialogResult = await DialogService.OpenAsync<EditSoftwareModulescatlist>("Edit Software Modulescatlist", new Dictionary<string, object>() { {"sprModulecatid", args.sprModulecatid} });
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var authenticationconnDeleteSoftwareModulescatlistResult = await Authenticationconn.DeleteSoftwareModulescatlist(data.sprModulecatid);
                    if (authenticationconnDeleteSoftwareModulescatlistResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception authenticationconnDeleteSoftwareModulescatlistException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete SoftwareModulescatlist" });
            }
        }
    }
}
