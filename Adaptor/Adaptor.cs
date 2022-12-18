using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adaptor
{
    public interface IJsonSerializer
    {
        public string Serialize(object obj);
    }

    public class FilmSerializer : IJsonSerializer
    {
        public string Serialize(object obj)
        {
            //Gelen filmleri deserialize et
            throw new NotImplementedException();
        }
    }

    public class DiziSerializer : IJsonSerializer
    {
        public string Serialize(object obj)
        {
            //Gelen dizi deserialize et
            throw new NotImplementedException();
        }
    }

    //Microsoft'un bize uyumsuz json serializer'ı
    public class MicrosoftSerializer
    {
        public T SerializeObjectToType<T>(T obj)
        {
            // Gelen nesneyi serilize etmek için temel operasyonel işlemler..
            // Daha sonradan da gerekli değerin geri döndürülmesi...
            return (T)(object)"serialized with CustomSerializer";
        }
    }

    public class MicrosoftSerializerAdapter : IJsonSerializer
    {
        public string Serialize(object obj)
        {
            MicrosoftSerializer microsoftSerializer = new MicrosoftSerializer();
            return microsoftSerializer.SerializeObjectToType<string>(obj.ToString());
        }
    }
}
