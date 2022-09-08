/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class BundleLoadResultReceiver : IReusable // TypeDefIndex: 7406
	{
		// Fields
		public BundleLoadResult result; // 0x10
		public int bundleHash; // 0x14
	
		// Nested types
		public class Spawner : ISpawner<BundleLoadResultReceiver> // TypeDefIndex: 7407
		{
			// Constructors
			public Spawner() {} // 0x0000000186905370-0x00000001869053D0
	
			// Methods
			// [XID] // 0x00000001895FBDF0-0x00000001895FBE10
			public BundleLoadResultReceiver Spawn() => default; // 0x0000000186904F50-0x0000000186905050
		}
	
		// Constructors
		public BundleLoadResultReceiver() {} // 0x00000001868F70A0-0x00000001868F7110
	
		// Methods
		// [XID] // 0x00000001895F4580-0x00000001895F45A0
		public void BeforeRecycle() {} // 0x00000001868F7000-0x00000001868F70A0
	}
}
