﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaWear.Windows.API.Interfaces
{
    public interface ICallbackModule
    {
       void HandleCallback(byte[] data);
    }
}
