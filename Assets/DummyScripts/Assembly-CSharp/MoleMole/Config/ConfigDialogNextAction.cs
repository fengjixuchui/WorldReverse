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
	public class ConfigDialogNextAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18381
	{
		// Fields
		private uint _talkID; // 0x30
	
		// Properties
		public uint talkID { /* [XID] */ /* 0x0000000189998650-0x0000000189998670 */ get => default; /* [XID] */ /* 0x000000018999FF30-0x000000018999FF50 */ private set {} } // 0x0000000188B912D0-0x0000000188B91370 0x0000000188B91370-0x0000000188B91420
	
		// Constructors
		public ConfigDialogNextAction() {} // 0x0000000188B91270-0x0000000188B912D0
	
		// Methods
		// [XID] // 0x00000001899A7B00-0x00000001899A7B20
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000188B90320-0x0000000188B90410
		// [XID] // 0x00000001899AF2F0-0x00000001899AF310
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000188B8F450-0x0000000188B8F500
		// [XID] // 0x00000001899B66F0-0x00000001899B6710
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF96C9 */) => default; // 0x0000000188B8F370-0x0000000188B8F450
		// [XID] // 0x00000001899BE2D0-0x00000001899BE2F0
		public override int GetHashNum() => default; // 0x0000000188B8FB80-0x0000000188B8FC50
		// [XID] // 0x00000001899C5A90-0x00000001899C5AB0
		public override void InitEmpty() {} // 0x0000000188B8FC50-0x0000000188B8FCF0
		[BlackList] // 0x00000001899CD0D0-0x00000001899CD110
		// [XID] // 0x00000001899CD0D0-0x00000001899CD110
		public override bool FromJson(JSONNode node) => default; // 0x0000000188B8F800-0x0000000188B8FB80
		// [XID] // 0x00000001899D76B0-0x00000001899D76D0
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000188B8FF20-0x0000000188B90120
		[BlackList] // 0x00000001899DEAF0-0x00000001899DEB30
		// [XID] // 0x00000001899DEAF0-0x00000001899DEB30
		public static new ConfigDialogNextAction ParseFromJson(JSONNode node) => default; // 0x0000000188B90630-0x0000000188B90880
		// [XID] // 0x00000001899E9480-0x00000001899E94A0
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF96CA */, bool useObjectPool = false /* Metadata: 0x00AF96CE */) => default; // 0x0000000188B8F500-0x0000000188B8F800
		// [XID] // 0x00000001899F0B70-0x00000001899F0B90
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF96CF */, bool useObjectPool = false /* Metadata: 0x00AF96D3 */) => default; // 0x0000000188B8FCF0-0x0000000188B8FF20
		// [XID] // 0x00000001899F8430-0x00000001899F8450
		public static new ConfigDialogNextAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF96D4 */, bool useObjectPool = false /* Metadata: 0x00AF96D8 */) => default; // 0x0000000188B90410-0x0000000188B90630
		[BlackList] // 0x00000001899FFA20-0x00000001899FFA60
		// [XID] // 0x00000001899FFA20-0x00000001899FFA60
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000188B90A10-0x0000000188B90CE0
		// [XID] // 0x0000000189A0A1A0-0x0000000189A0A1C0
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000188B90120-0x0000000188B90320
		[BlackList] // 0x0000000189A11AA0-0x0000000189A11AE0
		// [XID] // 0x0000000189A11AA0-0x0000000189A11AE0
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000188B90920-0x0000000188B90A10
		[BlackList] // 0x0000000189A1BC30-0x0000000189A1BC70
		// [XID] // 0x0000000189A1BC30-0x0000000189A1BC70
		public override void AutoAllocTypeFields() {} // 0x0000000188B8F220-0x0000000188B8F2C0
		[BlackList] // 0x0000000189A26220-0x0000000189A26260
		// [XID] // 0x0000000189A26220-0x0000000189A26260
		public override void AutoRecycleTypeFields() {} // 0x0000000188B8F2C0-0x0000000188B8F370
		[BlackList] // 0x0000000189A305F0-0x0000000189A30630
		// [XID] // 0x0000000189A305F0-0x0000000189A30630
		public override void ReturnToObjectPool() {} // 0x0000000188B90880-0x0000000188B90920
	}
}
