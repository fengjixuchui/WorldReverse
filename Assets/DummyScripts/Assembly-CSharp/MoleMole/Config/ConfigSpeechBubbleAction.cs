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
	public class ConfigSpeechBubbleAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18435
	{
		// Fields
		private uint _dialogID; // 0x30
		private uint _priority; // 0x34
		private bool _holdOn; // 0x38
		private bool _tryStop; // 0x39
	
		// Properties
		public uint dialogID { /* [XID] */ /* 0x0000000189783670-0x0000000189783690 */ get => default; /* [XID] */ /* 0x000000018978AD00-0x000000018978AD20 */ private set {} } // 0x000000018922ECC0-0x000000018922ED60 0x000000018922EF40-0x000000018922EFF0
		public uint priority { /* [XID] */ /* 0x0000000189792340-0x0000000189792360 */ get => default; /* [XID] */ /* 0x0000000189799890-0x00000001897998B0 */ private set {} } // 0x000000018922EE00-0x000000018922EEA0 0x000000018922F0A0-0x000000018922F150
		public bool holdOn { /* [XID] */ /* 0x00000001897A1720-0x00000001897A1740 */ get => default; /* [XID] */ /* 0x00000001897A8FA0-0x00000001897A8FC0 */ private set {} } // 0x000000018922ED60-0x000000018922EE00 0x000000018922EFF0-0x000000018922F0A0
		public bool tryStop { /* [XID] */ /* 0x00000001897B0820-0x00000001897B0840 */ get => default; /* [XID] */ /* 0x00000001897B8560-0x00000001897B8580 */ private set {} } // 0x000000018922EEA0-0x000000018922EF40 0x000000018922F150-0x000000018922F200
	
		// Constructors
		public ConfigSpeechBubbleAction() {} // 0x000000018922EC50-0x000000018922ECC0
	
		// Methods
		// [XID] // 0x00000001897C0600-0x00000001897C0620
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018922DCA0-0x000000018922DDF0
		// [XID] // 0x00000001897C7EB0-0x00000001897C7ED0
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018922C890-0x000000018922C940
		// [XID] // 0x00000001897CF210-0x00000001897CF230
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF9859 */) => default; // 0x000000018922C7B0-0x000000018922C890
		// [XID] // 0x00000001897D6A40-0x00000001897D6A60
		public override int GetHashNum() => default; // 0x000000018922CFC0-0x000000018922D090
		// [XID] // 0x00000001897DE1B0-0x00000001897DE1D0
		public override void InitEmpty() {} // 0x000000018922D090-0x000000018922D130
		[BlackList] // 0x00000001897E5C50-0x00000001897E5C90
		// [XID] // 0x00000001897E5C50-0x00000001897E5C90
		public override bool FromJson(JSONNode node) => default; // 0x000000018922CC40-0x000000018922CFC0
		// [XID] // 0x00000001897F07C0-0x00000001897F07E0
		private new bool InternalFromJson(JSONNode node) => default; // 0x000000018922D4D0-0x000000018922D910
		[BlackList] // 0x00000001897F7EE0-0x00000001897F7F20
		// [XID] // 0x00000001897F7EE0-0x00000001897F7F20
		public static new ConfigSpeechBubbleAction ParseFromJson(JSONNode node) => default; // 0x000000018922E010-0x000000018922E260
		// [XID] // 0x0000000189802600-0x0000000189802620
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF985A */, bool useObjectPool = false /* Metadata: 0x00AF985E */) => default; // 0x000000018922C940-0x000000018922CC40
		// [XID] // 0x0000000189809B30-0x0000000189809B50
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF985F */, bool useObjectPool = false /* Metadata: 0x00AF9863 */) => default; // 0x000000018922D130-0x000000018922D4D0
		// [XID] // 0x00000001898112C0-0x00000001898112E0
		public static new ConfigSpeechBubbleAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9864 */, bool useObjectPool = false /* Metadata: 0x00AF9868 */) => default; // 0x000000018922DDF0-0x000000018922E010
		[BlackList] // 0x0000000189818D50-0x0000000189818D90
		// [XID] // 0x0000000189818D50-0x0000000189818D90
		public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018922E3F0-0x000000018922E6C0
		// [XID] // 0x0000000189823070-0x0000000189823090
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018922D910-0x000000018922DCA0
		[BlackList] // 0x000000018982AAB0-0x000000018982AAF0
		// [XID] // 0x000000018982AAB0-0x000000018982AAF0
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018922E300-0x000000018922E3F0
		[BlackList] // 0x0000000189834F30-0x0000000189834F70
		// [XID] // 0x0000000189834F30-0x0000000189834F70
		public override void AutoAllocTypeFields() {} // 0x000000018922C660-0x000000018922C700
		[BlackList] // 0x000000018983F530-0x000000018983F570
		// [XID] // 0x000000018983F530-0x000000018983F570
		public override void AutoRecycleTypeFields() {} // 0x000000018922C700-0x000000018922C7B0
		[BlackList] // 0x00000001898498D0-0x0000000189849910
		// [XID] // 0x00000001898498D0-0x0000000189849910
		public override void ReturnToObjectPool() {} // 0x000000018922E260-0x000000018922E300
	}
}
