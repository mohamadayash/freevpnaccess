Imports System.Net
Imports DotRas


Public Class frmServers

    Private ServersCollection As List(Of ServerEntry)
    Private conn As RasConnection

    Private Sub frmServers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.gdvServers.AutoGenerateColumns = False

        Dim httpRequest As HttpWebRequest = HttpWebRequest.Create("http://freevpnaccess.com/")
        Dim httpResponse As HttpWebResponse = httpRequest.GetResponse()
        Dim htmlStream = httpResponse.GetResponseStream()
        Dim streamReader As New IO.StreamReader(htmlStream)
        Dim strhtml As String = streamReader.ReadToEnd()


        Dim htmlDocument As New HtmlAgilityPack.HtmlDocument
        htmlDocument.LoadHtml(strhtml)

        Dim arrServers = htmlDocument.DocumentNode.Descendants("table").FirstOrDefault.InnerHtml.Replace("<table>", "").Replace("</table>", "").Replace("<tr>", "").
            Replace("</tr>", "").Replace("<tbody>", "").Replace("</tbody>", "").Replace("<td>", ",").Replace("</td>", "").Split(",")

        ServersCollection = New List(Of ServerEntry)

        For i As Integer = 6 To arrServers.Length - 1 Step 5
            Dim Server As New ServerEntry
            Server.Location = arrServers(i).Trim()
            Server.Server = arrServers(i + 1).Trim()
            Server.Protocol = arrServers(i + 2).Trim()
            Server.Username = arrServers(i + 3).Trim()
            Server.Password = arrServers(i + 4).Trim()
            ServersCollection.Add(Server)
        Next

        Me.gdvServers.DataSource = ServersCollection



    End Sub

    Public Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gdvServers.CellContentClick

        Dim se As ServerEntry = Me.ServersCollection.Item(e.RowIndex)
        Dim EntryName As String = "ehVPN"
        Dim PhoneBook As New RasPhoneBook
        PhoneBook.Open(RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.User))

        If (Not PhoneBook.Entries.Contains(EntryName)) Then
            Dim entry As RasEntry = RasEntry.CreateVpnEntry(EntryName, se.Server, RasVpnStrategy.PptpOnly, DotRas.RasDevice.Create(EntryName, DotRas.RasDeviceType.Vpn))
            PhoneBook.Entries.Add(entry)
        End If


        Dim dialer As New RasDialer()
        dialer.EntryName = EntryName
        dialer.PhoneBookPath = PhoneBook.Path

        Dim oldentry = (From en As RasEntry In PhoneBook.Entries Where en.Name = EntryName Select en).FirstOrDefault
        oldentry.PhoneNumber = se.Server
        oldentry.Update()

        Try
            Try
                conn = RasConnection.GetActiveConnectionByName(dialer.EntryName, dialer.PhoneBookPath)
                conn.HangUp()
            Catch ex As Exception

            End Try
            Dim cred As New System.Net.NetworkCredential(se.Username, se.Password)
            dialer.Credentials = cred
            dialer.Dial()
        Catch ex As Exception

        Finally
            If (dialer Is Nothing) Then dialer.Dispose()
        End Try
    End Sub
End Class

Public Class ServerEntry
    Public Property Location As String
    Public Property Server As String
    Public Property Protocol As String
    Public Property Username As String

    Public Property Password As String

End Class
