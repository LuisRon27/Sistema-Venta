Module Modulo
    'Para poder generar la cadena de conexión
    Public conexionSql As New SqlClient.SqlConnection

    'Para la recepción de datos
    Public adaptadorSql As New SqlClient.SqlDataAdapter

    'Para la ejecución de los comandos de SQL
    Public consultasql As New SqlClient.SqlCommand

    'Para realizar las acciones de ejecucion 
    Public acciones As New SqlClient.SqlCommand

    'Para ser un repositorio de datos de la consulta 
    Public lectordatos As SqlClient.SqlDataReader

    'datatable para los combo
    Public tabladedatos As New DataTable

    'Para realizar las acciones de ejecucion 
    Public acciones2 As New SqlClient.SqlCommand

End Module
