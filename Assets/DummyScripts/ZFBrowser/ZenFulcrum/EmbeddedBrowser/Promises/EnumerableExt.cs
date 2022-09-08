/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 52: ZFBrowser.dll - Assembly: ZFBrowser, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5943-6607

namespace ZenFulcrum.EmbeddedBrowser.Promises
{
	public static class EnumerableExt // TypeDefIndex: 6099
	{
		// Methods
		public static IEnumerable<T> Empty<T>() => default;
	
		// Extension methods
		[DebuggerHidden] // 0x0000000189793020-0x0000000189793050
		public static IEnumerable<T> LazyEach<T>(this IEnumerable<T> source, Action<T> fn) => default;
		public static void Each<T>(this IEnumerable<T> source, Action<T> fn) {}
		public static void Each<T>(this IEnumerable<T> source, Action<T, int> fn) {}
	}
}
