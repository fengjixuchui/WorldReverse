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
	public class ConfigBlackScreenAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18407
	{
		// Fields
		private BlackScreenType _blackScreenType; // 0x30
		private float _durationToBlack; // 0x34
		private float _durationKeepBlack; // 0x38
		private float _durationFromBlack; // 0x3C
		private bool _changeToInteePos; // 0x40
		private string _inteePos; // 0x48
		private string _textMapID; // 0x50
		private bool _textShake; // 0x58
	
		// Properties
		public BlackScreenType blackScreenType { /* [XID] */ /* 0x0000000189869E80-0x0000000189869EA0 */ get => default; /* [XID] */ /* 0x0000000189871270-0x0000000189871290 */ private set {} } // 0x0000000187DFF280-0x0000000187DFF320 0x0000000187DFF7B0-0x0000000187DFF860
		public float durationToBlack { /* [XID] */ /* 0x0000000189878C30-0x0000000189878C50 */ get => default; /* [XID] */ /* 0x0000000189880200-0x0000000189880220 */ private set {} } // 0x0000000187DFF520-0x0000000187DFF5D0 0x0000000187DFFA70-0x0000000187DFFB20
		public float durationKeepBlack { /* [XID] */ /* 0x0000000189887720-0x0000000189887740 */ get => default; /* [XID] */ /* 0x000000018988EA40-0x000000018988EA60 */ private set {} } // 0x0000000187DFF470-0x0000000187DFF520 0x0000000187DFF9C0-0x0000000187DFFA70
		public float durationFromBlack { /* [XID] */ /* 0x0000000189895EE0-0x0000000189895F00 */ get => default; /* [XID] */ /* 0x000000018989D520-0x000000018989D540 */ private set {} } // 0x0000000187DFF3C0-0x0000000187DFF470 0x0000000187DFF910-0x0000000187DFF9C0
		public bool changeToInteePos { /* [XID] */ /* 0x00000001898A4EA0-0x00000001898A4EC0 */ get => default; /* [XID] */ /* 0x00000001898AC3A0-0x00000001898AC3C0 */ private set {} } // 0x0000000187DFF320-0x0000000187DFF3C0 0x0000000187DFF860-0x0000000187DFF910
		public string inteePos { /* [XID] */ /* 0x00000001898B3A00-0x00000001898B3A20 */ get => default; /* [XID] */ /* 0x00000001898BB810-0x00000001898BB830 */ private set {} } // 0x0000000187DFF5D0-0x0000000187DFF670 0x0000000187DFFB20-0x0000000187DFFBD0
		public string textMapID { /* [XID] */ /* 0x00000001898C2A40-0x00000001898C2A60 */ get => default; /* [XID] */ /* 0x00000001898CA440-0x00000001898CA460 */ private set {} } // 0x0000000187DFF670-0x0000000187DFF710 0x0000000187DFFBD0-0x0000000187DFFC80
		public bool textShake { /* [XID] */ /* 0x00000001898D1C70-0x00000001898D1C90 */ get => default; /* [XID] */ /* 0x00000001898D9510-0x00000001898D9530 */ private set {} } // 0x0000000187DFF710-0x0000000187DFF7B0 0x0000000187DFFC80-0x0000000187DFFD30
	
		// Constructors
		public ConfigBlackScreenAction() {} // 0x0000000187DFF1D0-0x0000000187DFF280
	
		// Methods
		// [XID] // 0x00000001898E11A0-0x00000001898E11C0
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000187DFE1C0-0x0000000187DFE370
		// [XID] // 0x00000001898E8B60-0x00000001898E8B80
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000187DFC590-0x0000000187DFC690
		// [XID] // 0x00000001898F0280-0x00000001898F02A0
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF9779 */) => default; // 0x0000000187DFC4B0-0x0000000187DFC590
		// [XID] // 0x00000001898F7D50-0x00000001898F7D70
		public override int GetHashNum() => default; // 0x0000000187DFCD10-0x0000000187DFCDE0
		// [XID] // 0x00000001898FF350-0x00000001898FF370
		public override void InitEmpty() {} // 0x0000000187DFCDE0-0x0000000187DFCED0
		[BlackList] // 0x0000000189906AF0-0x0000000189906B30
		// [XID] // 0x0000000189906AF0-0x0000000189906B30
		public override bool FromJson(JSONNode node) => default; // 0x0000000187DFC990-0x0000000187DFCD10
		// [XID] // 0x0000000189911280-0x00000001899112A0
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000187DFD4B0-0x0000000187DFDC10
		[BlackList] // 0x0000000189918E40-0x0000000189918E80
		// [XID] // 0x0000000189918E40-0x0000000189918E80
		public static new ConfigBlackScreenAction ParseFromJson(JSONNode node) => default; // 0x0000000187DFE590-0x0000000187DFE7E0
		// [XID] // 0x00000001899236C0-0x00000001899236E0
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF977A */, bool useObjectPool = false /* Metadata: 0x00AF977E */) => default; // 0x0000000187DFC690-0x0000000187DFC990
		// [XID] // 0x000000018992ADC0-0x000000018992ADE0
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF977F */, bool useObjectPool = false /* Metadata: 0x00AF9783 */) => default; // 0x0000000187DFCED0-0x0000000187DFD4B0
		// [XID] // 0x00000001899323C0-0x00000001899323E0
		public static new ConfigBlackScreenAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9784 */, bool useObjectPool = false /* Metadata: 0x00AF9788 */) => default; // 0x0000000187DFE370-0x0000000187DFE590
		[BlackList] // 0x0000000189939DB0-0x0000000189939DF0
		// [XID] // 0x0000000189939DB0-0x0000000189939DF0
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000187DFE970-0x0000000187DFEC40
		// [XID] // 0x0000000189944380-0x00000001899443A0
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000187DFDC10-0x0000000187DFE1C0
		[BlackList] // 0x000000018994B980-0x000000018994B9C0
		// [XID] // 0x000000018994B980-0x000000018994B9C0
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000187DFE880-0x0000000187DFE970
		[BlackList] // 0x0000000189955F40-0x0000000189955F80
		// [XID] // 0x0000000189955F40-0x0000000189955F80
		public override void AutoAllocTypeFields() {} // 0x0000000187DFC350-0x0000000187DFC3F0
		[BlackList] // 0x0000000189960840-0x0000000189960880
		// [XID] // 0x0000000189960840-0x0000000189960880
		public override void AutoRecycleTypeFields() {} // 0x0000000187DFC3F0-0x0000000187DFC4B0
		[BlackList] // 0x000000018996AF70-0x000000018996AFB0
		// [XID] // 0x000000018996AF70-0x000000018996AFB0
		public override void ReturnToObjectPool() {} // 0x0000000187DFE7E0-0x0000000187DFE880
	}
}
