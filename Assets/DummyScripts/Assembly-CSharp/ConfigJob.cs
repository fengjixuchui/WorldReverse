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
public class ConfigJob : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18953
{
	// Fields
	private bool _isForceMainThread; // 0x10
	private ConfigScheduleJobType _scheduleJobType; // 0x14
	private ConfigSchedulerType _scheduleType; // 0x18
	private SimpleSafeInt32 maxNodeNumRawNum; // 0x1C
	private SimpleSafeInt32 groupIdRawNum; // 0x20

	// Properties
	public bool isForceMainThread { /* [XID] */ /* 0x000000018982D6A0-0x000000018982D6C0 */ get => default; /* [XID] */ /* 0x0000000189834E30-0x0000000189834E50 */ private set {} } // 0x0000000181578E60-0x0000000181578F00 0x0000000181578DB0-0x0000000181578E60
	public ConfigScheduleJobType scheduleJobType { /* [XID] */ /* 0x000000018983C5F0-0x000000018983C610 */ get => default; /* [XID] */ /* 0x0000000189843C20-0x0000000189843C40 */ private set {} } // 0x0000000181578FE0-0x0000000181579080 0x00000001815795B0-0x0000000181579660
	public ConfigSchedulerType scheduleType { /* [XID] */ /* 0x000000018984B110-0x000000018984B130 */ get => default; /* [XID] */ /* 0x00000001898523A0-0x00000001898523C0 */ private set {} } // 0x0000000181578C30-0x0000000181578CD0 0x0000000181578800-0x00000001815788B0
	public int maxNodeNum { /* [XID] */ /* 0x0000000189859CD0-0x0000000189859CF0 */ get => default; /* [XID] */ /* 0x0000000189860DD0-0x0000000189860DF0 */ private set {} } // 0x0000000181579080-0x0000000181579150 0x0000000181578CD0-0x0000000181578DB0
	public int groupId { /* [XID] */ /* 0x0000000189BC3C30-0x0000000189BC3C50 */ get => default; /* [XID] */ /* 0x000000018986FA00-0x000000018986FA20 */ private set {} } // 0x0000000181579660-0x0000000181579730 0x0000000181579730-0x0000000181579810
	public bool isGlobal { /* [XID] */ /* 0x00000001898B83C0-0x00000001898B83E0 */ get => default; } // 0x0000000181579500-0x00000001815795B0 
	public int schedulerType { /* [XID] */ /* 0x00000001898BFB80-0x00000001898BFBA0 */ get => default; } // 0x0000000181579450-0x0000000181579500 

	// Constructors
	public ConfigJob() {} // 0x0000000181579F80-0x000000018157A030

	// Methods
	// [XID] // 0x00000001898770F0-0x0000000189877110
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181579C40-0x0000000181579DA0
	// [XID] // 0x000000018987EB00-0x000000018987EB20
	public void InitEmpty() {} // 0x0000000181578F00-0x0000000181578FE0
	[BlackList] // 0x0000000189885FE0-0x0000000189886020
	// [XID] // 0x0000000189885FE0-0x0000000189886020
	public bool FromJson(JSONNode node) => default; // 0x00000001815788B0-0x0000000181578C30
	// [XID] // 0x0000000189890120-0x0000000189890140
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181577A80-0x0000000181577FE0
	// [XID] // 0x0000000189897640-0x0000000189897660
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB4FF */, bool useObjectPool = false /* Metadata: 0x00AFB503 */) => default; // 0x0000000181579150-0x0000000181579450
	// [XID] // 0x000000018989EC00-0x000000018989EC20
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB504 */, bool useObjectPool = false /* Metadata: 0x00AFB508 */) => default; // 0x0000000181578430-0x0000000181578800
	[BlackList] // 0x00000001898A6600-0x00000001898A6640
	// [XID] // 0x00000001898A6600-0x00000001898A6640
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181577FE0-0x00000001815782B0
	// [XID] // 0x00000001898B0D20-0x00000001898B0D40
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181579810-0x0000000181579C40
	[BlackList] // 0x00000001898C7440-0x00000001898C7480
	// [XID] // 0x00000001898C7440-0x00000001898C7480
	public virtual void AutoAllocTypeFields() {} // 0x00000001815782B0-0x0000000181578350
	[BlackList] // 0x00000001898D1BB0-0x00000001898D1BF0
	// [XID] // 0x00000001898D1BB0-0x00000001898D1BF0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181578350-0x0000000181578430
	[BlackList] // 0x00000001898DC510-0x00000001898DC550
	// [XID] // 0x00000001898DC510-0x00000001898DC550
	public virtual void ReturnToObjectPool() {} // 0x0000000181579EE0-0x0000000181579F80
	[BlackList] // 0x00000001898E7330-0x00000001898E7370
	// [XID] // 0x00000001898E7330-0x00000001898E7370
	public virtual void OnPoolAllocated() {} // 0x0000000181579E40-0x0000000181579EE0
	[BlackList] // 0x00000001898F1BD0-0x00000001898F1C10
	// [XID] // 0x00000001898F1BD0-0x00000001898F1C10
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181579DA0-0x0000000181579E40
}

