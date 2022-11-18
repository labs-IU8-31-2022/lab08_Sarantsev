using System.Xml.Serialization;
using Animals;

XmlSerializer xmlSerializer = new XmlSerializer(typeof(Lion));

using (FileStream fs = new FileStream("lion.xml", FileMode.OpenOrCreate))
{
    Lion? for_deserialization = xmlSerializer.Deserialize(fs) as Lion;
    Console.WriteLine("Object has been deserialized successfully");
    Console.WriteLine($"{for_deserialization.Country} {for_deserialization.Name} {for_deserialization.HideFromOtherAnimal} {for_deserialization.WhatAnimal}");
}