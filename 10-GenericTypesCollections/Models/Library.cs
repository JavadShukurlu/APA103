using System;
using System.Collections.Generic;
using System.Text;

namespace _10_GenericTypesCollections.Models
{
    internal class Library<T>
    {
        
        public List<T>  Items { get; set; } = new List<T>();
        public string Name { get; set; }

        public Library(string name)
        {
            Name = name;
        }

        public void Add(T item)
        {
            Items.Add(item);
            Console.WriteLine($"Yeni kitab elave edildi");
        }

        public void Remove(T item)
        {
            Items.Remove(item);
            Console.WriteLine($"Kitab silindi");
        }

        public List<T> GetAll()
        {
            return Items;
        }


        public int ItemCount()
        {
            return Items.Count;
        }

        public T FindByIndex(int index)
        {
            if (index > Items.Count - 1 || index < 0)
            {
                
            }

            try
            {
                return Items[index];
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Index araliginda deyil!");
                return default(T);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }

    
}
