using Qlik.Engine;
using Qlik.Sense.Client;
using Qlik.Sense.RestClient;

namespace qlikloader
{
    internal class QlikLoader
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var uri = "https://192.168.0.0";
            var appId = "Fucker";
            
            var location = Location.FromUri(uri);
            location.AsNtlmUserViaProxy();
            var restClient = new RestClient(uri);
            restClient.AsNtlmUserViaProxy();

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
            }
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
        }
    }
}