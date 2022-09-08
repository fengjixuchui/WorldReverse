/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public abstract class BundleLoadJob : ResourceJob // TypeDefIndex: 7405
	{
		// Fields
		protected List<BundleLoadResultReceiver> _resultReceiver; // 0x20
	
		// Properties
		public int bundleHash { /* [XID] */ /* 0x0000000189BB1B00-0x0000000189BB1B40 */ get; /* [XID] */ /* 0x0000000189AAA590-0x0000000189AAA5D0 */ set; } // 0x00000001868F6910-0x00000001868F6970 0x00000001868F69D0-0x00000001868F6A30
		public static AssetBundleExternalResourceProvider.IBundleLoadProxy resourcesProxy { /* [XID] */ /* 0x0000000189BC6810-0x0000000189BC6850 */ get; set; } // 0x00000001868F6970-0x00000001868F69D0 0x00000001868F6A30-0x00000001868F6A90
	
		// Constructors
		protected BundleLoadJob() {} // Dummy constructor
		public BundleLoadJob(int bundleHash, BundleLoadResultReceiver resultReceiver) {} // 0x00000001868F6820-0x00000001868F6910
	
		// Methods
		// [XID] // 0x0000000189BD8A00-0x0000000189BD8A20
		public void LoadFinish(BundleLoadResult result) {} // 0x00000001868F65B0-0x00000001868F67C0
		// [XID] // 0x0000000189BE00D0-0x0000000189BE0330
		public void AddResultReceiver(BundleLoadResultReceiver resultReceiver) {} // 0x00000001868F6360-0x00000001868F6430
		// [XID] // 0x00000001895ECEE0-0x00000001895ECF00
		public override void BeforeRecycle() {} // 0x00000001868F6430-0x00000001868F65B0
	}
}
