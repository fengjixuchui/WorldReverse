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
using UnityEngine;
using UnityEngine.Serialization;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.Config
{
	[CSharpCallLua] // 0x00000001899BE290-0x00000001899BE2D0
	[RecycleType] // 0x00000001899BE290-0x00000001899BE2D0
	public class ConfigInterActor : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18373
	{
		// Fields
		// [FormerlySerializedAs] // 0x0000000189A425B0-0x0000000189A425F0
		[SerializeField] // 0x0000000189A425B0-0x0000000189A425F0
		private uint _configID; // 0x10
		// [FormerlySerializedAs] // 0x0000000189A4E700-0x0000000189A4E750
		[SerializeField] // 0x0000000189A4E700-0x0000000189A4E750
		private string _alias; // 0x18
		// [FormerlySerializedAs] // 0x0000000189A5A530-0x0000000189A5A570
		[SerializeField] // 0x0000000189A5A530-0x0000000189A5A570
		private bool _visible; // 0x20
		// [FormerlySerializedAs] // 0x0000000189A66820-0x0000000189A66860
		[SerializeField] // 0x0000000189A66820-0x0000000189A66860
		private string _bornPointName; // 0x28
		// [FormerlySerializedAs] // 0x0000000189A728B0-0x0000000189A72900
		[SerializeField] // 0x0000000189A728B0-0x0000000189A72900
		private bool _useRelativePos; // 0x30
		// [FormerlySerializedAs] // 0x0000000189A7E910-0x0000000189A7E960
		[SerializeField] // 0x0000000189A7E910-0x0000000189A7E960
		private Vector _relativePos; // 0x34
		// [FormerlySerializedAs] // 0x0000000189A8AAB0-0x0000000189A8AB00
		[SerializeField] // 0x0000000189A8AAB0-0x0000000189A8AB00
		private Vector _relativeRot; // 0x40
		// [FormerlySerializedAs] // 0x0000000189A968E0-0x0000000189A96920
		[SerializeField] // 0x0000000189A968E0-0x0000000189A96920
		private uint _questID; // 0x4C
		// [FormerlySerializedAs] // 0x0000000189AA2660-0x0000000189AA26A0
		[SerializeField] // 0x0000000189AA2660-0x0000000189AA26A0
		private RemoveActorType _removeActorType; // 0x50
	
		// Properties
		public uint configID { /* [XID] */ /* 0x0000000189AAE740-0x0000000189AAE760 */ get => default; /* [XID] */ /* 0x00000001895F2AA0-0x00000001895F2AC0 */ set {} } // 0x0000000188BA7710-0x0000000188BA77B0 0x0000000188BA7D50-0x0000000188BA7E00
		public string alias { /* [XID] */ /* 0x0000000189ABDA30-0x0000000189ABDA50 */ get => default; /* [XID] */ /* 0x0000000189AC55F0-0x0000000189AC5610 */ private set {} } // 0x0000000188BA75D0-0x0000000188BA7670 0x0000000188BA7BF0-0x0000000188BA7CA0
		public bool visible { /* [XID] */ /* 0x0000000189ACC9E0-0x0000000189ACCA00 */ get => default; /* [XID] */ /* 0x0000000189AD4760-0x0000000189AD4780 */ private set {} } // 0x0000000188BA7B50-0x0000000188BA7BF0 0x0000000188BA81B0-0x0000000188BA8360
		public string bornPointName { /* [XID] */ /* 0x0000000189AFF5B0-0x0000000189AFF5D0 */ get => default; /* [XID] */ /* 0x0000000189AE3A50-0x0000000189AE3A70 */ private set {} } // 0x0000000188BA7670-0x0000000188BA7710 0x0000000188BA7CA0-0x0000000188BA7D50
		public bool useRelativePos { /* [XID] */ /* 0x0000000189AEB2F0-0x0000000189AEB310 */ get => default; /* [XID] */ /* 0x0000000189AF2CB0-0x0000000189AF2CD0 */ private set {} } // 0x0000000188BA7AB0-0x0000000188BA7B50 0x0000000188BA8100-0x0000000188BA81B0
		public Vector relativePos { /* [XID] */ /* 0x0000000189626FD0-0x0000000189626FF0 */ get => default; /* [XID] */ /* 0x0000000189B01A70-0x0000000189B01A90 */ private set {} } // 0x0000000188BA7850-0x0000000188BA7930 0x0000000188BA7EB0-0x0000000188BA7F80
		public Vector relativeRot { /* [XID] */ /* 0x0000000189B09070-0x0000000189B09090 */ get => default; /* [XID] */ /* 0x0000000189B10AB0-0x0000000189B10AD0 */ private set {} } // 0x0000000188BA7930-0x0000000188BA7A10 0x0000000188BA7F80-0x0000000188BA8050
		public uint questID { /* [XID] */ /* 0x0000000189B17BC0-0x0000000189B17BE0 */ get => default; /* [XID] */ /* 0x0000000189A50AA0-0x0000000189A50AC0 */ set {} } // 0x0000000188BA77B0-0x0000000188BA7850 0x0000000188BA7E00-0x0000000188BA7EB0
		public RemoveActorType removeActorType { /* [XID] */ /* 0x0000000189B26D80-0x0000000189B26DA0 */ get => default; /* [XID] */ /* 0x0000000189B2DFB0-0x0000000189B2DFD0 */ private set {} } // 0x0000000188BA7A10-0x0000000188BA7AB0 0x0000000188BA8050-0x0000000188BA8100
	
		// Constructors
		public ConfigInterActor() {} // 0x0000000188BA7560-0x0000000188BA75D0
	
		// Methods
		// [XID] // 0x0000000189B35380-0x0000000189B353A0
		public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000188BA6ED0-0x0000000188BA70B0
		// [XID] // 0x0000000189B3CC40-0x0000000189B3CC60
		public void InitEmpty() {} // 0x0000000188BA58D0-0x0000000188BA59D0
		[BlackList] // 0x0000000189B448D0-0x0000000189B44910
		// [XID] // 0x0000000189B448D0-0x0000000189B44910
		public bool FromJson(JSONNode node) => default; // 0x0000000188BA5550-0x0000000188BA58D0
		// [XID] // 0x00000001899E8B20-0x00000001899E8B40
		private bool InternalFromJson(JSONNode node) => default; // 0x0000000188BA6030-0x0000000188BA6850
		// [XID] // 0x0000000189959AD0-0x0000000189959AF0
		public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF968B */, bool useObjectPool = false /* Metadata: 0x00AF968F */) => default; // 0x0000000188BA5250-0x0000000188BA5550
		// [XID] // 0x0000000189961450-0x0000000189961470
		private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9690 */, bool useObjectPool = false /* Metadata: 0x00AF9694 */) => default; // 0x0000000188BA59D0-0x0000000188BA6030
		[BlackList] // 0x0000000189B656A0-0x0000000189B656E0
		// [XID] // 0x0000000189B656A0-0x0000000189B656E0
		public bool ToBinary(ByteArray byteArray) => default; // 0x0000000188BA7290-0x0000000188BA7560
		// [XID] // 0x0000000189B6FDC0-0x0000000189B6FDE0
		private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000188BA6850-0x0000000188BA6ED0
		[BlackList] // 0x0000000189B77230-0x0000000189B77270
		// [XID] // 0x0000000189B77230-0x0000000189B77270
		public virtual void AutoAllocTypeFields() {} // 0x0000000188BA50D0-0x0000000188BA5170
		[BlackList] // 0x0000000189B81AD0-0x0000000189B81B10
		// [XID] // 0x0000000189B81AD0-0x0000000189B81B10
		public virtual void AutoRecycleTypeFields() {} // 0x0000000188BA5170-0x0000000188BA5250
		[BlackList] // 0x0000000189B8BD60-0x0000000189B8BDA0
		// [XID] // 0x0000000189B8BD60-0x0000000189B8BDA0
		public virtual void ReturnToObjectPool() {} // 0x0000000188BA71F0-0x0000000188BA7290
		[BlackList] // 0x0000000189B96260-0x0000000189B962A0
		// [XID] // 0x0000000189B96260-0x0000000189B962A0
		public virtual void OnPoolAllocated() {} // 0x0000000188BA7150-0x0000000188BA71F0
		[BlackList] // 0x0000000189BA0770-0x0000000189BA07B0
		// [XID] // 0x0000000189BA0770-0x0000000189BA07B0
		public virtual void OnBeforePoolRecycled() {} // 0x0000000188BA70B0-0x0000000188BA7150
	}
}
