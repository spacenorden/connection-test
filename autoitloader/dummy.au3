#include <Date.au3>

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
;$Qview.OpenDoc("qvp://cpmi-rpt-host.prd.digital.gbm.cloud.hk.hsbc/CUPID/Cupid Dashboard.qvw", "", "")
;$Qview.OpenDocument("qvp://D991961:testpwd@cpmi-rpt-host.prd.digital.gbm.cloud.hk.hsbc/CUPID/Cupid Dashboard.qvw", "", "")
$Qview.OpenDocument("qvp://cpmi-rpt-host.prd.digital.gbm.cloud.hk.hsbc/CUPID/Cupid Dashboard.qvw", "", "")

;WinSetState("QlikView", "", @SW_MAXIMIZE)

$ActiveDoc = $Qview.ActiveDocument


; Use this to get the proper object ID:
;$qMultiBox = $ActiveDoc.Sheets("Filters").GetMultiBoxes[0]
;MsgBox(0, "Object Info", "Name: " & $qMultiBox.GetCaption().Name.v & @CRLF & "ID: " & $qMultiBox.GetObjectId())

; Once you have it, put it here and use this:
$qMultiBox = $ActiveDoc.GetSheetObject("MB26_809225206")

$qField = $qMultiBox.GetField(21)
MsgBox(0, "Object Info", "Name: " & $qField.Name & @CRLF & "Value Count: " & $qField.GetValueCount(2))

$qMultiBox.GetField(21).Select("BLOOMBERG")

;MB26_809225206

;$Sheet = $ActiveDoc.ActivateSheet("Tables")

;$qStraightTableBoxes = $Sheet.GetStraightTableBoxes
$qStraightTableBox = $ActiveDoc.Sheets("Trade Details").GetStraightTableBoxes[0]
;MsgBox(0, "", "multi ID: " & $qStraightTableBox.GetObjectId())
MsgBox(0, "Object Info", "Name: " & $qStraightTableBox.GetCaption().Name.v & @CRLF & "ID: " & $qStraightTableBox.GetObjectId())
;CH182
;$qStraightTableBox = $qStraightTableBoxes[0]
;$qStraightTableBox = $ActiveDoc.GetSheetObject("CH26")


; Get the distinct ItemGroup Field Values
;$Years = $ActiveDoc.Fields("Year").GetPossibleValues 
$ActiveDoc.Fields("Year").Select ("2022")
;$ActiveDoc.Fields("Country").Select("Germany")
;Select "(* ^ *FRANCE*)"
$ActiveDoc.Fields("Country").Select("(* ^ *Germany*)")

MsgBox(0, "Count Info", "Without Germany: " & $qStraightTableBox.GetRowCount-1)

$Months = $ActiveDoc.Fields("Month").GetPossibleValues 
;$Days = $ActiveDoc.Fields("Day").GetPossibleValues 

;MsgBox(0, "", "Years: " & $Years.Count & @CRLF & "Months: " & $Months.Count & @CRLF & "Days: " & $Days.Count)

;Select is like a click selection in the QV Client
;$ActiveDoc.Fields("Year").Select ("2023") 
;$ActiveDoc.Fields("Month").Select ("Jan")
;$ActiveDoc.Fields("Day").Select ("1")

; Get all trades or only Sales Country = Germany?
;$ActiveDoc.Fields("Country").Select("Germany") 

$Log = "Start: " & _NowTime() & @CRLF
$Count = 0

for $i=0 to $Months.Count-1
  $curMonth = $Months.Item($i).Text
  ;Select is like a click selection in the QV Client
  ;$ActiveDoc.Fields("Year").Select ("2023") 
  
  ;;$ActiveDoc.Fields("Country").Clear
  $ActiveDoc.Fields("Month").Select($curMonth)
  ;;$Countries = $ActiveDoc.Fields("Country").GetPossibleValues
  
  ;;for $j=0 to $Countries.Count-1
    ;;$curCountry = $Countries.Item($j).Text
    ;Select is like a click selection in the QV Client
	
	;$ActiveDoc.Fields("Year").Select ("2023") 
    ;$ActiveDoc.Fields("Month").Select($curMonth)
    ;;$ActiveDoc.Fields("Country").Select($curCountry)
  
  
  ;$DayField = $ActiveDoc.Fields("Day")
  ;$Days = $DayField.GetPossibleValues
  ;$FirstHalf = $DayField.GetNoValues   ;empty array
  ;$SecondHalf = $DayField.GetNoValues   ;empty array
  ;$DayField.Clear   ;reset selection
  
;  rem ** cancel selection of first selected value **
;set f = ActiveDocument.Fields("Class")
;set fv = f.GetSelectedValues  
;fv.RemoveAt 0
;f.SelectValues fv

