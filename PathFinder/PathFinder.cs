using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.Toolkit;
using SharpDX.Toolkit.Graphics;
using SharpDX;
using PathFinder;
using SharpDX.Direct3D11;

namespace PathFinder
{
    class PathFinder
    {
    }
    public enum gamestate
    {
        load,
        world,
        battle

    }
   
    public class vars
    {
        public static gamestate state = gamestate.world;
        public static SpriteBatch spriteBatch;
        public static Device device;
    }
}
