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
	public class ConfigDialogInterAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18379
	{
		// Fields
		private DialogType _dialogType; // 0x30
		private uint _dialogID; // 0x34
		private float _protectTime; // 0x38
		private bool _playAudio; // 0x3C
	
		// Properties
		public DialogType dialogType { /* [XID] */ /* 0x00000001898BCDA0-0x00000001898BCDC0 */ get => default; /* [XID] */ /* 0x00000001898C4500-0x00000001898C4520 */ private set {} } // 0x0000000188B8ED70-0x0000000188B8EE10 0x0000000188B8F010-0x0000000188B8F0C0
		public uint dialogID { /* [XID] */ /* 0x00000001898CBA70-0x00000001898CBA90 */ get => default; /* [XID] */ /* 0x00000001898D32F0-0x00000001898D3310 */ private set {} } // 0x0000000188B8ECD0-0x0000000188B8ED70 0x0000000188B8EF60-0x0000000188B8F010
		public float protectTime { /* [XID] */ /* 0x00000001898DABE0-0x00000001898DAC00 */ get => default; /* [XID] */ /* 0x00000001898E2A60-0x00000001898E2A80 */ private set {} } // 0x0000000188B8EEB0-0x0000000188B8EF60 0x0000000188B8F170-0x0000000188B8F220
		public bool playAudio { /* [XID] */ /* 0x00000001898EA550-0x00000001898EA570 */ get => default; /* [XID] */ /* 0x00000001898F1CB0-0x00000001898F1CD0 */ private set {} } // 0x0000000188B8EE10-0x0000000188B8EEB0 0x0000000188B8F0C0-0x0000000188B8F170
	
		// Constructors
		public ConfigDialogInterAction() {} // 0x0000000188B8EC60-0x0000000188B8ECD0
	
		// Methods
		// [XID] // 0x00000001898F94F0-0x00000001898F9510
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000188B8DCB0-0x0000000188B8DE00
		// [XID] // 0x0000000189900E50-0x0000000189900E70
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000188B8C880-0x0000000188B8C930
		// [XID] // 0x00000001899085D0-0x00000001899085F0
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF96B9 */) => default; // 0x0000000188B8C7A0-0x0000000188B8C880
		// [XID] // 0x000000018990FC70-0x000000018990FC90
		public override int GetHashNum() => default; // 0x0000000188B8CFB0-0x0000000188B8D080
		// [XID] // 0x0000000189917780-0x00000001899177A0
		public override void InitEmpty() {} // 0x0000000188B8D080-0x0000000188B8D120
		[BlackList] // 0x000000018991ED80-0x000000018991EDC0
		// [XID] // 0x000000018991ED80-0x000000018991EDC0
		public override bool FromJson(JSONNode node) => default; // 0x0000000188B8CC30-0x0000000188B8CFB0
		// [XID] // 0x0000000189929760-0x0000000189929780
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000188B8D4C0-0x0000000188B8D910
		[BlackList] // 0x0000000189930DC0-0x0000000189930E00
		// [XID] // 0x0000000189930DC0-0x0000000189930E00
		public static new ConfigDialogInterAction ParseFromJson(JSONNode node) => default; // 0x0000000188B8E020-0x0000000188B8E270
		// [XID] // 0x000000018993B670-0x000000018993B690
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF96BA */, bool useObjectPool = false /* Metadata: 0x00AF96BE */) => default; // 0x0000000188B8C930-0x0000000188B8CC30
		// [XID] // 0x0000000189942750-0x0000000189942770
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF96BF */, bool useObjectPool = false /* Metadata: 0x00AF96C3 */) => default; // 0x0000000188B8D120-0x0000000188B8D4C0
		// [XID] // 0x000000018994A080-0x000000018994A0A0
		public static new ConfigDialogInterAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF96C4 */, bool useObjectPool = false /* Metadata: 0x00AF96C8 */) => default; // 0x0000000188B8DE00-0x0000000188B8E020
		[BlackList] // 0x0000000189951B10-0x0000000189951B50
		// [XID] // 0x0000000189951B10-0x0000000189951B50
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000188B8E400-0x0000000188B8E6D0
		// [XID] // 0x000000018995BF60-0x000000018995BF80
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000188B8D910-0x0000000188B8DCB0
		[BlackList] // 0x00000001899639E0-0x0000000189963A20
		// [XID] // 0x00000001899639E0-0x0000000189963A20
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000188B8E310-0x0000000188B8E400
		[BlackList] // 0x000000018996DDC0-0x000000018996DE00
		// [XID] // 0x000000018996DDC0-0x000000018996DE00
		public override void AutoAllocTypeFields() {} // 0x0000000188B8C650-0x0000000188B8C6F0
		[BlackList] // 0x0000000189978ED0-0x0000000189978F10
		// [XID] // 0x0000000189978ED0-0x0000000189978F10
		public override void AutoRecycleTypeFields() {} // 0x0000000188B8C6F0-0x0000000188B8C7A0
		[BlackList] // 0x00000001899833D0-0x0000000189983410
		// [XID] // 0x00000001899833D0-0x0000000189983410
		public override void ReturnToObjectPool() {} // 0x0000000188B8E270-0x0000000188B8E310
	}
}
