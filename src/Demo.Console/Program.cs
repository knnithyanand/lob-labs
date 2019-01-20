using System;
using System.Collections.Generic;
using Knnithyanand.LobLabs.Libs.Core;

namespace Demo.Cli
{
    class Program
    {
        // static EntityAttribute<String> TextAttribute = new EntityAttribute<String>()
        // {
        //     Name = nameof(TextAttribute),
        //     Description = "",
        //     Type = AttributeDataType.Text
        // };

        // static EntityAttribute<string> NumberAttribute = new EntityAttribute<string>()
        // {
        //     Name = nameof(NumberAttribute),
        //     Description = "",
        //     Type = AttributeDataType.Number
        // };

        static void Main(string[] args)
        {
            var CustomerEntity = new EntityType("Customer", "Represents a customer object")
            {
                Attributes = new List<EntityAttribute>(){
                    new TextAttribute("First Name"),
                    new TextAttribute("Last Name"),
                    new TextAttribute("Location"),
                    new TextAttribute("Phone No")
                }
            };

            var customer1 = CollectInput(CustomerEntity);

            DisplayOutput(customer1);
        }

        private static void DisplayOutput(EntityType entity)
        {
            foreach (var item in entity.Attributes)
            {
                Console.WriteLine($"{item.Name} : {item.Value}");
            }
        }

        private static EntityType CollectInput(EntityType entityType)
        {
            foreach (var attr in entityType.Attributes)
            {
                Console.Write($"Enter value for {attr.Name}: ");
                attr.Value = Console.ReadLine();
            }
            return entityType;
        }
    }
}