;rem ** select two non-consecutive field values in field **
;set f = ActiveDocument.Fields("Class")
;set fv = f.GetNoValues  'empty array
;fv.Add
;fv.Add
;fv(0).Text = "Group"
;fv(0).IsNumeric = false
;fv(1).Text = "Field"
;fv(1).IsNumeric = false
;f.SelectValues fv

;MsgBox(0, "", "Days in " & $curMonth & ": " & $Days.count)

#comments-start
 
  If $Days.Count > 15 Then
  
  ;$ActiveDoc.Fields("Year").Select ("2023")
  ;$ActiveDoc.Fields("Month").Select($curMonth)
  
    for $j=0 to 14
	  $curDay = $Days.Item($j).Text
	  $FirstHalf.Add
	  $FirstHalf.Item($j).Text = $curDay
	  $FirstHalf.Item($j).IsNumeric = False
      ;_ArrayAdd($FirstHalf, $curDay)
	  ;$DayField.Select($curDay)
    next
	$DayField.SelectValues($FirstHalf)
	MsgBox(0, "", "FirstHalf in " & $curMonth & ": " & $FirstHalf.Count)
	MsgBox(0, "", "Day Selection in " & $curMonth & ": " & $DayField.GetSelectedValues.Count)
	MsgBox(0, "", "Month Selection in " & $curMonth & ": " & $ActiveDoc.Fields("Month").GetSelectedValues.Count)
	MsgBox(0, "", "Year Selection in " & $curMonth & ": " & $ActiveDoc.Fields("Year").GetSelectedValues.Count)
	Exit
	
	$DayField.SelectValues($FirstHalf)
	;$DayField.SelectValues(["1", "2", "3"])
    $Count = $Count + $qStraightTableBox.GetRowCount - 1
	
	MsgBox(0, "", "Selection in " & $curMonth & ": " & $DayField.GetSelectedValues.Count)
	MsgBox(0, "", "First half of " & $curMonth & ": " & $Count)
	
    $qStraightTableBox.ExportEx("C:\HSBC\test_all_" & $curMonth & "_1.csv", 1, False, ";")
	
	Exit
	
	$DayField.Clear   ;reset selection
	
	for $j=15 to $Days.Count-1
	  $curDay = $Days.Item($j).Text
	  $SecondHalf.Add
	  $SecondHalf.Item($j-15).Text = $curDay
	  ;_ArrayAdd($SecondHalf, $curDay)
	next
	$DayField.SelectValues($SecondHalf, False)
	$Count = $Count + $qStraightTableBox.GetRowCount - 1
	
	MsgBox(0, "", "Second half of " & $curMonth & ": " & $Count)
	
    $qStraightTableBox.ExportEx("C:\HSBC\test_all_" & $curMonth & "_2.csv", 1, False, ";")
        
  Else
  
  	for $j=0 to $Days.Count-1
	  $curDay = $Days.Item($j).Text
	  $FirstHalf.Add
	  $FirstHalf.Item($j).Text = $curDay
	  ;_ArrayAdd($FirstHalf, $curDay)
	next
    $DayField.SelectValues($FirstHalf)
    $Count = $Count + $qStraightTableBox.GetRowCount - 1
	
	MsgBox(0, "", "First half of " & $curMonth & ": " & $Count)
	
    $qStraightTableBox.ExportEx("C:\HSBC\test_all_" & $curMonth & "_1.csv", 1, False, ";")
  EndIf

#comments-end

  
  ; Exports a file for each ItemGroup Field Distinct Selection, see above
  ;$obj.ExportBiff(@ScriptDir & "\QV_Export_Test" & $curVal &".xls")
  ;MsgBox(0, "", "No of Rows for " & $curVal & ": " & $qStraightTableBox.GetNoOfRows)
    ;;$qStraightTableBox.ExportEx("C:\HSBC\2022_test_new_" & $curMonth & "_" & $curCountry & ".csv", 1, False, ";")
	$qStraightTableBox.ExportEx("C:\HSBC\2022_Germany_" & $curMonth & ".csv", 1, False, ";")
  ;ConsoleWrite($curVal & @CRLF)
    $Count = $Count + $qStraightTableBox.GetRowCount-1
  ;;next
next

$Log = $Log & "End: " & _NowTime() & @CRLF

MsgBox(0, "", $Log & "Count: " & $Count) ; 370922
;$qStraightTableBox.GetNoOfRows)
ConsoleWrite("Row Count: " & $qStraightTableBox.GetRowCount)



;$qStraightTableBox.ExportEx("C:\HSBC\test.csv", 1, False, ";")



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
