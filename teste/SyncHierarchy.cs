using System;
using System.Collections.Generic;
using System.Text;
using static teste.Program;

namespace teste
{
    public class SyncHierarchy : ISyncEntity
    {
        public void Synchronize()
        {
            Console.WriteLine("SynchronizeHierarchy");
        }

        public void SynchronizeAll()
        {
            Console.WriteLine("SynchronizeAllHierarchy");
        }
    }
}
