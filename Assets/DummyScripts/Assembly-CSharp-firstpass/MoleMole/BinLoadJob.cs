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
	public class BinLoadJob : AssetLoadJob // TypeDefIndex: 7358
	{
		// Fields
		private ILoadedResourceReceiverOfBinData _receiver; // 0x30
		private ulong _hash; // 0x38
		private int _offset; // 0x40
		private int _length; // 0x44
		private bool _isAbort; // 0x48
		private ulong _handle; // 0x50
		private BundleLoadResultReceiver _bundleReceiver; // 0x58
	
		// Nested types
		public class Spawner : ISpawner<BinLoadJob, ResourceIdentifier, ILoadedResourceReceiverOfBinData, int, int, ulong> // TypeDefIndex: 7359
		{
			// Constructors
			public Spawner() {} // 0x0000000186905250-0x00000001869052B0
	
			// Methods
			// [XID] // 0x00000001899676E0-0x0000000189967700
			public BinLoadJob Spawn(ResourceIdentifier param1, ILoadedResourceReceiverOfBinData param2, int param3, int param4, ulong param5) => default; // 0x0000000186904E00-0x0000000186904F50
		}
	
		public class Polisher : IPolisher<BinLoadJob, ResourceIdentifier, ILoadedResourceReceiverOfBinData, int, int, ulong> // TypeDefIndex: 7360
		{
			// Constructors
			public Polisher() {} // 0x00000001869040A0-0x0000000186904100
	
			// Methods
			// [XID] // 0x000000018996E910-0x000000018996E930
			public void Polish(BinLoadJob reused, ResourceIdentifier param1, ILoadedResourceReceiverOfBinData param2, int param3, int param4, ulong param5) {} // 0x0000000186903C80-0x0000000186903E10
		}
	
		// Constructors
		public BinLoadJob() {} // Dummy constructor
		private BinLoadJob(ResourceIdentifier request, ILoadedResourceReceiverOfBinData receiver, int offset, int length, ulong hash) {} // 0x00000001868F50F0-0x00000001868F5290
	
		// Methods
		// [XID] // 0x00000001899246E0-0x0000000189924700
		public override void Start() {} // 0x00000001868F4560-0x00000001868F4720
		// [XID] // 0x000000018992BB40-0x000000018992BB60
		private void LoadBundle() {} // 0x00000001868F3ED0-0x00000001868F4320
		// [XID] // 0x00000001899331C0-0x00000001899331E0
		private void SyncLoad() {} // 0x00000001868F4720-0x00000001868F4920
		// [XID] // 0x000000018993ABD0-0x000000018993ABF0
		public override void Abort(bool byUser) {} // 0x00000001868F3BF0-0x00000001868F3CB0
		// [XID] // 0x0000000189941BB0-0x0000000189941BD0
		private void Finish() {} // 0x00000001868F3E30-0x00000001868F3ED0
		// [XID] // 0x00000001899497D0-0x00000001899497F0
		public override void Tick() {} // 0x00000001868F4920-0x00000001868F5090
		// [XID] // 0x0000000189950F90-0x0000000189950FB0
		public override void Recycle() {} // 0x00000001868F4440-0x00000001868F4560
		// [XID] // 0x00000001899587A0-0x00000001899587C0
		public override void BeforeRecycle() {} // 0x00000001868F3CB0-0x00000001868F3E30
		// [XID] // 0x000000018995FDD0-0x000000018995FDF0
		private void QuickFailAborted(bool drop = false /* Metadata: 0x00ADE9A2 */) {} // 0x00000001868F4320-0x00000001868F4440
	}
}
