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
	public class ConfigOpenBlossomMarkInterAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18433
	{
		// Fields
		private bool _openAll; // 0x30
	
		// Properties
		public bool openAll { /* [XID] */ /* 0x00000001896D6820-0x00000001896D6840 */ get => default; /* [XID] */ /* 0x00000001896DDF20-0x00000001896DDF40 */ private set {} } // 0x0000000188846B20-0x0000000188846BC0 0x0000000188846BC0-0x0000000188846C70
	
		// Constructors
		public ConfigOpenBlossomMarkInterAction() {} // 0x0000000188846AB0-0x0000000188846B20
	
		// Methods
		// [XID] // 0x00000001896E5450-0x00000001896E5470
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000188845B60-0x0000000188845C50
		// [XID] // 0x00000001896ECAE0-0x00000001896ECB00
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000188844C90-0x0000000188844D40
		// [XID] // 0x00000001896F42E0-0x00000001896F4300
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF9849 */) => default; // 0x0000000188844BB0-0x0000000188844C90
		// [XID] // 0x00000001896FBAF0-0x00000001896FBB10
		public override int GetHashNum() => default; // 0x00000001888453C0-0x0000000188845490
		// [XID] // 0x0000000189703050-0x0000000189703070
		public override void InitEmpty() {} // 0x0000000188845490-0x0000000188845530
		[BlackList] // 0x000000018970A740-0x000000018970A780
		// [XID] // 0x000000018970A740-0x000000018970A780
		public override bool FromJson(JSONNode node) => default; // 0x0000000188845040-0x00000001888453C0
		// [XID] // 0x0000000189714C70-0x0000000189714C90
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000188845760-0x0000000188845960
		[BlackList] // 0x000000018971C5E0-0x000000018971C620
		// [XID] // 0x000000018971C5E0-0x000000018971C620
		public static new ConfigOpenBlossomMarkInterAction ParseFromJson(JSONNode node) => default; // 0x0000000188845E70-0x00000001888460C0
		// [XID] // 0x0000000189726C80-0x0000000189726CA0
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF984A */, bool useObjectPool = false /* Metadata: 0x00AF984E */) => default; // 0x0000000188844D40-0x0000000188845040
		// [XID] // 0x000000018972E270-0x000000018972E290
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF984F */, bool useObjectPool = false /* Metadata: 0x00AF9853 */) => default; // 0x0000000188845530-0x0000000188845760
		// [XID] // 0x0000000189735920-0x0000000189735940
		public static new ConfigOpenBlossomMarkInterAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9854 */, bool useObjectPool = false /* Metadata: 0x00AF9858 */) => default; // 0x0000000188845C50-0x0000000188845E70
		[BlackList] // 0x000000018973D4B0-0x000000018973D4F0
		// [XID] // 0x000000018973D4B0-0x000000018973D4F0
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000188846250-0x0000000188846520
		// [XID] // 0x0000000189747BB0-0x0000000189747BD0
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000188845960-0x0000000188845B60
		[BlackList] // 0x000000018974F3B0-0x000000018974F3F0
		// [XID] // 0x000000018974F3B0-0x000000018974F3F0
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000188846160-0x0000000188846250
		[BlackList] // 0x00000001897596E0-0x0000000189759720
		// [XID] // 0x00000001897596E0-0x0000000189759720
		public override void AutoAllocTypeFields() {} // 0x0000000188844A60-0x0000000188844B00
		[BlackList] // 0x0000000189763F40-0x0000000189763F80
		// [XID] // 0x0000000189763F40-0x0000000189763F80
		public override void AutoRecycleTypeFields() {} // 0x0000000188844B00-0x0000000188844BB0
		[BlackList] // 0x000000018976E4C0-0x000000018976E500
		// [XID] // 0x000000018976E4C0-0x000000018976E500
		public override void ReturnToObjectPool() {} // 0x00000001888460C0-0x0000000188846160
	}
}
