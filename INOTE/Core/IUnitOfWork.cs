﻿using INOTE.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INOTE.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        INoteRepository Notes { get; }
        int Complete();
    }
}
