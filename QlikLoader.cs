//using Qlik.Engine;
//using Qlik.Sense.Client;
//using Qlik.Sense.RestClient;
//using System;
//using System.Collections.Generic;
using System.Runtime.InteropServices;

public class QlikOcxFunctions
{
    [DllImport("QlikOcx.ocx", EntryPoint = "StartRegFreeOperation")]
    public static extern void StartRegFreeOperation();
}

namespace qlikloader
{
    internal class QlikLoader
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
    	    
            if (OperatingSystem.IsWindows())
            {
                //QlikOcxFunctions.StartRegFreeOperation();
                const string progID = "QlikTech.QlikOCXCtrl";
                Type foo = Type.GetTypeFromProgID(progID);

                //var bar = Guid.Parse ("99929AA7-0334-4B2D-AC74-5E282A12D06C");
                //Type foo = Type.GetTypeFromCLSID (bar);

                dynamic COMobject = Activator.CreateInstance(foo);
                
                //COMobject.
                //return COMobject;
            }

            /*var uri = "http://gbw20115160";
            var appId = "QvAjaxZfc"; //http://gbw20115160/QvAjaxZfc/QvsViewClient.aspx?mark=40e5f854e46ac354&host=QVS%40gbw20115160&view=cupiddashboard%5Ccupid%20dashboard.qvw&slot=&platform=browser.chrome&dpi=96&xrfkey=yogZL35jtnQSUk2b
            
            var location = Location.FromUri(uri);
            location.AsNtlmUserViaProxy();
            var restClient = new RestClient(uri);
            restClient.AsNtlmUserViaProxy();
            Console.WriteLine(restClient.Get("/qrs/about"));

            using (var app = location.App(new AppIdentifier { AppId = appId }))
            {
                var theSheet = app.GetSheets().First();
                Console.WriteLine(theSheet.GetInfo().ToString());
                var objs = theSheet.GetChildInfos().Select(info => app.GetGenericObject(info.Id));
                foreach (var o in objs)
                {
                    var exportResult = o.ExportData(NxExportFileType.EXPORT_OOXML);
                    var data = restClient.GetBytes(exportResult.Url);
                    using (var writer = new BinaryWriter(new FileStream(o.Id + ".xlsx", FileMode.OpenOrCreate)))
                    {
                        writer.Write(data);
                    }
                }
            }*/

            System.Environment.Exit(0);
        }

        /*public static dynamic ComObjectGet() {
            const string progID = "QlikTech.QlikOCXCtrl";
            Type foo = Type.GetTypeFromProgID(progID);

            //var bar = Guid.Parse ("99929AA7-0334-4B2D-AC74-5E282A12D06C");
            //Type foo = Type.GetTypeFromCLSID (bar);

            dynamic COMobject = Activator.CreateInstance(foo);
            return COMobject;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }*/
    }
}