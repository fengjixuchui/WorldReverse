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
public class SECTR_Sector : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18970
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private SECTR_LayerGroup[] _layerGroups; // 0x10
	private string _sectorName; // 0x18
	private SECTR_SectorType _type; // 0x20
	private SimpleSafeInt32 widthIndexRawNum; // 0x24
	private SimpleSafeInt32 heightIndexRawNum; // 0x28
	private SimpleSafeFloat distanceToChangeRawNum; // 0x2C
	private MoleMole.Config.Vector _centerPos; // 0x30

	// Properties
	public SECTR_LayerGroup[] layerGroups { /* [XID] */ /* 0x00000001897ABCE0-0x00000001897ABD00 */ get => default; /* [XID] */ /* 0x00000001897B3CB0-0x00000001897B3CD0 */ private set {} } // 0x0000000183B92590-0x0000000183B92630 0x0000000183B91AE0-0x0000000183B91B90
	public string sectorName { /* [XID] */ /* 0x00000001897BBA90-0x00000001897BBAB0 */ get => default; /* [XID] */ /* 0x00000001897C3310-0x00000001897C3330 */ private set {} } // 0x0000000183B90890-0x0000000183B90930 0x0000000183B91730-0x0000000183B917E0
	public SECTR_SectorType type { /* [XID] */ /* 0x00000001897CAAD0-0x00000001897CAAF0 */ get => default; /* [XID] */ /* 0x00000001897D20F0-0x00000001897D2110 */ private set {} } // 0x0000000183B92630-0x0000000183B926D0 0x0000000183B91B90-0x0000000183B91C40
	public int widthIndex { /* [XID] */ /* 0x00000001897D9F50-0x00000001897D9F70 */ get => default; /* [XID] */ /* 0x00000001897E1260-0x00000001897E1280 */ private set {} } // 0x0000000183B90FC0-0x0000000183B91090 0x0000000183B926D0-0x0000000183B927B0
	public int heightIndex { /* [XID] */ /* 0x00000001897E8B30-0x00000001897E8B50 */ get => default; /* [XID] */ /* 0x00000001897F0700-0x00000001897F0720 */ private set {} } // 0x0000000183B907C0-0x0000000183B90890 0x0000000183B914F0-0x0000000183B915D0
	public float distanceToChange { /* [XID] */ /* 0x00000001897F7DE0-0x00000001897F7E00 */ get => default; /* [XID] */ /* 0x00000001897FF4B0-0x00000001897FF4D0 */ set {} } // 0x0000000183B90930-0x0000000183B90A10 0x0000000183B91410-0x0000000183B914F0
	public MoleMole.Config.Vector centerPos { /* [XID] */ /* 0x000000018979C870-0x000000018979C890 */ get => default; /* [XID] */ /* 0x000000018980E310-0x000000018980E330 */ set {} } // 0x0000000183B91C40-0x0000000183B91D20 0x0000000183B906F0-0x0000000183B907C0

	// Constructors
	public SECTR_Sector() {} // 0x0000000183B92850-0x0000000183B928B0

	// Methods
	// [XID] // 0x0000000189815A10-0x0000000189815A30
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183B922F0-0x0000000183B92450
	// [XID] // 0x000000018981D410-0x000000018981D430
	public void InitEmpty() {} // 0x0000000183B915D0-0x0000000183B91730
	[BlackList] // 0x0000000189824880-0x00000001898248C0
	// [XID] // 0x0000000189824880-0x00000001898248C0
	public bool FromJson(JSONNode node) => default; // 0x0000000183B91090-0x0000000183B91410
	// [XID] // 0x000000018982EE40-0x000000018982EE60
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183B8FA60-0x0000000183B90240
	// [XID] // 0x0000000189836750-0x0000000189836770
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB5E9 */, bool useObjectPool = false /* Metadata: 0x00AFB5ED */) => default; // 0x0000000183B917E0-0x0000000183B91AE0
	// [XID] // 0x000000018983DB20-0x000000018983DB40
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB5EE */, bool useObjectPool = false /* Metadata: 0x00AFB5F2 */) => default; // 0x0000000183B90A10-0x0000000183B90FC0
	[BlackList] // 0x0000000189845310-0x0000000189845350
	// [XID] // 0x0000000189845310-0x0000000189845350
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183B90240-0x0000000183B90510
	// [XID] // 0x000000018984F720-0x000000018984F740
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183B91D20-0x0000000183B922F0
	[BlackList] // 0x0000000189856920-0x0000000189856960
	// [XID] // 0x0000000189856920-0x0000000189856960
	public virtual void AutoAllocTypeFields() {} // 0x0000000183B90510-0x0000000183B905B0
	[BlackList] // 0x0000000189860D90-0x0000000189860DD0
	// [XID] // 0x0000000189860D90-0x0000000189860DD0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183B905B0-0x0000000183B906F0
	[BlackList] // 0x000000018986B640-0x000000018986B680
	// [XID] // 0x000000018986B640-0x000000018986B680
	public virtual void ReturnToObjectPool() {} // 0x0000000183B927B0-0x0000000183B92850
	[BlackList] // 0x0000000189875A00-0x0000000189875A40
	// [XID] // 0x0000000189875A00-0x0000000189875A40
	public virtual void OnPoolAllocated() {} // 0x0000000183B924F0-0x0000000183B92590
	[BlackList] // 0x0000000189880080-0x00000001898800C0
	// [XID] // 0x0000000189880080-0x00000001898800C0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183B92450-0x0000000183B924F0
}

