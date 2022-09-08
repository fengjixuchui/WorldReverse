/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class ObjectPoolForStat<T> // TypeDefIndex: 27832
	where T : class
{
	// Fields
	private static Stack<T> _cache;

	// Methods
	public static T Allocate() => default;
	public static T Allocate(ref bool isNew) => default;
	public static void Deallocate(T instance) {}
	public static void ReleaseAllCache() {}
	public static int CachePoolCount() => default;
}

