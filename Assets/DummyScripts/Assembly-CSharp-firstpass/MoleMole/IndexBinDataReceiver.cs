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
	public class IndexBinDataReceiver : ComplexLoadedResourceReceiverOfBinData, IReusable, IJobProxy // TypeDefIndex: 7387
	{
		// Fields
		private CallbackStatHelper _csh; // 0x10
		private IndexResultHandler _onFinishStub; // 0x18
		private int _index; // 0x20
		private bool _dropEarly; // 0x24
	
		// Properties
		private IndexResultHandler _onFinish { /* [XID] */ /* 0x00000001899D0ED0-0x00000001899D0EF0 */ get => default; /* [XID] */ /* 0x00000001899D8390-0x00000001899D83B0 */ set {} } // 0x0000000189BF3460-0x0000000189BF3500 0x0000000189BF35A0-0x0000000189BF3670
		public bool dropEarly { /* [XID] */ /* 0x00000001899F61E0-0x00000001899F6200 */ get => default; } // 0x0000000189BF3500-0x0000000189BF35A0 
	
		// Nested types
		public delegate void IndexResultHandler(int index, ulong pathHash, bool loadSucceeded, byte[] bytes); // TypeDefIndex: 7388; 0x0000000189BF37D0-0x0000000189BF3A10
	
		public class Spawner : ISpawner<IndexBinDataReceiver, IndexResultHandler, int> // TypeDefIndex: 7389
		{
			// Constructors
			public Spawner() {} // 0x0000000189C01000-0x0000000189C01060
	
			// Methods
			// [XID] // 0x0000000189A31180-0x0000000189A311A0
			public IndexBinDataReceiver Spawn(IndexResultHandler param1, int param2) => default; // 0x0000000189C00C80-0x0000000189C00D60
		}
	
		public class Polisher : IPolisher<IndexBinDataReceiver, IndexResultHandler, int> // TypeDefIndex: 7390
		{
			// Constructors
			public Polisher() {} // 0x0000000189BFE4C0-0x0000000189BFE520
	
			// Methods
			// [XID] // 0x0000000189A38E50-0x0000000189A38E70
			public void Polish(IndexBinDataReceiver reused, IndexResultHandler param1, int param2) {} // 0x0000000189BFE310-0x0000000189BFE400
		}
	
		// Constructors
		public IndexBinDataReceiver() {} // Dummy constructor
		private IndexBinDataReceiver(IndexResultHandler onFinish, int index) {} // 0x0000000189BF33D0-0x0000000189BF3460
	
		// Methods
		// [XID] // 0x00000001899DF960-0x00000001899DF980
		public bool CheckVoucher(object callback) => default; // 0x0000000189BF2D50-0x0000000189BF2E30
		// [XID] // 0x00000001899E7490-0x00000001899E74B0
		public object GetVoucher() => default; // 0x0000000189BF30F0-0x0000000189BF31A0
		// [XID] // 0x00000001899EE980-0x00000001899EE9A0
		public void Abort(bool byUser) {} // 0x0000000189BF2B00-0x0000000189BF2BC0
		// [XID] // 0x00000001899FD8B0-0x00000001899FD8D0
		public void BeforeRecycle() {} // 0x0000000189BF2CB0-0x0000000189BF2D50
		// [XID] // 0x0000000189A04F00-0x0000000189A04F20
		public void Fail(ulong pathHash, ResourceLoadFailureReason reason) {} // 0x0000000189BF2F00-0x0000000189BF3000
		// [XID] // 0x0000000189A0C5F0-0x0000000189A0C610
		public void Receive(ulong pathHash, byte[] bytes) {} // 0x0000000189BF31A0-0x0000000189BF3310
		// [XID] // 0x0000000189A13F50-0x0000000189A13F70
		public void AddOnFinishHandler(IndexResultHandler onFinish) {} // 0x0000000189BF2BC0-0x0000000189BF2CB0
		// [XID] // 0x0000000189A1B1A0-0x0000000189A1B1C0
		public void Recycle() {} // 0x0000000189BF3310-0x0000000189BF33D0
		// [XID] // 0x0000000189A22B20-0x0000000189A22B40
		public void Dismiss(object voucher) {} // 0x0000000189BF2E30-0x0000000189BF2F00
		// [XID] // 0x0000000189A29C80-0x0000000189A29CA0
		public AsyncJob GetAbortJob() => default; // 0x0000000189BF3000-0x0000000189BF30F0
	}
}
