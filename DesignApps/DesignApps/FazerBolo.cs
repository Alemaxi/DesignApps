using Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignApps
{
    public class FazerBolo
    {
        IBoloBuilder builder;
        IBoloBuilder builder2;
        IBoloBuilder builder3;

        public FazerBolo(IBoloBuilder builder, IBoloBuilder builder2, IBoloBuilder builder3)
        {
            this.builder = builder;
            this.builder2 = builder2;
            this.builder3 = builder3;
        }

        public void PrepararBolos()
        {
            Console.WriteLine("Bolos preparados com Builder: \n");

            builder.FazerMassa();
            builder.Rechear();
            builder.Confeitar();
            Console.WriteLine(builder.ObterBolo.ToString());

            builder2.FazerMassa();
            builder2.Rechear();
            builder2.Confeitar();
            Console.WriteLine(builder2.ObterBolo.ToString());
            
            builder3.FazerMassa();
            builder3.Rechear();
            builder3.Confeitar();
            Console.WriteLine(builder.ObterBolo.ToString());
            
        }
    }
}
