/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.EmbeddedBrowser
{
	public class Promise<PromisedT> : IPromise<PromisedT>, IPendingPromise<PromisedT>, IPromiseInfo // TypeDefIndex: 6105
	{
		// Fields
		private Exception rejectionException;
		private PromisedT resolveValue;
		private List<RejectHandler> rejectHandlers;
		private List<Action<PromisedT>> resolveCallbacks;
		private List<IRejectable> resolveRejectables;
	
		// Properties
		public int Id { get; private set; }
		public string Name { get; private set; }
		public PromiseState CurState { get; private set; }
		public PromisedT Value { get => default; }
	
		// Nested types
		private class Enumerated<T> : IEnumerator // TypeDefIndex: 6106
		{
			// Fields
			private Promise<T> promise;
			private bool abortOnFail;
	
			// Properties
			public object Current { get => default; }
	
			// Constructors
			public Enumerated() {} // Dummy constructor
			public Enumerated(Promise<T> promise, bool abortOnFail) {}
	
			// Methods
			public bool MoveNext() => default;
			public void Reset() {}
		}
	
		// Constructors
		public Promise() {}
		public Promise(Action<Action<PromisedT>, Action<Exception>> resolver) {}
	
		// Methods
		private void AddRejectHandler(Action<Exception> onRejected, IRejectable rejectable) {}
		private void AddResolveHandler(Action<PromisedT> onResolved, IRejectable rejectable) {}
		private void InvokeHandler<T>(Action<T> callback, IRejectable rejectable, T value) {}
		private void ClearHandlers() {}
		private void InvokeRejectHandlers(Exception ex) {}
		private void InvokeResolveHandlers(PromisedT value) {}
		public void Reject(Exception ex) {}
		public void Resolve(PromisedT value) {}
		public void Done(Action<PromisedT> onResolved, Action<Exception> onRejected) {}
		public void Done(Action<PromisedT> onResolved) {}
		public void Done() {}
		public IPromise<PromisedT> WithName(string name) => default;
		public IPromise<PromisedT> Catch(Action<Exception> onRejected) => default;
		public IPromise<ConvertedT> Then<ConvertedT>(Func<PromisedT, IPromise<ConvertedT>> onResolved) => default;
		public IPromise Then(Func<PromisedT, IPromise> onResolved) => default;
		public IPromise<PromisedT> Then(Action<PromisedT> onResolved) => default;
		public IPromise<ConvertedT> Then<ConvertedT>(Func<PromisedT, IPromise<ConvertedT>> onResolved, Action<Exception> onRejected) => default;
		public IPromise Then(Func<PromisedT, IPromise> onResolved, Action<Exception> onRejected) => default;
		public IPromise<PromisedT> Then(Action<PromisedT> onResolved, Action<Exception> onRejected) => default;
		public IPromise<ConvertedT> Then<ConvertedT>(Func<PromisedT, ConvertedT> transform) => default;
		[Obsolete] // 0x0000000189A03910-0x0000000189A03940
		public IPromise<ConvertedT> Transform<ConvertedT>(Func<PromisedT, ConvertedT> transform) => default;
		private void ActionHandlers(IRejectable resultPromise, Action<PromisedT> resolveHandler, Action<Exception> rejectHandler) {}
		public IPromise<IEnumerable<ConvertedT>> ThenAll<ConvertedT>(Func<PromisedT, IEnumerable<IPromise<ConvertedT>>> chain) => default;
		public IPromise ThenAll(Func<PromisedT, IEnumerable<IPromise>> chain) => default;
		public static IPromise<IEnumerable<PromisedT>> All(params /* 0x000000018989F6F0-0x000000018989F700 */ IPromise<PromisedT>[] promises) => default;
		public static IPromise<IEnumerable<PromisedT>> All(IEnumerable<IPromise<PromisedT>> promises) => default;
		public IPromise<ConvertedT> ThenRace<ConvertedT>(Func<PromisedT, IEnumerable<IPromise<ConvertedT>>> chain) => default;
		public IPromise ThenRace(Func<PromisedT, IEnumerable<IPromise>> chain) => default;
		public IEnumerator ToWaitFor(bool abortOnFail) => default;
		public static IPromise<PromisedT> Race(params /* 0x000000018989F6F0-0x000000018989F700 */ IPromise<PromisedT>[] promises) => default;
		public static IPromise<PromisedT> Race(IEnumerable<IPromise<PromisedT>> promises) => default;
		public static IPromise<PromisedT> Resolved(PromisedT promisedValue) => default;
		public static IPromise<PromisedT> Rejected(Exception ex) => default;
	}
}
