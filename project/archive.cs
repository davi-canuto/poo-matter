using System;
using System.Xml.Serialization;
using System.Text;
using System.IO;

class Archive<T> {

  public T Open(string archive) {
    XmlSerializer xml = new XmlSerializer(typeof(T));
    StreamReader f = new StreamReader(archive, Encoding.Default);
    T obj = (T) xml.Deserialize(f);
    f.Close();
    return obj;
  }

  public void ToSave(string archive, T obj) {
    XmlSerializer xml = new XmlSerializer(typeof(T));
    StreamWriter f = new StreamWriter(archive, false, Encoding.Default);
    xml.Serialize(f, obj);
    f.Close();
  }

}