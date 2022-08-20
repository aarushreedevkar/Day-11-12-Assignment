using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInventoryManagement1
{
    public class FetchJsonForRice
    {
        public Rice Read (string Path)
         {
            using (StreamReader file = new StreamReader(Path)) {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Rice>(json);
                }
                catch
                {
                    return null;
                }
            }

        }
    }
}
