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
	public class ConfigLuaAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18377
	{
		// Fields
		private bool _invoke; // 0x30
		private string _invokeAlias; // 0x38
		private uint _invokeParam; // 0x40
	
		// Properties
		public bool invoke { /* [XID] */ /* 0x00000001897F3830-0x00000001897F3850 */ get => default; /* [XID] */ /* 0x00000001897FB190-0x00000001897FB1B0 */ private set {} } // 0x000000018883EFA0-0x000000018883F040 0x000000018883F1A0-0x000000018883F250
		public string invokeAlias { /* [XID] */ /* 0x0000000189802620-0x0000000189802640 */ get => default; /* [XID] */ /* 0x0000000189809B50-0x0000000189809B70 */ private set {} } // 0x000000018883EE60-0x000000018883EF00 0x000000018883F040-0x000000018883F0F0
		public uint invokeParam { /* [XID] */ /* 0x00000001898112E0-0x0000000189811300 */ get => default; /* [XID] */ /* 0x0000000189818D90-0x0000000189818DB0 */ private set {} } // 0x000000018883EF00-0x000000018883EFA0 0x000000018883F0F0-0x000000018883F1A0
	
		// Constructors
		public ConfigLuaAction() {} // 0x000000018883EDF0-0x000000018883EE60
	
		// Methods
		// [XID] // 0x0000000189820610-0x0000000189820630
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018883DE60-0x000000018883DF90
		// [XID] // 0x0000000189827C80-0x0000000189827CA0
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018883CB60-0x000000018883CC40
		// [XID] // 0x000000018982EFC0-0x000000018982EFE0
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF96A9 */) => default; // 0x000000018883CA80-0x000000018883CB60
		// [XID] // 0x00000001898368D0-0x00000001898368F0
		public override int GetHashNum() => default; // 0x000000018883D2C0-0x000000018883D390
		// [XID] // 0x000000018983DC20-0x000000018983DC40
		public override void InitEmpty() {} // 0x000000018883D390-0x000000018883D460
		[BlackList] // 0x0000000189845490-0x00000001898454D0
		// [XID] // 0x0000000189845490-0x00000001898454D0
		public override bool FromJson(JSONNode node) => default; // 0x000000018883CF40-0x000000018883D2C0
		// [XID] // 0x000000018984F820-0x000000018984F840
		private new bool InternalFromJson(JSONNode node) => default; // 0x000000018883D7B0-0x000000018883DB50
		[BlackList] // 0x0000000189856A60-0x0000000189856AA0
		// [XID] // 0x0000000189856A60-0x0000000189856AA0
		public static new ConfigLuaAction ParseFromJson(JSONNode node) => default; // 0x000000018883E1B0-0x000000018883E400
		// [XID] // 0x0000000189860E90-0x0000000189860EB0
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF96AA */, bool useObjectPool = false /* Metadata: 0x00AF96AE */) => default; // 0x000000018883CC40-0x000000018883CF40
		// [XID] // 0x0000000189868710-0x0000000189868730
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF96AF */, bool useObjectPool = false /* Metadata: 0x00AF96B3 */) => default; // 0x000000018883D460-0x000000018883D7B0
		// [XID] // 0x000000018986FB60-0x000000018986FB80
		public static new ConfigLuaAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF96B4 */, bool useObjectPool = false /* Metadata: 0x00AF96B8 */) => default; // 0x000000018883DF90-0x000000018883E1B0
		[BlackList] // 0x0000000189877230-0x0000000189877270
		// [XID] // 0x0000000189877230-0x0000000189877270
		public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018883E590-0x000000018883E860
		// [XID] // 0x0000000189881880-0x00000001898818A0
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018883DB50-0x000000018883DE60
		[BlackList] // 0x0000000189888E40-0x0000000189888E80
		// [XID] // 0x0000000189888E40-0x0000000189888E80
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018883E4A0-0x000000018883E590
		[BlackList] // 0x0000000189893350-0x0000000189893390
		// [XID] // 0x0000000189893350-0x0000000189893390
		public override void AutoAllocTypeFields() {} // 0x000000018883C930-0x000000018883C9D0
		[BlackList] // 0x000000018989D540-0x000000018989D580
		// [XID] // 0x000000018989D540-0x000000018989D580
		public override void AutoRecycleTypeFields() {} // 0x000000018883C9D0-0x000000018883CA80
		[BlackList] // 0x00000001898A7B70-0x00000001898A7BB0
		// [XID] // 0x00000001898A7B70-0x00000001898A7BB0
		public override void ReturnToObjectPool() {} // 0x000000018883E400-0x000000018883E4A0
	}
}
