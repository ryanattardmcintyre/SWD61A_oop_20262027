using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_InheritanceAndPolymorphism.Example4
{
    public class DigitalFile
    {
        public DigitalFile() { Filename = ""; }

        public DigitalFile(string filename)
        { Filename = filename.ToLower(); Size = 0; }

        public DigitalFile(int size, string filename)
        {
            Size = size;
        }

        //this? this is a reserved word referring to the current instantiated object

        //in the following constructor, the order of calls will be
        //1) calling the prior constructor i.e the one that has just one parameter
        //2) it calls the current constructor i.e. the one with two parameters
        public DigitalFile(string filename, byte[] defaultContent): this(filename)
        {
            this.content = defaultContent;
        }

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
