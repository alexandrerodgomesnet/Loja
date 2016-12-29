using System.Web;

namespace Loja.Domain.Commom
{
    public class Utils
    {
        public static bool ExisteSession(string nomeSession)
        {
            return (!ReferenceEquals(HttpContext.Current.Session[nomeSession], "")) && (HttpContext.Current.Session[nomeSession] != null);
        }
    }
}
