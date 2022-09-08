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
	public class SeperateBundleLoadJob : BundleLoadJob // TypeDefIndex: 7408
	{
		// Fields
		private uint _bundleCreateRequest; // 0x28
		public static int jobCount; // 0x00
		public static float maxRequestInterval; // 0x04
		private float _requestTime; // 0x2C
		public static Action<string, float> onLoadFinish; // 0x08
	
		// Nested types
		public class Spawner : ISpawner<SeperateBundleLoadJob, int, BundleLoadResultReceiver> // TypeDefIndex: 7409
		{
			// Constructors
			public Spawner() {} // 0x00000001868A9A70-0x00000001868A9AD0
	
			// Methods
			// [XID] // 0x0000000189630430-0x0000000189630450
			public SeperateBundleLoadJob Spawn(int param1, BundleLoadResultReceiver param2) => default; // 0x00000001868A9860-0x00000001868A9940
		}
	
		public class Polisher : IPolisher<SeperateBundleLoadJob, int, BundleLoadResultReceiver> // TypeDefIndex: 7410
		{
			// Constructors
			public Polisher() {} // 0x000000018689ECA0-0x000000018689ED00
	
			// Methods
			// [XID] // 0x00000001899D8050-0x00000001899D8070
			public void Polish(SeperateBundleLoadJob reused, int param1, BundleLoadResultReceiver param2) {} // 0x000000018689EAA0-0x000000018689EBC0
		}
	
		// Constructors
		public SeperateBundleLoadJob() {} // Dummy constructor
		public SeperateBundleLoadJob(int bundleHash, BundleLoadResultReceiver resultReceiver) {} // 0x00000001868A2310-0x00000001868A23A0
		static SeperateBundleLoadJob() {} // 0x00000001868A22B0-0x00000001868A2310
	
		// Methods
		// [XID] // 0x0000000189603640-0x0000000189603660
		public override void Start() {} // 0x00000001868A1AA0-0x00000001868A1D90
		// [XID] // 0x000000018960B0C0-0x000000018960B0E0
		public override void Tick() {} // 0x00000001868A1F00-0x00000001868A21F0
		// [XID] // 0x0000000189612500-0x0000000189612520
		public override void Abort(bool byUser) {} // 0x00000001868A1840-0x00000001868A18F0
		// [XID] // 0x0000000189619E10-0x0000000189619E30
		public override void Sync() {} // 0x00000001868A1D90-0x00000001868A1F00
		// [XID] // 0x00000001896212B0-0x00000001896212D0
		public override void BeforeRecycle() {} // 0x00000001868A18F0-0x00000001868A19E0
		// [XID] // 0x0000000189628BA0-0x0000000189628BC0
		public override void Recycle() {} // 0x00000001868A19E0-0x00000001868A1AA0
	}
}
