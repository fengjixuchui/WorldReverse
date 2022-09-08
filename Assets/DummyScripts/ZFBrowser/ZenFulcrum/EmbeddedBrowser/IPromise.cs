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
	public interface IPromise // TypeDefIndex: 6121
	{
		// Methods
		IPromise WithName(string name);
		void Done(Action onResolved, Action<Exception> onRejected);
		void Done(Action onResolved);
		void Done();
		IPromise Catch(Action<Exception> onRejected);
		IPromise<ConvertedT> Then<ConvertedT>(Func<IPromise<ConvertedT>> onResolved);
		IPromise Then(Func<IPromise> onResolved);
		IPromise Then(Action onResolved);
		IPromise<ConvertedT> Then<ConvertedT>(Func<IPromise<ConvertedT>> onResolved, Action<Exception> onRejected);
		IPromise Then(Func<IPromise> onResolved, Action<Exception> onRejected);
		IPromise Then(Action onResolved, Action<Exception> onRejected);
		IPromise ThenAll(Func<IEnumerable<IPromise>> chain);
		IPromise<IEnumerable<ConvertedT>> ThenAll<ConvertedT>(Func<IEnumerable<IPromise<ConvertedT>>> chain);
		IPromise ThenSequence(Func<IEnumerable<Func<IPromise>>> chain);
		IPromise ThenRace(Func<IEnumerable<IPromise>> chain);
		IPromise<ConvertedT> ThenRace<ConvertedT>(Func<IEnumerable<IPromise<ConvertedT>>> chain);
		IEnumerator ToWaitFor(bool abortOnFail = false /* Metadata: 0x00ADBC78 */);
	}
}
