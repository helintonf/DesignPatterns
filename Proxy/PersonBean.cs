using System.Reflection;

namespace Proxy
{
    public interface PersonBean
    {
        object Invoke(object proxy, MethodInfo method, object[] parameters);
    }
}