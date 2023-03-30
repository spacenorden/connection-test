$Qview = New-Object -ComObject QlikTech.QlikOCXCtrl
$Qview | Get-Member
$Qview.AboutBox()
$ActiveDoc = $Qview.OpenDocument("qvp://cpmi-rpt-host.prd.digital.gbm.cloud.hk.hsbc/CUPID/Cupid Dashboard.qvw", "", "")
#$ActiveDoc = $Qview.ActiveDocument
#$qStraightTableBox = $ActiveDoc.Sheets("Trade Details").GetStraightTableBoxes[0]
#Write-Output "Object Info:"
#Write-Output "Name: " + $qStraightTableBox.GetCaption().Name.v
#Write-Output "ID: " + $qStraightTableBox.GetObjectId()