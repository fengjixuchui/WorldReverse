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
	public class ConfigShowMessageAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18411
	{
		// Fields
		private string _txtMapStr; // 0x30
	
		// Properties
		public string txtMapStr { /* [XID] */ /* 0x0000000189A5A510-0x0000000189A5A530 */ get => default; /* [XID] */ /* 0x0000000189A61C50-0x0000000189A61C70 */ private set {} } // 0x0000000189224980-0x0000000189224A20 0x0000000189224A20-0x0000000189224AD0
	
		// Constructors
		public ConfigShowMessageAction() {} // 0x0000000189224920-0x0000000189224980
	
		// Methods
		// [XID] // 0x0000000189A69BB0-0x0000000189A69BD0
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001892239D0-0x0000000189223AC0
		// [XID] // 0x0000000189A70F00-0x0000000189A70F20
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000189222A30-0x0000000189222B10
		// [XID] // 0x0000000189A78A80-0x0000000189A78AA0
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF9799 */) => default; // 0x0000000189222950-0x0000000189222A30
		// [XID] // 0x0000000189A7FE00-0x0000000189A7FE20
		public override int GetHashNum() => default; // 0x0000000189223190-0x0000000189223260
		// [XID] // 0x0000000189A87BC0-0x0000000189A87BE0
		public override void InitEmpty() {} // 0x0000000189223260-0x0000000189223330
		[BlackList] // 0x0000000189A8F370-0x0000000189A8F3B0
		// [XID] // 0x0000000189A8F370-0x0000000189A8F3B0
		public override bool FromJson(JSONNode node) => default; // 0x0000000189222E10-0x0000000189223190
		// [XID] // 0x0000000189A99D00-0x0000000189A99D20
		private new bool InternalFromJson(JSONNode node) => default; // 0x00000001892235A0-0x00000001892237D0
		[BlackList] // 0x0000000189AA0C60-0x0000000189AA0CA0
		// [XID] // 0x0000000189AA0C60-0x0000000189AA0CA0
		public static new ConfigShowMessageAction ParseFromJson(JSONNode node) => default; // 0x0000000189223CE0-0x0000000189223F30
		// [XID] // 0x0000000189AAB5D0-0x0000000189AAB5F0
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF979A */, bool useObjectPool = false /* Metadata: 0x00AF979E */) => default; // 0x0000000189222B10-0x0000000189222E10
		// [XID] // 0x0000000189AB2F20-0x0000000189AB2F40
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF979F */, bool useObjectPool = false /* Metadata: 0x00AF97A3 */) => default; // 0x0000000189223330-0x00000001892235A0
		// [XID] // 0x0000000189ABAC10-0x0000000189ABAC30
		public static new ConfigShowMessageAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF97A4 */, bool useObjectPool = false /* Metadata: 0x00AF97A8 */) => default; // 0x0000000189223AC0-0x0000000189223CE0
		[BlackList] // 0x0000000189AC23A0-0x0000000189AC23E0
		// [XID] // 0x0000000189AC23A0-0x0000000189AC23E0
		public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001892240C0-0x0000000189224390
		// [XID] // 0x0000000189ACC9C0-0x0000000189ACC9E0
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001892237D0-0x00000001892239D0
		[BlackList] // 0x0000000189AD4720-0x0000000189AD4760
		// [XID] // 0x0000000189AD4720-0x0000000189AD4760
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000189223FD0-0x00000001892240C0
		[BlackList] // 0x0000000189ADF270-0x0000000189ADF2B0
		// [XID] // 0x0000000189ADF270-0x0000000189ADF2B0
		public override void AutoAllocTypeFields() {} // 0x0000000189222800-0x00000001892228A0
		[BlackList] // 0x0000000189AE98D0-0x0000000189AE9910
		// [XID] // 0x0000000189AE98D0-0x0000000189AE9910
		public override void AutoRecycleTypeFields() {} // 0x00000001892228A0-0x0000000189222950
		[BlackList] // 0x0000000189AF43D0-0x0000000189AF4410
		// [XID] // 0x0000000189AF43D0-0x0000000189AF4410
		public override void ReturnToObjectPool() {} // 0x0000000189223F30-0x0000000189223FD0
	}
}
