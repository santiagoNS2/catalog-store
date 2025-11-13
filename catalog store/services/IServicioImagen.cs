namespace catalog_store.services
{
    public interface IServicioImagen
    {
        Task<string> SubirImagen(Stream archivo , string nombre);
    }
}
