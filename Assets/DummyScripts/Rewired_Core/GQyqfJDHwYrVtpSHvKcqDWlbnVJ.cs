/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

internal static class GQyqfJDHwYrVtpSHvKcqDWlbnVJ // TypeDefIndex: 4352
{
	// Nested types
	[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
	public delegate void EventFunction<T, TArgs>(T handler, TArgs value); // TypeDefIndex: 4353; 0x00000000-0x00000000

	[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
	[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
	public class HierarchyEventHelper<THandler, TValue> // TypeDefIndex: 4354
		where THandler : class
	{
		// Fields
		private readonly EventFunction<THandler, TValue> NYrjaeoFUBtElladMRkqaaiSfGs;
		private readonly List<THandler> hfyTPrEgDDYcWcMenreZUEIDhYBC;
		private readonly etabyBPtLZGexHfniBlZwQjQzulJ zsGZaANDMwjznPEzkQuGfNxxzfP;

		// Nested types
		[Flags] // 0x000000018990A800-0x000000018990A810
		public enum etabyBPtLZGexHfniBlZwQjQzulJ // TypeDefIndex: 4355
		{
			doFtcjAfrygYQXECsZOVnHNlHWm = -1,
			TCGihQKDgeeGtvEXifcuojmabzj = 0,
			zObnXUAQjuELSOKdkpgPxHrSqyO = 1,
			LNdKYuuukcmEUWWnVSjYrthVBue = 4,
			gJnvwjXDFJBcXQFEZiklAxTlVJE = 8
		}

		// Constructors
		public HierarchyEventHelper() {} // Dummy constructor
		public HierarchyEventHelper(EventFunction<THandler, TValue> executeDelegate) {}
		public HierarchyEventHelper(EventFunction<THandler, TValue> executeDelegate, etabyBPtLZGexHfniBlZwQjQzulJ executeOn) {}

		// Methods
		public void ExecuteOnAll(TValue value) {}
		public void GetHandlers(Transform transform) {}
	}

	// Methods
	public static void qJunMJiTJzbfTYhGhPVzXyqqhTQ<T, TArgs>(IList<T> param_000090f4, TArgs param_000090f5, EventFunction<T, TArgs> param_000090f6, bool param_000090f7)
		where T : class {}
}

