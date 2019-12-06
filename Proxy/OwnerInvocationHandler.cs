using System;
using System.Reflection;

namespace Proxy
{
    public class OwnerInvocationHandler : Person
    {
        public Person Person { get; set; }

        public OwnerInvocationHandler(Person person)
        {
            Person = person;
        }

        public object Invoke(object proxy, MethodInfo method, object[] parameters)
        {
            // SecurityManager.IsMethodRole(user)

           
           return method.Invoke(Person, parameters);
        }
    }
}