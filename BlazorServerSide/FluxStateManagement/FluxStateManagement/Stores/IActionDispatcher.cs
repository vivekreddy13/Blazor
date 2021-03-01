using System;

namespace FluxStateManagement.Stores.CounterStore
{
    public interface IActionDispatcher
    {
        void Dispatch(IAction action);
        void Subscript(Action<IAction> actionHandler);
        void Unsubscript(Action<IAction> actionHandler);
    }
}