' Hinweis: Anweisungen zum Aktivieren des klassischen Modus von IIS6 oder IIS7 
' finden Sie unter "http://go.microsoft.com/?LinkId=9394802".
Imports System.Web.Http

Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Sub Application_Start()
        AreaRegistration.RegisterAllAreas()

        WebApiConfig.Register(GlobalConfiguration.Configuration)
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
    End Sub
End Class
