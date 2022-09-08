/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.Config
{
	[CSharpCallLua] // 0x000000018998DB20-0x000000018998DB60
	[RecycleType] // 0x000000018998DB20-0x000000018998DB60
	public class ConfigTeleportToAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18443
	{
		// Fields
		private Vector _position; // 0x30
		private Vector _forward; // 0x3C
	
		// Properties
		public Vector position { /* [XID] */ /* 0x0000000189ADF230-0x0000000189ADF250 */ get => default; /* [XID] */ /* 0x0000000189AE6AD0-0x0000000189AE6AF0 */ private set {} } // 0x0000000188D3F740-0x0000000188D3F820 0x0000000188D3F8F0-0x0000000188D3F9C0
		public Vector forward { /* [XID] */ /* 0x0000000189AEE580-0x0000000189AEE5A0 */ get => default; /* [XID] */ /* 0x0000000189AF5B30-0x0000000189AF5B50 */ private set {} } // 0x0000000188D3F660-0x0000000188D3F740 0x0000000188D3F820-0x0000000188D3F8F0
	
		// Constructors
		public ConfigTeleportToAction() {} // 0x0000000188D3F600-0x0000000188D3F660
	
		// Methods
		// [XID] // 0x0000000189AFD050-0x0000000189AFD070
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000188D3E670-0x0000000188D3E7A0
		// [XID] // 0x0000000189B04860-0x0000000189B04880
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000188D3D460-0x0000000188D3D510
		// [XID] // 0x0000000189B0BFD0-0x0000000189B0BFF0
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF9899 */) => default; // 0x0000000188D3D380-0x0000000188D3D460
		// [XID] // 0x0000000189B13670-0x0000000189B13690
		public override int GetHashNum() => default; // 0x0000000188D3DB90-0x0000000188D3DC60
		// [XID] // 0x0000000189B1AD40-0x0000000189B1AD60
		public override void InitEmpty() {} // 0x0000000188D3DC60-0x0000000188D3DD50
		[BlackList] // 0x0000000189B22310-0x0000000189B22350
		// [XID] // 0x0000000189B22310-0x0000000189B22350
		public override bool FromJson(JSONNode node) => default; // 0x0000000188D3D810-0x0000000188D3DB90
		// [XID] // 0x0000000189B2C830-0x0000000189B2C850
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000188D3E040-0x0000000188D3E350
		[BlackList] // 0x0000000189B33CE0-0x0000000189B33D20
		// [XID] // 0x0000000189B33CE0-0x0000000189B33D20
		public static new ConfigTeleportToAction ParseFromJson(JSONNode node) => default; // 0x0000000188D3E9C0-0x0000000188D3EC10
		// [XID] // 0x0000000189B3E640-0x0000000189B3E660
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF989A */, bool useObjectPool = false /* Metadata: 0x00AF989E */) => default; // 0x0000000188D3D510-0x0000000188D3D810
		// [XID] // 0x0000000189B46160-0x0000000189B46180
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF989F */, bool useObjectPool = false /* Metadata: 0x00AF98A3 */) => default; // 0x0000000188D3DD50-0x0000000188D3E040
		// [XID] // 0x0000000189B4D730-0x0000000189B4D750
		public static new ConfigTeleportToAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF98A4 */, bool useObjectPool = false /* Metadata: 0x00AF98A8 */) => default; // 0x0000000188D3E7A0-0x0000000188D3E9C0
		[BlackList] // 0x0000000189B54F10-0x0000000189B54F50
		// [XID] // 0x0000000189B54F10-0x0000000189B54F50
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000188D3EDA0-0x0000000188D3F070
		// [XID] // 0x0000000189B5FB00-0x0000000189B5FB20
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000188D3E350-0x0000000188D3E670
		[BlackList] // 0x0000000189B671C0-0x0000000189B67200
		// [XID] // 0x0000000189B671C0-0x0000000189B67200
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000188D3ECB0-0x0000000188D3EDA0
		[BlackList] // 0x0000000189B71750-0x0000000189B71790
		// [XID] // 0x0000000189B71750-0x0000000189B71790
		public override void AutoAllocTypeFields() {} // 0x0000000188D3D210-0x0000000188D3D2B0
		[BlackList] // 0x0000000189B7BA50-0x0000000189B7BA90
		// [XID] // 0x0000000189B7BA50-0x0000000189B7BA90
		public override void AutoRecycleTypeFields() {} // 0x0000000188D3D2B0-0x0000000188D3D380
		[BlackList] // 0x0000000189B86520-0x0000000189B86560
		// [XID] // 0x0000000189B86520-0x0000000189B86560
		public override void ReturnToObjectPool() {} // 0x0000000188D3EC10-0x0000000188D3ECB0
	}
}
