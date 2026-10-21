using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_InheritanceAndPolymorphism.Example4
{
    public class DigitalTextFile: DigitalFile
    {
        protected string textContent;

        public string TextContent { get { return textContent; } }
        public override void Load(string path)
        {
            if (System.IO.Path.GetExtension(path) == ".txt" )
            { textContent = File.ReadAllText(path); }
        }

        //static polymorphism: when you have more than ONE method with
        //                     the same name BUT different (number/typed) parameters

        public void Save(string path, string data)
        {

        }

        public void Save(string path, string data, bool overwrite = false)
        {

        }
    }
}
