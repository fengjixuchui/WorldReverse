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
	public class ConfigSitOrStandAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18439
	{
		// Fields
		private bool _isSit; // 0x30
		private StandDirection _standDirection; // 0x34
	
		// Properties
		public bool isSit { /* [XID] */ /* 0x000000018990B390-0x000000018990B3B0 */ get => default; /* [XID] */ /* 0x0000000189913060-0x0000000189913080 */ private set {} } // 0x000000018922C3C0-0x000000018922C460 0x000000018922C500-0x000000018922C5B0
		public StandDirection standDirection { /* [XID] */ /* 0x000000018991A810-0x000000018991A830 */ get => default; /* [XID] */ /* 0x0000000189922020-0x0000000189922040 */ private set {} } // 0x000000018922C460-0x000000018922C500 0x000000018922C5B0-0x000000018922C660
	
		// Constructors
		public ConfigSitOrStandAction() {} // 0x000000018922C360-0x000000018922C3C0
	
		// Methods
		// [XID] // 0x0000000189929740-0x0000000189929760
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018922B3F0-0x000000018922B500
		// [XID] // 0x0000000189930D80-0x0000000189930DA0
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018922A330-0x000000018922A3E0
		// [XID] // 0x00000001899380F0-0x0000000189938110
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF9879 */) => default; // 0x000000018922A250-0x000000018922A330
		// [XID] // 0x000000018993FB80-0x000000018993FBA0
		public override int GetHashNum() => default; // 0x000000018922AA60-0x000000018922AB30
		// [XID] // 0x0000000189947240-0x0000000189947260
		public override void InitEmpty() {} // 0x000000018922AB30-0x000000018922ABD0
		[BlackList] // 0x000000018994E8E0-0x000000018994E920
		// [XID] // 0x000000018994E8E0-0x000000018994E920
		public override bool FromJson(JSONNode node) => default; // 0x000000018922A6E0-0x000000018922AA60
		// [XID] // 0x0000000189958FF0-0x0000000189959010
		private new bool InternalFromJson(JSONNode node) => default; // 0x000000018922AE70-0x000000018922B160
		[BlackList] // 0x0000000189960800-0x0000000189960840
		// [XID] // 0x0000000189960800-0x0000000189960840
		public static new ConfigSitOrStandAction ParseFromJson(JSONNode node) => default; // 0x000000018922B720-0x000000018922B970
		// [XID] // 0x000000018996AF50-0x000000018996AF70
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF987A */, bool useObjectPool = false /* Metadata: 0x00AF987E */) => default; // 0x000000018922A3E0-0x000000018922A6E0
		// [XID] // 0x0000000189972A50-0x0000000189972A70
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF987F */, bool useObjectPool = false /* Metadata: 0x00AF9883 */) => default; // 0x000000018922ABD0-0x000000018922AE70
		// [XID] // 0x000000018997A270-0x000000018997A290
		public static new ConfigSitOrStandAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9884 */, bool useObjectPool = false /* Metadata: 0x00AF9888 */) => default; // 0x000000018922B500-0x000000018922B720
		[BlackList] // 0x0000000189981A60-0x0000000189981AA0
		// [XID] // 0x0000000189981A60-0x0000000189981AA0
		public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018922BB00-0x000000018922BDD0
		// [XID] // 0x000000018998C250-0x000000018998C270
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018922B160-0x000000018922B3F0
		[BlackList] // 0x0000000189993F30-0x0000000189993F70
		// [XID] // 0x0000000189993F30-0x0000000189993F70
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018922BA10-0x000000018922BB00
		[BlackList] // 0x000000018999E950-0x000000018999E990
		// [XID] // 0x000000018999E950-0x000000018999E990
		public override void AutoAllocTypeFields() {} // 0x000000018922A100-0x000000018922A1A0
		[BlackList] // 0x00000001899A9160-0x00000001899A91A0
		// [XID] // 0x00000001899A9160-0x00000001899A91A0
		public override void AutoRecycleTypeFields() {} // 0x000000018922A1A0-0x000000018922A250
		[BlackList] // 0x00000001899B3BA0-0x00000001899B3BE0
		// [XID] // 0x00000001899B3BA0-0x00000001899B3BE0
		public override void ReturnToObjectPool() {} // 0x000000018922B970-0x000000018922BA10
	}
}
