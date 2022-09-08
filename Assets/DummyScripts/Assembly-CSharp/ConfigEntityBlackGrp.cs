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
public class ConfigEntityBlackGrp : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18049
{
	// Fields
	private bool _isBlack; // 0x10
	private EntityType _entityType; // 0x14
	private SimpleSafeUInt32[] _entityIds; // 0x18

	// Properties
	public bool isBlack { /* [XID] */ /* 0x00000001898DF9A0-0x00000001898DF9C0 */ get => default; /* [XID] */ /* 0x00000001898E7490-0x00000001898E74B0 */ private set {} } // 0x0000000182D074A0-0x0000000182D07540 0x0000000182D07C90-0x0000000182D07D40
	public EntityType entityType { /* [XID] */ /* 0x00000001898EED00-0x00000001898EED20 */ get => default; /* [XID] */ /* 0x00000001898F6580-0x00000001898F65A0 */ private set {} } // 0x0000000182D07400-0x0000000182D074A0 0x0000000182D06FA0-0x0000000182D07050
	public SimpleSafeUInt32[] entityIds { /* [XID] */ /* 0x00000001898FDCA0-0x00000001898FDCC0 */ get => default; /* [XID] */ /* 0x00000001899054C0-0x00000001899054E0 */ private set {} } // 0x0000000182D07D40-0x0000000182D07DE0 0x0000000182D07050-0x0000000182D07100

	// Constructors
	public ConfigEntityBlackGrp() {} // 0x0000000182D083D0-0x0000000182D08440

	// Methods
	// [XID] // 0x000000018990CD70-0x000000018990CD90
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182D080D0-0x0000000182D081F0
	// [XID] // 0x0000000189914540-0x0000000189914560
	public void InitEmpty() {} // 0x0000000182D078C0-0x0000000182D07990
	[BlackList] // 0x000000018991C0C0-0x000000018991C100
	// [XID] // 0x000000018991C0C0-0x000000018991C100
	public bool FromJson(JSONNode node) => default; // 0x0000000182D07540-0x0000000182D078C0
	// [XID] // 0x00000001899267E0-0x0000000189926800
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182D06800-0x0000000182D06B80
	// [XID] // 0x000000018992DDB0-0x000000018992DDD0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF87DD */, bool useObjectPool = false /* Metadata: 0x00AF87E1 */) => default; // 0x0000000182D07990-0x0000000182D07C90
	// [XID] // 0x00000001899351D0-0x00000001899351F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF87E2 */, bool useObjectPool = false /* Metadata: 0x00AF87E6 */) => default; // 0x0000000182D07100-0x0000000182D07400
	[BlackList] // 0x000000018993CD50-0x000000018993CD90
	// [XID] // 0x000000018993CD50-0x000000018993CD90
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182D06B80-0x0000000182D06E50
	// [XID] // 0x0000000189947280-0x00000001899472A0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182D07DE0-0x0000000182D080D0
	[BlackList] // 0x000000018994E9A0-0x000000018994E9E0
	// [XID] // 0x000000018994E9A0-0x000000018994E9E0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182D06E50-0x0000000182D06EF0
	[BlackList] // 0x0000000189959090-0x00000001899590D0
	// [XID] // 0x0000000189959090-0x00000001899590D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182D06EF0-0x0000000182D06FA0
	[BlackList] // 0x0000000189963A60-0x0000000189963AA0
	// [XID] // 0x0000000189963A60-0x0000000189963AA0
	public virtual void ReturnToObjectPool() {} // 0x0000000182D08330-0x0000000182D083D0
	[BlackList] // 0x000000018996DE60-0x000000018996DEA0
	// [XID] // 0x000000018996DE60-0x000000018996DEA0
	public virtual void OnPoolAllocated() {} // 0x0000000182D08290-0x0000000182D08330
	[BlackList] // 0x0000000189978FF0-0x0000000189979030
	// [XID] // 0x0000000189978FF0-0x0000000189979030
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182D081F0-0x0000000182D08290
}

