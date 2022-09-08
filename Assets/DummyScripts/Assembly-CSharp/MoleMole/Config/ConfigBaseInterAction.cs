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
	public class ConfigBaseInterAction : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14934
	{
		// Fields
		private InteractionType _type; // 0x10
		private float _delayTime; // 0x14
		private float _duration; // 0x18
		private string[] _aliasList; // 0x20
		private bool _checkNextImmediately; // 0x28
	
		// Properties
		public InteractionType type { /* [XID] */ /* 0x0000000189A98B00-0x0000000189A98B20 */ get => default; /* [XID] */ /* 0x0000000189A9FE30-0x0000000189A9FE50 */ private set {} } // 0x0000000187DFBF40-0x0000000187DFBFE0 0x0000000187DFC2A0-0x0000000187DFC350
		public float delayTime { /* [XID] */ /* 0x0000000189AA7600-0x0000000189AA7620 */ get => default; /* [XID] */ /* 0x0000000189AAECA0-0x0000000189AAECC0 */ private set {} } // 0x0000000187DFBDE0-0x0000000187DFBE90 0x0000000187DFC140-0x0000000187DFC1F0
		public float duration { /* [XID] */ /* 0x0000000189AB6660-0x0000000189AB6680 */ get => default; /* [XID] */ /* 0x0000000189ABE190-0x0000000189ABE1B0 */ private set {} } // 0x0000000187DFBE90-0x0000000187DFBF40 0x0000000187DFC1F0-0x0000000187DFC2A0
		public string[] aliasList { /* [XID] */ /* 0x00000001895FD350-0x00000001895FD370 */ get => default; /* [XID] */ /* 0x0000000189ACD240-0x0000000189ACD260 */ private set {} } // 0x0000000187DFBCA0-0x0000000187DFBD40 0x0000000187DFBFE0-0x0000000187DFC090
		public bool checkNextImmediately { /* [XID] */ /* 0x0000000189AD5000-0x0000000189AD5020 */ get => default; /* [XID] */ /* 0x0000000189ADC840-0x0000000189ADC860 */ private set {} } // 0x0000000187DFBD40-0x0000000187DFBDE0 0x0000000187DFC090-0x0000000187DFC140
	
		// Constructors
		public ConfigBaseInterAction(InteractionType type) {} // 0x0000000187DFBC10-0x0000000187DFBCA0
		public ConfigBaseInterAction(InteractionType type, float duration) {} // 0x0000000187DFBB60-0x0000000187DFBC10
		public ConfigBaseInterAction() {} // 0x0000000187DFBAE0-0x0000000187DFBB60
	
		// Methods
		// [XID] // 0x0000000189AE41F0-0x0000000189AE4210
		public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000187DFB010-0x0000000187DFB170
		// [XID] // 0x0000000189AEB9D0-0x0000000189AEB9F0
		public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000187DF9A40-0x0000000187DF9B10
		// [XID] // 0x0000000189AF3450-0x0000000189AF3470
		public virtual ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AEFAA6 */) => default; // 0x0000000187DF9960-0x0000000187DF9A40
		// [XID] // 0x0000000189AFAD00-0x0000000189AFAD20
		public virtual int GetHashNum() => default; // 0x0000000187DFA190-0x0000000187DFA260
		// [XID] // 0x0000000189B02230-0x0000000189B02250
		public virtual void InitEmpty() {} // 0x0000000187DFA260-0x0000000187DFA330
		[BlackList] // 0x0000000189B09670-0x0000000189B096B0
		// [XID] // 0x0000000189B09670-0x0000000189B096B0
		public virtual bool FromJson(JSONNode node) => default; // 0x0000000187DF9E10-0x0000000187DFA190
		// [XID] // 0x0000000189A41AF0-0x0000000189A41B10
		private bool InternalFromJson(JSONNode node) => default; // 0x0000000187DFA720-0x0000000187DFAC00
		[BlackList] // 0x0000000189B1B3C0-0x0000000189B1B400
		// [XID] // 0x0000000189B1B3C0-0x0000000189B1B400
		public static ConfigBaseInterAction ParseFromJson(JSONNode node) => default; // 0x0000000187DFB480-0x0000000187DFB680
		// [XID] // 0x00000001899A5400-0x00000001899A5420
		public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFAA7 */, bool useObjectPool = false /* Metadata: 0x00AEFAAB */) => default; // 0x0000000187DF9B10-0x0000000187DF9E10
		// [XID] // 0x0000000189B2CE10-0x0000000189B2CE30
		private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFAAC */, bool useObjectPool = false /* Metadata: 0x00AEFAB0 */) => default; // 0x0000000187DFA330-0x0000000187DFA720
		// [XID] // 0x000000018998E610-0x000000018998E630
		public static ConfigBaseInterAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFAB1 */, bool useObjectPool = false /* Metadata: 0x00AEFAB5 */) => default; // 0x0000000187DFB2B0-0x0000000187DFB480
		[BlackList] // 0x0000000189B3BC90-0x0000000189B3BCD0
		// [XID] // 0x0000000189B3BC90-0x0000000189B3BCD0
		public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000187DFB810-0x0000000187DFBAE0
		// [XID] // 0x0000000189B46860-0x0000000189B46880
		private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000187DFAC00-0x0000000187DFB010
		[BlackList] // 0x0000000189B4DDE0-0x0000000189B4DE20
		// [XID] // 0x0000000189B4DDE0-0x0000000189B4DE20
		public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000187DFB720-0x0000000187DFB810
		[BlackList] // 0x0000000189B58790-0x0000000189B587D0
		// [XID] // 0x0000000189B58790-0x0000000189B587D0
		public virtual void AutoAllocTypeFields() {} // 0x0000000187DF9810-0x0000000187DF98B0
		[BlackList] // 0x0000000189B62B80-0x0000000189B62BC0
		// [XID] // 0x0000000189B62B80-0x0000000189B62BC0
		public virtual void AutoRecycleTypeFields() {} // 0x0000000187DF98B0-0x0000000187DF9960
		[BlackList] // 0x0000000189B6D3A0-0x0000000189B6D3E0
		// [XID] // 0x0000000189B6D3A0-0x0000000189B6D3E0
		public virtual void ReturnToObjectPool() {} // 0x0000000187DFB680-0x0000000187DFB720
		[BlackList] // 0x0000000189B778F0-0x0000000189B77930
		// [XID] // 0x0000000189B778F0-0x0000000189B77930
		public virtual void OnPoolAllocated() {} // 0x0000000187DFB210-0x0000000187DFB2B0
		[BlackList] // 0x0000000189B82130-0x0000000189B82170
		// [XID] // 0x0000000189B82130-0x0000000189B82170
		public virtual void OnBeforePoolRecycled() {} // 0x0000000187DFB170-0x0000000187DFB210
	}
}
