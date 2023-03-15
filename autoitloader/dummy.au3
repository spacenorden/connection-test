$oMyError = ObjEvent("AutoIt.Error", "MyErrFunc")

;$Qview = ObjCreate("QlikTech.QlikView")
$Qview = ObjCreate("QlikTech.QlikOCXCtrl")

;app only:
;$Qview.MsgBox("QlikView Messagebox Qv_Version " & $Qview.QvVersion )

;if IsObj($Qview) Then
;	$Qview.MsgBox(0, "", $Qview.OSName)
;Else
;	$Qview.MsgBox(0, "", "Failed to open QlikView Client")
;	Exit (1)
;EndIf

;$Qview.OpenDoc("C:\HSBC\connection-test\Data Visualization.qvw", "", "")
;$Qview.OpenDocument("C:\HSBC\connection-test\Data Visualization.qvw", "", "")
;$Qview.OpenDoc("qvp://cpmi-rpt-host.prd.digital.gbm.cloud.hk.hsbc/CUPID/Cupid Dashboard.qvw")
$Qview.OpenDocument("qvp://cpmi-rpt-host.prd.digital.gbm.cloud.hk.hsbc/CUPID/Cupid Dashboard.qvw")

;WinSetState("QlikView", "", @SW_MAXIMIZE)

$ActiveDoc = $Qview.ActiveDocument

$Sheet = $ActiveDoc.ActivateSheet("Tables")

$qStraightTableBoxes = $Sheet.GetStraightTableBoxes
;$qStraightTableBoxes = $ActiveDoc.Sheets("Trade Details").GetStraightTableBoxes
$qStraightTableBox = $qStraightTableBoxes[0]
;$qStraightTableBox = $ActiveDoc.GetSheetObject("CH26")


;$Qview.MsgBox("No of Rows: " & $qStraightTableBox.GetNoOfRows)
ConsoleWrite("Row Count: " & $qStraightTableBox.GetRowCount)

$qStraightTableBox.ExportEx("C:\HSBC\test.csv", 1, False, ";")



; INSERT HERE and start every call with "QvDoc."
Local $Sheet, $qStraightTableBox, $obj, $w, $h

$Sheet = $ActiveDoc.ActivateSheet("DataSheet")

; Right Click on the object to see the Object ID, don't use the Sheet ID !
$obj = $ActiveDoc.GetSheetObject("TB02")

$w = $obj.GetColumnCount
$h= $obj.GetRowCount

If $h >=  1 Then
	; Export the full object
	ConsoleWrite( $w  & " " & $h & @CRLF)
	$obj.ExportBiff(@ScriptDir & "\QV_Export_Test.xls") 
EndIf

; Get the distinct ItemGroup Field Values
$Values = $ActiveDoc.Fields("ItemGroup").GetPossibleValues 

for $i=0 to $Values.Count-1
  $curVal = $Values.Item($i).Text
  ;Select is like a click selection in the QV Client
  $ActiveDoc.Fields("ItemGroup").Select ($curVal) 
  ; Exports a file for each ItemGroup Field Distinct Selection, see above
  $obj.ExportBiff(@ScriptDir & "\QV_Export_Test" & $curVal &".xls") 
  ConsoleWrite($curVal & @CRLF)
next


ConsoleWrite(@ScriptDir & "\QV_Export_Test.xls" & @CRLF)

$Sheet.FitZoomToWindow

ConsoleWrite($ActiveDoc.GetVariable("MyVarTest") & @CRLF)
ConsoleWrite($ActiveDoc.GetPathName & @CRLF)

;$Qview.Quit


Func MyErrFunc()
	$HexNumber = hex($oMyError.number, 8)
	Msgbox(0,"COM Test","We intercepted a COM Error !"    & @CRLF & @CRLF & _
	  "err.description is: "    & @TAB & $oMyError.description    & @CRLF & _
	  "err.windescription:"     & @TAB & $oMyError.windescription & @CRLF & _
	  "err.number is: "         & @TAB & $HexNumber               & @CRLF & _
	  "err.lastdllerror is: "   & @TAB & $oMyError.lastdllerror   & @CRLF & _
	  "err.scriptline is: "     & @TAB & $oMyError.scriptline     & @CRLF & _
	  "err.source is: "         & @TAB & $oMyError.source         & @CRLF & _
	  "err.helpfile is: "       & @TAB & $oMyError.helpfile       & @CRLF & _
	  "err.helpcontext is: "    & @TAB & $oMyError.helpcontext)
	SetError(1)  ; to check for after this function returns
	Exit
EndFunc
