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
	public class ConfigSimpleBlackScreenAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18429
	{
		// Fields
		private float _durationToBlack; // 0x30
		private float _durationKeepBlack; // 0x34
		private float _durationFromBlack; // 0x38
		private string _textMapID; // 0x40
	
		// Properties
		public float durationToBlack { /* [XID] */ /* 0x0000000189B2C850-0x0000000189B2C870 */ get => default; /* [XID] */ /* 0x0000000189B33D20-0x0000000189B33D40 */ private set {} } // 0x0000000189227330-0x00000001892273E0 0x00000001892275E0-0x0000000189227690
		public float durationKeepBlack { /* [XID] */ /* 0x0000000189B3B5B0-0x0000000189B3B5D0 */ get => default; /* [XID] */ /* 0x0000000189B42FD0-0x0000000189B42FF0 */ private set {} } // 0x0000000189227280-0x0000000189227330 0x0000000189227530-0x00000001892275E0
		public float durationFromBlack { /* [XID] */ /* 0x0000000189B4A850-0x0000000189B4A870 */ get => default; /* [XID] */ /* 0x0000000189B51FC0-0x0000000189B51FE0 */ private set {} } // 0x00000001892271D0-0x0000000189227280 0x0000000189227480-0x0000000189227530
		public string textMapID { /* [XID] */ /* 0x0000000189B59820-0x0000000189B59840 */ get => default; /* [XID] */ /* 0x0000000189B610B0-0x0000000189B610D0 */ private set {} } // 0x00000001892273E0-0x0000000189227480 0x0000000189227690-0x0000000189227740
	
		// Constructors
		public ConfigSimpleBlackScreenAction() {} // 0x0000000189227170-0x00000001892271D0
	
		// Methods
		// [XID] // 0x0000000189B68840-0x0000000189B68860
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001892261C0-0x0000000189226310
		// [XID] // 0x0000000189B6FD60-0x0000000189B6FD80
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000189224D00-0x0000000189224DE0
		// [XID] // 0x0000000189B77210-0x0000000189B77230
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF9829 */) => default; // 0x0000000189224C20-0x0000000189224D00
		// [XID] // 0x0000000189B7E820-0x0000000189B7E840
		public override int GetHashNum() => default; // 0x0000000189225460-0x0000000189225530
		// [XID] // 0x0000000189B86560-0x0000000189B86580
		public override void InitEmpty() {} // 0x0000000189225530-0x0000000189225600
		[BlackList] // 0x0000000189B8D5B0-0x0000000189B8D5F0
		// [XID] // 0x0000000189B8D5B0-0x0000000189B8D5F0
		public override bool FromJson(JSONNode node) => default; // 0x00000001892250E0-0x0000000189225460
		// [XID] // 0x0000000189B97BA0-0x0000000189B97BC0
		private new bool InternalFromJson(JSONNode node) => default; // 0x00000001892259D0-0x0000000189225E30
		[BlackList] // 0x0000000189B9EED0-0x0000000189B9EF10
		// [XID] // 0x0000000189B9EED0-0x0000000189B9EF10
		public static new ConfigSimpleBlackScreenAction ParseFromJson(JSONNode node) => default; // 0x0000000189226530-0x0000000189226780
		// [XID] // 0x0000000189BA96A0-0x0000000189BA96C0
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF982A */, bool useObjectPool = false /* Metadata: 0x00AF982E */) => default; // 0x0000000189224DE0-0x00000001892250E0
		// [XID] // 0x0000000189BB0EB0-0x0000000189BB0ED0
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF982F */, bool useObjectPool = false /* Metadata: 0x00AF9833 */) => default; // 0x0000000189225600-0x00000001892259D0
		// [XID] // 0x0000000189BB80A0-0x0000000189BB80C0
		public static new ConfigSimpleBlackScreenAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9834 */, bool useObjectPool = false /* Metadata: 0x00AF9838 */) => default; // 0x0000000189226310-0x0000000189226530
		[BlackList] // 0x0000000189BBF790-0x0000000189BBF7D0
		// [XID] // 0x0000000189BBF790-0x0000000189BBF7D0
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000189226910-0x0000000189226BE0
		// [XID] // 0x0000000189BCA8B0-0x0000000189BCA8D0
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000189225E30-0x00000001892261C0
		[BlackList] // 0x0000000189BD1EA0-0x0000000189BD1EE0
		// [XID] // 0x0000000189BD1EA0-0x0000000189BD1EE0
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000189226820-0x0000000189226910
		[BlackList] // 0x0000000189BDC720-0x0000000189BDC760
		// [XID] // 0x0000000189BDC720-0x0000000189BDC760
		public override void AutoAllocTypeFields() {} // 0x0000000189224AD0-0x0000000189224B70
		[BlackList] // 0x00000001895EC250-0x00000001895EC290
		// [XID] // 0x00000001895EC250-0x00000001895EC290
		public override void AutoRecycleTypeFields() {} // 0x0000000189224B70-0x0000000189224C20
		[BlackList] // 0x00000001895F6A40-0x00000001895F6A80
		// [XID] // 0x00000001895F6A40-0x00000001895F6A80
		public override void ReturnToObjectPool() {} // 0x0000000189226780-0x0000000189226820
	}
}
