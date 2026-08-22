Imports Newtonsoft.Json.Linq
Imports System
Module Test
    Sub Main()
        Dim jsonString As String = "{""data"":[{""name"":""A""},{""name"":""B""}]}"
        Dim json = JObject.Parse(jsonString)
        Dim dataArr = json("data")
        For Each item In dataArr
            Console.WriteLine(item("name").ToString())
        Next
    End Sub
End Module
