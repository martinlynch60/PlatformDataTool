using System;

namespace PlatformDataTool.Objects  
{
    public class Application
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}