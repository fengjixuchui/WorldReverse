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
public class ConfigAudioIncrementalResources : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17618
{
	// Fields
	private string[] _sfxFiles; // 0x10
	private string[] _musicFiles; // 0x18
	private string[] _voFiles; // 0x20

	// Properties
	public string[] sfxFiles { /* [XID] */ /* 0x00000001899FCE10-0x00000001899FCE30 */ get => default; /* [XID] */ /* 0x0000000189A04290-0x0000000189A042B0 */ private set {} } // 0x000000018205C280-0x000000018205C320 0x000000018205C6A0-0x000000018205C750
	public string[] musicFiles { /* [XID] */ /* 0x0000000189A0B9F0-0x0000000189A0BA10 */ get => default; /* [XID] */ /* 0x0000000189A13280-0x0000000189A132A0 */ private set {} } // 0x000000018205CBF0-0x000000018205CC90 0x000000018205BDC0-0x000000018205BE70
	public string[] voFiles { /* [XID] */ /* 0x0000000189A1A4D0-0x0000000189A1A4F0 */ get => default; /* [XID] */ /* 0x0000000189A21BF0-0x0000000189A21C10 */ private set {} } // 0x000000018205C750-0x000000018205C7F0 0x000000018205C1D0-0x000000018205C280

	// Constructors
	public ConfigAudioIncrementalResources() {} // 0x000000018205D2F0-0x000000018205D350

	// Methods
	// [XID] // 0x0000000189A29180-0x0000000189A291A0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018205CFF0-0x000000018205D110
	// [XID] // 0x0000000189A30770-0x0000000189A30790
	public void InitEmpty() {} // 0x000000018205C7F0-0x000000018205C8F0
	[BlackList] // 0x0000000189A380F0-0x0000000189A38130
	// [XID] // 0x0000000189A380F0-0x0000000189A38130
	public bool FromJson(JSONNode node) => default; // 0x000000018205C320-0x000000018205C6A0
	// [XID] // 0x0000000189A427B0-0x0000000189A427D0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018205B5F0-0x000000018205B9A0
	// [XID] // 0x0000000189A49CC0-0x0000000189A49CE0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF74ED */, bool useObjectPool = false /* Metadata: 0x00AF74F1 */) => default; // 0x000000018205C8F0-0x000000018205CBF0
	// [XID] // 0x0000000189A51710-0x0000000189A51730
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF74F2 */, bool useObjectPool = false /* Metadata: 0x00AF74F6 */) => default; // 0x000000018205BE70-0x000000018205C1D0
	[BlackList] // 0x0000000189A58DE0-0x0000000189A58E20
	// [XID] // 0x0000000189A58DE0-0x0000000189A58E20
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018205B9A0-0x000000018205BC70
	// [XID] // 0x0000000189A63950-0x0000000189A63970
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018205CC90-0x000000018205CFF0
	[BlackList] // 0x0000000189A6B1D0-0x0000000189A6B210
	// [XID] // 0x0000000189A6B1D0-0x0000000189A6B210
	public virtual void AutoAllocTypeFields() {} // 0x000000018205BC70-0x000000018205BD10
	[BlackList] // 0x0000000189A75630-0x0000000189A75670
	// [XID] // 0x0000000189A75630-0x0000000189A75670
	public virtual void AutoRecycleTypeFields() {} // 0x000000018205BD10-0x000000018205BDC0
	[BlackList] // 0x0000000189A7FF40-0x0000000189A7FF80
	// [XID] // 0x0000000189A7FF40-0x0000000189A7FF80
	public virtual void ReturnToObjectPool() {} // 0x000000018205D250-0x000000018205D2F0
	[BlackList] // 0x0000000189A8AC80-0x0000000189A8ACC0
	// [XID] // 0x0000000189A8AC80-0x0000000189A8ACC0
	public virtual void OnPoolAllocated() {} // 0x000000018205D1B0-0x000000018205D250
	[BlackList] // 0x0000000189A95250-0x0000000189A95290
	// [XID] // 0x0000000189A95250-0x0000000189A95290
	public virtual void OnBeforePoolRecycled() {} // 0x000000018205D110-0x000000018205D1B0
}

