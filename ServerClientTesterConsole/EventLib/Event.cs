using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTester
{
    public class Event
    {
        public enum EventTypeEnum { NULLEVENTENUM, CreateAccount, LoginAttempt, ServerResponseSuccess, ServerResponseError };

        public static Event NULLEVENT = new Event(EventTypeEnum.NULLEVENTENUM, null);

        private EventTypeEnum _eventType;

        private object _eventData;

        public Event(EventTypeEnum eType, object eData)
        {
            _eventType = eType;
            _eventData = eData;
        }

        #region Getters/Setters
        public EventTypeEnum EventType
        {
            get
            {
                return _eventType;
            }
            set
            {
                _eventType = value;
            }
        }

        public object EventData
        {
            get
            {
                return _eventData;
            }
            set
            {
                _eventData = value;
            }
        }
        #endregion
    }
}
