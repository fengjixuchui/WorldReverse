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
public class ConfigCrowdGroupColliderInfo : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17774
{
	// Fields
	private MoleMole.Config.Vector _spawnPosition; // 0x10
	private MoleMole.Config.Vector _spawnFaceFwd; // 0x1C
	private SimpleSafeFloat heightRawNum; // 0x28
	private SimpleSafeFloat radiusRawNum; // 0x2C

	// Properties
	public MoleMole.Config.Vector spawnPosition { /* [XID] */ /* 0x0000000189680C20-0x0000000189680C40 */ get => default; /* [XID] */ /* 0x0000000189688680-0x00000001896886A0 */ private set {} } // 0x00000001833A5030-0x00000001833A5110 0x00000001833A55D0-0x00000001833A56A0
	public MoleMole.Config.Vector spawnFaceFwd { /* [XID] */ /* 0x000000018968FFA0-0x000000018968FFC0 */ get => default; /* [XID] */ /* 0x0000000189697900-0x0000000189697920 */ private set {} } // 0x00000001833A5410-0x00000001833A54F0 0x00000001833A5B60-0x00000001833A5C30
	public float height { /* [XID] */ /* 0x000000018969ED90-0x000000018969EDB0 */ get => default; /* [XID] */ /* 0x00000001896A60B0-0x00000001896A60D0 */ private set {} } // 0x00000001833A5C30-0x00000001833A5D10 0x00000001833A54F0-0x00000001833A55D0
	public float radius { /* [XID] */ /* 0x00000001896AD570-0x00000001896AD590 */ get => default; /* [XID] */ /* 0x00000001896B4C70-0x00000001896B4C90 */ private set {} } // 0x00000001833A56A0-0x00000001833A5780 0x00000001833A5FE0-0x00000001833A60C0

	// Constructors
	public ConfigCrowdGroupColliderInfo() {} // 0x00000001833A6160-0x00000001833A61C0

	// Methods
	// [XID] // 0x00000001896BC040-0x00000001896BC060
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001833A5D10-0x00000001833A5EA0
	// [XID] // 0x00000001896C3520-0x00000001896C3540
	public void InitEmpty() {} // 0x00000001833A4F00-0x00000001833A5030
	[BlackList] // 0x00000001896CAAB0-0x00000001896CAAF0
	// [XID] // 0x00000001896CAAB0-0x00000001896CAAF0
	public bool FromJson(JSONNode node) => default; // 0x00000001833A4B80-0x00000001833A4F00
	// [XID] // 0x00000001896D5240-0x00000001896D5260
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001833A3E10-0x00000001833A4320
	// [XID] // 0x00000001896DC780-0x00000001896DC7A0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7BB9 */, bool useObjectPool = false /* Metadata: 0x00AF7BBD */) => default; // 0x00000001833A5110-0x00000001833A5410
	// [XID] // 0x00000001896E4070-0x00000001896E4090
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7BBE */, bool useObjectPool = false /* Metadata: 0x00AF7BC2 */) => default; // 0x00000001833A47A0-0x00000001833A4B80
	[BlackList] // 0x00000001896EB560-0x00000001896EB5A0
	// [XID] // 0x00000001896EB560-0x00000001896EB5A0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001833A4320-0x00000001833A45F0
	// [XID] // 0x00000001896F5BE0-0x00000001896F5C00
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001833A5780-0x00000001833A5B60
	[BlackList] // 0x00000001896FD3D0-0x00000001896FD410
	// [XID] // 0x00000001896FD3D0-0x00000001896FD410
	public virtual void AutoAllocTypeFields() {} // 0x00000001833A45F0-0x00000001833A4690
	[BlackList] // 0x0000000189707830-0x0000000189707870
	// [XID] // 0x0000000189707830-0x0000000189707870
	public virtual void AutoRecycleTypeFields() {} // 0x00000001833A4690-0x00000001833A47A0
	[BlackList] // 0x0000000189712310-0x0000000189712350
	// [XID] // 0x0000000189712310-0x0000000189712350
	public virtual void ReturnToObjectPool() {} // 0x00000001833A60C0-0x00000001833A6160
	[BlackList] // 0x000000018971C740-0x000000018971C780
	// [XID] // 0x000000018971C740-0x000000018971C780
	public virtual void OnPoolAllocated() {} // 0x00000001833A5F40-0x00000001833A5FE0
	[BlackList] // 0x0000000189726DE0-0x0000000189726E20
	// [XID] // 0x0000000189726DE0-0x0000000189726E20
	public virtual void OnBeforePoolRecycled() {} // 0x00000001833A5EA0-0x00000001833A5F40
}

