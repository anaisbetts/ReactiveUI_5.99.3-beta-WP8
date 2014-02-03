using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using PivotApp1.Views;
using ReactiveUI;
using ReactiveUI.Mobile;
using Splat;

namespace PivotApp1.ViewModels
{
#if FALSE
    public class AkavacheDriver : ISuspensionDriver, IEnableLogger
    {
        public AkavacheDriver(string applicationName)
        {
            BlobCache.ApplicationName = applicationName;
            BlobCache.SerializerSettings = new JsonSerializerSettings()
            {
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                TypeNameHandling = TypeNameHandling.All,
            };
        }

        public IObservable<T> LoadState<T>() where T : class, IApplicationRootState
        {
            return BlobCache.UserAccount.GetObjectAsync<T>("__AppState"); ; ; ;
        }

        public IObservable<Unit> SaveState<T>(T state) where T : class, IApplicationRootState
        {
            return BlobCache.UserAccount.InsertObject("__AppState", state)
                .SelectMany(BlobCache.UserAccount.Flush());
        }

        public IObservable<Unit> InvalidateState()
        {
            BlobCache.UserAccount.InvalidateObject<object>("__AppState");
            return Observable.Return(Unit.Default);
        }
    }
#endif

    [DataContract]
    public class AppBootstrapper : ReactiveObject, IApplicationRootState
    {
        [DataMember]
        RoutingState _Router;

        public IRoutingState Router
        {
            get { return _Router; }
            set { _Router = (RoutingState)value; }
        }

        public AppBootstrapper()
        {
            Router = new RoutingState();

            Locator.CurrentMutable.Register(() => new TestPage(), typeof(MainViewModel));

            Locator.CurrentMutable.RegisterConstant(this, typeof(IApplicationRootState));
            Locator.CurrentMutable.RegisterConstant(this, typeof(IScreen));

            Router.Navigate.Execute(new MainViewModel(this));
        }
    }
}
