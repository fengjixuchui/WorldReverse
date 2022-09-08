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
public class ConfigScenePoint : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14974
{
	// Fields
	private ScenePointType _type; // 0x10
	private SimpleSafeUInt32 gadgetIdRawNum; // 0x14
	private SimpleSafeUInt16 areaIdRawNum; // 0x18
	private MoleMole.Config.Vector _pos; // 0x1C
	private MoleMole.Config.Vector _rot; // 0x28
	private MoleMole.Config.Vector _tranPos; // 0x34
	private MoleMole.Config.Vector _tranRot; // 0x40
	private bool _unlocked; // 0x4C
	private string _alias; // 0x50
	private bool _groupLimit; // 0x58

	// Properties
	public virtual RealScenePointType pointType { /* [XID] */ /* 0x00000001899F2C40-0x00000001899F2C60 */ get => default; } // 0x0000000183584300-0x00000001835843A0 
	public ScenePointType type { /* [XID] */ /* 0x00000001897841E0-0x0000000189784200 */ get => default; /* [XID] */ /* 0x0000000189A01630-0x0000000189A01650 */ private set {} } // 0x00000001835855B0-0x0000000183585650 0x0000000183584960-0x0000000183584A10
	public uint gadgetId { /* [XID] */ /* 0x0000000189A09070-0x0000000189A09090 */ get => default; /* [XID] */ /* 0x0000000189A10570-0x0000000189A10590 */ private set {} } // 0x00000001835839A0-0x0000000183583A70 0x00000001835838C0-0x00000001835839A0
	public ushort areaId { /* [XID] */ /* 0x0000000189A17BD0-0x0000000189A17BF0 */ get => default; /* [XID] */ /* 0x0000000189A1F1D0-0x0000000189A1F1F0 */ private set {} } // 0x0000000183583B10-0x0000000183583BE0 0x00000001835825F0-0x00000001835826D0
	public MoleMole.Config.Vector pos { /* [XID] */ /* 0x0000000189A26780-0x0000000189A267A0 */ get => default; /* [XID] */ /* 0x0000000189A2DAF0-0x0000000189A2DB10 */ private set {} } // 0x0000000183583540-0x0000000183583620 0x0000000183582910-0x00000001835829E0
	public MoleMole.Config.Vector rot { /* [XID] */ /* 0x0000000189A35710-0x0000000189A35730 */ get => default; /* [XID] */ /* 0x0000000189A3CB80-0x0000000189A3CBA0 */ private set {} } // 0x00000001835815A0-0x0000000183581680 0x0000000183582840-0x0000000183582910
	public MoleMole.Config.Vector tranPos { /* [XID] */ /* 0x0000000189A445D0-0x0000000189A445F0 */ get => default; /* [XID] */ /* 0x0000000189A4BBC0-0x0000000189A4BBE0 */ private set {} } // 0x0000000183581680-0x0000000183581760 0x00000001835837F0-0x00000001835838C0
	public MoleMole.Config.Vector tranRot { /* [XID] */ /* 0x0000000189A532C0-0x0000000189A532E0 */ get => default; /* [XID] */ /* 0x0000000189A5A9F0-0x0000000189A5AA10 */ private set {} } // 0x00000001835847B0-0x0000000183584890 0x0000000183584150-0x0000000183584220
	public bool unlocked { /* [XID] */ /* 0x0000000189B28D10-0x0000000189B28D30 */ get => default; /* [XID] */ /* 0x0000000189A6A0B0-0x0000000189A6A0D0 */ private set {} } // 0x00000001835826D0-0x0000000183582770 0x0000000183584450-0x0000000183584500
	public string alias { /* [XID] */ /* 0x00000001897CCF40-0x00000001897CCF60 */ get => default; /* [XID] */ /* 0x0000000189A79000-0x0000000189A79020 */ private set {} } // 0x00000001835834A0-0x0000000183583540 0x00000001835843A0-0x0000000183584450
	public bool groupLimit { /* [XID] */ /* 0x0000000189BA73D0-0x0000000189BA73F0 */ get => default; /* [XID] */ /* 0x0000000189A881A0-0x0000000189A881C0 */ private set {} } // 0x0000000183583A70-0x0000000183583B10 0x0000000183584700-0x00000001835847B0

