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
	public class ConfigMoveToAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18421
	{
		// Fields
		private MoveToType _moveType; // 0x30
		private Vector[] _routeList; // 0x38
		private bool _exactlyMove; // 0x40
	
		// Properties
		public MoveToType moveType { /* [XID] */ /* 0x00000001898585A0-0x00000001898585C0 */ get => default; /* [XID] */ /* 0x000000018985F610-0x000000018985F630 */ private set {} } // 0x0000000188841A00-0x0000000188841AA0 0x0000000188841BF0-0x0000000188841CA0
		public Vector[] routeList { /* [XID] */ /* 0x0000000189866EB0-0x0000000189866ED0 */ get => default; /* [XID] */ /* 0x000000018986E6B0-0x000000018986E6D0 */ private set {} } // 0x0000000188841AA0-0x0000000188841B40 0x0000000188841CA0-0x0000000188841D50
		public bool exactlyMove { /* [XID] */ /* 0x0000000189875AC0-0x0000000189875AE0 */ get => default; /* [XID] */ /* 0x000000018987D720-0x000000018987D740 */ private set {} } // 0x0000000188841960-0x0000000188841A00 0x0000000188841B40-0x0000000188841BF0
	
		// Constructors
		public ConfigMoveToAction() {} // 0x0000000188841900-0x0000000188841960
	
		// Methods
		// [XID] // 0x0000000189884530-0x0000000189884550
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000188840970-0x0000000188840AA0
		// [XID] // 0x000000018988BC60-0x000000018988BC80
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018883F610-0x000000018883F6F0
		// [XID] // 0x0000000189893330-0x0000000189893350
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF97E9 */) => default; // 0x000000018883F530-0x000000018883F610
		// [XID] // 0x000000018989AA10-0x000000018989AA30
		public override int GetHashNum() => default; // 0x000000018883FD70-0x000000018883FE40
		// [XID] // 0x00000001898A1D00-0x00000001898A1D20
		public override void InitEmpty() {} // 0x000000018883FE40-0x000000018883FF10
		[BlackList] // 0x00000001898A9570-0x00000001898A95B0
		// [XID] // 0x00000001898A9570-0x00000001898A95B0
		public override bool FromJson(JSONNode node) => default; // 0x000000018883F9F0-0x000000018883FD70
		// [XID] // 0x00000001898B39E0-0x00000001898B3A00
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000188840270-0x0000000188840630
		[BlackList] // 0x00000001898BB7D0-0x00000001898BB810
		// [XID] // 0x00000001898BB7D0-0x00000001898BB810
		public static new ConfigMoveToAction ParseFromJson(JSONNode node) => default; // 0x0000000188840CC0-0x0000000188840F10
		// [XID] // 0x00000001898C5BB0-0x00000001898C5BD0
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF97EA */, bool useObjectPool = false /* Metadata: 0x00AF97EE */) => default; // 0x000000018883F6F0-0x000000018883F9F0
		// [XID] // 0x00000001898CD2E0-0x00000001898CD300
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF97EF */, bool useObjectPool = false /* Metadata: 0x00AF97F3 */) => default; // 0x000000018883FF10-0x0000000188840270
		// [XID] // 0x00000001898D4BB0-0x00000001898D4BD0
		public static new ConfigMoveToAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF97F4 */, bool useObjectPool = false /* Metadata: 0x00AF97F8 */) => default; // 0x0000000188840AA0-0x0000000188840CC0
		[BlackList] // 0x00000001898DC5B0-0x00000001898DC5F0
		// [XID] // 0x00000001898DC5B0-0x00000001898DC5F0
		public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001888410A0-0x0000000188841370
		// [XID] // 0x00000001898E7450-0x00000001898E7470
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000188840630-0x0000000188840970
		[BlackList] // 0x00000001898EEC40-0x00000001898EEC80
		// [XID] // 0x00000001898EEC40-0x00000001898EEC80
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000188840FB0-0x00000001888410A0
		[BlackList] // 0x00000001898F94B0-0x00000001898F94F0
		// [XID] // 0x00000001898F94B0-0x00000001898F94F0
		public override void AutoAllocTypeFields() {} // 0x000000018883F3E0-0x000000018883F480
		[BlackList] // 0x0000000189903DD0-0x0000000189903E10
		// [XID] // 0x0000000189903DD0-0x0000000189903E10
		public override void AutoRecycleTypeFields() {} // 0x000000018883F480-0x000000018883F530
		[BlackList] // 0x000000018990E610-0x000000018990E650
		// [XID] // 0x000000018990E610-0x000000018990E650
		public override void ReturnToObjectPool() {} // 0x0000000188840F10-0x0000000188840FB0
	}
}
