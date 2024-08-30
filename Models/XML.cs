using System.Xml.Serialization;

namespace filezilla_integrate.Models
{
    public class XML
    {
        [XmlRoot(ElementName = "include")]
        public class Dialplan
        {
            [XmlElement(ElementName = "extension")]
            public List<Extension>? Extensions { get; set; }
        }

        public class Extension
        {
            [XmlAttribute(AttributeName = "name")]
            public string? Name { get; set; }

            [XmlElement(ElementName = "condition")]
            public List<Condition>? Conditions { get; set; }
        }

        public class Condition
        {
            [XmlAttribute(AttributeName = "field")]
            public string? Field { get; set; }

            [XmlAttribute(AttributeName = "expression")]
            public string? Expression { get; set; }

            [XmlElement(ElementName = "action")]
            public List<Action>? Action { get; set; }
        }

        public class Action
        {
            [XmlAttribute(AttributeName = "application")]
            public string? Application { get; set; }

            [XmlAttribute(AttributeName = "data")]
            public string? Data { get; set; }
        }
    }
}