	// Constructors
	public ConfigScenePoint(MoleMole.Config.Vector pos, MoleMole.Config.Vector rot, uint gadgetId) {} // 0x0000000183585750-0x0000000183585820
	public ConfigScenePoint() {} // 0x00000001835856F0-0x0000000183585750

	// Methods
	// [XID] // 0x0000000189A8FA30-0x0000000189A8FA50
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183585220-0x0000000183585470
	// [XID] // 0x0000000189A97080-0x0000000189A970A0
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183584890-0x0000000183584960
	// [XID] // 0x0000000189A9E470-0x0000000189A9E490
	public virtual ConfigScenePoint Clone(bool useObjectPool = false /* Metadata: 0x00AEFD08 */) => default; // 0x0000000183584220-0x0000000183584300
	// [XID] // 0x0000000189AA5DA0-0x0000000189AA5DC0
	public virtual int GetHashNum() => default; // 0x0000000183582770-0x0000000183582840
	// [XID] // 0x0000000189AAD4A0-0x0000000189AAD4C0
	public virtual void InitEmpty() {} // 0x0000000183583BE0-0x0000000183583D60
	[BlackList] // 0x0000000189AB4D70-0x0000000189AB4DB0
	// [XID] // 0x0000000189AB4D70-0x0000000189AB4DB0
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000183583120-0x00000001835834A0
	// [XID] // 0x0000000189A83DC0-0x0000000189A83DE0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183581760-0x0000000183582120
	[BlackList] // 0x0000000189AC71A0-0x0000000189AC71E0
	// [XID] // 0x0000000189AC71A0-0x0000000189AC71E0
	public static ConfigScenePoint ParseFromJson(JSONNode node) => default; // 0x0000000183584500-0x0000000183584700
	// [XID] // 0x0000000189AD19F0-0x0000000189AD1A10
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD09 */, bool useObjectPool = false /* Metadata: 0x00AEFD0D */) => default; // 0x0000000183583E50-0x0000000183584150
	// [XID] // 0x0000000189AD96D0-0x0000000189AD96F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD0E */, bool useObjectPool = false /* Metadata: 0x00AEFD12 */) => default; // 0x00000001835829E0-0x0000000183583120
	// [XID] // 0x00000001899B3090-0x00000001899B30B0
	public static ConfigScenePoint ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD13 */, bool useObjectPool = false /* Metadata: 0x00AEFD17 */) => default; // 0x0000000183583620-0x00000001835837F0
	[BlackList] // 0x0000000189AE8630-0x0000000189AE8670
	// [XID] // 0x0000000189AE8630-0x0000000189AE8670
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000183582120-0x00000001835823F0
	// [XID] // 0x0000000189AF3410-0x0000000189AF3430
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183584A10-0x0000000183585220
	[BlackList] // 0x0000000189AFACA0-0x0000000189AFACE0
	// [XID] // 0x0000000189AFACA0-0x0000000189AFACE0
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183583D60-0x0000000183583E50
	[BlackList] // 0x0000000189B05040-0x0000000189B05080
	// [XID] // 0x0000000189B05040-0x0000000189B05080
	public virtual void AutoAllocTypeFields() {} // 0x00000001835823F0-0x0000000183582490
	[BlackList] // 0x0000000189B0F810-0x0000000189B0F850
	// [XID] // 0x0000000189B0F810-0x0000000189B0F850
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183582490-0x00000001835825F0
	[BlackList] // 0x0000000189B19AB0-0x0000000189B19AF0
	// [XID] // 0x0000000189B19AB0-0x0000000189B19AF0
	public virtual void ReturnToObjectPool() {} // 0x0000000183585650-0x00000001835856F0
	[BlackList] // 0x0000000189B242C0-0x0000000189B24300
	// [XID] // 0x0000000189B242C0-0x0000000189B24300
	public virtual void OnPoolAllocated() {} // 0x0000000183585510-0x00000001835855B0
	[BlackList] // 0x0000000189B2E470-0x0000000189B2E4B0
	// [XID] // 0x0000000189B2E470-0x0000000189B2E4B0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183585470-0x0000000183585510
}

