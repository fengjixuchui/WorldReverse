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
public class ConfigFootprintEffect : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18014
{
	// Fields
	private string _effect; // 0x10
	private string _deformation; // 0x18

	// Properties
	public string effect { /* [XID] */ /* 0x00000001899652F0-0x0000000189965310 */ get => default; /* [XID] */ /* 0x000000018996C7D0-0x000000018996C7F0 */ private set {} } // 0x000000018468DF60-0x000000018468E000 0x000000018468ED40-0x000000018468EDF0
	public string deformation { /* [XID] */ /* 0x0000000189974230-0x0000000189974250 */ get => default; /* [XID] */ /* 0x000000018997B920-0x000000018997B940 */ private set {} } // 0x000000018468E380-0x000000018468E420 0x000000018468E800-0x000000018468E8B0

	// Constructors
	public ConfigFootprintEffect() {} // 0x000000018468EE90-0x000000018468EEF0

	// Methods
	// [XID] // 0x0000000189983490-0x00000001899834B0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018468EAF0-0x000000018468EC00
	// [XID] // 0x000000018998ACA0-0x000000018998ACC0
	public void InitEmpty() {} // 0x000000018468E420-0x000000018468E500
	[BlackList] // 0x0000000189992570-0x00000001899925B0
	// [XID] // 0x0000000189992570-0x00000001899925B0
	public bool FromJson(JSONNode node) => default; // 0x000000018468E000-0x000000018468E380
	// [XID] // 0x000000018999D0D0-0x000000018999D0F0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018468D5C0-0x000000018468D890
	// [XID] // 0x00000001899A4A50-0x00000001899A4A70
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF86A1 */, bool useObjectPool = false /* Metadata: 0x00AF86A5 */) => default; // 0x000000018468E500-0x000000018468E800
	// [XID] // 0x00000001899AC4D0-0x00000001899AC4F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF86A6 */, bool useObjectPool = false /* Metadata: 0x00AF86AA */) => default; // 0x000000018468DCA0-0x000000018468DF60
	[BlackList] // 0x00000001899B3C40-0x00000001899B3C80
	// [XID] // 0x00000001899B3C40-0x00000001899B3C80
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018468D890-0x000000018468DB60
	// [XID] // 0x00000001899BE3B0-0x00000001899BE3D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018468E8B0-0x000000018468EAF0
	[BlackList] // 0x00000001899C5B50-0x00000001899C5B90
	// [XID] // 0x00000001899C5B50-0x00000001899C5B90
	public virtual void AutoAllocTypeFields() {} // 0x000000018468DB60-0x000000018468DC00
	[BlackList] // 0x00000001899D0290-0x00000001899D02D0
	// [XID] // 0x00000001899D0290-0x00000001899D02D0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018468DC00-0x000000018468DCA0
	[BlackList] // 0x00000001899DA600-0x00000001899DA640
	// [XID] // 0x00000001899DA600-0x00000001899DA640
	public virtual void ReturnToObjectPool() {} // 0x000000018468EDF0-0x000000018468EE90
	[BlackList] // 0x00000001899E51E0-0x00000001899E5220
	// [XID] // 0x00000001899E51E0-0x00000001899E5220
	public virtual void OnPoolAllocated() {} // 0x000000018468ECA0-0x000000018468ED40
	[BlackList] // 0x00000001899EF450-0x00000001899EF490
	// [XID] // 0x00000001899EF450-0x00000001899EF490
	public virtual void OnBeforePoolRecycled() {} // 0x000000018468EC00-0x000000018468ECA0
}

