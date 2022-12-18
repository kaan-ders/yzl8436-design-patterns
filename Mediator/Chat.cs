using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    // Haberleşme için ortak bir arayüz sağlar.
    // Haberleşme Mediator tarafından gerçekleşeceği için bir örneğini tutar.
    // Mesaj alma ve mesaj gönderme özellikleri içermektedir.
    public abstract class Kullanici
    {
        public int id;
        public string name;

        private IChatRoomMediator _chatRoomMediator;

        public Kullanici(IChatRoomMediator chatRoomMediator)
        {
            _chatRoomMediator = chatRoomMediator;
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"{name} received new message. Message: {message}");
        }

        public void SendMessage(string message, int userId)
        {
            Console.WriteLine($"{name} send new message to: {userId} id user.");
            _chatRoomMediator.SendMessage(message, userId);
        }
    }

    // Colleague (User) soyutundan türer.
    // Mediator sayesinde diğer sınıf örnekler ile iletişim kurar.
    class ChatUser : Kullanici
    {
        public ChatUser(IChatRoomMediator chatRoomMediator) : base(chatRoomMediator)
        {

        }
    }

    // Colleague (User) nesneler arasındaki iletişim arayüzünü tanımlar.
    public interface IChatRoomMediator
    {
        void SendMessage(string message, int userId);
        void AddUserInRoom(Kullanici user);
    }

    // Mediator (IChatRoomMediator) arayüzünü uygular.
    // Colleague (User) nesneleri arasındaki iletişimi koordine eder.
    public class ChatRoomMediator : IChatRoomMediator
    {
        private Dictionary<int, Kullanici> _userDictionary;

        public ChatRoomMediator()
        {
            _userDictionary = new Dictionary<int, Kullanici>();
        }

        public void AddUserInRoom(Kullanici user)
        {
            _userDictionary.Add(user.id, user);
        }

        public void SendMessage(string message, int userId)
        {
            Kullanici user = _userDictionary[userId];
            user.ReceiveMessage(message);
        }
    }
}
