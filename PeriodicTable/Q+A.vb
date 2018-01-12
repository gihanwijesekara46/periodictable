Imports System.Reflection

Public Class Q_A

    Public Enum answers
        A
        B
        C
        D
    End Enum

    Public Sub New(ByVal Q As String, ByVal A1 As String, ByVal A2 As String, ByVal A3 As String, ByVal A4 As String, ByVal correct As answers)
        _question = Q
        _answerA = A1
        _answerB = A2
        _answerC = A3
        _answerD = A4
        _correctAnswer = correct
    End Sub

    Private _question As String
    Public ReadOnly Property question() As String
        Get
            Return _question
        End Get
    End Property

    Private _answerA As String
    Public ReadOnly Property answerA() As String
        Get
            Return _answerA
        End Get
    End Property

    Private _answerB As String
    Public ReadOnly Property answerB() As String
        Get
            Return _answerB
        End Get
    End Property

    Private _answerC As String
    Public ReadOnly Property answerC() As String
        Get
            Return _answerC
        End Get
    End Property

    Private _answerD As String
    Public ReadOnly Property answerD() As String
        Get
            Return _answerD
        End Get
    End Property

    Private _correctAnswer As answers
    Public ReadOnly Property correctAnswer() As answers
        Get
            Return _correctAnswer
        End Get
    End Property

    Public Function getAnswer() As String
        Return Me.GetType().GetProperty("answer" & [Enum].GetName(GetType(answers), _correctAnswer)).GetValue(Me, Nothing).ToString
    End Function

End Class
