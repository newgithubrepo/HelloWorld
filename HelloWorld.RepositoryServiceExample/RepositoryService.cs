using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.RepositoryServiceExample
{
    using HelloWorld.Contracts;
    using System.Reflection;

    public class RepositoryService:IRepositoryService
    {
        public void SaveData(dynamic data)
        {
            try
            {
                if (data == null)
                    throw new ArgumentNullException();

                foreach (var prop in data.GetType().GetProperties())
                {
                    string propName = prop.Name;
                    object value = prop.GetValue(data, null);
                    Console.WriteLine("Property {0}: {1}", propName, value ?? string.Empty);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("Finishing the save to console.");
            }
           

            
        }
    }
}
