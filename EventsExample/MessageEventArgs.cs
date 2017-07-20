using System;

namespace EventsExample
{
    //принято наследовать классы аргументов для обработчиков событий от EventArgs
    //это наследование не несет никакой функциональной нагрузки,
    //но так принято и это хорошая практика, см. также описание делегата Messanger.MesageSendHandler  
    public class MessageEventArgs : EventArgs
    {
        public string SenderName { get; set; }

        public string ReceiverName { get; set; }

        public string Message { get; set; }        
    }
}
