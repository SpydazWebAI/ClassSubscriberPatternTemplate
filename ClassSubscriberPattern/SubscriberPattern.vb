Public Class SubscriberPattern

    ''' <summary>
    ''' Abstract Class: Publisher / Subscriber DesignPattern subscribers implement this interface
    ''' to receive notifications from the publisher
    ''' </summary>
    Public Interface Observer

        ''' <summary>
        ''' This is the channel to receive data from the publisher this variable needs to match
        ''' the data being updated from the publisher
        ''' </summary>
        ''' <param name="Data"></param>
        Sub Update(ByVal Data As String)

    End Interface

    'Publisher & Subscriber DesignPattern
    'Author : Leroy S Dyer
    'Year : 2017
    ''' <summary>
    ''' Abstract Class: Publisher / Subscriber DesignPattern this interface is used as the main
    ''' task manager for the subscriber classes the subject is the information provider or Publisher
    ''' </summary>
    Public Interface Publisher

        Sub NotifyObservers()

        Sub RegisterObserver(ByVal mObserver As Observer)

        Sub RemoveObserver(ByVal mObserver As Observer)

    End Interface

End Class
