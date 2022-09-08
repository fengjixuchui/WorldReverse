/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class LoadedAsset : IReusable // TypeDefIndex: 7547
	{
		// Fields
		public UnityEngine.Object asset; // 0x10
		public ObjectInstanceCache instanceCache; // 0x18
	
		// Nested types
		public class Spawner : ISpawner<LoadedAsset> // TypeDefIndex: 7548
		{
			// Constructors
			public Spawner() {} // 0x0000000189C010C0-0x0000000189C01120
	
			// Methods
			// [XID] // 0x000000018995B3F0-0x000000018995B410
			public LoadedAsset Spawn() => default; // 0x0000000189C00F00-0x0000000189C01000
		}
	
		// Constructors
		private LoadedAsset() {} // 0x0000000189BF4C80-0x0000000189BF4CE0
	
		// Methods
		// [XID] // 0x0000000189953C10-0x0000000189953C30
		public void BeforeRecycle() {} // 0x0000000189BF4BE0-0x0000000189BF4C80
	}
}
