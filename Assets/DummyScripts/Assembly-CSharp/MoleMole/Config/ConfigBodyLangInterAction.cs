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
	public class ConfigBodyLangInterAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 14935
	{
		// Fields
		private bool _isContinue; // 0x30
		private int _bodyLangParam; // 0x34
		private int _loopState; // 0x38
		private bool _forceInterrupt; // 0x3C
		private int[] _randomParamList; // 0x40
		private bool _forceDoFreeStyle; // 0x48
	
		// Properties
		public bool isContinue { /* [XID] */ /* 0x0000000189B96930-0x0000000189B96950 */ get => default; /* [XID] */ /* 0x0000000189B9DE80-0x0000000189B9DEA0 */ private set {} } // 0x0000000187E02B00-0x0000000187E02BA0 0x0000000187E02EF0-0x0000000187E02FA0
		public int bodyLangParam { /* [XID] */ /* 0x0000000189BA5810-0x0000000189BA5830 */ get => default; /* [XID] */ /* 0x0000000189BACA30-0x0000000189BACA50 */ private set {} } // 0x0000000187E02920-0x0000000187E029C0 0x0000000187E02CE0-0x0000000187E02D90
		public int loopState { /* [XID] */ /* 0x0000000189BB42B0-0x0000000189BB42D0 */ get => default; /* [XID] */ /* 0x0000000189BBB8D0-0x0000000189BBB8F0 */ private set {} } // 0x0000000187E02BA0-0x0000000187E02C40 0x0000000187E02FA0-0x0000000187E03050
		public bool forceInterrupt { /* [XID] */ /* 0x0000000189BC3770-0x0000000189BC3790 */ get => default; /* [XID] */ /* 0x0000000189BCAF30-0x0000000189BCAF50 */ private set {} } // 0x0000000187E02A60-0x0000000187E02B00 0x0000000187E02E40-0x0000000187E02EF0
		public int[] randomParamList { /* [XID] */ /* 0x0000000189BD25C0-0x0000000189BD25E0 */ get => default; /* [XID] */ /* 0x0000000189BD9B40-0x0000000189BD9B60 */ private set {} } // 0x0000000187E02C40-0x0000000187E02CE0 0x0000000187E03050-0x0000000187E03100
		public bool forceDoFreeStyle { /* [XID] */ /* 0x00000001895E6590-0x00000001895E65B0 */ get => default; /* [XID] */ /* 0x00000001895EE090-0x00000001895EE0B0 */ private set {} } // 0x0000000187E029C0-0x0000000187E02A60 0x0000000187E02D90-0x0000000187E02E40
	
		// Constructors
		public ConfigBodyLangInterAction(InteractionType type, float duration, int bodyLangParam, bool forceInterrupt) {} // 0x0000000187E02860-0x0000000187E02920
		public ConfigBodyLangInterAction() {} // 0x0000000187E02790-0x0000000187E02860
	
		// Methods
		// [XID] // 0x00000001895F57F0-0x00000001895F5810
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000187E017B0-0x0000000187E01930
		// [XID] // 0x00000001895FCD90-0x00000001895FCDB0
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000187DFFF70-0x0000000187E00050
		// [XID] // 0x00000001896047D0-0x00000001896047F0
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AEFAB6 */) => default; // 0x0000000187DFFE90-0x0000000187DFFF70
		// [XID] // 0x000000018960C060-0x000000018960C080
		public override int GetHashNum() => default; // 0x0000000187E006D0-0x0000000187E007A0
		// [XID] // 0x00000001896135E0-0x0000000189613600
		public override void InitEmpty() {} // 0x0000000187E007A0-0x0000000187E00870
		[BlackList] // 0x000000018961AE60-0x000000018961AEA0
		// [XID] // 0x000000018961AE60-0x000000018961AEA0
		public override bool FromJson(JSONNode node) => default; // 0x0000000187E00350-0x0000000187E006D0
		// [XID] // 0x00000001896252F0-0x0000000189625310
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000187E00D30-0x0000000187E012F0
		[BlackList] // 0x000000018962CA90-0x000000018962CAD0
		// [XID] // 0x000000018962CA90-0x000000018962CAD0
		public static new ConfigBodyLangInterAction ParseFromJson(JSONNode node) => default; // 0x0000000187E01B50-0x0000000187E01DA0
		// [XID] // 0x00000001896378A0-0x00000001896378C0
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFAB7 */, bool useObjectPool = false /* Metadata: 0x00AEFABB */) => default; // 0x0000000187E00050-0x0000000187E00350
		// [XID] // 0x000000018963ECC0-0x000000018963ECE0
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFABC */, bool useObjectPool = false /* Metadata: 0x00AEFAC0 */) => default; // 0x0000000187E00870-0x0000000187E00D30
		// [XID] // 0x00000001896464C0-0x00000001896464E0
		public static new ConfigBodyLangInterAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFAC1 */, bool useObjectPool = false /* Metadata: 0x00AEFAC5 */) => default; // 0x0000000187E01930-0x0000000187E01B50
		[BlackList] // 0x000000018964DCE0-0x000000018964DD20
		// [XID] // 0x000000018964DCE0-0x000000018964DD20
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000187E01F30-0x0000000187E02200
		// [XID] // 0x0000000189658530-0x0000000189658550
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000187E012F0-0x0000000187E017B0
		[BlackList] // 0x000000018965FA60-0x000000018965FAA0
		// [XID] // 0x000000018965FA60-0x000000018965FAA0
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000187E01E40-0x0000000187E01F30
		[BlackList] // 0x000000018966A540-0x000000018966A580
		// [XID] // 0x000000018966A540-0x000000018966A580
		public override void AutoAllocTypeFields() {} // 0x0000000187DFFD30-0x0000000187DFFDD0
		[BlackList] // 0x00000001896751B0-0x00000001896751F0
		// [XID] // 0x00000001896751B0-0x00000001896751F0
		public override void AutoRecycleTypeFields() {} // 0x0000000187DFFDD0-0x0000000187DFFE90
		[BlackList] // 0x000000018967F8C0-0x000000018967F900
		// [XID] // 0x000000018967F8C0-0x000000018967F900
		public override void ReturnToObjectPool() {} // 0x0000000187E01DA0-0x0000000187E01E40
	}
}
