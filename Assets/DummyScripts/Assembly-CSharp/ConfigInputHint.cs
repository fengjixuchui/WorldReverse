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
public class ConfigInputHint : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18305
{
	// Fields
	private string _hintInfo; // 0x10
	private InputActionType[] _actionInfoList; // 0x18

	// Properties
	public string hintInfo { /* [XID] */ /* 0x00000001899B5280-0x00000001899B52A0 */ get => default; /* [XID] */ /* 0x00000001899BC930-0x00000001899BC950 */ private set {} } // 0x0000000182416130-0x00000001824161D0 0x0000000182415CA0-0x0000000182415D50
	public InputActionType[] actionInfoList { /* [XID] */ /* 0x00000001899C4340-0x00000001899C4360 */ get => default; /* [XID] */ /* 0x00000001899CBAC0-0x00000001899CBAE0 */ private set {} } // 0x00000001824161D0-0x0000000182416270 0x00000001824164E0-0x0000000182416590

	// Constructors
	public ConfigInputHint() {} // 0x0000000182416880-0x00000001824168E0

	// Methods
	// [XID] // 0x00000001899D2F70-0x00000001899D2F90
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182416590-0x00000001824166A0
	// [XID] // 0x00000001899DA5A0-0x00000001899DA5C0
	public void InitEmpty() {} // 0x0000000182415D50-0x0000000182415E30
	[BlackList] // 0x00000001899E1FE0-0x00000001899E2020
	// [XID] // 0x00000001899E1FE0-0x00000001899E2020
	public bool FromJson(JSONNode node) => default; // 0x0000000182415920-0x0000000182415CA0
	// [XID] // 0x00000001899EC490-0x00000001899EC4B0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182414F80-0x0000000182415250
	// [XID] // 0x00000001899F4110-0x00000001899F4130
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF93A7 */, bool useObjectPool = false /* Metadata: 0x00AF93AB */) => default; // 0x0000000182415E30-0x0000000182416130
	// [XID] // 0x00000001899FB770-0x00000001899FB790
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF93AC */, bool useObjectPool = false /* Metadata: 0x00AF93B0 */) => default; // 0x0000000182415660-0x0000000182415920
	[BlackList] // 0x0000000189A02A50-0x0000000189A02A90
	// [XID] // 0x0000000189A02A50-0x0000000189A02A90
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182415250-0x0000000182415520
	// [XID] // 0x0000000189A0D0C0-0x0000000189A0D0E0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182416270-0x00000001824164E0
	[BlackList] // 0x0000000189A14980-0x0000000189A149C0
	// [XID] // 0x0000000189A14980-0x0000000189A149C0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182415520-0x00000001824155C0
	[BlackList] // 0x0000000189A1EB90-0x0000000189A1EBD0
	// [XID] // 0x0000000189A1EB90-0x0000000189A1EBD0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001824155C0-0x0000000182415660
	[BlackList] // 0x0000000189A29020-0x0000000189A29060
	// [XID] // 0x0000000189A29020-0x0000000189A29060
	public virtual void ReturnToObjectPool() {} // 0x00000001824167E0-0x0000000182416880
	[BlackList] // 0x0000000189A33540-0x0000000189A33580
	// [XID] // 0x0000000189A33540-0x0000000189A33580
	public virtual void OnPoolAllocated() {} // 0x0000000182416740-0x00000001824167E0
	[BlackList] // 0x0000000189A3DED0-0x0000000189A3DF10
	// [XID] // 0x0000000189A3DED0-0x0000000189A3DF10
	public virtual void OnBeforePoolRecycled() {} // 0x00000001824166A0-0x0000000182416740
}

