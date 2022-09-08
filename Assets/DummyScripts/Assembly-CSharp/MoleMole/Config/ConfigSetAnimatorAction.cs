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
	public class ConfigSetAnimatorAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18445
	{
		// Fields
		private AnimatorParamType2 _paramType; // 0x30
		private string _paramName; // 0x38
		private int _intValue; // 0x40
		private float _floatValue; // 0x44
		private bool _boolValue; // 0x48
	
		// Properties
		public AnimatorParamType2 paramType { /* [XID] */ /* 0x0000000189B9AAE0-0x0000000189B9AB00 */ get => default; /* [XID] */ /* 0x0000000189BA22B0-0x0000000189BA22D0 */ private set {} } // 0x0000000189220120-0x00000001892201C0 0x0000000189220480-0x0000000189220530
		public string paramName { /* [XID] */ /* 0x0000000189BA9680-0x0000000189BA96A0 */ get => default; /* [XID] */ /* 0x0000000189BB0E90-0x0000000189BB0EB0 */ private set {} } // 0x0000000189220080-0x0000000189220120 0x00000001892203D0-0x0000000189220480
		public int intValue { /* [XID] */ /* 0x0000000189BB8080-0x0000000189BB80A0 */ get => default; /* [XID] */ /* 0x0000000189BBF770-0x0000000189BBF790 */ private set {} } // 0x000000018921FFE0-0x0000000189220080 0x0000000189220320-0x00000001892203D0
		public float floatValue { /* [XID] */ /* 0x0000000189BC73C0-0x0000000189BC73E0 */ get => default; /* [XID] */ /* 0x0000000189BCF0B0-0x0000000189BCF0D0 */ private set {} } // 0x000000018921FF30-0x000000018921FFE0 0x0000000189220270-0x0000000189220320
		public bool boolValue { /* [XID] */ /* 0x0000000189BD6440-0x0000000189BD6460 */ get => default; /* [XID] */ /* 0x0000000189BDDF40-0x0000000189BDDF60 */ private set {} } // 0x000000018921FE90-0x000000018921FF30 0x00000001892201C0-0x0000000189220270
	
		// Constructors
		public ConfigSetAnimatorAction() {} // 0x000000018921FE30-0x000000018921FE90
	
		// Methods
		// [XID] // 0x00000001895EAB50-0x00000001895EAB70
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018921EE70-0x000000018921EFD0
		// [XID] // 0x00000001895F1FD0-0x00000001895F1FF0
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018921D7E0-0x000000018921D8C0
		// [XID] // 0x00000001895F9920-0x00000001895F9940
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF98A9 */) => default; // 0x000000018921D700-0x000000018921D7E0
		// [XID] // 0x0000000189601020-0x0000000189601040
		public override int GetHashNum() => default; // 0x000000018921DF40-0x000000018921E010
		// [XID] // 0x00000001896089F0-0x0000000189608A10
		public override void InitEmpty() {} // 0x000000018921E010-0x000000018921E0E0
		[BlackList] // 0x00000001896101D0-0x0000000189610210
		// [XID] // 0x00000001896101D0-0x0000000189610210
		public override bool FromJson(JSONNode node) => default; // 0x000000018921DBC0-0x000000018921DF40
		// [XID] // 0x000000018961A7A0-0x000000018961A7C0
		private new bool InternalFromJson(JSONNode node) => default; // 0x000000018921E530-0x000000018921EA50
		[BlackList] // 0x0000000189621D60-0x0000000189621DA0
		// [XID] // 0x0000000189621D60-0x0000000189621DA0
		public static new ConfigSetAnimatorAction ParseFromJson(JSONNode node) => default; // 0x000000018921F1F0-0x000000018921F440
		// [XID] // 0x000000018962C410-0x000000018962C430
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF98AA */, bool useObjectPool = false /* Metadata: 0x00AF98AE */) => default; // 0x000000018921D8C0-0x000000018921DBC0
		// [XID] // 0x0000000189633F70-0x0000000189633F90
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF98AF */, bool useObjectPool = false /* Metadata: 0x00AF98B3 */) => default; // 0x000000018921E0E0-0x000000018921E530
		// [XID] // 0x000000018963B780-0x000000018963B7A0
		public static new ConfigSetAnimatorAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF98B4 */, bool useObjectPool = false /* Metadata: 0x00AF98B8 */) => default; // 0x000000018921EFD0-0x000000018921F1F0
		[BlackList] // 0x0000000189642F80-0x0000000189642FC0
		// [XID] // 0x0000000189642F80-0x0000000189642FC0
		public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018921F5D0-0x000000018921F8A0
		// [XID] // 0x000000018964D700-0x000000018964D720
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018921EA50-0x000000018921EE70
		[BlackList] // 0x0000000189654F00-0x0000000189654F40
		// [XID] // 0x0000000189654F00-0x0000000189654F40
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018921F4E0-0x000000018921F5D0
		[BlackList] // 0x000000018965F4A0-0x000000018965F4E0
		// [XID] // 0x000000018965F4A0-0x000000018965F4E0
		public override void AutoAllocTypeFields() {} // 0x000000018921D5B0-0x000000018921D650
		[BlackList] // 0x0000000189669F40-0x0000000189669F80
		// [XID] // 0x0000000189669F40-0x0000000189669F80
		public override void AutoRecycleTypeFields() {} // 0x000000018921D650-0x000000018921D700
		[BlackList] // 0x0000000189674950-0x0000000189674990
		// [XID] // 0x0000000189674950-0x0000000189674990
		public override void ReturnToObjectPool() {} // 0x000000018921F440-0x000000018921F4E0
	}
}
