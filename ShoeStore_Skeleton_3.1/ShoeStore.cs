using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeStore
{
    public class ShoeStore
    {
        public List<Shoe> shoes;

        public ShoeStore(string name, int storageCapacity)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            shoes = new List<Shoe>();
        }

        public string Name { get; set; }

        public int StorageCapacity { get; set; }    

        public List<Shoe> Shoes { get { return shoes; } }   

        public int Count { get { return shoes.Count; } }

        public string AddShoe(Shoe shoe)
        {
            if (shoes.Count == StorageCapacity)
            {
                return "No more space in the storage room.";
            }

            shoes.Add(shoe);

            return $"Successfully added {shoe.Type} {shoe.Material} pair of " +
                $"shoes to the store.";
        }

        public int RemoveShoes(string material)
        {
            return shoes.RemoveAll(s => s.Material == material);    
        }

        public List<Shoe> GetShoesByType(string type)
        {
            return shoes.Where(s => s.Type.ToLower() == type.ToLower()).ToList();
        }

        public Shoe GetShoeBySize(double size)
        {
            return shoes.FirstOrDefault(s => s.Size == size);
        }

        public string StockList(double size, string type)
        {
            IEnumerable<Shoe> stockList = shoes.Where(s => s.Size == size && s.Type == type);

            StringBuilder sb = new StringBuilder();

            if (!stockList.Any())
            {
                sb.AppendLine("No matches found!");
            }
            else
            {
                sb.AppendLine($"Stock list for size {size} - {type} shoes:");
                foreach (Shoe shoe in stockList)
                {
                    sb.AppendLine(shoe.ToString());
                }

            }

            return sb.ToString().Trim();
        }
    }
}
