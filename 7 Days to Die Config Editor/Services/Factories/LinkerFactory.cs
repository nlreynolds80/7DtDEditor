using Domain;
using Services.Linkers;
using System;

namespace Services.Factories
{
    public class LinkerFactory : ILinkerFactory
    {
        public ILinker<T> GetLinker<T>(T target)
        {
            switch(target)
            {
                case ILinker<EntityGroups> L:
                    return (ILinker<T>)new EntityGroupsLinker();
                default:
                    throw new ArgumentException(
                        message: "No linker supported for target",
                        paramName: nameof(target));
            }
        }
    }
}
