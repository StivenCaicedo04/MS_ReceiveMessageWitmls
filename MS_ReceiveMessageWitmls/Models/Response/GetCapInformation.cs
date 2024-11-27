namespace MS_ReceiveMessageWitmls.Models.Response
{
    public class GetCapInformation
    {
        public string? Version { get; set; } // Versión del protocolo WITSML soportada
        public string? ServerName { get; set; } // Nombre del servidor
        public string? Contact { get; set; } // Información de contacto del servidor
        public string? Description { get; set; } // Descripción del servidor
        public List<string>? Funtions { get; set; } // Lista de funciones que soportados (GetVersion, GetCap, etc.)
    }
}
