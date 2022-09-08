/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class BlockDataPage // TypeDefIndex: 19515
{
	// Fields
	protected ulong _path; // 0x10
	protected Status _status; // 0x18

	// Nested types
	protected enum Status // TypeDefIndex: 19516
	{
		Released = 0,
		Loading = 1,
		Loaded = 2
	}

	// Constructors
	protected BlockDataPage() {} // 0x0000000183CD7710-0x0000000183CD7770

	// Methods
	// [XID] // 0x000000018990CBF0-0x000000018990CC10
	public void Init(ulong path) {} // 0x0000000183CD7310-0x0000000183CD73C0
	// [XID] // 0x0000000189914300-0x0000000189914320
	public void Preload() {} // 0x0000000183CD7170-0x0000000183CD7310
	// [XID] // 0x000000018991BE00-0x000000018991BE20
	public void PreloadAsync(Action onLoadFinish, ref ConfigLoadAndSerializePattern pattern) {} // 0x0000000183CD73C0-0x0000000183CD7640
	protected abstract object SerializeBin(ByteArray byteArr, int threadFlag = 0 /* Metadata: 0x00AFCA71 */);
	protected abstract object SerializeJson(JSONNode node);
	// [XID] // 0x00000001899234C0-0x00000001899234E0
	protected virtual void OnSerialized(object obj, ulong path) {} // 0x0000000183CD7640-0x0000000183CD7710
}

