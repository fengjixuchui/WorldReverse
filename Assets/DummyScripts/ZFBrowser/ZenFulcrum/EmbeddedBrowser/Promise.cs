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
	public class Promise : IPromise, IPendingPromise, IPromiseInfo // TypeDefIndex: 6126
	{
		// Fields
		public static bool EnablePromiseTracking; // 0x00
		private static EventHandler<ExceptionEventArgs> unhandlerException; // 0x08
		internal static int nextPromiseId; // 0x10
		internal static HashSet<IPromiseInfo> pendingPromises; // 0x18
		private Exception rejectionException; // 0x10
		private List<RejectHandler> rejectHandlers; // 0x18
		private List<ResolveHandler> resolveHandlers; // 0x20
	
		// Properties
		public int Id { get; private set; } // 0x00000001856BCBB0-0x00000001856BCC10 0x00000001856BCDA0-0x00000001856BCE00
		public string Name { get; private set; } // 0x00000001856BCC10-0x00000001856BCC70 0x00000001856BCE00-0x00000001856BCEA0
		public PromiseState CurState { get; private set; } // 0x00000001856BCB50-0x00000001856BCBB0 0x00000001856BCD40-0x00000001856BCDA0
	
		// Events
		public static event EventHandler<ExceptionEventArgs> UnhandledException;
	
		// Nested types
		public struct ResolveHandler // TypeDefIndex: 6127
		{
			// Fields
			public Action callback; // 0x00
			public IRejectable rejectable; // 0x08
		}
	
		private class Enumerated : IEnumerator // TypeDefIndex: 6128
		{
			// Fields
			private Promise promise; // 0x10
			private bool abortOnFail; // 0x18
	
			// Properties
			public object Current { get => default; } // 0x00000001856AB210-0x00000001856AB260 
	
			// Constructors
			public Enumerated() {} // Dummy constructor
			public Enumerated(Promise promise, bool abortOnFail) {} // 0x00000001856AB180-0x00000001856AB210
	
			// Methods
			public bool MoveNext() => default; // 0x00000001856AB000-0x00000001856AB130
			public void Reset() {} // 0x00000001856AB130-0x00000001856AB180
		}
	
		// Constructors
		static Promise() {} // 0x00000001856BC6A0-0x00000001856BC790
		public Promise() {} // 0x00000001856BC790-0x00000001856BC8B0
		public Promise(Action<Action, Action<Exception>> resolver) {} // 0x00000001856BC8B0-0x00000001856BCA80
	
		// Methods
		public static IEnumerable<IPromiseInfo> GetPendingPromises() => default; // 0x00000001856BA350-0x00000001856BA3E0
		private void AddRejectHandler(Action<Exception> onRejected, IRejectable rejectable) {} // 0x00000001856B9AE0-0x00000001856B9BB0
		private void AddResolveHandler(Action onResolved, IRejectable rejectable) {} // 0x00000001856B9BB0-0x00000001856B9C80
		private void InvokeRejectHandler(Action<Exception> callback, IRejectable rejectable, Exception value) {} // 0x00000001856BA3E0-0x00000001856BA490
		private void InvokeResolveHandler(Action callback, IRejectable rejectable) {} // 0x00000001856BA600-0x00000001856BA6A0
		private void ClearHandlers() {} // 0x00000001856BA0A0-0x00000001856BA100
		private void InvokeRejectHandlers(Exception ex) {} // 0x00000001856BA490-0x00000001856BA600
		private void InvokeResolveHandlers() {} // 0x00000001856BA6A0-0x00000001856BA790
		public void Reject(Exception ex) {} // 0x00000001856BAAF0-0x00000001856BAE90
		public void Resolve() {} // 0x00000001856BAF30-0x00000001856BB2B0
		public void Done(Action onResolved, Action<Exception> onRejected) {} // 0x00000001856BA1B0-0x00000001856BA280
		public void Done(Action onResolved) {} // 0x00000001856BA280-0x00000001856BA350
		public void Done() {} // 0x00000001856BA100-0x00000001856BA1B0
		public IPromise WithName(string name) => default; // 0x00000001856BC600-0x00000001856BC6A0
		public IPromise Catch(Action<Exception> onRejected) => default; // 0x00000001856B9EC0-0x00000001856BA0A0
		public IPromise<ConvertedT> Then<ConvertedT>(Func<IPromise<ConvertedT>> onResolved) => default;
		public IPromise Then(Func<IPromise> onResolved) => default; // 0x00000001856BBA40-0x00000001856BBAC0
		public IPromise Then(Action onResolved) => default; // 0x00000001856BBCA0-0x00000001856BBD20
		public IPromise<ConvertedT> Then<ConvertedT>(Func<IPromise<ConvertedT>> onResolved, Action<Exception> onRejected) => default;
		public IPromise Then(Func<IPromise> onResolved, Action<Exception> onRejected) => default; // 0x00000001856BB860-0x00000001856BBA40
		public IPromise Then(Action onResolved, Action<Exception> onRejected) => default; // 0x00000001856BBAC0-0x00000001856BBCA0
		private void ActionHandlers(IRejectable resultPromise, Action resolveHandler, Action<Exception> rejectHandler) {} // 0x00000001856B9990-0x00000001856B9AE0
		public IPromise ThenAll(Func<IEnumerable<IPromise>> chain) => default; // 0x00000001856BB530-0x00000001856BB640
		public IPromise<IEnumerable<ConvertedT>> ThenAll<ConvertedT>(Func<IEnumerable<IPromise<ConvertedT>>> chain) => default;
		public static IPromise All(params /* 0x000000018989F6F0-0x000000018989F700 */ IPromise[] promises) => default; // 0x00000001856B9E30-0x00000001856B9EC0
		public static IPromise All(IEnumerable<IPromise> promises) => default; // 0x00000001856B9C80-0x00000001856B9E30
		public IPromise ThenSequence(Func<IEnumerable<Func<IPromise>>> chain) => default; // 0x00000001856BB750-0x00000001856BB860
		public static IPromise Sequence(params /* 0x000000018989F6F0-0x000000018989F700 */ Func<IPromise>[] fns) => default; // 0x00000001856BB340-0x00000001856BB3D0
		public static IPromise Sequence(IEnumerable<Func<IPromise>> fns) => default; // 0x00000001856BB3D0-0x00000001856BB530
		public IPromise ThenRace(Func<IEnumerable<IPromise>> chain) => default; // 0x00000001856BB640-0x00000001856BB750
		public IPromise<ConvertedT> ThenRace<ConvertedT>(Func<IEnumerable<IPromise<ConvertedT>>> chain) => default;
		public static IPromise Race(params /* 0x000000018989F6F0-0x000000018989F700 */ IPromise[] promises) => default; // 0x00000001856BA8B0-0x00000001856BA940
		public static IPromise Race(IEnumerable<IPromise> promises) => default; // 0x00000001856BA940-0x00000001856BAAF0
		public static IPromise Resolved() => default; // 0x00000001856BB2B0-0x00000001856BB340
		public static IPromise Rejected(Exception ex) => default; // 0x00000001856BAE90-0x00000001856BAF30
		internal static void PropagateUnhandledException(object sender, Exception ex) {} // 0x00000001856BA790-0x00000001856BA8B0
		public IEnumerator ToWaitFor(bool abortOnFail = false /* Metadata: 0x00ADBC79 */) => default; // 0x00000001856BBD20-0x00000001856BBF30
	}
}
