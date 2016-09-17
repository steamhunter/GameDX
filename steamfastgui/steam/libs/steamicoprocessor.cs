using SharpDX.Direct3D11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam
{
    public class steamicoprocessor
    {
        
            public static ShaderResourceView getGameIco(Device device, string iconurl)
            {

                return ShaderResourceView.FromFile(device, "Content\\"+iconurl + ".jpg");
            }
        
    }
}
