namespace EventsExample
{
    //Наш класс который умеет отправлять сообщения
    public class Messanger
    {
        //описываем делеат для нашего обработчика событий, как правило он возвращает void
        //и принимает на вход 2 параметра, первый - sender, туда будем передавать ссылку на объект,
        //который генерирует событие, второй - наш класс, наследник от EventArgs, в котором будут содержаться все необходимые данней для обработки события
        //тна практике такие делегаты никто не описывает а используют готовый 
        //public delegate void EventHandler(object sender, EventArgs e)
        //но тут с целью демонстрации мы опишем свой с такой же сигнатурой
        public delegate void MesageSendHandler(object sender, MessageEventArgs e);

        //поле контейнер обработчиков - сюда сетим любой обработчик соответствующий сигнатуре 
        //нашего делегата MesageSendHandler
        //по сути это поле класса в котором будут содержаться ссылки на возможные обработчики нашего события
        public event MesageSendHandler OnMessageSend;

        //метод отправки сообщения
        public void SendMessage(string from, string to, string message)
        {
            //проверям назначен ли обработчик на событие OnMessageSend
            if (OnMessageSend != null)
            {
                //вызываем обработчик, передаем в него ссылку на наш мессенджер в качестве первого параметра
                //в качестве второго - информацию о сообщении, которую мы заранее предопределили 
                //структурой свойств класса MessageEventArgs
                MessageEventArgs args = new MessageEventArgs()
                {
                    SenderName = from,
                    ReceiverName = to,
                    Message = message
                };
                OnMessageSend(this, args);
            }

            //тут делаем работу по отправке сообщения адресату, как то, 
            //найти получателя, выполнить всю работу по доставке сообщения            
            //.....
        }
    }
}
