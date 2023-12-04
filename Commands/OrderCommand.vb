Option Strict On

Public Class OrderCommand : Inherits ButtonCommandBase

	Private _viewModel As MainViewModel
	Public Sub New(ByVal viewModel As MainViewModel)
		_viewModel = viewModel
	End Sub
	Public Overrides Sub Execute(ByVal parameter As Object)
		If _viewModel.IsOrderEmpty() Then
			MessageBox.Show("Please select at least one item to order!", "Error", MessageBoxButton.OK, MessageBoxImage.Error)
			Return

		End If

		MessageBox.Show("Order has been processed!", "Success", MessageBoxButton.OK, MessageBoxImage.Information)
	End Sub
	Public Overrides Function CanExecute(ByVal parameter As Object) As Boolean
		Return True
	End Function

End Class
