using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelvetEyebrows.Models;

namespace VelvetEyebrows
{
    public class Session
    {
        private Session()
        {
            context = new VelvetEyebrowsContext();
        }
        private static Session? instance;
        public static Session Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Session();
                }
                return instance;
            }
        }
        private VelvetEyebrowsContext context;
        public VelvetEyebrowsContext Context => context;
    }
}
