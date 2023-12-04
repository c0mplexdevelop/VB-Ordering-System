Option Strict On

Imports System.ComponentModel

'Namespace VB_OrderingSystem
Public Class MainViewModel : Implements INotifyPropertyChanged

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub OnPropertyChanged(ByVal propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

    Private _burgetAmount As String
    Public Property BurgerAmount As String
        Get
            Return _burgetAmount
        End Get
        Set(value As String)
            _burgetAmount = value
            OnPropertyChanged("BurgerAmount")
        End Set
    End Property

    Private _friesAmount As String
    Public Property FriesAmount As String
        Get
            Return _friesAmount
        End Get
        Set(value As String)
            _friesAmount = value
            OnPropertyChanged("FriesAmount")
        End Set
    End Property

    Private _chickenAmount As String
    Public Property ChickenAmount As String
        Get
            Return _chickenAmount
        End Get
        Set(value As String)
            _chickenAmount = value
            OnPropertyChanged("ChickenAmount")
        End Set
    End Property


    Private _floatAmount As String
    Public Property FloatAmount As String
        Get
            Return _floatAmount
        End Get
        Set(value As String)
            _floatAmount = value
            OnPropertyChanged("FloatAmount")
        End Set
    End Property

    Private _gravyAmount As String
    Public Property GravyAmount As String
        Get
            Return _gravyAmount
        End Get
        Set(value As String)
            _gravyAmount = value
            OnPropertyChanged("GravyAmount")
        End Set
    End Property

    Private _riceAmoutn As String
    Public Property RiceAmount As String
        Get
            Return _riceAmoutn
        End Get
        Set(value As String)
            _riceAmoutn = value
            OnPropertyChanged("RiceAmount")
        End Set
    End Property

    Public Function IsOrderEmpty() As Boolean
        Return String.IsNullOrEmpty(BurgerAmount) AndAlso
                    String.IsNullOrEmpty(FriesAmount) AndAlso
                    String.IsNullOrEmpty(ChickenAmount) AndAlso
                    String.IsNullOrEmpty(FloatAmount) AndAlso
                    String.IsNullOrEmpty(GravyAmount) AndAlso
                    String.IsNullOrEmpty(RiceAmount)
    End Function

    Private clearCommadn As ICommand = New ClearCommand(Me)
    Public Property ClearCommand As ICommand
        Get
            Return clearCommadn
        End Get
        Set(value As ICommand)
            clearCommadn = value
        End Set
    End Property
    Private _orderCommand As ICommand = New OrderCommand(Me)
    Public Property OrderCommand As ICommand
        Get
            Return _orderCommand
        End Get
        Set(value As ICommand)
            _orderCommand = value
        End Set
    End Property

End Class
