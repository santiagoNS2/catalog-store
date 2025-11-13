using Firebase.Auth;
using Firebase.Storage;

namespace catalog_store.services
{
    public class ServicioImagen: IServicioImagen
    {
        public async Task<string> SubirImagen(Stream archivo, string nombre)
        {
            string email = "conexion@gmail.com";
            string clave = "Santiago123";
            string ruta = "catalogo-3b180.firebasestorage.app";
            string api_key = "AIzaSyAtP-PiD9RbI3y33JFCPfYZsJXQWr6-er0";

            var auth = new FirebaseAuthProvider(new FirebaseConfig(api_key));
            var a = await auth.SignInWithEmailAndPasswordAsync(email, clave);

            var cancellation = new CancellationTokenSource();

            var task = new FirebaseStorage(
              ruta,
              new FirebaseStorageOptions
              {
                  AuthTokenAsyncFactory = () => Task.FromResult(a.FirebaseToken),
                  ThrowOnCancel = true
              })

               .Child("Fotos_Perfil")
               .Child(nombre)
               .PutAsync(archivo, cancellation.Token);

            var downloadURL = await task;
            return downloadURL;
        }
    }
}