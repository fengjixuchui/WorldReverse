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
public class ConfigCombatLock : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17691
{
	// Fields
	private string _lockShape; // 0x10
	private bool _denyLockOn; // 0x18
	private SimpleSafeFloat lockWeightYaxisParamRawNum; // 0x1C
	private SimpleSafeFloat lockWeightYaxisThresholdRawNum; // 0x20
	private string _lockType; // 0x28
	private SimpleSafeFloat overrideRangeRawNum; // 0x30
	private SimpleSafeFloat overrideNormalPriRawNum; // 0x34
	private SimpleSafeFloat overrideCombatPriRawNum; // 0x38

	// Properties
	public string lockShape { /* [XID] */ /* 0x0000000189830940-0x0000000189830960 */ get => default; /* [XID] */ /* 0x0000000189837F80-0x0000000189837FA0 */ private set {} } // 0x0000000183C554B0-0x0000000183C55550 0x0000000183C55550-0x0000000183C55600
	public bool denyLockOn { /* [XID] */ /* 0x000000018983F6B0-0x000000018983F6D0 */ get => default; /* [XID] */ /* 0x0000000189846D10-0x0000000189846D30 */ private set {} } // 0x0000000183C560F0-0x0000000183C56190 0x0000000183C56480-0x0000000183C56530
	public float lockWeightYaxisParam { /* [XID] */ /* 0x0000000189986B60-0x0000000189986B80 */ get => default; /* [XID] */ /* 0x00000001898554D0-0x00000001898554F0 */ private set {} } // 0x0000000183C53660-0x0000000183C53740 0x0000000183C544C0-0x0000000183C545A0
	public float lockWeightYaxisThreshold { /* [XID] */ /* 0x000000018985CA90-0x000000018985CAB0 */ get => default; /* [XID] */ /* 0x00000001898643B0-0x00000001898643D0 */ private set {} } // 0x0000000183C54BB0-0x0000000183C54C90 0x0000000183C54D70-0x0000000183C54E50
	public string lockType { /* [XID] */ /* 0x000000018990F260-0x000000018990F280 */ get => default; /* [XID] */ /* 0x0000000189872BF0-0x0000000189872C10 */ private set {} } // 0x0000000183C54420-0x0000000183C544C0 0x0000000183C55900-0x0000000183C559B0
	public float overrideRange { /* [XID] */ /* 0x000000018987A890-0x000000018987A8B0 */ get => default; /* [XID] */ /* 0x0000000189881A00-0x0000000189881A20 */ private set {} } // 0x0000000183C552B0-0x0000000183C55390 0x0000000183C559B0-0x0000000183C55A90
	public float overrideNormalPri { /* [XID] */ /* 0x0000000189889040-0x0000000189889060 */ get => default; /* [XID] */ /* 0x0000000189890380-0x00000001898903A0 */ private set {} } // 0x0000000183C55A90-0x0000000183C55B70 0x0000000183C54C90-0x0000000183C54D70
	public float overrideCombatPri { /* [XID] */ /* 0x000000018992CFC0-0x000000018992CFE0 */ get => default; /* [XID] */ /* 0x000000018989ED80-0x000000018989EDA0 */ private set {} } // 0x0000000183C545A0-0x0000000183C54680 0x0000000183C551D0-0x0000000183C552B0

	// Constructors
	public ConfigCombatLock() {} // 0x0000000183C565D0-0x0000000183C566D0

	// Methods
	// [XID] // 0x0000000189738080-0x00000001897380A0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183C56190-0x0000000183C56340
	// [XID] // 0x00000001898ADF50-0x00000001898ADF70
	public void InitEmpty() {} // 0x0000000183C55390-0x0000000183C554B0
	[BlackList] // 0x00000001898B5470-0x00000001898B54B0
	// [XID] // 0x00000001898B5470-0x00000001898B54B0
	public bool FromJson(JSONNode node) => default; // 0x0000000183C54E50-0x0000000183C551D0
	// [XID] // 0x00000001898BFD60-0x00000001898BFD80
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183C53740-0x0000000183C53F80
	// [XID] // 0x00000001898C76A0-0x00000001898C76C0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF77E9 */, bool useObjectPool = false /* Metadata: 0x00AF77ED */) => default; // 0x0000000183C55600-0x0000000183C55900
	// [XID] // 0x00000001898CEC70-0x00000001898CEC90
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF77EE */, bool useObjectPool = false /* Metadata: 0x00AF77F2 */) => default; // 0x0000000183C54680-0x0000000183C54BB0
	[BlackList] // 0x00000001898D6640-0x00000001898D6680
	// [XID] // 0x00000001898D6640-0x00000001898D6680
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183C53F80-0x0000000183C54250
	// [XID] // 0x00000001898E12C0-0x00000001898E12E0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183C55B70-0x0000000183C560F0
	[BlackList] // 0x00000001898E8C80-0x00000001898E8CC0
	// [XID] // 0x00000001898E8C80-0x00000001898E8CC0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183C54250-0x0000000183C542F0
	[BlackList] // 0x00000001898F34A0-0x00000001898F34E0
	// [XID] // 0x00000001898F34A0-0x00000001898F34E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183C542F0-0x0000000183C54420
	[BlackList] // 0x00000001898FDD40-0x00000001898FDD80
	// [XID] // 0x00000001898FDD40-0x00000001898FDD80
	public virtual void ReturnToObjectPool() {} // 0x0000000183C56530-0x0000000183C565D0
	[BlackList] // 0x0000000189908730-0x0000000189908770
	// [XID] // 0x0000000189908730-0x0000000189908770
	public virtual void OnPoolAllocated() {} // 0x0000000183C563E0-0x0000000183C56480
	[BlackList] // 0x0000000189913120-0x0000000189913160
	// [XID] // 0x0000000189913120-0x0000000189913160
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183C56340-0x0000000183C563E0
}

