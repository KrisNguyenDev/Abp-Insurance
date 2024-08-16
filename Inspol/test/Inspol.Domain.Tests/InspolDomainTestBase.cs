﻿using Volo.Abp.Modularity;

namespace Inspol;

/* Inherit from this class for your domain layer tests. */
public abstract class InspolDomainTestBase<TStartupModule> : InspolTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
