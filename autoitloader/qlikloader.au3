#include <C:\Users\D991961\Work\autoitloader\qlikview.au3>

global $oMyError = ObjEvent("AutoIt.Error", "MyErrFunc")

$object_qv = _qv_open()
$o_document = _qv_opendocument($object_qv,"qvp://cpmi-rpt-host.prd.digital.gbm.cloud.hk.hsbc/CUPID/Cupid Dashboard.qvw")
; $loop = _qv_field_GetPossibleValues($o_document, "Formfaktor2", 300)
Exit




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