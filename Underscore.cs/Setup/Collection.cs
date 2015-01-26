﻿using Underscore.Collection;

namespace Underscore.Setup
{
    public class CollectionModule : IKernelModule
    {
        public void Load(Kernel kernel)
        {
            kernel.Register<ICreationComponent,CreationComponent>();
            kernel.Register<IPartitionComponent, PartitionComponent>();
            kernel.Register<Module.Collection>();
        }
    }
}