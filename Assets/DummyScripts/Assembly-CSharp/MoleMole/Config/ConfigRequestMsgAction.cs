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
	public class ConfigRequestMsgAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18423
	{
		// Fields
		private string _msgName; // 0x30
	
		// Properties
		public string msgName { /* [XID] */ /* 0x00000001899236A0-0x00000001899236C0 */ get => default; /* [XID] */ /* 0x000000018992ADA0-0x000000018992ADC0 */ private set {} } // 0x000000018921A8B0-0x000000018921A950 0x000000018921A950-0x000000018921AA00
	
		// Constructors
		public ConfigRequestMsgAction() {} // 0x000000018921A850-0x000000018921A8B0
	
		// Methods
		// [XID] // 0x00000001899323A0-0x00000001899323C0
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000189219900-0x00000001892199F0
		// [XID] // 0x0000000189939D90-0x0000000189939DB0
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000189218960-0x0000000189218A40
		// [XID] // 0x0000000189940FC0-0x0000000189940FE0
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF97F9 */) => default; // 0x0000000189218880-0x0000000189218960
		// [XID] // 0x0000000189948A60-0x0000000189948A80
		public override int GetHashNum() => default; // 0x00000001892190C0-0x0000000189219190
		// [XID] // 0x0000000189950210-0x0000000189950230
		public override void InitEmpty() {} // 0x0000000189219190-0x0000000189219260
		[BlackList] // 0x0000000189957700-0x0000000189957740
		// [XID] // 0x0000000189957700-0x0000000189957740
		public override bool FromJson(JSONNode node) => default; // 0x0000000189218D40-0x00000001892190C0
		// [XID] // 0x0000000189962350-0x0000000189962370
		private new bool InternalFromJson(JSONNode node) => default; // 0x00000001892194D0-0x0000000189219700
		[BlackList] // 0x00000001899697C0-0x0000000189969800
		// [XID] // 0x00000001899697C0-0x0000000189969800
		public static new ConfigRequestMsgAction ParseFromJson(JSONNode node) => default; // 0x0000000189219C10-0x0000000189219E60
		// [XID] // 0x0000000189974150-0x0000000189974170
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF97FA */, bool useObjectPool = false /* Metadata: 0x00AF97FE */) => default; // 0x0000000189218A40-0x0000000189218D40
		// [XID] // 0x000000018997B880-0x000000018997B8A0
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF97FF */, bool useObjectPool = false /* Metadata: 0x00AF9803 */) => default; // 0x0000000189219260-0x00000001892194D0
		// [XID] // 0x0000000189983390-0x00000001899833B0
		public static new ConfigRequestMsgAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9804 */, bool useObjectPool = false /* Metadata: 0x00AF9808 */) => default; // 0x00000001892199F0-0x0000000189219C10
		[BlackList] // 0x000000018998AB80-0x000000018998ABC0
		// [XID] // 0x000000018998AB80-0x000000018998ABC0
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000189219FF0-0x000000018921A2C0
		// [XID] // 0x0000000189995610-0x0000000189995630
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000189219700-0x0000000189219900
		[BlackList] // 0x000000018999D010-0x000000018999D050
		// [XID] // 0x000000018999D010-0x000000018999D050
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000189219F00-0x0000000189219FF0
		[BlackList] // 0x00000001899A7AC0-0x00000001899A7B00
		// [XID] // 0x00000001899A7AC0-0x00000001899A7B00
		public override void AutoAllocTypeFields() {} // 0x0000000189218730-0x00000001892187D0
		[BlackList] // 0x00000001899B23D0-0x00000001899B2410
		// [XID] // 0x00000001899B23D0-0x00000001899B2410
		public override void AutoRecycleTypeFields() {} // 0x00000001892187D0-0x0000000189218880
		[BlackList] // 0x00000001899BC8B0-0x00000001899BC8F0
		// [XID] // 0x00000001899BC8B0-0x00000001899BC8F0
		public override void ReturnToObjectPool() {} // 0x0000000189219E60-0x0000000189219F00
	}
}
