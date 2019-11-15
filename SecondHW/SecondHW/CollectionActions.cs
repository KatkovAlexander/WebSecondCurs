using System;
using System.Collections.Generic;

namespace SecondHW
{
    public class CollectionActions
    {
        public static List<Collection> Collections = new List<Collection>();
        
        public static void Add(int id, string name)
        {
            if (Collections.FindIndex(x => x.CollectionId == id) == -1)
            {
                Collections.Add(new Collection( id, name));
                Console.WriteLine("Operation completed successfully");
                Console.WriteLine();
                return;
            }
            Console.WriteLine("Couldn't add this Collection");
            Console.WriteLine();
        }

        public static void ChangeId(int current_id, int new_id)
        {
            if (Collections.FindIndex(x => x.CollectionId == new_id) != -1)
            {
                Console.WriteLine("No Collection with this id");
                return;
            }

            var index = Collections.FindIndex(x => x.CollectionId == current_id);

            try
            {
                Collections[index].CollectionId = new_id;
                Console.WriteLine("Operation completed successfully");
            }
            catch
            {
                Console.WriteLine("Couldn't find Collection with this id");
            }
            Console.WriteLine();
        }

        public static void Delete(int id)
        {
            var index = Collections.FindIndex(x => x.CollectionId == id);
            try
            {
                Collections.RemoveAt(index);
                Console.WriteLine("Operation completed successfully");
            }
            catch
            {
                Console.WriteLine("Couldn't delete Collection with this id");
            }
            Console.WriteLine();
        }
        public static void GetAll()
        {
            for (var i = 0; i < Collections.Count; i++)
            {
                Console.WriteLine($"{Collections[i].CollectionId} {Collections[i].CollectionName}");
            }
            Console.WriteLine();
        }

        public static void GetById(int i)
        {
            try
            {
                int index = Collections.FindIndex(x => x.CollectionId == i);
                Console.WriteLine($"{Collections[index].CollectionId} {Collections[index].CollectionName}");
            }
            catch
            {
                Console.WriteLine("Couldn't find Collection with this id");
            }
            Console.WriteLine();
        }
    }
}