Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Runtime.InteropServices

<Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", GetType(IDesigner))>
Public Class TransparentControl
    <DllImport("User32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)>
    Public Shared Function UpdateLayeredWindow(hwnd As IntPtr, hdcDst As IntPtr, pptDst As IntPtr, psize As IntPtr, hdcSrc As IntPtr, pprSrc As IntPtr, crKey As Integer, ByRef pblend As BLENDFUNCTION, dwFlags As Integer) As Boolean
    End Function

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure BLENDFUNCTION
        Public BlendOp As Byte
        Public BlendFlags As Byte
        Public SourceConstantAlpha As Byte
        Public AlphaFormat As Byte
    End Structure

    Public Const AC_SRC_OVER As Byte = &H0
    Public Const AC_SRC_ALPHA As Byte = &H1

    Public Const ULW_COLORKEY As Integer = &H1
    Public Const ULW_ALPHA As Integer = &H2
    Public Const ULW_OPAQUE As Integer = &H4

    Public Const WS_EX_DLGMODALFRAME As Integer = &H1
    Public Const WS_EX_NOPARENTNOTIFY As Integer = &H4
    Public Const WS_EX_TOPMOST As Integer = &H8
    Public Const WS_EX_ACCEPTFILES As Integer = &H10
    Public Const WS_EX_TRANSPARENT As Integer = &H20
    Public Const WS_EX_MDICHILD As Integer = &H40
    Public Const WS_EX_TOOLWINDOW As Integer = &H80
    Public Const WS_EX_WINDOWEDGE As Integer = &H100
    Public Const WS_EX_CLIENTEDGE As Integer = &H200
    Public Const WS_EX_CONTEXTHELP As Integer = &H400
    Public Const WS_EX_RIGHT As Integer = &H1000
    Public Const WS_EX_LEFT As Integer = &H0
    Public Const WS_EX_RTLREADING As Integer = &H2000
    Public Const WS_EX_LTRREADING As Integer = &H0
    Public Const WS_EX_LEFTSCROLLBAR As Integer = &H4000
    Public Const WS_EX_RIGHTSCROLLBAR As Integer = &H0
    Public Const WS_EX_CONTROLPARENT As Integer = &H10000
    Public Const WS_EX_STATICEDGE As Integer = &H20000
    Public Const WS_EX_APPWINDOW As Integer = &H40000
    Public Const WS_EX_OVERLAPPEDWINDOW As Integer = WS_EX_WINDOWEDGE Or WS_EX_CLIENTEDGE
    Public Const WS_EX_PALETTEWINDOW As Integer = WS_EX_WINDOWEDGE Or WS_EX_TOOLWINDOW Or WS_EX_TOPMOST
    Public Const WS_EX_LAYERED As Integer = &H80000
    Public Const WS_EX_NOINHERITLAYOUT As Integer = &H100000 ' Disable inheritence of mirroring by children
    Public Const WS_EX_NOREDIRECTIONBITMAP As Integer = &H200000
    Public Const WS_EX_LAYOUTRTL As Integer = &H400000 ' Right to left mirroring
    Public Const WS_EX_COMPOSITED As Integer = &H2000000
    Public Const WS_EX_NOACTIVATE As Integer = &H8000000

    Public Const WM_SYSCOMMAND = &H112
    Public Const WM_MOVE = &H3
    Public Const WM_SIZING = &H214

    Public Const SC_MINIMIZE = &HF020
    Public Const SC_MAXIMIZE = &HF030
    Public Const SC_RESTORE = &HF120
    Public Const SC_CLOSE = &HF060

    <DllImport("Gdi32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)>
    Public Shared Function GetObject(hFont As IntPtr, nSize As Integer, <Out> ByRef bm As BITMAP) As Integer
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Public Structure BITMAP
        Public bmType As Integer
        Public bmWidth As Integer
        Public bmHeight As Integer
        Public bmWidthBytes As Integer
        Public bmPlanes As Short
        Public bmBitsPixel As Short
        Public bmBits As IntPtr
    End Structure

    <DllImport("Gdi32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)>
    Public Shared Function CreateCompatibleDC(hDC As IntPtr) As IntPtr
    End Function

    <DllImport("Gdi32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)>
    Public Shared Function SelectObject(hDC As IntPtr, hObject As IntPtr) As IntPtr
    End Function

    <DllImport("Gdi32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)>
    Public Shared Function DeleteObject(hObject As IntPtr) As Boolean
    End Function

    <DllImport("User32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)>
    Public Shared Function GetDC(hWnd As IntPtr) As IntPtr
    End Function

    <DllImport("User32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)>
    Public Shared Function ReleaseDC(hWnd As IntPtr, hDC As IntPtr) As Integer
    End Function

    <DllImport("Gdi32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)>
    Public Shared Function DeleteDC(hdc As IntPtr) As Boolean
    End Function

    <DllImport("User32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)>
    Public Shared Function GetWindowRect(hWnd As IntPtr, <Out> ByRef lpRect As RECT) As Boolean
    End Function

    <DllImport("User32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)>
    Public Shared Function GetClientRect(hWnd As IntPtr, <Out> ByRef lpRect As RECT) As Boolean
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Public Structure RECT
        Public left As Integer
        Public top As Integer
        Public right As Integer
        Public bottom As Integer
        Public Sub New(Left As Integer, Top As Integer, Right As Integer, Bottom As Integer)
            Me.left = Left
            Me.top = Top
            Me.right = Right
            Me.bottom = Bottom
        End Sub
    End Structure

    Public Const WM_CREATE As Integer = &H1
    Public Const WM_NCHITTEST = &H84
    Public Const WM_NCMOUSEMOVE = &HA0
    Public Const WM_NCLBUTTONDOWN = &HA1
    Public Const WM_NCLBUTTONUP = &HA2
    Public Const WM_NCLBUTTONDBLCLK = &HA3

    Public Enum HT
        HTERROR = -2
        HTTRANSPARENT = -1
        HTNOWHERE = 0
        HTCLIENT = 1
        HTCAPTION = 2
        HTSYSMENU = 3
        HTGROWBOX = 4
        HTMENU = 5
        HTHSCROLL = 6
        HTVSCROLL = 7
        HTMINBUTTON = 8
        HTMAXBUTTON = 9
        HTLEFT = 10
        HTRIGHT = 11
        HTTOP = 12
        HTTOPLEFT = 13
        HTTOPRIGHT = 14
        HTBOTTOM = 15
        HTBOTTOMLEFT = 16
        HTBOTTOMRIGHT = 17
        HTBORDER = 18
        HTOBJECT = 19
        HTCLOSE = 20
        HTHELP = 21
    End Enum

    <DllImport("User32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)>
    Public Shared Function DefWindowProc(hWnd As IntPtr, uMsg As UInteger, wParam As Integer, lParam As IntPtr) As Integer
    End Function

    <DllImport("User32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)>
    Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As IntPtr, lParam As IntPtr) As Integer
    End Function

    <DllImport("User32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)>
    Public Shared Function ScreenToClient(hWnd As IntPtr, ByRef lpPoint As System.Drawing.Point) As Boolean
    End Function

    <DllImport("User32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)>
    Public Shared Function ClientToScreen(hWnd As IntPtr, ByRef lpPoint As System.Drawing.Point) As Boolean
    End Function

    <DllImport("User32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)>
    Public Shared Function GetParent(hWnd As IntPtr) As IntPtr
    End Function

    Public Sub New()
        MyBase.New()
        Me.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub SetPictureToLayeredWindow(hWnd As IntPtr, hBitmap As IntPtr)
        Dim bm As BITMAP
        GetObject(hBitmap, Marshal.SizeOf(GetType(BITMAP)), bm)
        Dim sizeBitmap As System.Drawing.Size = New System.Drawing.Size(bm.bmWidth, bm.bmHeight)

        Dim hDCScreen As IntPtr = GetDC(IntPtr.Zero)
        Dim hDCMem As IntPtr = CreateCompatibleDC(hDCScreen)
        Dim hBitmapOld As IntPtr = SelectObject(hDCMem, hBitmap)

        Dim bf As BLENDFUNCTION = New BLENDFUNCTION()
        bf.BlendOp = AC_SRC_OVER
        bf.SourceConstantAlpha = 255
        bf.AlphaFormat = AC_SRC_ALPHA

        Dim rectWnd As RECT
        GetWindowRect(hWnd, rectWnd)
        Dim ptClient As Drawing.Point
        ptClient.X = rectWnd.left
        ptClient.Y = rectWnd.top
        ScreenToClient(GetParent(hWnd), ptClient)

        Dim ptSrc As System.Drawing.Point = New System.Drawing.Point()
        Dim ptDest As System.Drawing.Point = New System.Drawing.Point(ptClient.X, ptClient.Y)

        Dim pptSrc = Marshal.AllocHGlobal(Marshal.SizeOf(GetType(System.Drawing.Point)))
        Marshal.StructureToPtr(ptSrc, pptSrc, False)

        Dim pptDest = Marshal.AllocHGlobal(Marshal.SizeOf(GetType(System.Drawing.Point)))
        Marshal.StructureToPtr(ptDest, pptDest, False)

        Dim psizeBitmap = Marshal.AllocHGlobal(Marshal.SizeOf(GetType(System.Drawing.Size)))
        Marshal.StructureToPtr(sizeBitmap, psizeBitmap, False)

        Dim bRet As Boolean = UpdateLayeredWindow(hWnd, hDCScreen, pptDest, psizeBitmap, hDCMem, pptSrc, 0, bf, ULW_ALPHA)

        Marshal.FreeHGlobal(pptSrc)
        Marshal.FreeHGlobal(pptDest)
        Marshal.FreeHGlobal(psizeBitmap)

        SelectObject(hDCMem, hBitmapOld)
        DeleteDC(hDCMem)
        ReleaseDC(IntPtr.Zero, hDCScreen)
    End Sub

    Public Function LoadImage(sFile As String, color As Color) As IntPtr
        Dim hBitmap = Nothing
        Try
            Using img As Image = Image.FromFile(sFile)
                Using bmp As New System.Drawing.Bitmap(img)
                    hBitmap = bmp.GetHbitmap(color)
                End Using
            End Using
        Catch ex As Exception
            Dim nError As Integer = Marshal.GetLastWin32Error()
            Dim win32Exception As Win32Exception = New Win32Exception(nError)
            MessageBox.Show(String.Format("Error : {0}{1}{2}{1}({3})", nError.ToString(), Environment.NewLine, win32Exception.Message, ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return hBitmap
    End Function

    Public Sub SetBitmap(hBitmap As IntPtr)
        SetPictureToLayeredWindow(Me.Handle, hBitmap)
    End Sub

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Dim bDesignMode As Boolean = (System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime)
            If Not bDesignMode Then
                cp.ExStyle += WS_EX_LAYERED
            End If
            Return cp
        End Get
    End Property

    <Editor(GetType(Windows.Forms.Design.FileNameEditor), GetType(Drawing.Design.UITypeEditor))>
    <Browsable(True), EditorBrowsable(EditorBrowsableState.Always)>
    <Description("Image path"), Category("Custom Properties")>
    Public Property ImagePath As String
        Get
            Return Me.Text
        End Get
        Set(ByVal ImagePath As String)
            Me.Text = ImagePath
        End Set
    End Property

    Protected Overrides Sub WndProc(ByRef m As Message)
        ' To disable Double-Click, set "MyBase.WndProc(m)" at end
        ' and uncomment "ElseIf (m.Msg = WM_NCLBUTTONDBLCLK) Then..."
        MyBase.WndProc(m)
        If (m.Msg = WM_CREATE) Then
            If (Me.ImagePath <> "") Then
                Dim hBitmap As IntPtr = LoadImage(Me.ImagePath, System.Drawing.Color.FromArgb(0))
                Me.SetBitmap(hBitmap)
            End If
            Me.BringToFront()
            Return
            'ElseIf (m.Msg = WM_NCLBUTTONDBLCLK) Then
            '    Console.Beep(6000, 10)
            '    m.Result = CType(0, IntPtr)
            '    Return
            'ElseIf (m.Msg = WM_SYSCOMMAND) Then
            '    If (CInt(m.WParam) And &HFFF0) = SC_MAXIMIZE Then
            '        Console.Beep(6000, 10)
            '        m.Result = CType(0, IntPtr)
            '        Return
            '    End If
        ElseIf (m.Msg = WM_NCHITTEST) Then
            Dim nRet = DefWindowProc(m.HWnd, WM_NCHITTEST, 0, m.LParam)
            Select Case nRet
                Case HT.HTLEFT
                Case HT.HTTOP
                Case HT.HTBOTTOM
                Case HT.HTRIGHT
                Case HT.HTBOTTOMLEFT
                Case HT.HTBOTTOMRIGHT
                Case HT.HTTOPLEFT
                Case HT.HTTOPRIGHT
                    m.Result = nRet
                Case Else
                    m.Result = HT.HTCAPTION
            End Select
            Return
        End If
    End Sub

End Class
