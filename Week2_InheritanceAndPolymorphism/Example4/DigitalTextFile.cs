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
        
        //dynamic polymorphism: when you decide to change the implementation of a base method
        //                      applied via virtual-override
        //                      aka overriding of methods
        public override void Load(string path)
        {
            if (System.IO.Path.GetExtension(path) == ".txt" )
            { textContent = File.ReadAllText(path); }
        }

        //static polymorphism: when you have more than ONE method with
        //                     the same name BUT different (number/typed) parameters
        //                     aka overloading of methods/constructors

        public void Save(string path, string data)
        {
            if (System.IO.Path.GetExtension(path) == ".txt")
            { File.WriteAllText(path, data); }
        }

        public void Save(string path, string data, bool overwrite = false)
        {
            if (System.IO.Path.GetExtension(path) == ".txt" && overwrite==true)
            {
                Save(path, data);
            }
            else if(System.IO.Path.GetExtension(path) == ".txt" && overwrite == false)
            {
                System.IO.File.AppendAllText(path, data);
            }
        }
    }
}
