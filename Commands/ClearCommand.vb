Public Class ClearCommand : Inherits ButtonCommandBase

	Private _viewModel As MainViewModel
	Public Sub New(ByVal viewModel As MainViewModel)
		_viewModel = viewModel
	End Sub
	Public Overrides Sub Execute(ByVal parameter As Object)
		_viewModel.FriesAmount = String.Empty
		_viewModel.ChickenAmount = String.Empty
		_viewModel.FloatAmount = String.Empty
		_viewModel.GravyAmount = String.Empty
		_viewModel.RiceAmount = String.Empty
	End Sub
	Public Overrides Function CanExecute(ByVal parameter As Object) As Boolean
		Return True
	End Function


End Class
