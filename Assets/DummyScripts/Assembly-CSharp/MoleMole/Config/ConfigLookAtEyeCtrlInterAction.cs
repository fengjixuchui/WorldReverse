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
	public class ConfigLookAtEyeCtrlInterAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18389
	{
		// Fields
		private bool _clearAll; // 0x30
		private bool _useTargetPos; // 0x31
		private Vector _targetPosition; // 0x34
		private Vector _eyeRotateVecLeft; // 0x40
		private Vector _eyeRotateVecRight; // 0x4C
		private float _eyeScaleX; // 0x58
		private float _eyeScaleZ; // 0x5C
		private float _turnTime; // 0x60
		private string _targetNpcAlias; // 0x68
		private string _targetPoint; // 0x70
	
		// Properties
		public bool clearAll { /* [XID] */ /* 0x0000000189677A50-0x0000000189677A70 */ get => default; /* [XID] */ /* 0x000000018967EFC0-0x000000018967EFE0 */ private set {} } // 0x0000000188837130-0x00000001888371D0 0x0000000188837860-0x0000000188837910
		public bool useTargetPos { /* [XID] */ /* 0x00000001896868B0-0x00000001896868D0 */ get => default; /* [XID] */ /* 0x000000018968E6D0-0x000000018968E6F0 */ private set {} } // 0x00000001888377C0-0x0000000188837860 0x0000000188837EF0-0x0000000188837FA0
		public Vector targetPosition { /* [XID] */ /* 0x0000000189696150-0x0000000189696170 */ get => default; /* [XID] */ /* 0x000000018969D810-0x000000018969D830 */ private set {} } // 0x0000000188837630-0x0000000188837710 0x0000000188837D70-0x0000000188837E40
		public Vector eyeRotateVecLeft { /* [XID] */ /* 0x00000001896A4820-0x00000001896A4840 */ get => default; /* [XID] */ /* 0x00000001896ABFF0-0x00000001896AC010 */ private set {} } // 0x00000001888371D0-0x00000001888372B0 0x0000000188837910-0x00000001888379E0
		public Vector eyeRotateVecRight { /* [XID] */ /* 0x00000001896B3210-0x00000001896B3230 */ get => default; /* [XID] */ /* 0x00000001896BAA10-0x00000001896BAA30 */ private set {} } // 0x00000001888372B0-0x0000000188837390 0x00000001888379E0-0x0000000188837AB0
		public float eyeScaleX { /* [XID] */ /* 0x00000001896C1A60-0x00000001896C1A80 */ get => default; /* [XID] */ /* 0x00000001896C9170-0x00000001896C9190 */ private set {} } // 0x0000000188837390-0x0000000188837440 0x0000000188837AB0-0x0000000188837B60
		public float eyeScaleZ { /* [XID] */ /* 0x00000001896D0AC0-0x00000001896D0AE0 */ get => default; /* [XID] */ /* 0x00000001896D7FD0-0x00000001896D7FF0 */ private set {} } // 0x0000000188837440-0x00000001888374F0 0x0000000188837B60-0x0000000188837C10
		public float turnTime { /* [XID] */ /* 0x00000001896DF8E0-0x00000001896DF900 */ get => default; /* [XID] */ /* 0x00000001896E6C40-0x00000001896E6C60 */ private set {} } // 0x0000000188837710-0x00000001888377C0 0x0000000188837E40-0x0000000188837EF0
		public string targetNpcAlias { /* [XID] */ /* 0x00000001896EE150-0x00000001896EE170 */ get => default; /* [XID] */ /* 0x00000001896F5A20-0x00000001896F5A40 */ private set {} } // 0x00000001888374F0-0x0000000188837590 0x0000000188837C10-0x0000000188837CC0
		public string targetPoint { /* [XID] */ /* 0x00000001896FD230-0x00000001896FD250 */ get => default; /* [XID] */ /* 0x00000001897046F0-0x0000000189704710 */ private set {} } // 0x0000000188837590-0x0000000188837630 0x0000000188837CC0-0x0000000188837D70
	
		// Constructors
		public ConfigLookAtEyeCtrlInterAction() {} // 0x00000001888370B0-0x0000000188837130
	
		// Methods
		// [XID] // 0x000000018970BF30-0x000000018970BF50
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000188836010-0x0000000188836250
		// [XID] // 0x0000000189713800-0x0000000189713820
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000188833EF0-0x0000000188833FF0
		// [XID] // 0x000000018971B060-0x000000018971B080
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF96F9 */) => default; // 0x0000000188833E10-0x0000000188833EF0
		// [XID] // 0x00000001897223E0-0x0000000189722400
		public override int GetHashNum() => default; // 0x0000000188834670-0x0000000188834740
		// [XID] // 0x0000000189729B00-0x0000000189729B20
		public override void InitEmpty() {} // 0x0000000188834740-0x0000000188834850
		[BlackList] // 0x0000000189731220-0x0000000189731260
		// [XID] // 0x0000000189731220-0x0000000189731260
		public override bool FromJson(JSONNode node) => default; // 0x00000001888342F0-0x0000000188834670
		// [XID] // 0x000000018973BA50-0x000000018973BA70
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000188834F70-0x0000000188835860
		[BlackList] // 0x0000000189743430-0x0000000189743470
		// [XID] // 0x0000000189743430-0x0000000189743470
		public static new ConfigLookAtEyeCtrlInterAction ParseFromJson(JSONNode node) => default; // 0x0000000188836470-0x00000001888366C0
		// [XID] // 0x000000018974DE10-0x000000018974DE30
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF96FA */, bool useObjectPool = false /* Metadata: 0x00AF96FE */) => default; // 0x0000000188833FF0-0x00000001888342F0
		// [XID] // 0x0000000189755530-0x0000000189755550
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF96FF */, bool useObjectPool = false /* Metadata: 0x00AF9703 */) => default; // 0x0000000188834850-0x0000000188834F70
		// [XID] // 0x000000018975C690-0x000000018975C6B0
		public static new ConfigLookAtEyeCtrlInterAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9704 */, bool useObjectPool = false /* Metadata: 0x00AF9708 */) => default; // 0x0000000188836250-0x0000000188836470
		[BlackList] // 0x0000000189763F80-0x0000000189763FC0
		// [XID] // 0x0000000189763F80-0x0000000189763FC0
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000188836850-0x0000000188836B20
		// [XID] // 0x000000018976E520-0x000000018976E540
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000188835860-0x0000000188836010
		[BlackList] // 0x0000000189775EA0-0x0000000189775EE0
		// [XID] // 0x0000000189775EA0-0x0000000189775EE0
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000188836760-0x0000000188836850
		[BlackList] // 0x0000000189780500-0x0000000189780540
		// [XID] // 0x0000000189780500-0x0000000189780540
		public override void AutoAllocTypeFields() {} // 0x0000000188833C70-0x0000000188833D10
		[BlackList] // 0x000000018978AD20-0x000000018978AD60
		// [XID] // 0x000000018978AD20-0x000000018978AD60
		public override void AutoRecycleTypeFields() {} // 0x0000000188833D10-0x0000000188833E10
		[BlackList] // 0x00000001897951A0-0x00000001897951E0
		// [XID] // 0x00000001897951A0-0x00000001897951E0
		public override void ReturnToObjectPool() {} // 0x00000001888366C0-0x0000000188836760
	}
}
