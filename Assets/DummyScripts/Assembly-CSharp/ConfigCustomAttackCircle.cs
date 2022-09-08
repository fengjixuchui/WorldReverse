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
public class ConfigCustomAttackCircle : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17945
{
	// Fields
	private SimpleSafeFloat customAttackCircle_RadiusRawNum; // 0x10
	private SimpleSafeFloat customAttackCircle_InnerRadiusRawNum; // 0x14

	// Properties
	public float customAttackCircle_Radius { /* [XID] */ /* 0x0000000189BC04F0-0x0000000189BC0510 */ get => default; /* [XID] */ /* 0x0000000189790B50-0x0000000189790B70 */ private set {} } // 0x0000000184B2FDB0-0x0000000184B2FE90 0x0000000184B30350-0x0000000184B30430
	public float customAttackCircle_InnerRadius { /* [XID] */ /* 0x00000001897984C0-0x00000001897984E0 */ get => default; /* [XID] */ /* 0x00000001897A0290-0x00000001897A02B0 */ private set {} } // 0x0000000184B308C0-0x0000000184B309A0 0x0000000184B30270-0x0000000184B30350

	// Constructors
	public ConfigCustomAttackCircle() {} // 0x0000000184B30A40-0x0000000184B30AF0

	// Methods
	// [XID] // 0x00000001897A7820-0x00000001897A7840
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184B30670-0x0000000184B30780
	// [XID] // 0x00000001897AF250-0x00000001897AF270
	public void InitEmpty() {} // 0x0000000184B2FE90-0x0000000184B2FF70
	[BlackList] // 0x00000001897B70F0-0x00000001897B7130
	// [XID] // 0x00000001897B70F0-0x00000001897B7130
	public bool FromJson(JSONNode node) => default; // 0x0000000184B2FA30-0x0000000184B2FDB0
	// [XID] // 0x00000001897C1CD0-0x00000001897C1CF0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184B2F080-0x0000000184B2F390
	// [XID] // 0x00000001897C95E0-0x00000001897C9600
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF844F */, bool useObjectPool = false /* Metadata: 0x00AF8453 */) => default; // 0x0000000184B2FF70-0x0000000184B30270
	// [XID] // 0x00000001897D0BD0-0x00000001897D0BF0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8454 */, bool useObjectPool = false /* Metadata: 0x00AF8458 */) => default; // 0x0000000184B2F7E0-0x0000000184B2FA30
	[BlackList] // 0x00000001897D89B0-0x00000001897D89F0
	// [XID] // 0x00000001897D89B0-0x00000001897D89F0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184B2F390-0x0000000184B2F660
	// [XID] // 0x00000001897E2CE0-0x00000001897E2D00
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184B30430-0x0000000184B30670
	[BlackList] // 0x00000001897EA520-0x00000001897EA560
	// [XID] // 0x00000001897EA520-0x00000001897EA560
	public virtual void AutoAllocTypeFields() {} // 0x0000000184B2F660-0x0000000184B2F700
	[BlackList] // 0x00000001897F4ED0-0x00000001897F4F10
	// [XID] // 0x00000001897F4ED0-0x00000001897F4F10
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184B2F700-0x0000000184B2F7E0
	[BlackList] // 0x00000001897FF6D0-0x00000001897FF710
	// [XID] // 0x00000001897FF6D0-0x00000001897FF710
	public virtual void ReturnToObjectPool() {} // 0x0000000184B309A0-0x0000000184B30A40
	[BlackList] // 0x0000000189809C30-0x0000000189809C70
	// [XID] // 0x0000000189809C30-0x0000000189809C70
	public virtual void OnPoolAllocated() {} // 0x0000000184B30820-0x0000000184B308C0
	[BlackList] // 0x0000000189814150-0x0000000189814190
	// [XID] // 0x0000000189814150-0x0000000189814190
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184B30780-0x0000000184B30820
}

