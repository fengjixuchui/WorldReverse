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
	public class ConfigPlayPostEffectAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18447
	{
		// Fields
		private string _assetName; // 0x30
		private bool _isRemove; // 0x38
	
		// Properties
		public string assetName { /* [XID] */ /* 0x0000000189689AD0-0x0000000189689AF0 */ get => default; /* [XID] */ /* 0x0000000189691910-0x0000000189691930 */ private set {} } // 0x0000000189218490-0x0000000189218530 0x00000001892185D0-0x0000000189218680
		public bool isRemove { /* [XID] */ /* 0x0000000189698E60-0x0000000189698E80 */ get => default; /* [XID] */ /* 0x00000001896A03D0-0x00000001896A03F0 */ private set {} } // 0x0000000189218530-0x00000001892185D0 0x0000000189218680-0x0000000189218730
	
		// Constructors
		public ConfigPlayPostEffectAction() {} // 0x0000000189218420-0x0000000189218490
	
		// Methods
		// [XID] // 0x00000001896A78C0-0x00000001896A78E0
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001892174B0-0x00000001892175C0
		// [XID] // 0x00000001896AED10-0x00000001896AED30
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000189216350-0x0000000189216430
		// [XID] // 0x00000001896B6420-0x00000001896B6440
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF98B9 */) => default; // 0x0000000189216270-0x0000000189216350
		// [XID] // 0x00000001896BD6A0-0x00000001896BD6C0
		public override int GetHashNum() => default; // 0x0000000189216AB0-0x0000000189216B80
		// [XID] // 0x00000001896C4D50-0x00000001896C4D70
		public override void InitEmpty() {} // 0x0000000189216B80-0x0000000189216C50
		[BlackList] // 0x00000001896CC1D0-0x00000001896CC210
		// [XID] // 0x00000001896CC1D0-0x00000001896CC210
		public override bool FromJson(JSONNode node) => default; // 0x0000000189216730-0x0000000189216AB0
		// [XID] // 0x00000001896D6800-0x00000001896D6820
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000189216F30-0x0000000189217220
		[BlackList] // 0x00000001896DDEE0-0x00000001896DDF20
		// [XID] // 0x00000001896DDEE0-0x00000001896DDF20
		public static new ConfigPlayPostEffectAction ParseFromJson(JSONNode node) => default; // 0x00000001892177E0-0x0000000189217A30
		// [XID] // 0x00000001896E82C0-0x00000001896E82E0
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF98BA */, bool useObjectPool = false /* Metadata: 0x00AF98BE */) => default; // 0x0000000189216430-0x0000000189216730
		// [XID] // 0x00000001896EF920-0x00000001896EF940
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF98BF */, bool useObjectPool = false /* Metadata: 0x00AF98C3 */) => default; // 0x0000000189216C50-0x0000000189216F30
		// [XID] // 0x00000001896F72D0-0x00000001896F72F0
		public static new ConfigPlayPostEffectAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF98C4 */, bool useObjectPool = false /* Metadata: 0x00AF98C8 */) => default; // 0x00000001892175C0-0x00000001892177E0
		[BlackList] // 0x00000001896FEC70-0x00000001896FECB0
		// [XID] // 0x00000001896FEC70-0x00000001896FECB0
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000189217BC0-0x0000000189217E90
		// [XID] // 0x0000000189709080-0x00000001897090A0
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000189217220-0x00000001892174B0
		[BlackList] // 0x0000000189710930-0x0000000189710970
		// [XID] // 0x0000000189710930-0x0000000189710970
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000189217AD0-0x0000000189217BC0
		[BlackList] // 0x000000018971B020-0x000000018971B060
		// [XID] // 0x000000018971B020-0x000000018971B060
		public override void AutoAllocTypeFields() {} // 0x0000000189216120-0x00000001892161C0
		[BlackList] // 0x00000001897254C0-0x0000000189725500
		// [XID] // 0x00000001897254C0-0x0000000189725500
		public override void AutoRecycleTypeFields() {} // 0x00000001892161C0-0x0000000189216270
		[BlackList] // 0x000000018972FBD0-0x000000018972FC10
		// [XID] // 0x000000018972FBD0-0x000000018972FC10
		public override void ReturnToObjectPool() {} // 0x0000000189217A30-0x0000000189217AD0
	}
}
