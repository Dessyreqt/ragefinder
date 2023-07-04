using System;
using System.IO;
using System.Xml.Serialization;

namespace RageFinder
{
    [Serializable]
    public class FormationData
    {
        public bool[] FormationOnVeldt { get; set; }
        public int SelectedGroupNum { get; set; }
        public bool Resetting { get; set; }
        
        public FormationData()
        {
            FormationOnVeldt = new bool[512];
            SelectedGroupNum = 0;
            Resetting = false;
        }

        public static void Save(FormationData formationData)
        {
            using (Stream writer = new FileStream("formations.xml", FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(FormationData));
                serializer.Serialize(writer, formationData);
                writer.Close();
            }
        }

        public static FormationData Load()
        {
            try
            {

                using (Stream reader = new FileStream("formations.xml", FileMode.Open, FileAccess.Read))
                {
                    var serializer = new XmlSerializer(typeof(FormationData));
                    var formationData = (FormationData)serializer.Deserialize(reader);
                    reader.Close();

                    return formationData;
                }
            }
            catch (Exception)
            {
                return new FormationData();
            }
        }
    }
}
