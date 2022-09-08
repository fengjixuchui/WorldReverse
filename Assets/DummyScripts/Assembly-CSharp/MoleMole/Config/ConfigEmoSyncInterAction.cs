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
	public class ConfigEmoSyncInterAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18404
	{
		// Fields
		private string _dataPath; // 0x30
		private string _phonemePath; // 0x38
		private string _emotionPath; // 0x40
		private string _mateDataPath; // 0x48
		private string _matePhonemePath; // 0x50
		private string _mateEmotionPath; // 0x58
		private EmoBackType _backType; // 0x60
		private bool _enableBlink; // 0x64
		private ulong[] _dataPathHashList; // 0x68
		private ulong[] _phonemePathHashList; // 0x70
		private ulong[] _emotionPathHashList; // 0x78
		private ulong[] _mateDataPathHashList; // 0x80
		private ulong[] _matePhonemePathHashList; // 0x88
		private ulong[] _mateEmotionPathHashList; // 0x90
	
		// Properties
		public string dataPath { /* [XID] */ /* 0x00000001896FA010-0x00000001896FA030 */ get => default; /* [XID] */ /* 0x0000000189701820-0x0000000189701840 */ private set {} } // 0x0000000188B98460-0x0000000188B98500 0x0000000188B98D70-0x0000000188B98E20
		public string phonemePath { /* [XID] */ /* 0x00000001897090A0-0x00000001897090C0 */ get => default; /* [XID] */ /* 0x0000000189710970-0x0000000189710990 */ private set {} } // 0x0000000188B98B70-0x0000000188B98C10 0x0000000188B99500-0x0000000188B995B0
		public string emotionPath { /* [XID] */ /* 0x0000000189717CD0-0x0000000189717CF0 */ get => default; /* [XID] */ /* 0x000000018971F710-0x000000018971F730 */ private set {} } // 0x0000000188B985A0-0x0000000188B98640 0x0000000188B98ED0-0x0000000188B98F80
		public string mateDataPath { /* [XID] */ /* 0x0000000189726CE0-0x0000000189726D00 */ get => default; /* [XID] */ /* 0x000000018972E290-0x000000018972E2B0 */ private set {} } // 0x0000000188B98790-0x0000000188B98830 0x0000000188B990E0-0x0000000188B99190
		public string matePhonemePath { /* [XID] */ /* 0x0000000189735940-0x0000000189735960 */ get => default; /* [XID] */ /* 0x000000018973D4F0-0x000000018973D510 */ private set {} } // 0x0000000188B98A30-0x0000000188B98AD0 0x0000000188B993A0-0x0000000188B99450
		public string mateEmotionPath { /* [XID] */ /* 0x0000000189744970-0x0000000189744990 */ get => default; /* [XID] */ /* 0x000000018974C6C0-0x000000018974C6E0 */ private set {} } // 0x0000000188B988E0-0x0000000188B98980 0x0000000188B99240-0x0000000188B992F0
		public EmoBackType backType { /* [XID] */ /* 0x0000000189753920-0x0000000189753940 */ get => default; /* [XID] */ /* 0x000000018975AF40-0x000000018975AF60 */ private set {} } // 0x0000000188B98320-0x0000000188B983C0 0x0000000188B98C10-0x0000000188B98CC0
		public bool enableBlink { /* [XID] */ /* 0x00000001897628F0-0x0000000189762910 */ get => default; /* [XID] */ /* 0x0000000189769EF0-0x0000000189769F10 */ private set {} } // 0x0000000188B98640-0x0000000188B986E0 0x0000000188B98F80-0x0000000188B99030
		public ulong[] dataPathHashList { /* [XID] */ /* 0x00000001897716F0-0x0000000189771710 */ get => default; /* [XID] */ /* 0x0000000189778E60-0x0000000189778E80 */ private set {} } // 0x0000000188B983C0-0x0000000188B98460 0x0000000188B98CC0-0x0000000188B98D70
		public ulong[] phonemePathHashList { /* [XID] */ /* 0x00000001897804E0-0x0000000189780500 */ get => default; /* [XID] */ /* 0x0000000189787CE0-0x0000000189787D00 */ private set {} } // 0x0000000188B98AD0-0x0000000188B98B70 0x0000000188B99450-0x0000000188B99500
		public ulong[] emotionPathHashList { /* [XID] */ /* 0x000000018978F200-0x000000018978F220 */ get => default; /* [XID] */ /* 0x0000000189796A30-0x0000000189796A50 */ private set {} } // 0x0000000188B98500-0x0000000188B985A0 0x0000000188B98E20-0x0000000188B98ED0
		public ulong[] mateDataPathHashList { /* [XID] */ /* 0x000000018979EB70-0x000000018979EB90 */ get => default; /* [XID] */ /* 0x00000001897A6260-0x00000001897A6280 */ private set {} } // 0x0000000188B986E0-0x0000000188B98790 0x0000000188B99030-0x0000000188B990E0
		public ulong[] matePhonemePathHashList { /* [XID] */ /* 0x00000001897AD6D0-0x00000001897AD6F0 */ get => default; /* [XID] */ /* 0x00000001897B5830-0x00000001897B5850 */ private set {} } // 0x0000000188B98980-0x0000000188B98A30 0x0000000188B992F0-0x0000000188B993A0
		public ulong[] mateEmotionPathHashList { /* [XID] */ /* 0x00000001897BD560-0x00000001897BD580 */ get => default; /* [XID] */ /* 0x00000001897C4940-0x00000001897C4960 */ private set {} } // 0x0000000188B98830-0x0000000188B988E0 0x0000000188B99190-0x0000000188B99240
	
		// Constructors
		public ConfigEmoSyncInterAction() {} // 0x0000000188B982B0-0x0000000188B98320
	
		// Methods
		// [XID] // 0x00000001897CC110-0x00000001897CC130
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000188B97200-0x0000000188B97450
		// [XID] // 0x00000001897D3A40-0x00000001897D3A60
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000188B944E0-0x0000000188B94700
		// [XID] // 0x00000001897DB4D0-0x00000001897DB4F0
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF9769 */) => default; // 0x0000000188B94400-0x0000000188B944E0
		// [XID] // 0x00000001897E2BA0-0x00000001897E2BC0
		public override int GetHashNum() => default; // 0x0000000188B94D80-0x0000000188B94E50
		// [XID] // 0x00000001897EA380-0x00000001897EA3A0
		public override void InitEmpty() {} // 0x0000000188B94E50-0x0000000188B94FF0
		[BlackList] // 0x00000001897F2090-0x00000001897F20D0
		// [XID] // 0x00000001897F2090-0x00000001897F20D0
		public override bool FromJson(JSONNode node) => default; // 0x0000000188B94A00-0x0000000188B94D80
		// [XID] // 0x00000001897FC920-0x00000001897FC940
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000188B95AC0-0x0000000188B967E0
		[BlackList] // 0x0000000189803E50-0x0000000189803E90
		// [XID] // 0x0000000189803E50-0x0000000189803E90
		public static new ConfigEmoSyncInterAction ParseFromJson(JSONNode node) => default; // 0x0000000188B97670-0x0000000188B978C0
		// [XID] // 0x000000018980E3B0-0x000000018980E3D0
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF976A */, bool useObjectPool = false /* Metadata: 0x00AF976E */) => default; // 0x0000000188B94700-0x0000000188B94A00
		// [XID] // 0x0000000189815AB0-0x0000000189815AD0
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF976F */, bool useObjectPool = false /* Metadata: 0x00AF9773 */) => default; // 0x0000000188B94FF0-0x0000000188B95AC0
		// [XID] // 0x000000018981D550-0x000000018981D570
		public static new ConfigEmoSyncInterAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9774 */, bool useObjectPool = false /* Metadata: 0x00AF9778 */) => default; // 0x0000000188B97450-0x0000000188B97670
		[BlackList] // 0x0000000189824A20-0x0000000189824A60
		// [XID] // 0x0000000189824A20-0x0000000189824A60
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000188B97A50-0x0000000188B97D20
		// [XID] // 0x000000018982EFA0-0x000000018982EFC0
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000188B967E0-0x0000000188B97200
		[BlackList] // 0x0000000189836890-0x00000001898368D0
		// [XID] // 0x0000000189836890-0x00000001898368D0
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000188B97960-0x0000000188B97A50
		[BlackList] // 0x0000000189840C40-0x0000000189840C80
		// [XID] // 0x0000000189840C40-0x0000000189840C80
		public override void AutoAllocTypeFields() {} // 0x0000000188B94270-0x0000000188B94310
		[BlackList] // 0x000000018984B250-0x000000018984B290
		// [XID] // 0x000000018984B250-0x000000018984B290
		public override void AutoRecycleTypeFields() {} // 0x0000000188B94310-0x0000000188B94400
		[BlackList] // 0x0000000189855330-0x0000000189855370
		// [XID] // 0x0000000189855330-0x0000000189855370
		public override void ReturnToObjectPool() {} // 0x0000000188B978C0-0x0000000188B97960
	}
}
