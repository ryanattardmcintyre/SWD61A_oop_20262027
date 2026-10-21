using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_InheritanceAndPolymorphism.Example4
{
    public class DigitalFile
    {
        //Field
        protected byte[] content;

        //Properties
        public string Filename { get; set; }
        public double Size { get; set; }
        public byte[] Content { get { return content; } }

        //Methods
        public virtual void Load(string path)
        {
            content = System.IO.File.ReadAllBytes(path);
        }
        public void Save(string path, byte[] data)
        {
            File.WriteAllBytes(path, data);
        }
    }
}
