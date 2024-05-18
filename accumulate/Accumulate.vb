Imports System.Runtime.CompilerServices

Module AccumulateExtensions
    <Extension()>
    Public Iterator Function Accumulate (Of T)(source As IEnumerable(Of T), func As Func(Of T, T)) As IEnumerable(Of T)
        For Each item In source
            Yield func(item)
        Next
    End Function
End Module