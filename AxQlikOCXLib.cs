//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Reflection.AssemblyVersion("12.60.0.0")]
[assembly: System.Windows.Forms.AxHost.TypeLibraryTimeStamp("05/24/2021 11:37:04")]

namespace AxQlikOCXLib {
    
    
    [System.Windows.Forms.AxHost.ClsidAttribute("{a806e1d7-b077-415e-af08-28afe10ddf4a}")]
    [System.ComponentModel.DesignTimeVisibleAttribute(true)]
    [System.ComponentModel.DefaultEvent("OnContextMenu")]
    public class AxQlikOCX : System.Windows.Forms.AxHost {
        
        private QlikOCXLib._DQlikOCX ocx;
        
        private AxQlikOCXEventMulticaster eventMulticaster;
        
        private System.Windows.Forms.AxHost.ConnectionPointCookie cookie;
        
        public AxQlikOCX() : 
                base("a806e1d7-b077-415e-af08-28afe10ddf4a") {
            this.SetAboutBoxDelegate(new AboutBoxDelegate(AboutBox));
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(4)]
        public virtual string DocName {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("DocName", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.DocName;
            }
            set {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("DocName", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.DocName = value;
            }
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(5)]
        public virtual string UserName {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("UserName", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.UserName;
            }
            set {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("UserName", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.UserName = value;
            }
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(6)]
        public virtual string Password {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("Password", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.Password;
            }
            set {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("Password", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.Password = value;
            }
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(8)]
        public virtual string License {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("License", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.License;
            }
            set {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("License", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.License = value;
            }
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(11)]
        public virtual int AccessMode {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("AccessMode", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.AccessMode;
            }
            set {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("AccessMode", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.AccessMode = value;
            }
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(12)]
        public virtual bool AllowDialog {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("AllowDialog", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.AllowDialog;
            }
            set {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("AllowDialog", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.AllowDialog = value;
            }
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(15)]
        public virtual string SRC {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("SRC", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.SRC;
            }
            set {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("SRC", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.SRC = value;
            }
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(16)]
        public virtual bool AutoScan {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("AutoScan", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.AutoScan;
            }
            set {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("AutoScan", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.AutoScan = value;
            }
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(18)]
        public virtual QlikOCXLib.QVX_LVL_ALL ProductLevel {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("ProductLevel", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.ProductLevel;
            }
            set {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("ProductLevel", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.ProductLevel = value;
            }
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(19)]
        public virtual string ObjectID {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("ObjectID", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.ObjectID;
            }
            set {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("ObjectID", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.ObjectID = value;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(1)]
        public virtual QlikView.Application Application {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("Application", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.Application;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(2)]
        public virtual QlikView.Doc ActiveDocument {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("ActiveDocument", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.ActiveDocument;
            }
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(17)]
        public virtual object Interface {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("Interface", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.Interface;
            }
        }
        
        public event _DQlikOCXEvents_OnContextMenuEventHandler OnContextMenu;
        
        public event _DQlikOCXEvents_OnContextMenuCommandEventHandler OnContextMenuCommand;
        
        public event _DQlikOCXEvents_OnMacroEventHandler OnMacro;
        
        public event System.EventHandler OnMouseOver;
        
        public event System.EventHandler OnDataChanged;
        
        public event _DQlikOCXEvents_OnQvEventEventHandler OnQvEvent;
        
        public event _DQlikOCXEvents_OnHtmlHelpEventHandler OnHtmlHelp;
        
        public event _DQlikOCXEvents_OnCommandEventHandler OnCommand;
        
        public event _DQlikOCXEvents_OnMessageEventHandler OnMessage;
        
        public event _DQlikOCXEvents_OnReloadFailedEventHandler OnReloadFailed;
        
        public virtual QlikView.Doc OpenDocument(string docName) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("OpenDocument", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            object[] paramArray = new object[] {
                    docName,
                    "",
                    ""};
            System.Type typeVar = typeof(QlikOCXLib._DQlikOCX);
            System.Reflection.MethodInfo methodToInvoke = typeVar.GetMethod("OpenDocument");
            QlikView.Doc returnValue = ((QlikView.Doc)(methodToInvoke.Invoke(this.ocx, paramArray)));
            return returnValue;
        }
        
        public virtual QlikView.Doc OpenDocument(string docName, string userName, string password) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("OpenDocument", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            QlikView.Doc returnValue = ((QlikView.Doc)(this.ocx.OpenDocument(docName, userName, password)));
            return returnValue;
        }
        
        public virtual bool HasOpenDocument() {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("HasOpenDocument", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            bool returnValue = ((bool)(this.ocx.HasOpenDocument()));
            return returnValue;
        }
        
        public virtual bool SetRegistration(string serial, string key) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("SetRegistration", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            bool returnValue = ((bool)(this.ocx.SetRegistration(serial, key)));
            return returnValue;
        }
        
        public virtual QlikView.Doc OpenDocumentEx(string docName, int accessMode) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("OpenDocumentEx", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            object[] paramArray = new object[] {
                    docName,
                    accessMode,
                    ((bool)(true)),
                    "",
                    ""};
            System.Type typeVar = typeof(QlikOCXLib._DQlikOCX);
            System.Reflection.MethodInfo methodToInvoke = typeVar.GetMethod("OpenDocumentEx");
            QlikView.Doc returnValue = ((QlikView.Doc)(methodToInvoke.Invoke(this.ocx, paramArray)));
            return returnValue;
        }
        
        public virtual QlikView.Doc OpenDocumentEx(string docName, int accessMode, bool allowDialog, string userName, string password) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("OpenDocumentEx", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            QlikView.Doc returnValue = ((QlikView.Doc)(this.ocx.OpenDocumentEx(docName, accessMode, allowDialog, userName, password)));
            return returnValue;
        }
        
        public virtual QlikView.Doc CreateDocument() {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("CreateDocument", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            QlikView.Doc returnValue = ((QlikView.Doc)(this.ocx.CreateDocument()));
            return returnValue;
        }
        
        public virtual void ScanFrame(object frame) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("ScanFrame", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.ScanFrame(frame);
        }
        
        public virtual void LockPaint() {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("LockPaint", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.LockPaint();
        }
        
        public virtual void UnlockPaint() {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("UnlockPaint", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.UnlockPaint();
        }
        
        public virtual void CreateCellDataAccessor(QlikView.IArrayOfArrayOfRCCell cells, out QlikOCXLib.ICellDataAccessor pAccessor) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("CreateCellDataAccessor", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.CreateCellDataAccessor(cells, out pAccessor);
        }
        
        public virtual void RefreshDocument() {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("RefreshDocument", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.RefreshDocument();
        }
        
        public virtual void AboutBox() {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("AboutBox", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.AboutBox();
        }
        
        public virtual void OnDownloadComplete(object lpDisp, ref object uRL) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("OnDownloadComplete", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.OnDownloadComplete(lpDisp, ref uRL);
        }
        
        protected override void CreateSink() {
            try {
                this.eventMulticaster = new AxQlikOCXEventMulticaster(this);
                this.cookie = new System.Windows.Forms.AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(QlikOCXLib._DQlikOCXEvents));
            }
            catch (System.Exception ) {
            }
        }
        
        protected override void DetachSink() {
            try {
                this.cookie.Disconnect();
            }
            catch (System.Exception ) {
            }
        }
        
        protected override void AttachInterfaces() {
            try {
                this.ocx = ((QlikOCXLib._DQlikOCX)(this.GetOcx()));
            }
            catch (System.Exception ) {
            }
        }
        
        internal void RaiseOnOnContextMenu(object sender, _DQlikOCXEvents_OnContextMenuEvent e) {
            if ((this.OnContextMenu != null)) {
                this.OnContextMenu(sender, e);
            }
        }
        
        internal void RaiseOnOnContextMenuCommand(object sender, _DQlikOCXEvents_OnContextMenuCommandEvent e) {
            if ((this.OnContextMenuCommand != null)) {
                this.OnContextMenuCommand(sender, e);
            }
        }
        
        internal void RaiseOnOnMacro(object sender, _DQlikOCXEvents_OnMacroEvent e) {
            if ((this.OnMacro != null)) {
                this.OnMacro(sender, e);
            }
        }
        
        internal void RaiseOnOnMouseOver(object sender, System.EventArgs e) {
            if ((this.OnMouseOver != null)) {
                this.OnMouseOver(sender, e);
            }
        }
        
        internal void RaiseOnOnDataChanged(object sender, System.EventArgs e) {
            if ((this.OnDataChanged != null)) {
                this.OnDataChanged(sender, e);
            }
        }
        
        internal void RaiseOnOnQvEvent(object sender, _DQlikOCXEvents_OnQvEventEvent e) {
            if ((this.OnQvEvent != null)) {
                this.OnQvEvent(sender, e);
            }
        }
        
        internal void RaiseOnOnHtmlHelp(object sender, _DQlikOCXEvents_OnHtmlHelpEvent e) {
            if ((this.OnHtmlHelp != null)) {
                this.OnHtmlHelp(sender, e);
            }
        }
        
        internal void RaiseOnOnCommand(object sender, _DQlikOCXEvents_OnCommandEvent e) {
            if ((this.OnCommand != null)) {
                this.OnCommand(sender, e);
            }
        }
        
        internal void RaiseOnOnMessage(object sender, _DQlikOCXEvents_OnMessageEvent e) {
            if ((this.OnMessage != null)) {
                this.OnMessage(sender, e);
            }
        }
        
        internal void RaiseOnOnReloadFailed(object sender, _DQlikOCXEvents_OnReloadFailedEvent e) {
            if ((this.OnReloadFailed != null)) {
                this.OnReloadFailed(sender, e);
            }
        }
    }
    
    public delegate void _DQlikOCXEvents_OnContextMenuEventHandler(object sender, _DQlikOCXEvents_OnContextMenuEvent e);
    
    public class _DQlikOCXEvents_OnContextMenuEvent {
        
        public string contextObject;
        
        public int contextMenu;
        
        public short okToContinue;
        
        public _DQlikOCXEvents_OnContextMenuEvent(string contextObject, int contextMenu, short okToContinue) {
            this.contextObject = contextObject;
            this.contextMenu = contextMenu;
            this.okToContinue = okToContinue;
        }
    }
    
    public delegate void _DQlikOCXEvents_OnContextMenuCommandEventHandler(object sender, _DQlikOCXEvents_OnContextMenuCommandEvent e);
    
    public class _DQlikOCXEvents_OnContextMenuCommandEvent {
        
        public string contextObject;
        
        public int menuCommand;
        
        public short okToContinue;
        
        public _DQlikOCXEvents_OnContextMenuCommandEvent(string contextObject, int menuCommand, short okToContinue) {
            this.contextObject = contextObject;
            this.menuCommand = menuCommand;
            this.okToContinue = okToContinue;
        }
    }
    
    public delegate void _DQlikOCXEvents_OnMacroEventHandler(object sender, _DQlikOCXEvents_OnMacroEvent e);
    
    public class _DQlikOCXEvents_OnMacroEvent {
        
        public string macroName;
        
        public short okToContinue;
        
        public _DQlikOCXEvents_OnMacroEvent(string macroName, short okToContinue) {
            this.macroName = macroName;
            this.okToContinue = okToContinue;
        }
    }
    
    public delegate void _DQlikOCXEvents_OnQvEventEventHandler(object sender, _DQlikOCXEvents_OnQvEventEvent e);
    
    public class _DQlikOCXEvents_OnQvEventEvent {
        
        public string eventCategory;
        
        public string eventSource;
        
        public _DQlikOCXEvents_OnQvEventEvent(string eventCategory, string eventSource) {
            this.eventCategory = eventCategory;
            this.eventSource = eventSource;
        }
    }
    
    public delegate void _DQlikOCXEvents_OnHtmlHelpEventHandler(object sender, _DQlikOCXEvents_OnHtmlHelpEvent e);
    
    public class _DQlikOCXEvents_OnHtmlHelpEvent {
        
        public int helpData;
        
        public short helpCommand;
        
        public short okToContinue;
        
        public _DQlikOCXEvents_OnHtmlHelpEvent(int helpData, short helpCommand, short okToContinue) {
            this.helpData = helpData;
            this.helpCommand = helpCommand;
            this.okToContinue = okToContinue;
        }
    }
    
    public delegate void _DQlikOCXEvents_OnCommandEventHandler(object sender, _DQlikOCXEvents_OnCommandEvent e);
    
    public class _DQlikOCXEvents_OnCommandEvent {
        
        public int command;
        
        public short okToContinue;
        
        public _DQlikOCXEvents_OnCommandEvent(int command, short okToContinue) {
            this.command = command;
            this.okToContinue = okToContinue;
        }
    }
    
    public delegate void _DQlikOCXEvents_OnMessageEventHandler(object sender, _DQlikOCXEvents_OnMessageEvent e);
    
    public class _DQlikOCXEvents_OnMessageEvent {
        
        public string text;
        
        public string caption;
        
        public int uType;
        
        public int result;
        
        public _DQlikOCXEvents_OnMessageEvent(string text, string caption, int uType, int result) {
            this.text = text;
            this.caption = caption;
            this.uType = uType;
            this.result = result;
        }
    }
    
    public delegate void _DQlikOCXEvents_OnReloadFailedEventHandler(object sender, _DQlikOCXEvents_OnReloadFailedEvent e);
    
    public class _DQlikOCXEvents_OnReloadFailedEvent {
        
        public string msg;
        
        public string title;
        
        public int buttons;
        
        public int result;
        
        public _DQlikOCXEvents_OnReloadFailedEvent(string msg, string title, int buttons, int result) {
            this.msg = msg;
            this.title = title;
            this.buttons = buttons;
            this.result = result;
        }
    }
    
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    public class AxQlikOCXEventMulticaster : QlikOCXLib._DQlikOCXEvents {
        
        private AxQlikOCX parent;
        
        public AxQlikOCXEventMulticaster(AxQlikOCX parent) {
            this.parent = parent;
        }
        
        public virtual void OnContextMenu(string contextObject, int contextMenu, ref short okToContinue) {
            _DQlikOCXEvents_OnContextMenuEvent oncontextmenuEvent = new _DQlikOCXEvents_OnContextMenuEvent(contextObject, contextMenu, okToContinue);
            this.parent.RaiseOnOnContextMenu(this.parent, oncontextmenuEvent);
            okToContinue = oncontextmenuEvent.okToContinue;
        }
        
        public virtual void OnContextMenuCommand(string contextObject, ref int menuCommand, ref short okToContinue) {
            _DQlikOCXEvents_OnContextMenuCommandEvent oncontextmenucommandEvent = new _DQlikOCXEvents_OnContextMenuCommandEvent(contextObject, menuCommand, okToContinue);
            this.parent.RaiseOnOnContextMenuCommand(this.parent, oncontextmenucommandEvent);
            menuCommand = oncontextmenucommandEvent.menuCommand;
            okToContinue = oncontextmenucommandEvent.okToContinue;
        }
        
        public virtual void OnMacro(string macroName, ref short okToContinue) {
            _DQlikOCXEvents_OnMacroEvent onmacroEvent = new _DQlikOCXEvents_OnMacroEvent(macroName, okToContinue);
            this.parent.RaiseOnOnMacro(this.parent, onmacroEvent);
            okToContinue = onmacroEvent.okToContinue;
        }
        
        public virtual void OnMouseOver() {
            System.EventArgs onmouseoverEvent = new System.EventArgs();
            this.parent.RaiseOnOnMouseOver(this.parent, onmouseoverEvent);
        }
        
        public virtual void OnDataChanged() {
            System.EventArgs ondatachangedEvent = new System.EventArgs();
            this.parent.RaiseOnOnDataChanged(this.parent, ondatachangedEvent);
        }
        
        public virtual void OnQvEvent(string eventCategory, string eventSource) {
            _DQlikOCXEvents_OnQvEventEvent onqveventEvent = new _DQlikOCXEvents_OnQvEventEvent(eventCategory, eventSource);
            this.parent.RaiseOnOnQvEvent(this.parent, onqveventEvent);
        }
        
        public virtual void OnHtmlHelp(int helpData, short helpCommand, ref short okToContinue) {
            _DQlikOCXEvents_OnHtmlHelpEvent onhtmlhelpEvent = new _DQlikOCXEvents_OnHtmlHelpEvent(helpData, helpCommand, okToContinue);
            this.parent.RaiseOnOnHtmlHelp(this.parent, onhtmlhelpEvent);
            okToContinue = onhtmlhelpEvent.okToContinue;
        }
        
        public virtual void OnCommand(int command, ref short okToContinue) {
            _DQlikOCXEvents_OnCommandEvent oncommandEvent = new _DQlikOCXEvents_OnCommandEvent(command, okToContinue);
            this.parent.RaiseOnOnCommand(this.parent, oncommandEvent);
            okToContinue = oncommandEvent.okToContinue;
        }
        
        public virtual void OnMessage(string text, string caption, int uType, ref int result) {
            _DQlikOCXEvents_OnMessageEvent onmessageEvent = new _DQlikOCXEvents_OnMessageEvent(text, caption, uType, result);
            this.parent.RaiseOnOnMessage(this.parent, onmessageEvent);
            result = onmessageEvent.result;
        }
        
        public virtual void OnReloadFailed(string msg, string title, int buttons, ref int result) {
            _DQlikOCXEvents_OnReloadFailedEvent onreloadfailedEvent = new _DQlikOCXEvents_OnReloadFailedEvent(msg, title, buttons, result);
            this.parent.RaiseOnOnReloadFailed(this.parent, onreloadfailedEvent);
            result = onreloadfailedEvent.result;
        }
    }
}
