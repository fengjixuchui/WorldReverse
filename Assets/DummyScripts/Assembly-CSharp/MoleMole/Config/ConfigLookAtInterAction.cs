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
	public class ConfigLookAtInterAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18387
	{
		// Fields
		private bool _enableHead; // 0x30
		private bool _useTargetPos; // 0x31
		private bool _enableAbsolute; // 0x32
		private Vector _targetOffset; // 0x34
		private Vector _targetPosition; // 0x40
		private Vector _headRotateVec; // 0x4C
		private bool _enableBody; // 0x58
		private float _bodyAngle; // 0x5C
		private float _headTurnTime; // 0x60
		private float _bodyTurnTime; // 0x64
		private string _targetNpcAlias; // 0x68
		private LookAtTargetType _lookAtTargetType; // 0x70
	
		// Properties
		public bool enableHead { /* [XID] */ /* 0x0000000189B20A70-0x0000000189B20A90 */ get => default; /* [XID] */ /* 0x0000000189B28190-0x0000000189B281B0 */ private set {} } // 0x000000018883BAC0-0x000000018883BB60 0x000000018883C350-0x000000018883C400
		public bool useTargetPos { /* [XID] */ /* 0x0000000189B2F4F0-0x0000000189B2F510 */ get => default; /* [XID] */ /* 0x0000000189B36DD0-0x0000000189B36DF0 */ private set {} } // 0x000000018883BFF0-0x000000018883C090 0x000000018883C880-0x000000018883C930
		public bool enableAbsolute { /* [XID] */ /* 0x0000000189B3E660-0x0000000189B3E680 */ get => default; /* [XID] */ /* 0x0000000189B46180-0x0000000189B461A0 */ private set {} } // 0x000000018883B980-0x000000018883BA20 0x000000018883C1F0-0x000000018883C2A0
		public Vector targetOffset { /* [XID] */ /* 0x0000000189B4D770-0x0000000189B4D790 */ get => default; /* [XID] */ /* 0x0000000189B54F70-0x0000000189B54F90 */ private set {} } // 0x000000018883BE30-0x000000018883BF10 0x000000018883C6E0-0x000000018883C7B0
		public Vector targetPosition { /* [XID] */ /* 0x0000000189B5C970-0x0000000189B5C990 */ get => default; /* [XID] */ /* 0x0000000189B63F70-0x0000000189B63F90 */ private set {} } // 0x000000018883BF10-0x000000018883BFF0 0x000000018883C7B0-0x000000018883C880
		public Vector headRotateVec { /* [XID] */ /* 0x0000000189B6B770-0x0000000189B6B790 */ get => default; /* [XID] */ /* 0x0000000189B72D70-0x0000000189B72D90 */ private set {} } // 0x000000018883BB60-0x000000018883BC40 0x000000018883C400-0x000000018883C4D0
		public bool enableBody { /* [XID] */ /* 0x0000000189B7A310-0x0000000189B7A330 */ get => default; /* [XID] */ /* 0x0000000189B81AB0-0x0000000189B81AD0 */ private set {} } // 0x000000018883BA20-0x000000018883BAC0 0x000000018883C2A0-0x000000018883C350
		public float bodyAngle { /* [XID] */ /* 0x0000000189B89150-0x0000000189B89170 */ get => default; /* [XID] */ /* 0x0000000189B90770-0x0000000189B90790 */ private set {} } // 0x000000018883B820-0x000000018883B8D0 0x000000018883C090-0x000000018883C140
		public float headTurnTime { /* [XID] */ /* 0x0000000189B97BC0-0x0000000189B97BE0 */ get => default; /* [XID] */ /* 0x0000000189B9EF10-0x0000000189B9EF30 */ private set {} } // 0x000000018883BC40-0x000000018883BCF0 0x000000018883C4D0-0x000000018883C580
		public float bodyTurnTime { /* [XID] */ /* 0x0000000189BA67E0-0x0000000189BA6800 */ get => default; /* [XID] */ /* 0x0000000189BADA60-0x0000000189BADA80 */ private set {} } // 0x000000018883B8D0-0x000000018883B980 0x000000018883C140-0x000000018883C1F0
		public string targetNpcAlias { /* [XID] */ /* 0x0000000189BB5250-0x0000000189BB5270 */ get => default; /* [XID] */ /* 0x0000000189BBC930-0x0000000189BBC950 */ private set {} } // 0x000000018883BD90-0x000000018883BE30 0x000000018883C630-0x000000018883C6E0
		public LookAtTargetType lookAtTargetType { /* [XID] */ /* 0x0000000189BC45A0-0x0000000189BC45C0 */ get => default; /* [XID] */ /* 0x0000000189BCBFA0-0x0000000189BCBFC0 */ private set {} } // 0x000000018883BCF0-0x000000018883BD90 0x000000018883C580-0x000000018883C630
	
		// Constructors
		public ConfigLookAtInterAction() {} // 0x000000018883B7B0-0x000000018883B820
	
		// Methods
		// [XID] // 0x0000000189BD3530-0x0000000189BD3550
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018883A6E0-0x000000018883A950
		// [XID] // 0x0000000189BDADE0-0x0000000189BDAE00
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000188838220-0x0000000188838300
		// [XID] // 0x00000001895E7810-0x00000001895E7830
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF96E9 */) => default; // 0x0000000188838140-0x0000000188838220
		// [XID] // 0x00000001895EF100-0x00000001895EF120
		public override int GetHashNum() => default; // 0x0000000188838980-0x0000000188838A50
		// [XID] // 0x00000001895F6AA0-0x00000001895F6AC0
		public override void InitEmpty() {} // 0x0000000188838A50-0x0000000188838B60
		[BlackList] // 0x00000001895FDEC0-0x00000001895FDF00
		// [XID] // 0x00000001895FDEC0-0x00000001895FDF00
		public override bool FromJson(JSONNode node) => default; // 0x0000000188838600-0x0000000188838980
		// [XID] // 0x0000000189608A10-0x0000000189608A30
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000188839390-0x0000000188839E10
		[BlackList] // 0x0000000189610210-0x0000000189610250
		// [XID] // 0x0000000189610210-0x0000000189610250
		public static new ConfigLookAtInterAction ParseFromJson(JSONNode node) => default; // 0x000000018883AB70-0x000000018883ADC0
		// [XID] // 0x000000018961A7E0-0x000000018961A800
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF96EA */, bool useObjectPool = false /* Metadata: 0x00AF96EE */) => default; // 0x0000000188838300-0x0000000188838600
		// [XID] // 0x0000000189621DC0-0x0000000189621DE0
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF96EF */, bool useObjectPool = false /* Metadata: 0x00AF96F3 */) => default; // 0x0000000188838B60-0x0000000188839390
		// [XID] // 0x0000000189629730-0x0000000189629750
		public static new ConfigLookAtInterAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF96F4 */, bool useObjectPool = false /* Metadata: 0x00AF96F8 */) => default; // 0x000000018883A950-0x000000018883AB70
		[BlackList] // 0x0000000189631060-0x00000001896310A0
		// [XID] // 0x0000000189631060-0x00000001896310A0
		public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018883AF50-0x000000018883B220
		// [XID] // 0x000000018963B7A0-0x000000018963B7C0
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000188839E10-0x000000018883A6E0
		[BlackList] // 0x0000000189642FC0-0x0000000189643000
		// [XID] // 0x0000000189642FC0-0x0000000189643000
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018883AE60-0x000000018883AF50
		[BlackList] // 0x000000018964D720-0x000000018964D760
		// [XID] // 0x000000018964D720-0x000000018964D760
		public override void AutoAllocTypeFields() {} // 0x0000000188837FA0-0x0000000188838040
		[BlackList] // 0x0000000189657E70-0x0000000189657EB0
		// [XID] // 0x0000000189657E70-0x0000000189657EB0
		public override void AutoRecycleTypeFields() {} // 0x0000000188838040-0x0000000188838140
		[BlackList] // 0x0000000189662380-0x00000001896623C0
		// [XID] // 0x0000000189662380-0x00000001896623C0
		public override void ReturnToObjectPool() {} // 0x000000018883ADC0-0x000000018883AE60
	}
}
