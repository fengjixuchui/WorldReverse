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
	public class ConfigAudioStateInterAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18397
	{
		// Fields
		private string _stateGroup; // 0x30
		private string _state; // 0x38
	
		// Properties
		public string stateGroup { /* [XID] */ /* 0x0000000189AEE5A0-0x0000000189AEE5C0 */ get => default; /* [XID] */ /* 0x0000000189AF5B50-0x0000000189AF5B70 */ private set {} } // 0x0000000187DF2410-0x0000000187DF24B0 0x0000000187DF2550-0x0000000187DF2600
		public string state { /* [XID] */ /* 0x0000000189AFD070-0x0000000189AFD090 */ get => default; /* [XID] */ /* 0x0000000189B04880-0x0000000189B048A0 */ private set {} } // 0x0000000187DF24B0-0x0000000187DF2550 0x0000000187DF2600-0x0000000187DF26B0
	
		// Constructors
		public ConfigAudioStateInterAction() {} // 0x0000000187DF2360-0x0000000187DF2410
	
		// Methods
		// [XID] // 0x0000000189B0BFF0-0x0000000189B0C010
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000187DF13F0-0x0000000187DF1500
		// [XID] // 0x0000000189B13690-0x0000000189B136B0
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000187DF0210-0x0000000187DF0310
		// [XID] // 0x0000000189B1AD60-0x0000000189B1AD80
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF9739 */) => default; // 0x0000000187DF0130-0x0000000187DF0210
		// [XID] // 0x0000000189B22350-0x0000000189B22370
		public override int GetHashNum() => default; // 0x0000000187DF0990-0x0000000187DF0A60
		// [XID] // 0x0000000189B298A0-0x0000000189B298C0
		public override void InitEmpty() {} // 0x0000000187DF0A60-0x0000000187DF0B50
		[BlackList] // 0x0000000189B30EB0-0x0000000189B30EF0
		// [XID] // 0x0000000189B30EB0-0x0000000189B30EF0
		public override bool FromJson(JSONNode node) => default; // 0x0000000187DF0610-0x0000000187DF0990
		// [XID] // 0x0000000189B3B5D0-0x0000000189B3B5F0
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000187DF0E50-0x0000000187DF1160
		[BlackList] // 0x0000000189B42FF0-0x0000000189B43030
		// [XID] // 0x0000000189B42FF0-0x0000000189B43030
		public static new ConfigAudioStateInterAction ParseFromJson(JSONNode node) => default; // 0x0000000187DF1720-0x0000000187DF1970
		// [XID] // 0x0000000189B4D750-0x0000000189B4D770
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF973A */, bool useObjectPool = false /* Metadata: 0x00AF973E */) => default; // 0x0000000187DF0310-0x0000000187DF0610
		// [XID] // 0x0000000189B54F50-0x0000000189B54F70
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF973F */, bool useObjectPool = false /* Metadata: 0x00AF9743 */) => default; // 0x0000000187DF0B50-0x0000000187DF0E50
		// [XID] // 0x0000000189B5C950-0x0000000189B5C970
		public static new ConfigAudioStateInterAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9744 */, bool useObjectPool = false /* Metadata: 0x00AF9748 */) => default; // 0x0000000187DF1500-0x0000000187DF1720
		[BlackList] // 0x0000000189B63F30-0x0000000189B63F70
		// [XID] // 0x0000000189B63F30-0x0000000189B63F70
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000187DF1B00-0x0000000187DF1DD0
		// [XID] // 0x0000000189B6E440-0x0000000189B6E460
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000187DF1160-0x0000000187DF13F0
		[BlackList] // 0x0000000189B75BF0-0x0000000189B75C30
		// [XID] // 0x0000000189B75BF0-0x0000000189B75C30
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000187DF1A10-0x0000000187DF1B00
		[BlackList] // 0x0000000189B80090-0x0000000189B800D0
		// [XID] // 0x0000000189B80090-0x0000000189B800D0
		public override void AutoAllocTypeFields() {} // 0x0000000187DEFFE0-0x0000000187DF0080
		[BlackList] // 0x0000000189B8A790-0x0000000189B8A7D0
		// [XID] // 0x0000000189B8A790-0x0000000189B8A7D0
		public override void AutoRecycleTypeFields() {} // 0x0000000187DF0080-0x0000000187DF0130
		[BlackList] // 0x0000000189B94B70-0x0000000189B94BB0
		// [XID] // 0x0000000189B94B70-0x0000000189B94BB0
		public override void ReturnToObjectPool() {} // 0x0000000187DF1970-0x0000000187DF1A10
	}
}
