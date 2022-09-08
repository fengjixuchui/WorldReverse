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
	public class ConfigVisibleInterAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18395
	{
		// Fields
		private bool _isVisible; // 0x30
	
		// Properties
		public bool isVisible { /* [XID] */ /* 0x0000000189A3F760-0x0000000189A3F780 */ get => default; /* [XID] */ /* 0x0000000189A46DF0-0x0000000189A46E10 */ private set {} } // 0x0000000188D4C1D0-0x0000000188D4C270 0x0000000188D4C270-0x0000000188D4C320
	
		// Constructors
		public ConfigVisibleInterAction() {} // 0x0000000188D4C170-0x0000000188D4C1D0
	
		// Methods
		// [XID] // 0x0000000189A4E6E0-0x0000000189A4E700
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000188D4B220-0x0000000188D4B310
		// [XID] // 0x0000000189A55DA0-0x0000000189A55DC0
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000188D4A350-0x0000000188D4A400
		// [XID] // 0x0000000189A5D720-0x0000000189A5D740
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF9729 */) => default; // 0x0000000188D4A270-0x0000000188D4A350
		// [XID] // 0x0000000189A64FA0-0x0000000189A64FC0
		public override int GetHashNum() => default; // 0x0000000188D4AA80-0x0000000188D4AB50
		// [XID] // 0x0000000189A6C6C0-0x0000000189A6C6E0
		public override void InitEmpty() {} // 0x0000000188D4AB50-0x0000000188D4ABF0
		[BlackList] // 0x0000000189A73F30-0x0000000189A73F70
		// [XID] // 0x0000000189A73F30-0x0000000189A73F70
		public override bool FromJson(JSONNode node) => default; // 0x0000000188D4A700-0x0000000188D4AA80
		// [XID] // 0x0000000189A7E8F0-0x0000000189A7E910
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000188D4AE20-0x0000000188D4B020
		[BlackList] // 0x0000000189A86170-0x0000000189A861B0
		// [XID] // 0x0000000189A86170-0x0000000189A861B0
		public static new ConfigVisibleInterAction ParseFromJson(JSONNode node) => default; // 0x0000000188D4B530-0x0000000188D4B780
		// [XID] // 0x0000000189A90C50-0x0000000189A90C70
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF972A */, bool useObjectPool = false /* Metadata: 0x00AF972E */) => default; // 0x0000000188D4A400-0x0000000188D4A700
		// [XID] // 0x0000000189A983E0-0x0000000189A98400
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF972F */, bool useObjectPool = false /* Metadata: 0x00AF9733 */) => default; // 0x0000000188D4ABF0-0x0000000188D4AE20
		// [XID] // 0x0000000189A9F7D0-0x0000000189A9F7F0
		public static new ConfigVisibleInterAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9734 */, bool useObjectPool = false /* Metadata: 0x00AF9738 */) => default; // 0x0000000188D4B310-0x0000000188D4B530
		[BlackList] // 0x0000000189AA7060-0x0000000189AA70A0
		// [XID] // 0x0000000189AA7060-0x0000000189AA70A0
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000188D4B910-0x0000000188D4BBE0
		// [XID] // 0x0000000189AB1B20-0x0000000189AB1B40
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000188D4B020-0x0000000188D4B220
		[BlackList] // 0x0000000189AB8E10-0x0000000189AB8E50
		// [XID] // 0x0000000189AB8E10-0x0000000189AB8E50
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000188D4B820-0x0000000188D4B910
		[BlackList] // 0x0000000189AC3EC0-0x0000000189AC3F00
		// [XID] // 0x0000000189AC3EC0-0x0000000189AC3F00
		public override void AutoAllocTypeFields() {} // 0x0000000188D4A120-0x0000000188D4A1C0
		[BlackList] // 0x0000000189ACE3D0-0x0000000189ACE410
		// [XID] // 0x0000000189ACE3D0-0x0000000189ACE410
		public override void AutoRecycleTypeFields() {} // 0x0000000188D4A1C0-0x0000000188D4A270
		[BlackList] // 0x0000000189AD9150-0x0000000189AD9190
		// [XID] // 0x0000000189AD9150-0x0000000189AD9190
		public override void ReturnToObjectPool() {} // 0x0000000188D4B780-0x0000000188D4B820
	}
}
