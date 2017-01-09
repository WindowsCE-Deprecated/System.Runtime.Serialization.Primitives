namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
    internal sealed class AssemblyFileVersionAttribute : Attribute
    {
        public AssemblyFileVersionAttribute(string version) { }
    }
}
