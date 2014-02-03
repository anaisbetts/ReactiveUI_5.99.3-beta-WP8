ReactiveUI_5.99.3-beta-WP8
==========================

Repro repo for issue with the ReactiveUI 5.99.3-beta NuGet package

When running the project, it fails with the following error:

`Type 'ReactiveUI.Xaml.RoutedViewHost' must have a property 'ViewModel'`

And Stacktrace:

```
{System.Windows.ApplicationUnhandledExceptionEventArgs}
    base: {System.Windows.ApplicationUnhandledExceptionEventArgs}
    ExceptionObject: {System.ArgumentException: Type 'ReactiveUI.Xaml.RoutedViewHost' must have a property 'ViewModel'
   at ReactiveUI.Reflection.GetValueFetcherOrThrow(Type type, String propName)
   at ReactiveUI.Reflection.TryGetValueForPropertyChain[TValue](TValue& changeValue, Object current, String[] propNames)
   at ReactiveUI.ObservedChangedMixin.TryGetValue[TSender,TValue](IObservedChange`2 This, TValue& changeValue)
   at ReactiveUI.ObservedChangedMixin.fillInValue[TSender,TValue](IObservedChange`2 This)
   at ReactiveUI.ReactiveNotifyPropertyChangedMixin.observedChangeFor(String propertyName, IObservedChange`2 sourceChange)
   at ReactiveUI.ReactiveNotifyPropertyChangedMixin.nestedObservedChanges(String propertyName, IObservedChange`2 sourceChange, Boolean beforeChange)
   at ReactiveUI.ReactiveNotifyPropertyChangedMixin.<>c__DisplayClass12`2.<>c__DisplayClass14.<SubscribeToExpressionChain>b__d(IObservedChange`2 y)
   at System.Reactive.Linq.ObservableImpl.Select`2._.OnNext(TSource value)
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Reactive.PlatformServices.ExceptionServicesImpl.Rethrow(Exception exception)
   at System.Reactive.ExceptionHelpers.Throw(Exception exception)
   at System.Reactive.Stubs.<.cctor>b__1(Exception ex)
   at System.Reactive.AnonymousSafeObserver`1.OnError(Exception error)
   at System.Reactive.Linq.ObservableImpl.Select`2._.OnError(Exception error)
   at System.Reactive.Linq.ObservableImpl.Switch`1._.Iter.OnError(Exception error)
   at System.Reactive.Linq.ObservableImpl.Select`2._.OnError(Exception error)
   at System.Reactive.Linq.ObservableImpl.DistinctUntilChanged`2._.OnError(Exception error)
   at System.Reactive.Linq.ObservableImpl.Select`2._.OnError(Exception error)
   at System.Reactive.Linq.ObservableImpl.Where`1._.OnError(Exception error)
   at System.Reactive.Linq.ObservableImpl.Switch`1._.OnError(Exception error)
   at System.Reactive.Linq.ObservableImpl.Select`2._.OnNext(TSource value)
   at System.Reactive.Linq.ObservableImpl.Return`1._.Invoke()
   at System.Reactive.Concurrency.Scheduler.Invoke(IScheduler scheduler, Action action)
   at System.Reactive.Concurrency.ImmediateScheduler.Schedule[TState](TState state, Func`3 action)
   at System.Reactive.Concurrency.Scheduler.Schedule(IScheduler scheduler, Action action)
   at System.Reactive.Linq.ObservableImpl.Return`1._.Run()
   at System.Reactive.Linq.ObservableImpl.Return`1.Run(IObserver`1 observer, IDisposable cancel, Action`1 setSink)
   at System.Reactive.Producer`1.SubscribeRaw(IObserver`1 observer, Boolean enableSafeguard)
   at System.ObservableExtensions.SubscribeSafe[T](IObservable`1 source, IObserver`1 observer)
   at System.Reactive.Linq.ObservableImpl.Select`2.Run(IObserver`1 observer, IDisposable cancel, Action`1 setSink)
   at System.Reactive.Producer`1.SubscribeRaw(IObserver`1 observer, Boolean enableSafeguard)
   at System.ObservableExtensions.SubscribeSafe[T](IObservable`1 source, IObserver`1 observer)
   at System.Reactive.Linq.ObservableImpl.Switch`1._.Run()
   at System.Reactive.Linq.ObservableImpl.Switch`1.Run(IObserver`1 observer, IDisposable cancel, Action`1 setSink)
   at System.Reactive.Producer`1.SubscribeRaw(IObserver`1 observer, Boolean enableSafeguard)
   at System.ObservableExtensions.SubscribeSafe[T](IObservable`1 source, IObserver`1 observer)
   at System.Reactive.Linq.ObservableImpl.Where`1.Run(IObserver`1 observer, IDisposable cancel, Action`1 setSink)
   at System.Reactive.Producer`1.SubscribeRaw(IObserver`1 observer, Boolean enableSafeguard)
   at System.ObservableExtensions.SubscribeSafe[T](IObservable`1 source, IObserver`1 observer)
   at System.Reactive.Linq.ObservableImpl.Select`2.Run(IObserver`1 observer, IDisposable cancel, Action`1 setSink)
   at System.Reactive.Producer`1.SubscribeRaw(IObserver`1 observer, Boolean enableSafeguard)
   at System.ObservableExtensions.SubscribeSafe[T](IObservable`1 source, IObserver`1 observer)
   at System.Reactive.Linq.ObservableImpl.DistinctUntilChanged`2.Run(IObserver`1 observer, IDisposable cancel, Action`1 setSink)
   at System.Reactive.Producer`1.SubscribeRaw(IObserver`1 observer, Boolean enableSafeguard)
   at System.ObservableExtensions.SubscribeSafe[T](IObservable`1 source, IObserver`1 observer)
   at System.Reactive.Linq.ObservableImpl.Select`2.Run(IObserver`1 observer, IDisposable cancel, Action`1 setSink)
   at System.Reactive.Producer`1.Run(IScheduler _, State x)
   at System.Reactive.Concurrency.ScheduledItem`2.InvokeCore()
   at System.Reactive.Concurrency.ScheduledItem`1.Invoke()
   at System.Reactive.Concurrency.CurrentThreadScheduler.Trampoline.Run(SchedulerQueue`1 queue)
   at System.Reactive.Concurrency.CurrentThreadScheduler.Schedule[TState](TState state, TimeSpan dueTime, Func`3 action)
   at System.Reactive.Concurrency.LocalScheduler.Schedule[TState](TState state, Func`3 action)
   at System.Reactive.Producer`1.SubscribeRaw(IObserver`1 observer, Boolean enableSafeguard)
   at System.ObservableExtensions.SubscribeSafe[T](IObservable`1 source, IObserver`1 observer)
   at System.Reactive.Linq.ObservableImpl.Switch`1._.OnNext(IObservable`1 value)
   at System.Reactive.Linq.ObservableImpl.Merge`1._.Iter.OnNext(TSource value)
   at System.Reactive.Linq.ObservableImpl.Select`2._.OnNext(TSource value)
   at System.Reactive.Observer`1.OnNext(T value)
   at System.Reactive.Subjects.Subject`1.OnNext(T value)
   at System.Reactive.Linq.ObservableImpl.FromEventPattern.Impl`2.<>c__DisplayClass4.<GetHandler>b__0(Object sender, TEventArgs eventArgs)
   at MS.Internal.CoreInvokeHandler.InvokeEventHandler(Int32 typeIndex, Delegate handlerDelegate, Object sender, Object args)
   at MS.Internal.JoltHelper.FireEvent(IntPtr unmanagedObj, IntPtr unmanagedObjArgs, Int32 argsTypeIndex, Int32 actualArgsTypeIndex, String eventName)}
```
