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
    public partial class ISoftComponent : ComponentBase
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
        protected RadzenDataList<Landpag2.Models.Authenticationconn.SoftwareModulescatlist> datalist0;

        IEnumerable<Landpag2.Models.Authenticationconn.SoftwareModulescatlist> _getsoftcategory;
        protected IEnumerable<Landpag2.Models.Authenticationconn.SoftwareModulescatlist> getsoftcategory
        {
            get
            {
                return _getsoftcategory;
            }
            set
            {
                if (!object.Equals(_getsoftcategory, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getsoftcategory", NewValue = value, OldValue = _getsoftcategory };
                    _getsoftcategory = value;
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

        }

        protected async System.Threading.Tasks.Task Datalist0LoadData(LoadDataArgs args)
        {
            var authenticationconnGetSoftwareModulescatlistsResult = await Authenticationconn.GetSoftwareModulescatlists();
            getsoftcategory = authenticationconnGetSoftwareModulescatlistsResult;
        }
    }
}
