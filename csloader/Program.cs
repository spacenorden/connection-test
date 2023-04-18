using System;
using System.Reflection;
using System.Runtime.InteropServices;

// https://stackoverflow.com/questions/18362368/loading-dlls-at-runtime-in-c-sharp

public class QlikOcxFunctions
{
    [DllImport("QlikOcx_x64.ocx", EntryPoint = "StartRegFreeOperation")]
    public static extern void StartRegFreeOperation();

    [DllImport("QlikOcx_x64.ocx", EntryPoint = "MsgBox")]
    public static extern void MsgBox();
}

public class CSLoader {
    [STAThread]
    public static void Main(string[] args) {
    Console.WriteLine("Hello, World!");

    if (OperatingSystem.IsWindows()) {
        QlikOcxFunctions.StartRegFreeOperation();

        const string progID = "QlikTech.QlikOCXCtrl";
        Type foo = Type.GetTypeFromProgID(progID);

                //var bar = Guid.Parse ("99929AA7-0334-4B2D-AC74-5E282A12D06C");
                //Type foo = Type.GetTypeFromCLSID (bar);
        Console.WriteLine("{0}", foo.AssemblyQualifiedName);
        //dynamic COMobject = Activator.CreateInstance(foo);

        Type ttype = Type.GetTypeFromProgID("QlikTech.QlikOCXCtrl");
        dynamic comObject = Activator.CreateInstance(ttype);
        //object comObject = Activator.CreateInstance(myType);
        
        var QlikOCXDLL = Assembly.LoadFile(@"C:\Users\D991961\Work\csloader\x64\QlikOCXLib.dll");
        var QlikOCXType = QlikOCXDLL.GetType("QlikOCXLib.QlikOCXClass");
        

        //Now you can use reflection or dynamic to call the method. I will show you the dynamic way

        dynamic cc = Activator.CreateInstance(QlikOCXType);
        Console.WriteLine("{0}", QlikOCXType.AssemblyQualifiedName);

        foreach(Type type in QlikOCXDLL.GetExportedTypes())
            if (type.IsClass)
            {
                dynamic c = Activator.CreateInstance(type);
                Console.WriteLine("{0}", type.AssemblyQualifiedName);
            }

        cc.AboutBox();

        //object [] inputParameters = new object []
        //    {0, "test", "fucker"};
        //comObject.InvokeMember("MsgBox", System.Reflection.BindingFlags.InvokeMethod, null, comObject, inputParameters);

        comObject.AboutBox();

        var DLL = Assembly.LoadFile(@"C:\Users\D991961\Work\csloader\QlikOcx_x64.ocx");

        foreach(Type type in DLL.GetExportedTypes())
        {
            dynamic c = Activator.CreateInstance(type);
            c.Output(@"Hello");
        }

        Console.ReadLine();


        var handle = Activator.CreateInstance("../QlikOcx64.ocx", "QlikTech.QlikOCXCtrl");
        var obj = handle.Unwrap();
        Console.WriteLine("{0}: {1}", obj.GetType().Name, obj);

        //Console.WriteLine("{0}", obj.OSName());
        //obj.MsgBox(0, "", obj.OSName());
        //testName = "QlikTech.QlikOCXCtrl";
        //var data = CreateInstance<IProviderInitializer>(testName).GetProviderInfo();
        //Console.WriteLine("Data: " + data);

    }
    return;
}

/*static I CreateInstance<I>(string myClassName) where I : class {
    var createdInstance = Activator.CreateInstance(null, myClassName);
    return createdInstance.Unwrap() as I;
}*/
}