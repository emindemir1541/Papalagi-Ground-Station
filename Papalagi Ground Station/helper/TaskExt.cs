using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papalagi_Ground_Station.helper
{
   public class TaskExt
    {
        public static async Task<IEnumerable<T>> WhenAll<T>(params Task<T>[] tasks)
        {
            var allTasks = Task.WhenAll(tasks);

            try
            {
                return await allTasks;
            }
            catch (Exception)
            {

            }

            throw allTasks.Exception ?? throw new Exception("Exception Couldn't found");
        }
    }
}
