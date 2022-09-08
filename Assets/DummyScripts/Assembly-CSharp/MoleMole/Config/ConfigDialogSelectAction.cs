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
	[CSharpCallLua] // 0x00000001899BE290-0x00000001899BE2D0
	[RecycleType] // 0x00000001899BE290-0x00000001899BE2D0
	public class ConfigDialogSelectAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18383
	{
		// Fields
		private uint[] _talkIDList; // 0x30
		private uint[] _dialogIDList; // 0x38
		private uint[] _grpIDList; // 0x40
		private bool _useGrpId; // 0x48
	
		// Properties
		public uint[] talkIDList { /* [XID] */ /* 0x0000000189A45660-0x0000000189A45680 */ get => default; /* [XID] */ /* 0x0000000189A4CC00-0x0000000189A4CC20 */ private set {} } // 0x0000000188B93E10-0x0000000188B93EB0 0x0000000188B940B0-0x0000000188B94160
		public uint[] dialogIDList { /* [XID] */ /* 0x0000000189A544D0-0x0000000189A544F0 */ get => default; /* [XID] */ /* 0x0000000189A5BFC0-0x0000000189A5BFE0 */ private set {} } // 0x0000000188B93CD0-0x0000000188B93D70 0x0000000188B93F50-0x0000000188B94000
		public uint[] grpIDList { /* [XID] */ /* 0x0000000189A63830-0x0000000189A63850 */ get => default; /* [XID] */ /* 0x0000000189A6B0D0-0x0000000189A6B0F0 */ private set {} } // 0x0000000188B93D70-0x0000000188B93E10 0x0000000188B94000-0x0000000188B940B0
		public bool useGrpId { /* [XID] */ /* 0x0000000189A72890-0x0000000189A728B0 */ get => default; /* [XID] */ /* 0x0000000189A7A410-0x0000000189A7A430 */ private set {} } // 0x0000000188B93EB0-0x0000000188B93F50 0x0000000188B94160-0x0000000188B94210
	
		// Constructors
		public ConfigDialogSelectAction() {} // 0x0000000188B93C60-0x0000000188B93CD0
	
		// Methods
		// [XID] // 0x0000000189A818D0-0x0000000189A818F0
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000188B92CB0-0x0000000188B92E00
		// [XID] // 0x0000000189A89410-0x0000000189A89430
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000188B91650-0x0000000188B91760
		// [XID] // 0x0000000189A90C70-0x0000000189A90C90
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF96D9 */) => default; // 0x0000000188B91570-0x0000000188B91650
		// [XID] // 0x0000000189A98400-0x0000000189A98420
		public override int GetHashNum() => default; // 0x0000000188B91DE0-0x0000000188B91EB0
		// [XID] // 0x0000000189A9F7F0-0x0000000189A9F810
		public override void InitEmpty() {} // 0x0000000188B91EB0-0x0000000188B91FB0
		[BlackList] // 0x0000000189AA70A0-0x0000000189AA70E0
		// [XID] // 0x0000000189AA70A0-0x0000000189AA70E0
		public override bool FromJson(JSONNode node) => default; // 0x0000000188B91A60-0x0000000188B91DE0
		// [XID] // 0x0000000189AB1B40-0x0000000189AB1B60
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000188B923E0-0x0000000188B92890
		[BlackList] // 0x0000000189AB8E50-0x0000000189AB8E90
		// [XID] // 0x0000000189AB8E50-0x0000000189AB8E90
		public static new ConfigDialogSelectAction ParseFromJson(JSONNode node) => default; // 0x0000000188B93020-0x0000000188B93270
		// [XID] // 0x0000000189AC3F00-0x0000000189AC3F20
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF96DA */, bool useObjectPool = false /* Metadata: 0x00AF96DE */) => default; // 0x0000000188B91760-0x0000000188B91A60
		// [XID] // 0x0000000189ACB310-0x0000000189ACB330
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF96DF */, bool useObjectPool = false /* Metadata: 0x00AF96E3 */) => default; // 0x0000000188B91FB0-0x0000000188B923E0
		// [XID] // 0x0000000189AD2DA0-0x0000000189AD2DC0
		public static new ConfigDialogSelectAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF96E4 */, bool useObjectPool = false /* Metadata: 0x00AF96E8 */) => default; // 0x0000000188B92E00-0x0000000188B93020
		[BlackList] // 0x0000000189ADA820-0x0000000189ADA860
		// [XID] // 0x0000000189ADA820-0x0000000189ADA860
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000188B93400-0x0000000188B936D0
		// [XID] // 0x0000000189AE54A0-0x0000000189AE54C0
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000188B92890-0x0000000188B92CB0
		[BlackList] // 0x0000000189AEC9C0-0x0000000189AECA00
		// [XID] // 0x0000000189AEC9C0-0x0000000189AECA00
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000188B93310-0x0000000188B93400
		[BlackList] // 0x0000000189AF73A0-0x0000000189AF73E0
		// [XID] // 0x0000000189AF73A0-0x0000000189AF73E0
		public override void AutoAllocTypeFields() {} // 0x0000000188B91420-0x0000000188B914C0
		[BlackList] // 0x0000000189B01A30-0x0000000189B01A70
		// [XID] // 0x0000000189B01A30-0x0000000189B01A70
		public override void AutoRecycleTypeFields() {} // 0x0000000188B914C0-0x0000000188B91570
		[BlackList] // 0x0000000189B0C010-0x0000000189B0C050
		// [XID] // 0x0000000189B0C010-0x0000000189B0C050
		public override void ReturnToObjectPool() {} // 0x0000000188B93270-0x0000000188B93310
	}
}
