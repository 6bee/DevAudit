﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DevAudit.AuditLibrary
{
    public class LibrariesdotIODataSource : HttpDataSource
    {
        #region Constructors
        public LibrariesdotIODataSource(AuditTarget target, Dictionary<string, object> datasource_options) : base(target, datasource_options)
        {

        }
        #endregion

        #region Overriden methods
        public override Task<Dictionary<IPackage, List<IArtifact>>> SearchArtifacts(List<Package> packages)
        {
            /*
            CallerInformation caller = this.HostEnvironment.Here();
            this.HostEnvironment.Status("Searching Libraries.io for artifacts for {0} packages.", packages.Count());
            List<Task> tasks = new List<Task>(packages.Count());
            Stopwatch sw = new Stopwatch();
            sw.Start();
            object package_info_lock = new object();
     
            foreach (IPackage package in packages)
            {

            }
            */
            throw new NotImplementedException();
        }

        public override Task<Dictionary<IPackage, List<IVulnerability>>> SearchVulnerabilities(List<Package> packages)
        {
            throw new NotImplementedException();
        }

        public override bool IsEligibleForTarget(AuditTarget target)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Overriden properties
        public override int MaxConcurrentSearches
        {
            get
            {
                return 5;
            }
        }
        #endregion

        #region Methods
        private IArtifact GetArtifact(IPackage package)
        {
            throw new Exception();
            /*
            using (HttpClient client = CreateHttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(string.Format("v" + api_version + "/project/{0}", id));
                if (response.IsSuccessStatusCode)
                {
                    string r = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<OSSIndexProject>>(r).FirstOrDefault();
                }
                else
                {
                    throw new OSSIndexHttpException(id, response.StatusCode, response.ReasonPhrase, response.RequestMessage);
                }
            }
            */
        }
        #endregion
    }
}
