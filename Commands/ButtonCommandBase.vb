Public MustInherit Class ButtonCommandBase : Implements ICommand
	Private Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged


	Public Overridable Sub Execute(ByVal parameter As Object) Implements ICommand.Execute
		Throw New NotImplementedException()
	End Sub

	Public Overridable Function CanExecute(ByVal parameter As Object) As Boolean Implements ICommand.CanExecute
		Throw New NotImplementedException()
	End Function

End Class
