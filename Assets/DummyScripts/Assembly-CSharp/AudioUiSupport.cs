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
public class AudioUiSupport : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17631
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _comboRtpcKey; // 0x10
	private SimpleSafeFloat countdownRawNum; // 0x18

	// Properties
	public ConfigWwiseString comboRtpcKey { /* [XID] */ /* 0x0000000189734390-0x00000001897343B0 */ get => default; /* [XID] */ /* 0x000000018973BC60-0x000000018973BC80 */ private set {} } // 0x0000000184735ED0-0x0000000184735F70 0x0000000184736070-0x0000000184736120
	public float countdown { /* [XID] */ /* 0x0000000189743530-0x0000000189743550 */ get => default; /* [XID] */ /* 0x000000018974B1C0-0x000000018974B1E0 */ private set {} } // 0x0000000184735A70-0x0000000184735B50 0x00000001847356A0-0x0000000184735780

	// Constructors
	public AudioUiSupport() {} // 0x0000000184736990-0x00000001847369F0

	// Methods
	// [XID] // 0x0000000189752210-0x0000000189752230
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184736690-0x00000001847367B0
	// [XID] // 0x0000000189759840-0x0000000189759860
	public void InitEmpty() {} // 0x0000000184735F70-0x0000000184736070
	[BlackList] // 0x00000001897613F0-0x0000000189761430
	// [XID] // 0x00000001897613F0-0x0000000189761430
	public bool FromJson(JSONNode node) => default; // 0x0000000184735B50-0x0000000184735ED0
	// [XID] // 0x000000018976B920-0x000000018976B940
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184734EA0-0x00000001847351D0
	// [XID] // 0x0000000189772DE0-0x0000000189772E00
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF756D */, bool useObjectPool = false /* Metadata: 0x00AF7571 */) => default; // 0x0000000184736120-0x0000000184736420
	// [XID] // 0x000000018977A520-0x000000018977A540
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7572 */, bool useObjectPool = false /* Metadata: 0x00AF7576 */) => default; // 0x0000000184735780-0x0000000184735A70
	[BlackList] // 0x00000001897820C0-0x0000000189782100
	// [XID] // 0x00000001897820C0-0x0000000189782100
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001847351D0-0x00000001847354A0
	// [XID] // 0x000000018978C4D0-0x000000018978C4F0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184736420-0x0000000184736690
	[BlackList] // 0x00000001897939C0-0x0000000189793A00
	// [XID] // 0x00000001897939C0-0x0000000189793A00
	public virtual void AutoAllocTypeFields() {} // 0x00000001847354A0-0x0000000184735540
	[BlackList] // 0x000000018979ECF0-0x000000018979ED30
	// [XID] // 0x000000018979ECF0-0x000000018979ED30
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184735540-0x00000001847356A0
	[BlackList] // 0x00000001897A9100-0x00000001897A9140
	// [XID] // 0x00000001897A9100-0x00000001897A9140
	public virtual void ReturnToObjectPool() {} // 0x00000001847368F0-0x0000000184736990
	[BlackList] // 0x00000001897B3F30-0x00000001897B3F70
	// [XID] // 0x00000001897B3F30-0x00000001897B3F70
	public virtual void OnPoolAllocated() {} // 0x0000000184736850-0x00000001847368F0
	[BlackList] // 0x00000001897BF010-0x00000001897BF050
	// [XID] // 0x00000001897BF010-0x00000001897BF050
	public virtual void OnBeforePoolRecycled() {} // 0x00000001847367B0-0x0000000184736850
}

