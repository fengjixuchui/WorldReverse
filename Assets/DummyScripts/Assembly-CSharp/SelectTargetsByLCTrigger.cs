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
public class SelectTargetsByLCTrigger : SelectTargets, IAutoAllocRecycle // TypeDefIndex: 16844
{
	// Fields
	private TargetType _campTargetType; // 0x28

	// Properties
	public TargetType campTargetType { /* [XID] */ /* 0x000000018973D8D0-0x000000018973D8F0 */ get => default; /* [XID] */ /* 0x0000000189744D10-0x0000000189744D30 */ private set {} } // 0x0000000184CA08C0-0x0000000184CA0960 0x0000000184CA0D60-0x0000000184CA0E10

	// Constructors
	public SelectTargetsByLCTrigger() {} // 0x0000000184CA0EB0-0x0000000184CA0F10

	// Methods
	// [XID] // 0x000000018974C940-0x000000018974C960
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184CA0C70-0x0000000184CA0D60
	// [XID] // 0x0000000189753C60-0x0000000189753C80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184CA09C0-0x0000000184CA0A70
	// [XID] // 0x000000018975B1C0-0x000000018975B1E0
	public override SelectTargets Clone(bool useObjectPool = false /* Metadata: 0x00AF4850 */) => default; // 0x0000000184CA0530-0x0000000184CA0610
	// [XID] // 0x0000000189762B90-0x0000000189762BB0
	public override int GetHashNum() => default; // 0x0000000184C9F4D0-0x0000000184C9F5A0
	// [XID] // 0x000000018976A190-0x000000018976A1B0
	public override void InitEmpty() {} // 0x0000000184C9FFC0-0x0000000184CA0060
	[BlackList] // 0x00000001897719F0-0x0000000189771A30
	// [XID] // 0x00000001897719F0-0x0000000189771A30
	public override bool FromJson(JSONNode node) => default; // 0x0000000184C9F9B0-0x0000000184C9FD30
	// [XID] // 0x000000018977C040-0x000000018977C060
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184C9ED70-0x0000000184C9EF90
	[BlackList] // 0x0000000189783910-0x0000000189783950
	// [XID] // 0x0000000189783910-0x0000000189783950
	public static new SelectTargetsByLCTrigger ParseFromJson(JSONNode node) => default; // 0x0000000184CA0670-0x0000000184CA08C0
	// [XID] // 0x000000018978DE50-0x000000018978DE70
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4851 */, bool useObjectPool = false /* Metadata: 0x00AF4855 */) => default; // 0x0000000184CA0230-0x0000000184CA0530
	// [XID] // 0x0000000189795500-0x0000000189795520
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4856 */, bool useObjectPool = false /* Metadata: 0x00AF485A */) => default; // 0x0000000184C9F680-0x0000000184C9F8B0
	// [XID] // 0x000000018979D950-0x000000018979D970
	public static new SelectTargetsByLCTrigger ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF485B */, bool useObjectPool = false /* Metadata: 0x00AF485F */) => default; // 0x0000000184C9FD30-0x0000000184C9FF50
	[BlackList] // 0x00000001897A4C10-0x00000001897A4C50
	// [XID] // 0x00000001897A4C10-0x00000001897A4C50
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184C9EF90-0x0000000184C9F260
	// [XID] // 0x00000001897AF490-0x00000001897AF4B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184CA0A70-0x0000000184CA0C70
	[BlackList] // 0x00000001897B72F0-0x00000001897B7330
	// [XID] // 0x00000001897B72F0-0x00000001897B7330
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184CA0140-0x0000000184CA0230
	[BlackList] // 0x00000001897C1DF0-0x00000001897C1E30
	// [XID] // 0x00000001897C1DF0-0x00000001897C1E30
	public override void AutoAllocTypeFields() {} // 0x0000000184C9F260-0x0000000184C9F300
	[BlackList] // 0x00000001897CC470-0x00000001897CC4B0
	// [XID] // 0x00000001897CC470-0x00000001897CC4B0
	public override void AutoRecycleTypeFields() {} // 0x0000000184C9F300-0x0000000184C9F3B0
	[BlackList] // 0x00000001897D6E00-0x00000001897D6E40
	// [XID] // 0x00000001897D6E00-0x00000001897D6E40
	public override void ReturnToObjectPool() {} // 0x0000000184CA0E10-0x0000000184CA0EB0
}

