Imports Google.Apis.Auth
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Drive.v2
Imports Google.Apis.Drive.v2.Data
Imports Google.Apis.Download
Imports Google.Apis.Services
Imports System.Data
Imports System.Threading
Imports System.Data.SqlClient
Imports System.Threading.Tasks
Imports Google.Apis.Drive.v2.FilesResource
Imports Google.Apis.Upload
Imports Google.Apis.Upload.ResumableUpload

Public Class BackUpGoogl
    '******************Declaration *****************************
    Dim service As New DriveService
    '"1EgwbygEdJ6PiFBTrw5ZSLWRGVWzPf8Ft"
    Dim myFile As New File
    ' Dim byteary As Byte() = System.IO.File.ReadAllBytes(dbstring) 'file name or location place here
    '  Dim stream As New System.IO.MemoryStream(byteary)
    '***********END of Dclaration ****************************

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If service.ApplicationName <> "PostalAccount" Then
            creatservices(TextEdit1.Text, TextEdit3.Text)
        End If
        Dim parentId As String = TextEdit2.Text
        Dim f As New Google.Apis.Drive.v2.Data.File()
        f.Title = DateAndTime.Now.ToString() + dbstring
        f.Description = " Postal Backup"
        f.MimeType = "text/plain , image/jpeg"

        If Not String.IsNullOrEmpty(parentId) Then
            f.Parents = New List(Of ParentReference)() From {
                New ParentReference() With {
                    .Id = parentId
                }
            }
        End If
        Dim myFile As New File
        Dim byteary As Byte() = System.IO.File.ReadAllBytes(dbstring)
        Dim stream As New System.IO.MemoryStream(byteary)
        Dim uploadrst As FilesResource.InsertMediaUpload = service.Files.Insert(f, stream, f.MimeType)
        AddHandler uploadrst.ProgressChanged, AddressOf UploadProgessEvent
        ' AddHandler uploadrst.ResponseReceived, AddressOf Upload_ResponseReceived
        uploadrst.ChunkSize = FilesResource.InsertMediaUpload.MinimumChunkSize
        uploadrst.Upload()
        Dim file As File = uploadrst.ResponseBody
        LabelControl1.Text = "*** " & file.Title & " : upload successful " & "**"

    End Sub

    Private Sub creatservices(ByVal clintid As String, ByVal clintcode As String)
        'Dim clintid = "407254939089-0ovabfdkgt96ennk8frqo4ohukv8bhkj.apps.googleusercontent.com"
        'Dim clintcode = "HES01cOXSuFY2rReRIDpSgnN"
        Dim UC As UserCredential = GoogleWebAuthorizationBroker.AuthorizeAsync(New ClientSecrets() With {.ClientId = clintid, .ClientSecret = clintcode}, {DriveService.Scope.Drive}, "user", CancellationToken.None).Result
        service = New DriveService(New BaseClientService.Initializer() With {.HttpClientInitializer = UC, .ApplicationName = "PostalAccount"})
    End Sub
    Private Sub UploadProgessEvent(ByVal obj As Google.Apis.Upload.IUploadProgress)
        Dim byteary As Byte() = System.IO.File.ReadAllBytes(dbstring)
        Dim y As Integer = (obj.BytesSent * 100) / byteary.Length '.ToString() & "%"

        Try
            ProgressBarControl1.EditValue = y
            LabelControl2.Text = y.ToString & " %"
            LabelControl1.Text = "Upload Progress :" & y.ToString + " % "
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ' Label1.Text = obj.BytesSent.ToString() & "%"
    End Sub

    Private Sub BackUpGoogl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub ImageComboBoxEdit1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ImageComboBoxEdit1.SelectedIndexChanged
        If ImageComboBoxEdit1.Value = "Gilli" Then
            TextEdit2.Text = "1EgwbygEdJ6PiFBTrw5ZSLWRGVWzPf8Ft"
           
        End If
        If ImageComboBoxEdit1.Value = "Talita" Then
            TextEdit2.Text = "1O_cgTbNde9rU66_O6EAna7Jz7FM651Bv"

        End If

    End Sub
End Class