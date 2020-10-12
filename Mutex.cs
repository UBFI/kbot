using System;
using System.Threading;

namespace myApp
{
    internal class InstanceUnique : IDisposable
    {
        private readonly Mutex _mMutex;
        private bool _mMutexOwned;


        public InstanceUnique(string name)
        {
            _mMutex = new Mutex(false, name);
            _mMutexOwned = false;
        }



        #region IDisposable Members


        public void Dispose()
        {
            if (_mMutexOwned)
                _mMutex.ReleaseMutex();
        }

        #endregion

        public bool IsRunning()
        {
            _mMutexOwned = _mMutex.WaitOne(0, true);
            return !(_mMutexOwned);
        }
    }
}