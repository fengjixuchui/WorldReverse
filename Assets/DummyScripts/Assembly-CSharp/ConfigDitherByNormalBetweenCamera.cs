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
public class ConfigDitherByNormalBetweenCamera : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17955
{
	// Fields
	private SimpleSafeFloat detectDitherRangeRawNum; // 0x10

	// Properties
	public float detectDitherRange { /* [XID] */ /* 0x0000000189846C70-0x0000000189846C90 */ get => default; /* [XID] */ /* 0x000000018984E2E0-0x000000018984E300 */ private set {} } // 0x00000001823890A0-0x0000000182389180 0x0000000182389180-0x0000000182389260

	// Constructors
	public ConfigDitherByNormalBetweenCamera() {} // 0x00000001823896E0-0x0000000182389780

	// Methods
	// [XID] // 0x0000000189855430-0x0000000189855450
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182389410-0x0000000182389500
	// [XID] // 0x000000018985CA70-0x000000018985CA90
	public void InitEmpty() {} // 0x0000000182388CD0-0x0000000182388DA0
	[BlackList] // 0x0000000189864330-0x0000000189864370
	// [XID] // 0x0000000189864330-0x0000000189864370
	public bool FromJson(JSONNode node) => default; // 0x0000000182388950-0x0000000182388CD0
	// [XID] // 0x000000018986E7B0-0x000000018986E7D0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182388130-0x0000000182388340
	// [XID] // 0x0000000189875BC0-0x0000000189875BE0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF84B5 */, bool useObjectPool = false /* Metadata: 0x00AF84B9 */) => default; // 0x0000000182388DA0-0x00000001823890A0
	// [XID] // 0x000000018987D800-0x000000018987D820
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF84BA */, bool useObjectPool = false /* Metadata: 0x00AF84BE */) => default; // 0x0000000182388780-0x0000000182388950
	[BlackList] // 0x00000001898846F0-0x0000000189884730
	// [XID] // 0x00000001898846F0-0x0000000189884730
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182388340-0x0000000182388610
	// [XID] // 0x000000018988EB80-0x000000018988EBA0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182389260-0x0000000182389410
	[BlackList] // 0x0000000189896000-0x0000000189896040
	// [XID] // 0x0000000189896000-0x0000000189896040
	public virtual void AutoAllocTypeFields() {} // 0x0000000182388610-0x00000001823886B0
	[BlackList] // 0x00000001898A0510-0x00000001898A0550
	// [XID] // 0x00000001898A0510-0x00000001898A0550
	public virtual void AutoRecycleTypeFields() {} // 0x00000001823886B0-0x0000000182388780
	[BlackList] // 0x00000001898AAA20-0x00000001898AAA60
	// [XID] // 0x00000001898AAA20-0x00000001898AAA60
	public virtual void ReturnToObjectPool() {} // 0x0000000182389640-0x00000001823896E0
	[BlackList] // 0x00000001898B5390-0x00000001898B53D0
	// [XID] // 0x00000001898B5390-0x00000001898B53D0
	public virtual void OnPoolAllocated() {} // 0x00000001823895A0-0x0000000182389640
	[BlackList] // 0x00000001898BFCA0-0x00000001898BFCE0
	// [XID] // 0x00000001898BFCA0-0x00000001898BFCE0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182389500-0x00000001823895A0
}

