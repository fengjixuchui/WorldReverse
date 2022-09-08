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
	public interface IPromise<PromisedT> // TypeDefIndex: 6101
	{
		// Properties
		PromisedT Value { get; }
	
		// Methods
		IPromise<PromisedT> WithName(string name);
		void Done(Action<PromisedT> onResolved, Action<Exception> onRejected);
		void Done(Action<PromisedT> onResolved);
		void Done();
		IPromise<PromisedT> Catch(Action<Exception> onRejected);
		IPromise<ConvertedT> Then<ConvertedT>(Func<PromisedT, IPromise<ConvertedT>> onResolved);
		IPromise Then(Func<PromisedT, IPromise> onResolved);
		IPromise<PromisedT> Then(Action<PromisedT> onResolved);
		IPromise<ConvertedT> Then<ConvertedT>(Func<PromisedT, IPromise<ConvertedT>> onResolved, Action<Exception> onRejected);
		IPromise Then(Func<PromisedT, IPromise> onResolved, Action<Exception> onRejected);
		IPromise<PromisedT> Then(Action<PromisedT> onResolved, Action<Exception> onRejected);
		IPromise<ConvertedT> Then<ConvertedT>(Func<PromisedT, ConvertedT> transform);
		[Obsolete] // 0x0000000189A03910-0x0000000189A03940
		IPromise<ConvertedT> Transform<ConvertedT>(Func<PromisedT, ConvertedT> transform);
		IPromise<IEnumerable<ConvertedT>> ThenAll<ConvertedT>(Func<PromisedT, IEnumerable<IPromise<ConvertedT>>> chain);
		IPromise ThenAll(Func<PromisedT, IEnumerable<IPromise>> chain);
		IPromise<ConvertedT> ThenRace<ConvertedT>(Func<PromisedT, IEnumerable<IPromise<ConvertedT>>> chain);
		IPromise ThenRace(Func<PromisedT, IEnumerable<IPromise>> chain);
		IEnumerator ToWaitFor(bool abortOnFail = false /* Metadata: 0x00ADBC6B */);
	}
}
