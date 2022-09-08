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
	public class ListAmortizedTickHelper : ListAmortizedUpdateHelper<MoleMole.IAmortizedTicker> // TypeDefIndex: 10457
	{
		// Nested types
		public class Spawner : ISpawner<ListAmortizedTickHelper> // TypeDefIndex: 10458
		{
			// Constructors
			public Spawner() {} // 0x0000000189C01060-0x0000000189C010C0
	
			// Methods
			// [XID] // 0x0000000189ADE400-0x0000000189ADE420
			public ListAmortizedTickHelper Spawn() => default; // 0x0000000189C00E30-0x0000000189C00F00
		}
	
		public class Polisher : IPolisher<ListAmortizedTickHelper> // TypeDefIndex: 10459
		{
			// Constructors
			public Polisher() {} // 0x0000000189BFE460-0x0000000189BFE4C0
	
			// Methods
			// [XID] // 0x0000000189B30070-0x0000000189B30090
			public void Polish(ListAmortizedTickHelper instance) {} // 0x0000000189BFE250-0x0000000189BFE310
		}
	
		// Constructors
		public ListAmortizedTickHelper() {} // 0x0000000189BF4B50-0x0000000189BF4BE0
	
		// Methods
		// [XID] // 0x00000001899E0E50-0x00000001899E0E70
		protected override void DoFirstUpdate(IAmortizedTicker inElement, float globalTime, float deltaTime) {} // 0x0000000189BF4930-0x0000000189BF4A40
		// [XID] // 0x0000000189ACEC10-0x0000000189ACEC30
		protected override void DoUpdate(IAmortizedTicker inElement, float globalTime) {} // 0x0000000189BF4A40-0x0000000189BF4B50
	}
}
