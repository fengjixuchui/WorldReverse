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
	public class AssetUnloadJob : ResourceJob // TypeDefIndex: 7418
	{
		// Fields
		private const int WAIT = 3; // Metadata: 0x00ADE9B8
		private static readonly List<int> _reusedDependencyBundleList; // 0x00
		public static AssetBundleExternalResourceProvider.IAssetReleaseProxy releaser; // 0x08
		private ResourceIdentifier _request; // 0x18
		private int _startFrame; // 0x28
	
		// Properties
		public ResourceIdentifier request { /* [XID] */ /* 0x00000001896AB310-0x00000001896AB330 */ get => default; } // 0x00000001868EBBF0-0x00000001868EBCC0 
	
		// Nested types
		public class Spawner : ISpawner<AssetUnloadJob, ResourceIdentifier> // TypeDefIndex: 7419
		{
			// Constructors
			public Spawner() {} // 0x00000001869052B0-0x0000000186905310
	
			// Methods
			// [XID] // 0x00000001896D7540-0x00000001896D7560
			public AssetUnloadJob Spawn(ResourceIdentifier param1) => default; // 0x0000000186905120-0x0000000186905250
		}
	
		public class Polisher : IPolisher<AssetUnloadJob, ResourceIdentifier> // TypeDefIndex: 7420
		{
			// Constructors
			public Polisher() {} // 0x0000000186904040-0x00000001869040A0
	
			// Methods
			// [XID] // 0x00000001896DEEA0-0x00000001896DEEC0
			public void Polish(AssetUnloadJob reused, ResourceIdentifier param1) {} // 0x0000000186903EF0-0x0000000186903FE0
		}
	
		// Constructors
		public AssetUnloadJob() {} // Dummy constructor
		static AssetUnloadJob() {} // 0x00000001868EBAE0-0x00000001868EBB70
		public AssetUnloadJob(ResourceIdentifier request) {} // 0x00000001868EBB70-0x00000001868EBBF0
	
		// Methods
		// [XID] // 0x00000001896B2570-0x00000001896B2590
		public override void Start() {} // 0x00000001868EB6C0-0x00000001868EB760
		// [XID] // 0x0000000189A04C80-0x0000000189A04CA0
		public override void Tick() {} // 0x00000001868EB760-0x00000001868EBA80
		// [XID] // 0x00000001896C1140-0x00000001896C1160
		public override void Abort(bool byUser) {} // 0x00000001868EB490-0x00000001868EB540
		// [XID] // 0x00000001896C8710-0x00000001896C8730
		public override void BeforeRecycle() {} // 0x00000001868EB540-0x00000001868EB600
		// [XID] // 0x0000000189A43320-0x0000000189A43340
		public override void Recycle() {} // 0x00000001868EB600-0x00000001868EB6C0
	}
}
