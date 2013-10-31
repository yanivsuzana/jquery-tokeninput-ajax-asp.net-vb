Imports System.Web
Imports System.Web.Services
Imports System.Web.Script.Serialization



Public Class search
    Implements System.Web.IHttpHandler

    <Serializable()> Private Class SearchResult
        Public id As String
        Public name As String
    End Class

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest

        context.Response.ContentType = "text/plain"
        Dim SearchString As String = "" & HttpContext.Current.Request("query")


        'Dim objAgr As New Agreements.AgreementsService()
        'objAgr.Url = HttpContext.Current.Application("AgreementsWebService")
        'Dim ds As DataSet = objAgr.GetProfessionsByName("C419E7CB-F7EB-45A1-9834-E972A133CF29", SearchString)

        Dim Response As String = String.Empty
        Dim SearchResultsForSelectFromList As List(Of SearchResult) = New List(Of SearchResult)
        Dim SearchResultsForAutocomplete As Dictionary(Of String, String) = New Dictionary(Of String, String)

        Dim sResult As SearchResult

        ' For Each currRow As DataRow In ds.Tables(0).Rows
        If (SearchString = "w") Then
            sResult = New SearchResult()
            sResult.name = "wolf"
            sResult.id = "235423sdf"
            'sResult.name = currRow("Name").ToString()
            'sResult.id = currRow("ID").ToString()
            SearchResultsForSelectFromList.Add(sResult)
            sResult = New SearchResult()
            sResult.name = "wolf2"
            sResult.id = "235423sdsf"
            SearchResultsForSelectFromList.Add(sResult)
        End If
        If (SearchString = "y") Then
            sResult = New SearchResult()
            sResult.name = "yaniv"
            sResult.id = "235423sdf"
            SearchResultsForSelectFromList.Add(sResult)
            sResult = New SearchResult()
            sResult.name = "yaniv ss"
            sResult.id = "235423sdsf"
            SearchResultsForSelectFromList.Add(sResult)
        ElseIf (SearchString = "") Then
            sResult = New SearchResult()
            SearchResultsForSelectFromList.Add(sResult)
        End If
       

        '  Next


  

        Dim serializer As JavaScriptSerializer = New JavaScriptSerializer()


        Response = serializer.Serialize(SearchResultsForSelectFromList)



        HttpContext.Current.Response.Write(Response)



    End Sub

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class