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
	public abstract class AssetLoadJob : ResourceJob // TypeDefIndex: 7354
	{
		// Fields
		public static int jobCount; // 0x00
		public static float maxRequestInterval; // 0x04
		protected float _requestTime; // 0x18
		public static Action<string, float> onLoadFinish; // 0x08
	
		// Properties
		protected static List<int> _reusedDependencyBundleList { get; private set; } // 0x00000001868E7E90-0x00000001868E7F20 0x00000001868E8120-0x00000001868E81B0
		public static AssetBundleExternalResourceProvider.IAssetLoadProxy resourcesProxy { /* [XID] */ /* 0x00000001898D4000-0x00000001898D4040 */ get; set; } // 0x00000001868E8020-0x00000001868E80B0 0x00000001868E81B0-0x00000001868E8240
		protected ResourceIdentifier _request { /* [XID] */ /* 0x00000001898E6660-0x00000001898E66A0 */ get; /* [XID] */ /* 0x00000001898F10A0-0x00000001898F10E0 */ set; } // 0x00000001868E7E20-0x00000001868E7E90 0x00000001868E80B0-0x00000001868E8120
		public ResourceIdentifier request { /* [XID] */ /* 0x0000000189903170-0x0000000189903190 */ get; } // 0x00000001868E7F20-0x00000001868E8020 
	
		// Constructors
		protected AssetLoadJob() {} // Dummy constructor
		static AssetLoadJob() {} // 0x00000001868E7CC0-0x00000001868E7D60
		protected AssetLoadJob(ResourceIdentifier request) {} // 0x00000001868E7D60-0x00000001868E7E20
	
		// Methods
		// [XID] // 0x00000001898FB520-0x00000001898FB540
		public override void BeforeRecycle() {} // 0x00000001868E7B70-0x00000001868E7C60
	}
}
