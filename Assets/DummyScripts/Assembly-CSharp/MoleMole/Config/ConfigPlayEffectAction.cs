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
	public class ConfigPlayEffectAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18441
	{
		// Fields
		private string _effectIndex; // 0x30
		private string _patternName; // 0x38
		private Vector _pos; // 0x40
		private Vector _euler; // 0x4C
		private Vector _scale; // 0x58
		private bool _isLoop; // 0x64
		private bool _attachToEntity; // 0x65
		private bool _isRemove; // 0x66
	
		// Properties
		public string effectIndex { /* [XID] */ /* 0x00000001899C87E0-0x00000001899C8800 */ get => default; /* [XID] */ /* 0x00000001899D01F0-0x00000001899D0210 */ private set {} } // 0x0000000189215620-0x00000001892156C0 0x0000000189215BF0-0x0000000189215CA0
		public string patternName { /* [XID] */ /* 0x00000001899D7690-0x00000001899D76B0 */ get => default; /* [XID] */ /* 0x00000001899DEAD0-0x00000001899DEAF0 */ private set {} } // 0x00000001892158E0-0x0000000189215980 0x0000000189215ED0-0x0000000189215F80
		public Vector pos { /* [XID] */ /* 0x00000001899E6730-0x00000001899E6750 */ get => default; /* [XID] */ /* 0x00000001899EDD40-0x00000001899EDD60 */ private set {} } // 0x0000000189215980-0x0000000189215A60 0x0000000189215F80-0x0000000189216050
		public Vector euler { /* [XID] */ /* 0x00000001899F55D0-0x00000001899F55F0 */ get => default; /* [XID] */ /* 0x00000001899FCCF0-0x00000001899FCD10 */ private set {} } // 0x00000001892156C0-0x00000001892157A0 0x0000000189215CA0-0x0000000189215D70
		public Vector scale { /* [XID] */ /* 0x0000000189A04130-0x0000000189A04150 */ get => default; /* [XID] */ /* 0x0000000189A0B870-0x0000000189A0B890 */ private set {} } // 0x0000000189215A60-0x0000000189215B40 0x0000000189216050-0x0000000189216120
		public bool isLoop { /* [XID] */ /* 0x0000000189A130E0-0x0000000189A13100 */ get => default; /* [XID] */ /* 0x0000000189A1A390-0x0000000189A1A3B0 */ private set {} } // 0x00000001892157A0-0x0000000189215840 0x0000000189215D70-0x0000000189215E20
		public bool attachToEntity { /* [XID] */ /* 0x0000000189A21A70-0x0000000189A21A90 */ get => default; /* [XID] */ /* 0x0000000189A28F80-0x0000000189A28FA0 */ private set {} } // 0x0000000189215580-0x0000000189215620 0x0000000189215B40-0x0000000189215BF0
		public bool isRemove { /* [XID] */ /* 0x0000000189A30570-0x0000000189A30590 */ get => default; /* [XID] */ /* 0x0000000189A37F70-0x0000000189A37F90 */ private set {} } // 0x0000000189215840-0x00000001892158E0 0x0000000189215E20-0x0000000189215ED0
	
		// Constructors
		public ConfigPlayEffectAction() {} // 0x0000000189215510-0x0000000189215580
	
		// Methods
		// [XID] // 0x0000000189A3F720-0x0000000189A3F740
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001892144A0-0x00000001892146B0
		// [XID] // 0x0000000189A46D90-0x0000000189A46DB0
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001892126B0-0x00000001892127B0
		// [XID] // 0x0000000189A4E6C0-0x0000000189A4E6E0
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF9889 */) => default; // 0x00000001892125D0-0x00000001892126B0
		// [XID] // 0x0000000189A55D80-0x0000000189A55DA0
		public override int GetHashNum() => default; // 0x0000000189212E30-0x0000000189212F00
		// [XID] // 0x0000000189A5D700-0x0000000189A5D720
		public override void InitEmpty() {} // 0x0000000189212F00-0x0000000189213020
		[BlackList] // 0x0000000189A64F60-0x0000000189A64FA0
		// [XID] // 0x0000000189A64F60-0x0000000189A64FA0
		public override bool FromJson(JSONNode node) => default; // 0x0000000189212AB0-0x0000000189212E30
		// [XID] // 0x0000000189A6F680-0x0000000189A6F6A0
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000189213660-0x0000000189213E10
		[BlackList] // 0x0000000189A76E30-0x0000000189A76E70
		// [XID] // 0x0000000189A76E30-0x0000000189A76E70
		public static new ConfigPlayEffectAction ParseFromJson(JSONNode node) => default; // 0x00000001892148D0-0x0000000189214B20
		// [XID] // 0x0000000189A818B0-0x0000000189A818D0
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF988A */, bool useObjectPool = false /* Metadata: 0x00AF988E */) => default; // 0x00000001892127B0-0x0000000189212AB0
		// [XID] // 0x0000000189A893F0-0x0000000189A89410
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF988F */, bool useObjectPool = false /* Metadata: 0x00AF9893 */) => default; // 0x0000000189213020-0x0000000189213660
		// [XID] // 0x0000000189A90C30-0x0000000189A90C50
		public static new ConfigPlayEffectAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9894 */, bool useObjectPool = false /* Metadata: 0x00AF9898 */) => default; // 0x00000001892146B0-0x00000001892148D0
		[BlackList] // 0x0000000189A983A0-0x0000000189A983E0
		// [XID] // 0x0000000189A983A0-0x0000000189A983E0
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000189214CB0-0x0000000189214F80
		// [XID] // 0x0000000189AA2640-0x0000000189AA2660
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000189213E10-0x00000001892144A0
		[BlackList] // 0x0000000189AA9BC0-0x0000000189AA9C00
		// [XID] // 0x0000000189AA9BC0-0x0000000189AA9C00
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000189214BC0-0x0000000189214CB0
		[BlackList] // 0x0000000189AB47B0-0x0000000189AB47F0
		// [XID] // 0x0000000189AB47B0-0x0000000189AB47F0
		public override void AutoAllocTypeFields() {} // 0x0000000189212440-0x00000001892124E0
		[BlackList] // 0x0000000189ABF190-0x0000000189ABF1D0
		// [XID] // 0x0000000189ABF190-0x0000000189ABF1D0
		public override void AutoRecycleTypeFields() {} // 0x00000001892124E0-0x00000001892125D0
		[BlackList] // 0x0000000189AC9AA0-0x0000000189AC9AE0
		// [XID] // 0x0000000189AC9AA0-0x0000000189AC9AE0
		public override void ReturnToObjectPool() {} // 0x0000000189214B20-0x0000000189214BC0
	}
}
