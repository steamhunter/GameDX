﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamConnect.Exeptions
{

    [Serializable]
    public class GameNotFoundException : Exception
    {
        public GameNotFoundException()
        {

        }
        public GameNotFoundException(string message) : base(message)
        {

        }
        public GameNotFoundException(string message, Exception inner) : base(message, inner)
        {

        }
        protected GameNotFoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {

        }
    }
}
