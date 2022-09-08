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
	public class ConfigAudioPlayAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18413
	{
		// Fields
		private string _audioEventStr; // 0x30
	
		// Properties
		public string audioEventStr { /* [XID] */ /* 0x0000000189B09050-0x0000000189B09070 */ get => default; /* [XID] */ /* 0x0000000189B10A90-0x0000000189B10AB0 */ private set {} } // 0x0000000187DEFE90-0x0000000187DEFF30 0x0000000187DEFF30-0x0000000187DEFFE0
	
		// Constructors
		public ConfigAudioPlayAction() {} // 0x0000000187DEFDE0-0x0000000187DEFE90
	
		// Methods
		// [XID] // 0x0000000189B17BA0-0x0000000189B17BC0
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000187DEEE90-0x0000000187DEEF80
		// [XID] // 0x0000000189B1F520-0x0000000189B1F540
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000187DEDEF0-0x0000000187DEDFD0
		// [XID] // 0x0000000189B26D60-0x0000000189B26D80
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF97A9 */) => default; // 0x0000000187DEDE10-0x0000000187DEDEF0
		// [XID] // 0x0000000189B2DF90-0x0000000189B2DFB0
		public override int GetHashNum() => default; // 0x0000000187DEE650-0x0000000187DEE720
		// [XID] // 0x0000000189B35360-0x0000000189B35380
		public override void InitEmpty() {} // 0x0000000187DEE720-0x0000000187DEE7F0
		[BlackList] // 0x0000000189B3CC00-0x0000000189B3CC40
		// [XID] // 0x0000000189B3CC00-0x0000000189B3CC40
		public override bool FromJson(JSONNode node) => default; // 0x0000000187DEE2D0-0x0000000187DEE650
		// [XID] // 0x0000000189B47840-0x0000000189B47860
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000187DEEA60-0x0000000187DEEC90
		[BlackList] // 0x0000000189B4EF70-0x0000000189B4EFB0
		// [XID] // 0x0000000189B4EF70-0x0000000189B4EFB0
		public static new ConfigAudioPlayAction ParseFromJson(JSONNode node) => default; // 0x0000000187DEF1A0-0x0000000187DEF3F0
		// [XID] // 0x0000000189B59840-0x0000000189B59860
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF97AA */, bool useObjectPool = false /* Metadata: 0x00AF97AE */) => default; // 0x0000000187DEDFD0-0x0000000187DEE2D0
		// [XID] // 0x0000000189B610D0-0x0000000189B610F0
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF97AF */, bool useObjectPool = false /* Metadata: 0x00AF97B3 */) => default; // 0x0000000187DEE7F0-0x0000000187DEEA60
		// [XID] // 0x0000000189B68860-0x0000000189B68880
		public static new ConfigAudioPlayAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF97B4 */, bool useObjectPool = false /* Metadata: 0x00AF97B8 */) => default; // 0x0000000187DEEF80-0x0000000187DEF1A0
		[BlackList] // 0x0000000189B6FD80-0x0000000189B6FDC0
		// [XID] // 0x0000000189B6FD80-0x0000000189B6FDC0
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000187DEF580-0x0000000187DEF850
		// [XID] // 0x0000000189B7A2F0-0x0000000189B7A310
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000187DEEC90-0x0000000187DEEE90
		[BlackList] // 0x0000000189B81A70-0x0000000189B81AB0
		// [XID] // 0x0000000189B81A70-0x0000000189B81AB0
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000187DEF490-0x0000000187DEF580
		[BlackList] // 0x0000000189B8BD20-0x0000000189B8BD60
		// [XID] // 0x0000000189B8BD20-0x0000000189B8BD60
		public override void AutoAllocTypeFields() {} // 0x0000000187DEDCC0-0x0000000187DEDD60
		[BlackList] // 0x0000000189B96220-0x0000000189B96260
		// [XID] // 0x0000000189B96220-0x0000000189B96260
		public override void AutoRecycleTypeFields() {} // 0x0000000187DEDD60-0x0000000187DEDE10
		[BlackList] // 0x0000000189BA0730-0x0000000189BA0770
		// [XID] // 0x0000000189BA0730-0x0000000189BA0770
		public override void ReturnToObjectPool() {} // 0x0000000187DEF3F0-0x0000000187DEF490
	}
}
