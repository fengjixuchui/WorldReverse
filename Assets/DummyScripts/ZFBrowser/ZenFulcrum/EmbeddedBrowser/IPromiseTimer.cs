/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.EmbeddedBrowser
{
	public interface IPromiseTimer // TypeDefIndex: 6144
	{
		// Methods
		IPromise WaitFor(float seconds);
		IPromise WaitUntil(Func<TimeData, bool> predicate);
		IPromise WaitWhile(Func<TimeData, bool> predicate);
		void Update(float deltaTime);
	}
}
