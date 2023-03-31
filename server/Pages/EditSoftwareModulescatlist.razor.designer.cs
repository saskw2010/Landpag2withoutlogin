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
    public partial class EditSoftwareModulescatlistComponent : ComponentBase
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

        [Parameter]
        public dynamic sprModulecatid { get; set; }

        bool _hasChanges;
        protected bool hasChanges
        {
            get
            {
                return _hasChanges;
            }
            set
            {
                if (!object.Equals(_hasChanges, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "hasChanges", NewValue = value, OldValue = _hasChanges };
                    _hasChanges = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        bool _canEdit;
        protected bool canEdit
        {
            get
            {
                return _canEdit;
            }
            set
            {
                if (!object.Equals(_canEdit, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "canEdit", NewValue = value, OldValue = _canEdit };
                    _canEdit = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        Landpag2.Models.Authenticationconn.SoftwareModulescatlist _softwaremodulescatlist;
        protected Landpag2.Models.Authenticationconn.SoftwareModulescatlist softwaremodulescatlist
        {
            get
            {
                return _softwaremodulescatlist;
            }
            set
            {
                if (!object.Equals(_softwaremodulescatlist, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "softwaremodulescatlist", NewValue = value, OldValue = _softwaremodulescatlist };
                    _softwaremodulescatlist = value;
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
            hasChanges = false;

            canEdit = true;

            var authenticationconnGetSoftwareModulescatlistBysprModulecatidResult = await Authenticationconn.GetSoftwareModulescatlistBysprModulecatid(sprModulecatid);
            softwaremodulescatlist = authenticationconnGetSoftwareModulescatlistBysprModulecatidResult;
        }

        protected async System.Threading.Tasks.Task CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            Authenticationconn.Reset();

            await this.Load();
        }

        protected async System.Threading.Tasks.Task Form0Submit(Landpag2.Models.Authenticationconn.SoftwareModulescatlist args)
        {
            try
            {
                var authenticationconnUpdateSoftwareModulescatlistResult = await Authenticationconn.UpdateSoftwareModulescatlist(sprModulecatid, softwaremodulescatlist);
                DialogService.Close(softwaremodulescatlist);
            }
            catch (System.Exception authenticationconnUpdateSoftwareModulescatlistException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to update SoftwareModulescatlist" });

            hasChanges = authenticationconnUpdateSoftwareModulescatlistException is DbUpdateConcurrencyException;
            }
        }

        protected async System.Threading.Tasks.Task Button4Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
