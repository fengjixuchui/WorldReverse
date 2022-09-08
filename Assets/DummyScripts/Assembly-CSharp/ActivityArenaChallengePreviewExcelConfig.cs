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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ActivityArenaChallengePreviewExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15005
{
	// Fields
	protected SimpleSafeUInt32 scheduleIdRawNum; // 0x10
	protected SimpleSafeUInt32 rewardIdRawNum; // 0x14
	protected SimpleSafeFloat[] _centerPosList; // 0x18
	protected SimpleSafeUInt32 guideQuestId1RawNum; // 0x20

	// Properties
	public uint scheduleId { /* [XID] */ /* 0x0000000189AFBF00-0x0000000189AFBF20 */ get => default; /* [XID] */ /* 0x0000000189B03830-0x0000000189B03850 */ protected set {} } // 0x0000000181C76F90-0x0000000181C77060 0x0000000181C78590-0x0000000181C78670
	public uint rewardId { /* [XID] */ /* 0x0000000189B0AEA0-0x0000000189B0AEC0 */ get => default; /* [XID] */ /* 0x0000000189B12720-0x0000000189B12740 */ protected set {} } // 0x0000000181C783E0-0x0000000181C784B0 0x0000000181C77060-0x0000000181C77140
	public SimpleSafeFloat[] centerPosList { /* [XID] */ /* 0x0000000189B19A90-0x0000000189B19AB0 */ get => default; /* [XID] */ /* 0x0000000189B21030-0x0000000189B21050 */ protected set {} } // 0x0000000181C78340-0x0000000181C783E0 0x0000000181C77DE0-0x0000000181C77E90
	public uint guideQuestId1 { /* [XID] */ /* 0x0000000189B28730-0x0000000189B28750 */ get => default; /* [XID] */ /* 0x0000000189B2FB50-0x0000000189B2FB70 */ protected set {} } // 0x0000000181C772E0-0x0000000181C773B0 0x0000000181C784B0-0x0000000181C78590

	// Constructors
	public ActivityArenaChallengePreviewExcelConfig() {} // 0x0000000181C78850-0x0000000181C788B0

	// Methods
	// [IDTag] // 0x0000000189B37530-0x0000000189B37570
	// [XID] // 0x0000000189B37530-0x0000000189B37570
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181C773B0-0x0000000181C778E0
	// [IDTag] // 0x0000000189B41ED0-0x0000000189B41F10
	// [XID] // 0x0000000189B41ED0-0x0000000189B41F10
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181C778E0-0x0000000181C77DE0
	// [XID] // 0x0000000189B4C740-0x0000000189B4C760
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFE39 */, bool useObjectPool = false /* Metadata: 0x00AEFE3D */) => default; // 0x0000000181C77E90-0x0000000181C78340
	[BlackList] // 0x0000000189B53DE0-0x0000000189B53E20
	// [XID] // 0x0000000189B53DE0-0x0000000189B53E20
	public virtual void AutoAllocTypeFields() {} // 0x0000000181C77140-0x0000000181C771E0
	[BlackList] // 0x0000000189B5E820-0x0000000189B5E860
	// [XID] // 0x0000000189B5E820-0x0000000189B5E860
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181C771E0-0x0000000181C772E0
	[BlackList] // 0x0000000189B69000-0x0000000189B69040
	// [XID] // 0x0000000189B69000-0x0000000189B69040
	public virtual void ReturnToObjectPool() {} // 0x0000000181C787B0-0x0000000181C78850
	[BlackList] // 0x0000000189B733F0-0x0000000189B73430
	// [XID] // 0x0000000189B733F0-0x0000000189B73430
	public virtual void OnPoolAllocated() {} // 0x0000000181C78710-0x0000000181C787B0
	[BlackList] // 0x0000000189B7D800-0x0000000189B7D840
	// [XID] // 0x0000000189B7D800-0x0000000189B7D840
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181C78670-0x0000000181C78710
}

