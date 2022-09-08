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
	public class ConfigTimeProtectAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18427
	{
		// Constructors
		public ConfigTimeProtectAction() {} // 0x0000000188D416A0-0x0000000188D41700
	
		// Methods
		// [XID] // 0x0000000189A8DAB0-0x0000000189A8DAD0
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000188D40790-0x0000000188D40840
		// [XID] // 0x0000000189A95050-0x0000000189A95070
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000188D3FBE0-0x0000000188D3FC90
		// [XID] // 0x0000000189A9C950-0x0000000189A9C970
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF9819 */) => default; // 0x0000000188D3FB00-0x0000000188D3FBE0
		// [XID] // 0x0000000189AA40E0-0x0000000189AA4100
		public override int GetHashNum() => default; // 0x0000000188D40310-0x0000000188D403E0
		// [XID] // 0x0000000189AAB5B0-0x0000000189AAB5D0
		public override void InitEmpty() {} // 0x0000000188D403E0-0x0000000188D40480
		[BlackList] // 0x0000000189AB2EE0-0x0000000189AB2F20
		// [XID] // 0x0000000189AB2EE0-0x0000000189AB2F20
		public override bool FromJson(JSONNode node) => default; // 0x0000000188D3FF90-0x0000000188D40310
		// [XID] // 0x0000000189ABDA10-0x0000000189ABDA30
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000188D405B0-0x0000000188D406A0
		[BlackList] // 0x0000000189AC55B0-0x0000000189AC55F0
		// [XID] // 0x0000000189AC55B0-0x0000000189AC55F0
		public static new ConfigTimeProtectAction ParseFromJson(JSONNode node) => default; // 0x0000000188D40A60-0x0000000188D40CB0
		// [XID] // 0x0000000189ACFB10-0x0000000189ACFB30
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF981A */, bool useObjectPool = false /* Metadata: 0x00AF981E */) => default; // 0x0000000188D3FC90-0x0000000188D3FF90
		// [XID] // 0x0000000189AD77E0-0x0000000189AD7800
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF981F */, bool useObjectPool = false /* Metadata: 0x00AF9823 */) => default; // 0x0000000188D40480-0x0000000188D405B0
		// [XID] // 0x0000000189ADF250-0x0000000189ADF270
		public static new ConfigTimeProtectAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9824 */, bool useObjectPool = false /* Metadata: 0x00AF9828 */) => default; // 0x0000000188D40840-0x0000000188D40A60
		[BlackList] // 0x0000000189AE6AF0-0x0000000189AE6B30
		// [XID] // 0x0000000189AE6AF0-0x0000000189AE6B30
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000188D40E40-0x0000000188D41110
		// [XID] // 0x0000000189AF1690-0x0000000189AF16B0
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000188D406A0-0x0000000188D40790
		[BlackList] // 0x0000000189AF8CF0-0x0000000189AF8D30
		// [XID] // 0x0000000189AF8CF0-0x0000000189AF8D30
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000188D40D50-0x0000000188D40E40
		[BlackList] // 0x0000000189B03290-0x0000000189B032D0
		// [XID] // 0x0000000189B03290-0x0000000189B032D0
		public override void AutoAllocTypeFields() {} // 0x0000000188D3F9C0-0x0000000188D3FA60
		[BlackList] // 0x0000000189B0D9B0-0x0000000189B0D9F0
		// [XID] // 0x0000000189B0D9B0-0x0000000189B0D9F0
		public override void AutoRecycleTypeFields() {} // 0x0000000188D3FA60-0x0000000188D3FB00
		[BlackList] // 0x0000000189B17B60-0x0000000189B17BA0
		// [XID] // 0x0000000189B17B60-0x0000000189B17BA0
		public override void ReturnToObjectPool() {} // 0x0000000188D40CB0-0x0000000188D40D50
	}
}
