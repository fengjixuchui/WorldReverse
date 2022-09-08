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
public class ConfigUIPhotograph : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19105
{
	// Fields
	private SimpleSafeFloat fovMaxRawNum; // 0x10
	private SimpleSafeFloat fovMinRawNum; // 0x14
	private SimpleSafeFloat cameraShiftUpRawNum; // 0x18
	private SimpleSafeFloat cameraShiftDownRawNum; // 0x1C
	private SimpleSafeFloat cameraShiftLeftRawNum; // 0x20
	private SimpleSafeFloat cameraShiftRightRawNum; // 0x24
	private SimpleSafeFloat blurDistanceRawNum; // 0x28
	private SimpleSafeFloat blurRangeRawNum; // 0x2C
	private SimpleSafeFloat blurAmountRawNum; // 0x30

	// Properties
	public float fovMax { /* [XID] */ /* 0x000000018972E150-0x000000018972E170 */ get => default; /* [XID] */ /* 0x0000000189735840-0x0000000189735860 */ private set {} } // 0x00000001844FE2E0-0x00000001844FE3C0 0x00000001844FE040-0x00000001844FE120
	public float fovMin { /* [XID] */ /* 0x000000018973D390-0x000000018973D3B0 */ get => default; /* [XID] */ /* 0x0000000189744850-0x0000000189744870 */ private set {} } // 0x00000001844FD870-0x00000001844FD950 0x00000001844FEDA0-0x00000001844FEE80
	public float cameraShiftUp { /* [XID] */ /* 0x000000018974C5E0-0x000000018974C600 */ get => default; /* [XID] */ /* 0x0000000189753860-0x0000000189753880 */ private set {} } // 0x00000001844FC370-0x00000001844FC450 0x00000001844FCAF0-0x00000001844FCBD0
	public float cameraShiftDown { /* [XID] */ /* 0x000000018975ADA0-0x000000018975ADC0 */ get => default; /* [XID] */ /* 0x0000000189762830-0x0000000189762850 */ private set {} } // 0x00000001844FD790-0x00000001844FD870 0x00000001844FE120-0x00000001844FE200
	public float cameraShiftLeft { /* [XID] */ /* 0x0000000189769E50-0x0000000189769E70 */ get => default; /* [XID] */ /* 0x00000001897715B0-0x00000001897715D0 */ private set {} } // 0x00000001844FEF60-0x00000001844FF040 0x00000001844FD330-0x00000001844FD410
	public float cameraShiftRight { /* [XID] */ /* 0x0000000189778D60-0x0000000189778D80 */ get => default; /* [XID] */ /* 0x0000000189780320-0x0000000189780340 */ private set {} } // 0x00000001844FDA30-0x00000001844FDB10 0x00000001844FDB10-0x00000001844FDBF0
	public float blurDistance { /* [XID] */ /* 0x0000000189787AE0-0x0000000189787B00 */ get => default; /* [XID] */ /* 0x000000018978F100-0x000000018978F120 */ private set {} } // 0x00000001844FCA10-0x00000001844FCAF0 0x00000001844FEE80-0x00000001844FEF60
	public float blurRange { /* [XID] */ /* 0x0000000189796910-0x0000000189796930 */ get => default; /* [XID] */ /* 0x000000018979EAD0-0x000000018979EAF0 */ private set {} } // 0x00000001844FD950-0x00000001844FDA30 0x00000001844FE200-0x00000001844FE2E0
	public float blurAmount { /* [XID] */ /* 0x00000001897A61C0-0x00000001897A61E0 */ get => default; /* [XID] */ /* 0x00000001897AD650-0x00000001897AD670 */ private set {} } // 0x00000001844FC930-0x00000001844FCA10 0x00000001844FE3C0-0x00000001844FE4A0

	// Constructors
	public ConfigUIPhotograph() {} // 0x00000001844FF0E0-0x00000001844FF140

	// Methods
	// [XID] // 0x00000001897B5770-0x00000001897B5790
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001844FEAA0-0x00000001844FEC60
	// [XID] // 0x00000001897BD420-0x00000001897BD440
	public void InitEmpty() {} // 0x00000001844FDBF0-0x00000001844FDD40
	[BlackList] // 0x00000001897C4760-0x00000001897C47A0
	// [XID] // 0x00000001897C4760-0x00000001897C47A0
	public bool FromJson(JSONNode node) => default; // 0x00000001844FD410-0x00000001844FD790
	// [XID] // 0x00000001897CF0F0-0x00000001897CF110
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001844FB870-0x00000001844FC370
	// [XID] // 0x0000000189661840-0x0000000189661860
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC1ED */, bool useObjectPool = false /* Metadata: 0x00AFC1F1 */) => default; // 0x00000001844FDD40-0x00000001844FE040
	// [XID] // 0x00000001897DE130-0x00000001897DE150
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC1F2 */, bool useObjectPool = false /* Metadata: 0x00AFC1F6 */) => default; // 0x00000001844FCBD0-0x00000001844FD330
	[BlackList] // 0x00000001897E5AD0-0x00000001897E5B10
	// [XID] // 0x00000001897E5AD0-0x00000001897E5B10
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001844FC450-0x00000001844FC720
	// [XID] // 0x00000001897F06A0-0x00000001897F06C0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001844FE4A0-0x00000001844FEAA0
	[BlackList] // 0x00000001897F7DA0-0x00000001897F7DE0
	// [XID] // 0x00000001897F7DA0-0x00000001897F7DE0
	public virtual void AutoAllocTypeFields() {} // 0x00000001844FC720-0x00000001844FC7C0
	[BlackList] // 0x0000000189802500-0x0000000189802540
	// [XID] // 0x0000000189802500-0x0000000189802540
	public virtual void AutoRecycleTypeFields() {} // 0x00000001844FC7C0-0x00000001844FC930
	[BlackList] // 0x000000018980C810-0x000000018980C850
	// [XID] // 0x000000018980C810-0x000000018980C850
	public virtual void ReturnToObjectPool() {} // 0x00000001844FF040-0x00000001844FF0E0
	[BlackList] // 0x0000000189817180-0x00000001898171C0
	// [XID] // 0x0000000189817180-0x00000001898171C0
	public virtual void OnPoolAllocated() {} // 0x00000001844FED00-0x00000001844FEDA0
	[BlackList] // 0x0000000189821BD0-0x0000000189821C10
	// [XID] // 0x0000000189821BD0-0x0000000189821C10
	public virtual void OnBeforePoolRecycled() {} // 0x00000001844FEC60-0x00000001844FED00
}

