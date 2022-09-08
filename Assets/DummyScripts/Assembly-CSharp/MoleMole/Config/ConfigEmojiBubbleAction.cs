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
	public class ConfigEmojiBubbleAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18425
	{
		// Fields
		private string _pattarnName; // 0x30
		private bool _tryStop; // 0x38
	
		// Properties
		public string pattarnName { /* [XID] */ /* 0x00000001899D1880-0x00000001899D18A0 */ get => default; /* [XID] */ /* 0x00000001899D8E10-0x00000001899D8E30 */ private set {} } // 0x0000000188B9B920-0x0000000188B9B9C0 0x0000000188B9BA60-0x0000000188B9BB10
		public bool tryStop { /* [XID] */ /* 0x00000001899E0440-0x00000001899E0460 */ get => default; /* [XID] */ /* 0x00000001899E7F20-0x00000001899E7F40 */ private set {} } // 0x0000000188B9B9C0-0x0000000188B9BA60 0x0000000188B9BB10-0x0000000188B9BBC0
	
		// Constructors
		public ConfigEmojiBubbleAction() {} // 0x0000000188B9B8B0-0x0000000188B9B920
	
		// Methods
		// [XID] // 0x00000001899EF3B0-0x00000001899EF3D0
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000188B9A940-0x0000000188B9AA50
		// [XID] // 0x00000001899F6D30-0x00000001899F6D50
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000188B997E0-0x0000000188B998C0
		// [XID] // 0x00000001899FE450-0x00000001899FE470
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF9809 */) => default; // 0x0000000188B99700-0x0000000188B997E0
		// [XID] // 0x0000000189A05D30-0x0000000189A05D50
		public override int GetHashNum() => default; // 0x0000000188B99F40-0x0000000188B9A010
		// [XID] // 0x0000000189A0D060-0x0000000189A0D080
		public override void InitEmpty() {} // 0x0000000188B9A010-0x0000000188B9A0E0
		[BlackList] // 0x0000000189A148C0-0x0000000189A14900
		// [XID] // 0x0000000189A148C0-0x0000000189A14900
		public override bool FromJson(JSONNode node) => default; // 0x0000000188B99BC0-0x0000000188B99F40
		// [XID] // 0x0000000189A1EB10-0x0000000189A1EB30
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000188B9A3C0-0x0000000188B9A6B0
		[BlackList] // 0x0000000189A261A0-0x0000000189A261E0
		// [XID] // 0x0000000189A261A0-0x0000000189A261E0
		public static new ConfigEmojiBubbleAction ParseFromJson(JSONNode node) => default; // 0x0000000188B9AC70-0x0000000188B9AEC0
		// [XID] // 0x0000000189A30590-0x0000000189A305B0
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF980A */, bool useObjectPool = false /* Metadata: 0x00AF980E */) => default; // 0x0000000188B998C0-0x0000000188B99BC0
		// [XID] // 0x0000000189A37F90-0x0000000189A37FB0
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF980F */, bool useObjectPool = false /* Metadata: 0x00AF9813 */) => default; // 0x0000000188B9A0E0-0x0000000188B9A3C0
		// [XID] // 0x0000000189A3F740-0x0000000189A3F760
		public static new ConfigEmojiBubbleAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9814 */, bool useObjectPool = false /* Metadata: 0x00AF9818 */) => default; // 0x0000000188B9AA50-0x0000000188B9AC70
		[BlackList] // 0x0000000189A46DB0-0x0000000189A46DF0
		// [XID] // 0x0000000189A46DB0-0x0000000189A46DF0
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000188B9B050-0x0000000188B9B320
		// [XID] // 0x0000000189A515B0-0x0000000189A515D0
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000188B9A6B0-0x0000000188B9A940
		[BlackList] // 0x0000000189A58C60-0x0000000189A58CA0
		// [XID] // 0x0000000189A58C60-0x0000000189A58CA0
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000188B9AF60-0x0000000188B9B050
		[BlackList] // 0x0000000189A637F0-0x0000000189A63830
		// [XID] // 0x0000000189A637F0-0x0000000189A63830
		public override void AutoAllocTypeFields() {} // 0x0000000188B995B0-0x0000000188B99650
		[BlackList] // 0x0000000189A6E020-0x0000000189A6E060
		// [XID] // 0x0000000189A6E020-0x0000000189A6E060
		public override void AutoRecycleTypeFields() {} // 0x0000000188B99650-0x0000000188B99700
		[BlackList] // 0x0000000189A78A40-0x0000000189A78A80
		// [XID] // 0x0000000189A78A40-0x0000000189A78A80
		public override void ReturnToObjectPool() {} // 0x0000000188B9AEC0-0x0000000188B9AF60
	}
}
