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
public class ConfigWall : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19117
{
	// Fields
	private string _collisionEffectPattern; // 0x10
	private SimpleSafeFloat fadeDurationRawNum; // 0x18

	// Properties
	public string collisionEffectPattern { /* [XID] */ /* 0x000000018974C5C0-0x000000018974C5E0 */ get => default; /* [XID] */ /* 0x0000000189753840-0x0000000189753860 */ private set {} } // 0x0000000182871EC0-0x0000000182871F60 0x00000001828715A0-0x0000000182871650
	public float fadeDuration { /* [XID] */ /* 0x000000018975AD80-0x000000018975ADA0 */ get => default; /* [XID] */ /* 0x0000000189762810-0x0000000189762830 */ private set {} } // 0x0000000182871950-0x0000000182871A30 0x00000001828713C0-0x00000001828714A0

	// Constructors
	public ConfigWall() {} // 0x0000000182872000-0x00000001828720A0

	// Methods
	// [XID] // 0x0000000189769E30-0x0000000189769E50
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182871C70-0x0000000182871D80
	// [XID] // 0x0000000189771590-0x00000001897715B0
	public void InitEmpty() {} // 0x00000001828714A0-0x00000001828715A0
	[BlackList] // 0x0000000189778D20-0x0000000189778D60
	// [XID] // 0x0000000189778D20-0x0000000189778D60
	public bool FromJson(JSONNode node) => default; // 0x0000000182871040-0x00000001828713C0
	// [XID] // 0x00000001897834D0-0x00000001897834F0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182870670-0x0000000182870970
	// [XID] // 0x000000018978AB80-0x000000018978ABA0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC289 */, bool useObjectPool = false /* Metadata: 0x00AFC28D */) => default; // 0x0000000182871650-0x0000000182871950
	// [XID] // 0x0000000189792160-0x0000000189792180
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC28E */, bool useObjectPool = false /* Metadata: 0x00AFC292 */) => default; // 0x0000000182870DB0-0x0000000182871040
	[BlackList] // 0x0000000189799750-0x0000000189799790
	// [XID] // 0x0000000189799750-0x0000000189799790
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182870970-0x0000000182870C40
	// [XID] // 0x00000001897A4790-0x00000001897A47B0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182871A30-0x0000000182871C70
	[BlackList] // 0x00000001897ABC60-0x00000001897ABCA0
	// [XID] // 0x00000001897ABC60-0x00000001897ABCA0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182870C40-0x0000000182870CE0
	[BlackList] // 0x00000001897B6E90-0x00000001897B6ED0
	// [XID] // 0x00000001897B6E90-0x00000001897B6ED0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182870CE0-0x0000000182870DB0
	[BlackList] // 0x00000001897C1A10-0x00000001897C1A50
	// [XID] // 0x00000001897C1A10-0x00000001897C1A50
	public virtual void ReturnToObjectPool() {} // 0x0000000182871F60-0x0000000182872000
	[BlackList] // 0x00000001897CBF30-0x00000001897CBF70
	// [XID] // 0x00000001897CBF30-0x00000001897CBF70
	public virtual void OnPoolAllocated() {} // 0x0000000182871E20-0x0000000182871EC0
	[BlackList] // 0x00000001897D68A0-0x00000001897D68E0
	// [XID] // 0x00000001897D68A0-0x00000001897D68E0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182871D80-0x0000000182871E20
}

