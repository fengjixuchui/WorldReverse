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

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class AudioMutualExclusion : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17600
{
	// Fields
	private string _eventNameA; // 0x10
	private string _eventNameB; // 0x18
	private AudioScope _scope; // 0x20

	// Properties
	public string eventNameA { /* [XID] */ /* 0x000000018988EBC0-0x000000018988EBE0 */ get => default; /* [XID] */ /* 0x00000001898960E0-0x0000000189896100 */ private set {} } // 0x0000000184C30630-0x0000000184C306D0 0x0000000184C2F0A0-0x0000000184C2F150
	public string eventNameB { /* [XID] */ /* 0x000000018989D6E0-0x000000018989D700 */ get => default; /* [XID] */ /* 0x00000001898A50E0-0x00000001898A5100 */ private set {} } // 0x0000000184C2F150-0x0000000184C2F1F0 0x0000000184C300F0-0x0000000184C301A0
	public AudioScope scope { /* [XID] */ /* 0x00000001898AC540-0x00000001898AC560 */ get => default; /* [XID] */ /* 0x00000001898B3B00-0x00000001898B3B20 */ private set {} } // 0x0000000184C2F9B0-0x0000000184C2FA50 0x0000000184C30580-0x0000000184C30630

	// Constructors
	public AudioMutualExclusion() {} // 0x0000000184C30C90-0x0000000184C30CF0

	// Methods
	// [XID] // 0x00000001898BB8B0-0x00000001898BB8D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184C30990-0x0000000184C30AB0
	// [XID] // 0x00000001898C2B60-0x00000001898C2B80
	public void InitEmpty() {} // 0x0000000184C301A0-0x0000000184C30280
	[BlackList] // 0x00000001898CA500-0x00000001898CA540
	// [XID] // 0x00000001898CA500-0x00000001898CA540
	public bool FromJson(JSONNode node) => default; // 0x0000000184C2FD70-0x0000000184C300F0
	// [XID] // 0x00000001898D4D10-0x00000001898D4D30
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184C2F1F0-0x0000000184C2F590
	// [XID] // 0x00000001898DC7B0-0x00000001898DC7D0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF744F */, bool useObjectPool = false /* Metadata: 0x00AF7453 */) => default; // 0x0000000184C30280-0x0000000184C30580
	// [XID] // 0x00000001898E41E0-0x00000001898E4200
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7454 */, bool useObjectPool = false /* Metadata: 0x00AF7458 */) => default; // 0x0000000184C2FA50-0x0000000184C2FD70
	[BlackList] // 0x00000001898EBC70-0x00000001898EBCB0
	// [XID] // 0x00000001898EBC70-0x00000001898EBCB0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184C2F590-0x0000000184C2F860
	// [XID] // 0x00000001898F66A0-0x00000001898F66C0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184C306D0-0x0000000184C30990
	[BlackList] // 0x00000001898FDD80-0x00000001898FDDC0
	// [XID] // 0x00000001898FDD80-0x00000001898FDDC0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184C2F860-0x0000000184C2F900
	[BlackList] // 0x0000000189908790-0x00000001899087D0
	// [XID] // 0x0000000189908790-0x00000001899087D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184C2F900-0x0000000184C2F9B0
	[BlackList] // 0x0000000189913160-0x00000001899131A0
	// [XID] // 0x0000000189913160-0x00000001899131A0
	public virtual void ReturnToObjectPool() {} // 0x0000000184C30BF0-0x0000000184C30C90
	[BlackList] // 0x000000018991D870-0x000000018991D8B0
	// [XID] // 0x000000018991D870-0x000000018991D8B0
	public virtual void OnPoolAllocated() {} // 0x0000000184C30B50-0x0000000184C30BF0
	[BlackList] // 0x0000000189927FD0-0x0000000189928010
	// [XID] // 0x0000000189927FD0-0x0000000189928010
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184C30AB0-0x0000000184C30B50
}

