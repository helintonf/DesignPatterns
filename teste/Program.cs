using System;

namespace teste
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var machine = new SyncMachine();

            machine.Synchronize();
        }

        public class SyncMachine
        {
            public ISyncEntity Entity { get; set; }

            public void Synchronize()
            {
                EntityTypeEnum entityType = EntityTypeEnum.Hierarchy;

                var type = $@"teste.Sync{entityType.ToString()}";

                var coco = System.Reflection.Assembly.GetExecutingAssembly().FullName;
                var tata = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;

                Entity = (ISyncEntity)System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(type);
                var teste = GetInstance(type);


                Entity.SynchronizeAll();
            }


            public object GetInstance(string strFullyQualifiedName)
            {
                Type type = Type.GetType(strFullyQualifiedName);
                if (type != null)
                    return Activator.CreateInstance(type);
                foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
                {
                    type = asm.GetType(strFullyQualifiedName);
                    if (type != null)
                        return Activator.CreateInstance(type);
                }
                return null;
            }
        }

        public interface ISyncEntity
        {
            void Synchronize();

            void SynchronizeAll();
        }

        public enum EntityTypeEnum
        {
            Hierarchy = 0,
            LegalHierarchy = 1,
            HierarchyAddress = 2,
            LegalHierarchyAddress = 3,
            Person = 4,
            HierarchyRole = 5,
            Role = 6,
            Certificate = 7,
            Country = 8,
            HierarchyType = 9,
            LegalHierarchyRole = 10,
            LegalNature = 11,
            EconomicActivity = 12,
            DatabaseConnection = 13,
            CompanyReferenceType = 14,
            Locality = 15,
            LegalSituation = 16
        }

        public class SyncCertificate : ISyncEntity
        {
            public void Synchronize()
            {
                Console.WriteLine("SynchronizeCertificate");
            }

            public void SynchronizeAll()
            {
                Console.WriteLine("SynchronizeAllCertificate");
            }
        }

       

        // Define other methods and classes here
    }
}