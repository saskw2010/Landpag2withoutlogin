using Radzen;
using System;
using System.Web;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Data;
using System.Text.Encodings.Web;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;
using Landpag2.Data;

namespace Landpag2
{
    public partial class AuthenticationconnService
    {
        AuthenticationconnContext Context
        {
           get
           {
             return this.context;
           }
        }

        private readonly AuthenticationconnContext context;
        private readonly NavigationManager navigationManager;

        public AuthenticationconnService(AuthenticationconnContext context, NavigationManager navigationManager)
        {
            this.context = context;
            this.navigationManager = navigationManager;
        }

        public void Reset() => Context.ChangeTracker.Entries().Where(e => e.Entity != null).ToList().ForEach(e => e.State = EntityState.Detached);

        public async Task ExportSoftwareModulescatlistsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/authenticationconn/softwaremodulescatlists/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/authenticationconn/softwaremodulescatlists/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportSoftwareModulescatlistsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/authenticationconn/softwaremodulescatlists/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/authenticationconn/softwaremodulescatlists/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnSoftwareModulescatlistsRead(ref IQueryable<Models.Authenticationconn.SoftwareModulescatlist> items);

        public async Task<IQueryable<Models.Authenticationconn.SoftwareModulescatlist>> GetSoftwareModulescatlists(Query query = null)
        {
            var items = Context.SoftwareModulescatlists.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p.Trim());
                    }
                }

                if (!string.IsNullOrEmpty(query.Filter))
                {
                    if (query.FilterParameters != null)
                    {
                        items = items.Where(query.Filter, query.FilterParameters);
                    }
                    else
                    {
                        items = items.Where(query.Filter);
                    }
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnSoftwareModulescatlistsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnSoftwareModulescatlistCreated(Models.Authenticationconn.SoftwareModulescatlist item);
        partial void OnAfterSoftwareModulescatlistCreated(Models.Authenticationconn.SoftwareModulescatlist item);

        public async Task<Models.Authenticationconn.SoftwareModulescatlist> CreateSoftwareModulescatlist(Models.Authenticationconn.SoftwareModulescatlist softwareModulescatlist)
        {
            OnSoftwareModulescatlistCreated(softwareModulescatlist);

            var existingItem = Context.SoftwareModulescatlists
                              .Where(i => i.sprModulecatid == softwareModulescatlist.sprModulecatid)
                              .FirstOrDefault();

            if (existingItem != null)
            {
               throw new Exception("Item already available");
            }            

            try
            {
                Context.SoftwareModulescatlists.Add(softwareModulescatlist);
                Context.SaveChanges();
            }
            catch
            {
                Context.Entry(softwareModulescatlist).State = EntityState.Detached;
                throw;
            }

            OnAfterSoftwareModulescatlistCreated(softwareModulescatlist);

            return softwareModulescatlist;
        }

        partial void OnSoftwareModulescatlistDeleted(Models.Authenticationconn.SoftwareModulescatlist item);
        partial void OnAfterSoftwareModulescatlistDeleted(Models.Authenticationconn.SoftwareModulescatlist item);

        public async Task<Models.Authenticationconn.SoftwareModulescatlist> DeleteSoftwareModulescatlist(Int64? sprModulecatid)
        {
            var itemToDelete = Context.SoftwareModulescatlists
                              .Where(i => i.sprModulecatid == sprModulecatid)
                              .FirstOrDefault();

            if (itemToDelete == null)
            {
               throw new Exception("Item no longer available");
            }

            OnSoftwareModulescatlistDeleted(itemToDelete);

            Context.SoftwareModulescatlists.Remove(itemToDelete);

            try
            {
                Context.SaveChanges();
            }
            catch
            {
                Context.Entry(itemToDelete).State = EntityState.Unchanged;
                throw;
            }

            OnAfterSoftwareModulescatlistDeleted(itemToDelete);

            return itemToDelete;
        }

        partial void OnSoftwareModulescatlistGet(Models.Authenticationconn.SoftwareModulescatlist item);

        public async Task<Models.Authenticationconn.SoftwareModulescatlist> GetSoftwareModulescatlistBysprModulecatid(Int64? sprModulecatid)
        {
            var items = Context.SoftwareModulescatlists
                              .AsNoTracking()
                              .Where(i => i.sprModulecatid == sprModulecatid);

            var itemToReturn = items.FirstOrDefault();

            OnSoftwareModulescatlistGet(itemToReturn);

            return await Task.FromResult(itemToReturn);
        }

        public async Task<Models.Authenticationconn.SoftwareModulescatlist> CancelSoftwareModulescatlistChanges(Models.Authenticationconn.SoftwareModulescatlist item)
        {
            var entityToCancel = Context.Entry(item);
            if (entityToCancel.State == EntityState.Modified)
            {
              entityToCancel.CurrentValues.SetValues(entityToCancel.OriginalValues);
              entityToCancel.State = EntityState.Unchanged;
            }

            return item;
        }

        partial void OnSoftwareModulescatlistUpdated(Models.Authenticationconn.SoftwareModulescatlist item);
        partial void OnAfterSoftwareModulescatlistUpdated(Models.Authenticationconn.SoftwareModulescatlist item);

        public async Task<Models.Authenticationconn.SoftwareModulescatlist> UpdateSoftwareModulescatlist(Int64? sprModulecatid, Models.Authenticationconn.SoftwareModulescatlist softwareModulescatlist)
        {
            OnSoftwareModulescatlistUpdated(softwareModulescatlist);

            var itemToUpdate = Context.SoftwareModulescatlists
                              .Where(i => i.sprModulecatid == sprModulecatid)
                              .FirstOrDefault();
            if (itemToUpdate == null)
            {
               throw new Exception("Item no longer available");
            }

            var entryToUpdate = Context.Entry(itemToUpdate);
            entryToUpdate.CurrentValues.SetValues(softwareModulescatlist);
            entryToUpdate.State = EntityState.Modified;
            Context.SaveChanges();       

            OnAfterSoftwareModulescatlistUpdated(softwareModulescatlist);

            return softwareModulescatlist;
        }
    }
}
