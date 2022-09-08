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
	public class BinDataReceiver : ILoadedResourceReceiverOfBinData, IReusable // TypeDefIndex: 7382
	{
		// Fields
		private CallbackStatHelper _csh; // 0x10
		private ResultHandler _onFinishStub; // 0x18
	
		// Properties
		private ResultHandler _onFinish { /* [XID] */ /* 0x0000000189985450-0x0000000189985470 */ get => default; /* [XID] */ /* 0x000000018998CEC0-0x000000018998CEE0 */ set {} } // 0x00000001868F3180-0x00000001868F3220 0x00000001868F32C0-0x00000001868F3390
		public bool dropEarly { /* [XID] */ /* 0x0000000189994C40-0x0000000189994C60 */ get => default; } // 0x00000001868F3220-0x00000001868F32C0 
	
		// Nested types
		public delegate void ResultHandler(ulong pathHash, bool loadSucceeded, byte[] bytes); // TypeDefIndex: 7383; 0x0000000186904BA0-0x0000000186904D80
	
		public class Spawner : ISpawner<BinDataReceiver, ResultHandler> // TypeDefIndex: 7384
		{
			// Constructors
			public Spawner() {} // 0x0000000186905310-0x0000000186905370
	
			// Methods
			// [XID] // 0x00000001899C1FF0-0x00000001899C2010
			public BinDataReceiver Spawn(ResultHandler param1) => default; // 0x0000000186905050-0x0000000186905120
		}
	
		public class Polisher : IPolisher<BinDataReceiver, ResultHandler> // TypeDefIndex: 7385
		{
			// Constructors
			public Polisher() {} // 0x0000000186903FE0-0x0000000186904040
	
			// Methods
			// [XID] // 0x00000001899C9360-0x00000001899C9380
			public void Polish(BinDataReceiver reused, ResultHandler param1) {} // 0x0000000186903E10-0x0000000186903EF0
		}
	
		// Constructors
		public BinDataReceiver() {} // Dummy constructor
		private BinDataReceiver(ResultHandler onFinish) {} // 0x00000001868F3100-0x00000001868F3180
	
		// Methods
		// [XID] // 0x000000018999C480-0x000000018999C4A0
		public void BeforeRecycle() {} // 0x00000001868F2D40-0x00000001868F2DE0
		// [XID] // 0x00000001899A3DE0-0x00000001899A3E00
		public void Fail(ulong pathHash, ResourceLoadFailureReason reason) {} // 0x00000001868F2DE0-0x00000001868F2EE0
		// [XID] // 0x00000001899AB9B0-0x00000001899AB9D0
		public void Receive(ulong pathHash, byte[] bytes) {} // 0x00000001868F2EE0-0x00000001868F3040
		// [XID] // 0x00000001899B3290-0x00000001899B32B0
		public void AddOnFinishHandler(ResultHandler onFinish) {} // 0x00000001868F2C50-0x00000001868F2D40
		// [XID] // 0x00000001899BA5C0-0x00000001899BA5E0
		public void Recycle() {} // 0x00000001868F3040-0x00000001868F3100
	}
}
