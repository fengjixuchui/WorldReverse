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
public class QuestGuideEx : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14940
{
	// Fields
	private QuestGuideType _type; // 0x10
	private QuestGuideAuto _autoGuide; // 0x14
	private string[] _param; // 0x18
	private uint _guideScene; // 0x20
	private QuestGuideStyle _guideStyle; // 0x24
	private QuestGuideLayer _guideLayer; // 0x28

	// Properties
	public QuestGuideType type { /* [XID] */ /* 0x0000000189A0D860-0x0000000189A0D880 */ get => default; /* [XID] */ /* 0x0000000189A14F60-0x0000000189A14F80 */ private set {} } // 0x00000001832A4940-0x00000001832A49E0 0x00000001832A4020-0x00000001832A40D0
	public QuestGuideAuto autoGuide { /* [XID] */ /* 0x0000000189A1C0B0-0x0000000189A1C0D0 */ get => default; /* [XID] */ /* 0x0000000189A23980-0x0000000189A239A0 */ private set {} } // 0x00000001832A3110-0x00000001832A31B0 0x00000001832A3AF0-0x00000001832A3BA0
	public string[] param { /* [XID] */ /* 0x0000000189A2ADE0-0x0000000189A2AE00 */ get => default; /* [XID] */ /* 0x0000000189A32320-0x0000000189A32340 */ private set {} } // 0x00000001832A4A90-0x00000001832A4B30 0x00000001832A49E0-0x00000001832A4A90
	public uint guideScene { /* [XID] */ /* 0x0000000189A39DB0-0x0000000189A39DD0 */ get => default; /* [XID] */ /* 0x0000000189A41650-0x0000000189A41670 */ private set {} } // 0x00000001832A3070-0x00000001832A3110 0x00000001832A4540-0x00000001832A45F0
	public QuestGuideStyle guideStyle { /* [XID] */ /* 0x0000000189A48C90-0x0000000189A48CB0 */ get => default; /* [XID] */ /* 0x0000000189A503E0-0x0000000189A50400 */ private set {} } // 0x00000001832A45F0-0x00000001832A4690 0x00000001832A3F70-0x00000001832A4020
	public QuestGuideLayer guideLayer { /* [XID] */ /* 0x0000000189A57970-0x0000000189A57990 */ get => default; /* [XID] */ /* 0x0000000189A5F5F0-0x0000000189A5F610 */ private set {} } // 0x00000001832A3A50-0x00000001832A3AF0 0x00000001832A3620-0x00000001832A36D0

	// Constructors
	public QuestGuideEx(QuestGuideType type, string[] param, QuestGuideStyle guideStyle, uint guideScene, QuestGuideLayer guideLayer, QuestGuideAuto autoGuide) {} // 0x00000001832A4BD0-0x00000001832A4CB0
	public QuestGuideEx() {} // 0x00000001832A4CB0-0x00000001832A4D10

	// Methods
	// [XID] // 0x0000000189A66F00-0x0000000189A66F20
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001832A4690-0x00000001832A4800
	// [XID] // 0x0000000189A6E6E0-0x0000000189A6E700
	public void InitEmpty() {} // 0x00000001832A3BA0-0x00000001832A3C70
	[BlackList] // 0x0000000189A75D70-0x0000000189A75DB0
	// [XID] // 0x0000000189A75D70-0x0000000189A75DB0
	public bool FromJson(JSONNode node) => default; // 0x00000001832A36D0-0x00000001832A3A50
	// [XID] // 0x0000000189A804A0-0x0000000189A804C0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001832A2660-0x00000001832A2C50
	// [XID] // 0x0000000189A881C0-0x0000000189A881E0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB00 */, bool useObjectPool = false /* Metadata: 0x00AEFB04 */) => default; // 0x00000001832A3C70-0x00000001832A3F70
	// [XID] // 0x0000000189A8FA50-0x0000000189A8FA70
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB05 */, bool useObjectPool = false /* Metadata: 0x00AEFB09 */) => default; // 0x00000001832A31B0-0x00000001832A3620
	[BlackList] // 0x0000000189A970A0-0x0000000189A970E0
	// [XID] // 0x0000000189A970A0-0x0000000189A970E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001832A2C50-0x00000001832A2F20
	// [XID] // 0x0000000189AA13A0-0x0000000189AA13C0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001832A40D0-0x00000001832A4540
	[BlackList] // 0x0000000189AA8AE0-0x0000000189AA8B20
	// [XID] // 0x0000000189AA8AE0-0x0000000189AA8B20
	public virtual void AutoAllocTypeFields() {} // 0x00000001832A2F20-0x00000001832A2FC0
	[BlackList] // 0x0000000189AB3600-0x0000000189AB3640
	// [XID] // 0x0000000189AB3600-0x0000000189AB3640
	public virtual void AutoRecycleTypeFields() {} // 0x00000001832A2FC0-0x00000001832A3070
	[BlackList] // 0x0000000189ABE150-0x0000000189ABE190
	// [XID] // 0x0000000189ABE150-0x0000000189ABE190
	public virtual void ReturnToObjectPool() {} // 0x00000001832A4B30-0x00000001832A4BD0
	[BlackList] // 0x0000000189AC8910-0x0000000189AC8950
	// [XID] // 0x0000000189AC8910-0x0000000189AC8950
	public virtual void OnPoolAllocated() {} // 0x00000001832A48A0-0x00000001832A4940
	[BlackList] // 0x0000000189AD3380-0x0000000189AD33C0
	// [XID] // 0x0000000189AD3380-0x0000000189AD33C0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001832A4800-0x00000001832A48A0
}

