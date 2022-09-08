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
public class DirectionTarDistanceScatter : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17829
{
	// Fields
	private SimpleSafeFloat maxDistanceRawNum; // 0x10
	private SimpleSafeFloat maxScatterAngleRawNum; // 0x14
	private SimpleSafeFloat centerRoteRawNum; // 0x18
	private SimpleSafeFloat randomRoteRawNum; // 0x1C

	// Properties
	public float maxDistance { /* [XID] */ /* 0x0000000189708330-0x0000000189708350 */ get => default; /* [XID] */ /* 0x0000000189845550-0x0000000189845570 */ private set {} } // 0x0000000185469150-0x0000000185469230 0x0000000185467EB0-0x0000000185467F90
	public float maxScatterAngle { /* [XID] */ /* 0x0000000189AB3BA0-0x0000000189AB3BC0 */ get => default; /* [XID] */ /* 0x0000000189853AE0-0x0000000189853B00 */ private set {} } // 0x0000000185468310-0x00000001854683F0 0x0000000185467A30-0x0000000185467B10
	public float centerRote { /* [XID] */ /* 0x000000018972D5F0-0x000000018972D610 */ get => default; /* [XID] */ /* 0x0000000189862B50-0x0000000189862B70 */ private set {} } // 0x00000001854683F0-0x00000001854684D0 0x00000001854689B0-0x0000000185468A90
	public float randomRote { /* [XID] */ /* 0x00000001898C8000-0x00000001898C8020 */ get => default; /* [XID] */ /* 0x0000000189871350-0x0000000189871370 */ private set {} } // 0x0000000185468A90-0x0000000185468B70 0x00000001854684D0-0x00000001854685B0

	// Constructors
	public DirectionTarDistanceScatter() {} // 0x00000001854692D0-0x0000000185469370

	// Methods
	// [XID] // 0x0000000189878D10-0x0000000189878D30
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185468ED0-0x0000000185469010
	// [XID] // 0x0000000189880360-0x0000000189880380
	public void InitEmpty() {} // 0x00000001854685B0-0x00000001854686B0
	[BlackList] // 0x00000001898877E0-0x0000000189887820
	// [XID] // 0x00000001898877E0-0x0000000189887820
	public bool FromJson(JSONNode node) => default; // 0x0000000185467F90-0x0000000185468310
	// [XID] // 0x0000000189891A20-0x0000000189891A40
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000185467060-0x00000001854675C0
	// [XID] // 0x0000000189899370-0x0000000189899390
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7E4F */, bool useObjectPool = false /* Metadata: 0x00AF7E53 */) => default; // 0x00000001854686B0-0x00000001854689B0
	// [XID] // 0x00000001898A05D0-0x00000001898A05F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7E54 */, bool useObjectPool = false /* Metadata: 0x00AF7E58 */) => default; // 0x0000000185467B10-0x0000000185467EB0
	[BlackList] // 0x00000001898A7C70-0x00000001898A7CB0
	// [XID] // 0x00000001898A7C70-0x00000001898A7CB0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001854675C0-0x0000000185467890
	// [XID] // 0x00000001898B2450-0x00000001898B2470
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185468B70-0x0000000185468ED0
	[BlackList] // 0x00000001898BA1A0-0x00000001898BA1E0
	// [XID] // 0x00000001898BA1A0-0x00000001898BA1E0
	public virtual void AutoAllocTypeFields() {} // 0x0000000185467890-0x0000000185467930
	[BlackList] // 0x00000001898C4620-0x00000001898C4660
	// [XID] // 0x00000001898C4620-0x00000001898C4660
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185467930-0x0000000185467A30
	[BlackList] // 0x00000001898CEBF0-0x00000001898CEC30
	// [XID] // 0x00000001898CEBF0-0x00000001898CEC30
	public virtual void ReturnToObjectPool() {} // 0x0000000185469230-0x00000001854692D0
	[BlackList] // 0x00000001898D9570-0x00000001898D95B0
	// [XID] // 0x00000001898D9570-0x00000001898D95B0
	public virtual void OnPoolAllocated() {} // 0x00000001854690B0-0x0000000185469150
	[BlackList] // 0x00000001898E4180-0x00000001898E41C0
	// [XID] // 0x00000001898E4180-0x00000001898E41C0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185469010-0x00000001854690B0
}

