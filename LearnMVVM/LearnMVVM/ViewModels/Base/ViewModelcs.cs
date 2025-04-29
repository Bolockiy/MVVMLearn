using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LearnMVVM.ViewModels.Base
{
    internal abstract class ViewModel : INotifyPropertyChanged, IDisposable
    { 
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void onPropertyChanged([CallerMemberName] string ProperyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(ProperyName));
        }

        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyrName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            onPropertyChanged(PropertyrName);
            return true;
        }
        public virtual void Dispose()
        {
            Dispose(true);
        }
        private bool _Disposed;
        protected virtual void Dispose(bool Disposing)
        {
            if (!Disposing || _Disposed) return;
            _Disposed = true;
            // Освоюождение управляемых ресурсов
        }
    }
}
