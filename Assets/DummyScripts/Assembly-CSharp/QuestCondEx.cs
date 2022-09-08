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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class QuestCondEx : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14939
{
	// Fields
	private QuestCondType _type; // 0x10
	private int[] _param; // 0x18

	// Properties
	public QuestCondType type { /* [XID] */ /* 0x0000000189969E20-0x0000000189969E40 */ get => default; /* [XID] */ /* 0x0000000189971C20-0x0000000189971C40 */ private set {} } // 0x0000000183643BF0-0x0000000183643C90 0x0000000183643680-0x0000000183643730
	public int[] param { /* [XID] */ /* 0x0000000189979450-0x0000000189979470 */ get => default; /* [XID] */ /* 0x00000001899805A0-0x00000001899805C0 */ private set {} } // 0x0000000183643D40-0x0000000183643DE0 0x0000000183643C90-0x0000000183643D40

	// Constructors
	public QuestCondEx(QuestCondType type, int[] param) {} // 0x0000000183643EE0-0x0000000183643F80
	public QuestCondEx() {} // 0x0000000183643E80-0x0000000183643EE0

	// Methods
	// [XID] // 0x0000000189987ED0-0x0000000189987EF0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001836439A0-0x0000000183643AB0
	// [XID] // 0x000000018998F8E0-0x000000018998F900
	public void InitEmpty() {} // 0x00000001836432B0-0x0000000183643380
	[BlackList] // 0x00000001899972E0-0x0000000189997320
	// [XID] // 0x00000001899972E0-0x0000000189997320
	public bool FromJson(JSONNode node) => default; // 0x0000000183642F30-0x00000001836432B0
	// [XID] // 0x00000001899A1F90-0x00000001899A1FB0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183642470-0x0000000183642730
	// [XID] // 0x000000018994ACD0-0x000000018994ACF0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFAF6 */, bool useObjectPool = false /* Metadata: 0x00AEFAFA */) => default; // 0x0000000183643380-0x0000000183643680
	// [XID] // 0x00000001899B1290-0x00000001899B12B0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFAFB */, bool useObjectPool = false /* Metadata: 0x00AEFAFF */) => default; // 0x0000000183642C90-0x0000000183642F30
	[BlackList] // 0x00000001899B8570-0x00000001899B85B0
	// [XID] // 0x00000001899B8570-0x00000001899B85B0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183642880-0x0000000183642B50
	// [XID] // 0x00000001899C32E0-0x00000001899C3300
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183643730-0x00000001836439A0
	[BlackList] // 0x00000001899CA7A0-0x00000001899CA7E0
	// [XID] // 0x00000001899CA7A0-0x00000001899CA7E0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183642B50-0x0000000183642BF0
	[BlackList] // 0x00000001899D4D10-0x00000001899D4D50
	// [XID] // 0x00000001899D4D10-0x00000001899D4D50
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183642BF0-0x0000000183642C90
	[BlackList] // 0x00000001899DF190-0x00000001899DF1D0
	// [XID] // 0x00000001899DF190-0x00000001899DF1D0
	public virtual void ReturnToObjectPool() {} // 0x0000000183643DE0-0x0000000183643E80
	[BlackList] // 0x00000001899E9A00-0x00000001899E9A40
	// [XID] // 0x00000001899E9A00-0x00000001899E9A40
	public virtual void OnPoolAllocated() {} // 0x0000000183643B50-0x0000000183643BF0
	[BlackList] // 0x00000001899F4750-0x00000001899F4790
	// [XID] // 0x00000001899F4750-0x00000001899F4790
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183643AB0-0x0000000183643B50
	// [XID] // 0x00000001899FEB10-0x00000001899FEB30
	public bool IsValid(uint mainQuestId) => default; // 0x0000000183642730-0x0000000183642880
}

