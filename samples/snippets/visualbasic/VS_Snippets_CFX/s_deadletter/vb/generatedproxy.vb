'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.12
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

' Do not add data members to types. Will cause serialization to fail.

Imports System.Runtime.Serialization
Imports System.ServiceModel.Channels

Namespace Microsoft.ServiceModel.Samples


	<System.Runtime.Serialization.DataContractAttribute()> _
	Partial Public Class PurchaseOrder
		Inherits Object
		Implements System.Runtime.Serialization.IExtensibleDataObject

		Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject

		Private CustomerIdField As String

		Private PONumberField As String

		Private orderLineItemsField() As Microsoft.ServiceModel.Samples.PurchaseOrderLineItem

		Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
			Get
				Return Me.extensionDataField
			End Get
			Set(ByVal value As System.Runtime.Serialization.ExtensionDataObject)
				Me.extensionDataField = value
			End Set
		End Property

		<System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property CustomerId() As String
			Get
				Return Me.CustomerIdField
			End Get
			Set(ByVal value As String)
				Me.CustomerIdField = value
			End Set
		End Property

		<System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property PONumber() As String
			Get
				Return Me.PONumberField
			End Get
			Set(ByVal value As String)
				Me.PONumberField = value
			End Set
		End Property

		<System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property orderLineItems() As Microsoft.ServiceModel.Samples.PurchaseOrderLineItem()
			Get
				Return Me.orderLineItemsField
			End Get
			Set(ByVal value As Microsoft.ServiceModel.Samples.PurchaseOrderLineItem())
				Me.orderLineItemsField = value
			End Set
		End Property
	End Class

	<System.Runtime.Serialization.DataContractAttribute()> _
	Partial Public Class PurchaseOrderLineItem
		Inherits Object
		Implements System.Runtime.Serialization.IExtensibleDataObject

		Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject

		Private ProductIdField As String

		Private QuantityField As Integer

		Private UnitCostField As Single

		Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
			Get
				Return Me.extensionDataField
			End Get
			Set(ByVal value As System.Runtime.Serialization.ExtensionDataObject)
				Me.extensionDataField = value
			End Set
		End Property

		<System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property ProductId() As String
			Get
				Return Me.ProductIdField
			End Get
			Set(ByVal value As String)
				Me.ProductIdField = value
			End Set
		End Property

		<System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property Quantity() As Integer
			Get
				Return Me.QuantityField
			End Get
			Set(ByVal value As Integer)
				Me.QuantityField = value
			End Set
		End Property

		<System.Runtime.Serialization.DataMemberAttribute()> _
		Public Property UnitCost() As Single
			Get
				Return Me.UnitCostField
			End Get
			Set(ByVal value As Single)
				Me.UnitCostField = value
			End Set
		End Property
	End Class
End Namespace


<System.ServiceModel.ServiceContractAttribute(Namespace:="http://Microsoft.ServiceModel.Samples")> _
Public Interface IOrderProcessor

	<System.ServiceModel.OperationContractAttribute(IsOneWay:=True, Action:="http://Microsoft.ServiceModel.Samples/IOrderProcessor/SubmitPurchaseOrder")> _
	Sub SubmitPurchaseOrder(ByVal po As Microsoft.ServiceModel.Samples.PurchaseOrder)
End Interface

Public Interface IOrderProcessorChannel
	Inherits IOrderProcessor, System.ServiceModel.IClientChannel
End Interface

Partial Public Class OrderProcessorClient
	Inherits System.ServiceModel.ClientBase(Of IOrderProcessor)
	Implements IOrderProcessor

	Public Sub New()
	End Sub

	Public Sub New(ByVal endpointConfigurationName As String)
		MyBase.New(endpointConfigurationName)
	End Sub

	Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
		MyBase.New(endpointConfigurationName, remoteAddress)
	End Sub

	Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
		MyBase.New(endpointConfigurationName, remoteAddress)
	End Sub

	Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
		MyBase.New(binding, remoteAddress)
	End Sub

	Public Sub SubmitPurchaseOrder(ByVal po As Microsoft.ServiceModel.Samples.PurchaseOrder) Implements IOrderProcessor.SubmitPurchaseOrder
		MyBase.Channel.SubmitPurchaseOrder(po)
	End Sub
End Class