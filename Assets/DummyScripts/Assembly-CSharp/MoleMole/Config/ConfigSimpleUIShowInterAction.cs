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
	public class ConfigSimpleUIShowInterAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18431
	{
		// Fields
		private string _contextName; // 0x30
		private bool _isClose; // 0x38
		private string _param; // 0x40
	
		// Properties
		public string contextName { /* [XID] */ /* 0x000000018960BA20-0x000000018960BA40 */ get => default; /* [XID] */ /* 0x0000000189613000-0x0000000189613020 */ private set {} } // 0x0000000189229D10-0x0000000189229DB0 0x0000000189229EF0-0x0000000189229FA0
		public bool isClose { /* [XID] */ /* 0x000000018961A7C0-0x000000018961A7E0 */ get => default; /* [XID] */ /* 0x0000000189621DA0-0x0000000189621DC0 */ private set {} } // 0x0000000189229DB0-0x0000000189229E50 0x0000000189229FA0-0x000000018922A050
		public string param { /* [XID] */ /* 0x0000000189629710-0x0000000189629730 */ get => default; /* [XID] */ /* 0x0000000189631040-0x0000000189631060 */ private set {} } // 0x0000000189229E50-0x0000000189229EF0 0x000000018922A050-0x000000018922A100
	
		// Constructors
		public ConfigSimpleUIShowInterAction() {} // 0x0000000189229CA0-0x0000000189229D10
	
		// Methods
		// [XID] // 0x0000000189638AB0-0x0000000189638AD0
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000189228D10-0x0000000189228E40
		// [XID] // 0x000000018963FED0-0x000000018963FEF0
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000189227970-0x0000000189227A70
		// [XID] // 0x0000000189647730-0x0000000189647750
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF9839 */) => default; // 0x0000000189227890-0x0000000189227970
		// [XID] // 0x000000018964ED00-0x000000018964ED20
		public override int GetHashNum() => default; // 0x00000001892280F0-0x00000001892281C0
		// [XID] // 0x0000000189656590-0x00000001896565B0
		public override void InitEmpty() {} // 0x00000001892281C0-0x00000001892282B0
		[BlackList] // 0x000000018965DCD0-0x000000018965DD10
		// [XID] // 0x000000018965DCD0-0x000000018965DD10
		public override bool FromJson(JSONNode node) => default; // 0x0000000189227D70-0x00000001892280F0
		// [XID] // 0x0000000189668660-0x0000000189668680
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000189228630-0x0000000189228A00
		[BlackList] // 0x00000001896700D0-0x0000000189670110
		// [XID] // 0x00000001896700D0-0x0000000189670110
		public static new ConfigSimpleUIShowInterAction ParseFromJson(JSONNode node) => default; // 0x0000000189229060-0x00000001892292B0
		// [XID] // 0x000000018967A7E0-0x000000018967A800
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF983A */, bool useObjectPool = false /* Metadata: 0x00AF983E */) => default; // 0x0000000189227A70-0x0000000189227D70
		// [XID] // 0x00000001896820D0-0x00000001896820F0
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF983F */, bool useObjectPool = false /* Metadata: 0x00AF9843 */) => default; // 0x00000001892282B0-0x0000000189228630
		// [XID] // 0x0000000189689AF0-0x0000000189689B10
		public static new ConfigSimpleUIShowInterAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9844 */, bool useObjectPool = false /* Metadata: 0x00AF9848 */) => default; // 0x0000000189228E40-0x0000000189229060
		[BlackList] // 0x0000000189691930-0x0000000189691970
		// [XID] // 0x0000000189691930-0x0000000189691970
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000189229440-0x0000000189229710
		// [XID] // 0x000000018969BD00-0x000000018969BD20
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000189228A00-0x0000000189228D10
		[BlackList] // 0x00000001896A3280-0x00000001896A32C0
		// [XID] // 0x00000001896A3280-0x00000001896A32C0
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000189229350-0x0000000189229440
		[BlackList] // 0x00000001896AD470-0x00000001896AD4B0
		// [XID] // 0x00000001896AD470-0x00000001896AD4B0
		public override void AutoAllocTypeFields() {} // 0x0000000189227740-0x00000001892277E0
		[BlackList] // 0x00000001896B7B30-0x00000001896B7B70
		// [XID] // 0x00000001896B7B30-0x00000001896B7B70
		public override void AutoRecycleTypeFields() {} // 0x00000001892277E0-0x0000000189227890
		[BlackList] // 0x00000001896C1A00-0x00000001896C1A40
		// [XID] // 0x00000001896C1A00-0x00000001896C1A40
		public override void ReturnToObjectPool() {} // 0x00000001892292B0-0x0000000189229350
	}
}
