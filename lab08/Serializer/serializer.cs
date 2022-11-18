using System.Xml.Serialization;
using Animals;

Animal for_serialization = new Lion("Russia", "Bob", false, eClassificationAnimal.Omnivores);

XmlSerializer xmlSerializer = new XmlSerializer(typeof(Lion));

using (FileStream fs = new FileStream("lion.xml", FileMode.OpenOrCreate))
{
    xmlSerializer.Serialize(fs, for_serialization);
    Console.WriteLine("Object has been serialized succesfully");
}
