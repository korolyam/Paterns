using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlClassLibrary
{
    public class Channel
    {
        private static List<int> _channels = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        private int _number = 0;
        private int _currentChannel;
        private int _backChannel;
        private bool _isBackChannel = false;

        public Channel()
        {
            _currentChannel = _channels[_number];
        }

        public void List()
        {
            Console.WriteLine("Список каналов: " + string.Join(", ", _channels));
        }

        public void ForNumber(int number)
        {
            if (!_channels.Contains(number))
            {
                throw new ArgumentException($"Ошибка. {number}-го канала не существует (существующие каналы можно узнать - *.List())");
            }
            else
            {
                _isBackChannel = true;
                _backChannel = _currentChannel;
                _number = number;  
                _currentChannel = number;
            }
        }

        public void Next()
        {
            if (_currentChannel == _channels.Last())
            {
                throw new ArgumentOutOfRangeException("Ошибка. Следующего канала не существует");
            }
            else
            {
                _isBackChannel = true;
                _backChannel = _currentChannel;
                _number++;
                _currentChannel = _channels[_number];
            }
        }

        public void Previous()
        {
            if (_currentChannel == _channels.First())
            {
                throw new ArgumentOutOfRangeException("Ошибка. Предыдущего канала не существует");
            }
            else
            {
                _isBackChannel = true;
                _backChannel = _currentChannel;
                _number--;
                _currentChannel = _channels[_number];
            }
        }

        public void Back()
        {
            if (!_isBackChannel)
            {
                throw new ArgumentNullException("Ошибка. Вы не можете вернуться на прошлый канал");
            }
            else
            {
                int temp = _currentChannel;
                _currentChannel = _backChannel;
                _backChannel = temp;
            }
        }
    }
}