using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluxStateManagement.Stores.CounterStore
{

    public class CounterState
    {
        public int Count { get; set; }
        public CounterState(int count)
        {
            Count = count;
        }
    }
    public class CounterStore
    {
        private readonly IActionDispatcher actionDispatcher;
        private CounterState _state;

        public CounterStore(IActionDispatcher actionDispatcher)
        {
            _state = new CounterState(0);
            this.actionDispatcher = actionDispatcher;
            this.actionDispatcher.Subscript(HandleActions);
        }

        public CounterState GetState()
        {
            return _state;
        }

        private void HandleActions(IAction action)
        {
            switch(action.Name)
            {
                case IncrementAction.INCREMENT:
                    IncrementCount();
                    break;
                case DecrementAction.DECREMENT:
                    DecrementCount();
                    break;
                default:
                    break;
            }
        }

        private void IncrementCount()
        {
            var count = this._state.Count;
            count++;
            this._state = new CounterState(count);
            BrodcastStateChange();
        }

        private void DecrementCount()
        {
            var count = this._state.Count;
            count--;
            this._state = new CounterState(count);
            BrodcastStateChange();
        }


        #region observer pattern

        private Action _listeners;

        public void AddStateChangeListeners(Action listener)
        {
            _listeners += listener;
        }

        public void RemoveStateChangeListeners(Action listeners)
        {
            listeners -= listeners;
        }

        private void BrodcastStateChange()
        {
            _listeners.Invoke();
        }

        #endregion
    }
}
