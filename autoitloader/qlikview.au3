;~ QV OPEN
Func _qv_open()

    Run("C:\SWDTOOLS\QlikView\Qv.exe", "C:\SWDTOOLS\QlikView\")
    sleep(5000)
    Local $qv_object = Afx:00007FF611660000:8:0000000000010003:0000000000000000:0000000006390C75
	QlikTech.QlikOCXCtrl.12
	QlikTech.QvPluginCtrl.12
	 ;ObjCreate("QlikTech.QlikView")
    if IsObj($qv_object) Then
        sleep(1000)
        return $qv_object
    Else
        SetError(3, "Could not create COM Object")
        return 1
    EndIf

EndFunc


;~ QV Open Document
func _qv_opendocument($qv_object, $qvwfile)

    if IsObj($qv_object) Then

        if FileExists($qvwfile) Then
            $qv_object.OpenDoc($qvwfile)
            return $qv_object.ActiveDocument
        Else
            SetError(2, "File not found")
            return 1
        EndIf

    Else
        SetError(1, "Variable is not an object")
        return 1
    EndIf

EndFunc