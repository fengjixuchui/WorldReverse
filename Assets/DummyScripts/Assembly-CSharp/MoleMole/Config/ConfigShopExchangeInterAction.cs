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
	public class ConfigShopExchangeInterAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18399
	{
		// Fields
		private string _shopType; // 0x30
	
		// Properties
		public string shopType { /* [XID] */ /* 0x0000000189BA96C0-0x0000000189BA96E0 */ get => default; /* [XID] */ /* 0x0000000189BB0ED0-0x0000000189BB0EF0 */ private set {} } // 0x00000001892226B0-0x0000000189222750 0x0000000189222750-0x0000000189222800
	
		// Constructors
		public ConfigShopExchangeInterAction() {} // 0x0000000189222650-0x00000001892226B0
	
		// Methods
		// [XID] // 0x0000000189BB80C0-0x0000000189BB80E0
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000189221700-0x00000001892217F0
		// [XID] // 0x0000000189BBF7D0-0x0000000189BBF7F0
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000189220760-0x0000000189220840
		// [XID] // 0x0000000189BC73E0-0x0000000189BC7400
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF9749 */) => default; // 0x0000000189220680-0x0000000189220760
		// [XID] // 0x0000000189BCF0D0-0x0000000189BCF0F0
		public override int GetHashNum() => default; // 0x0000000189220EC0-0x0000000189220F90
		// [XID] // 0x0000000189BD6460-0x0000000189BD6480
		public override void InitEmpty() {} // 0x0000000189220F90-0x0000000189221060
		[BlackList] // 0x0000000189BDDF60-0x0000000189BDDFA0
		// [XID] // 0x0000000189BDDF60-0x0000000189BDDFA0
		public override bool FromJson(JSONNode node) => default; // 0x0000000189220B40-0x0000000189220EC0
		// [XID] // 0x00000001895EDA10-0x00000001895EDA30
		private new bool InternalFromJson(JSONNode node) => default; // 0x00000001892212D0-0x0000000189221500
		[BlackList] // 0x00000001895F5230-0x00000001895F5270
		// [XID] // 0x00000001895F5230-0x00000001895F5270
		public static new ConfigShopExchangeInterAction ParseFromJson(JSONNode node) => default; // 0x0000000189221A10-0x0000000189221C60
		// [XID] // 0x00000001895FF830-0x00000001895FF850
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF974A */, bool useObjectPool = false /* Metadata: 0x00AF974E */) => default; // 0x0000000189220840-0x0000000189220B40
		// [XID] // 0x0000000189606F80-0x0000000189606FA0
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF974F */, bool useObjectPool = false /* Metadata: 0x00AF9753 */) => default; // 0x0000000189221060-0x00000001892212D0
		// [XID] // 0x000000018960E8E0-0x000000018960E900
		public static new ConfigShopExchangeInterAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9754 */, bool useObjectPool = false /* Metadata: 0x00AF9758 */) => default; // 0x00000001892217F0-0x0000000189221A10
		[BlackList] // 0x0000000189615F60-0x0000000189615FA0
		// [XID] // 0x0000000189615F60-0x0000000189615FA0
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000189221DF0-0x00000001892220C0
		// [XID] // 0x0000000189620800-0x0000000189620820
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000189221500-0x0000000189221700
		[BlackList] // 0x0000000189627CB0-0x0000000189627CF0
		// [XID] // 0x0000000189627CB0-0x0000000189627CF0
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000189221D00-0x0000000189221DF0
		[BlackList] // 0x0000000189632580-0x00000001896325C0
		// [XID] // 0x0000000189632580-0x00000001896325C0
		public override void AutoAllocTypeFields() {} // 0x0000000189220530-0x00000001892205D0
		[BlackList] // 0x000000018963D150-0x000000018963D190
		// [XID] // 0x000000018963D150-0x000000018963D190
		public override void AutoRecycleTypeFields() {} // 0x00000001892205D0-0x0000000189220680
		[BlackList] // 0x0000000189647750-0x0000000189647790
		// [XID] // 0x0000000189647750-0x0000000189647790
		public override void ReturnToObjectPool() {} // 0x0000000189221C60-0x0000000189221D00
	}
}
