using System.Reflection;

namespace Common
{
    public class ObjectFactory
    {
        public static T CreateObject<T>(string assemblyName, string className) where T : class
        {
            object objType = Assembly.Load(assemblyName).CreateInstance($"{assemblyName}.{className}", true, BindingFlags.Default, null, null, null, null);
            T resObject = (T)objType;
            return resObject;
        }
    }
}