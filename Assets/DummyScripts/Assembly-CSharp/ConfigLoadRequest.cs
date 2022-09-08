/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class ConfigLoadRequest : ISimplePoolObject, AsyncJobProxy // TypeDefIndex: 26579
{
	// Fields
	private static SimpleObjectPool<ConfigLoadRequest> _pool; // 0x00
	private LoadState _state; // 0x10
	public HashList<Action> callbacks; // 0x18
	private object _obj; // 0x20

	// Properties
	public LoadState state { /* [XID] */ /* 0x0000000189930820-0x0000000189930840 */ get => default; } // 0x00000001836DBC50-0x00000001836DBCF0 
	public object obj { /* [XID] */ /* 0x0000000189937D00-0x0000000189937D20 */ get => default; } // 0x00000001836DBEC0-0x00000001836DBF60 

	// Nested types
	public enum LoadState // TypeDefIndex: 26580
	{
		NONE = 0,
		LOADING = 1,
		LOADED = 2,
		FAILED = 3
	}

	// Constructors
	public ConfigLoadRequest() {} // 0x00000001836DC0A0-0x00000001836DC110
	static ConfigLoadRequest() {} // 0x00000001836DC030-0x00000001836DC0A0

	// Methods
	// [XID] // 0x0000000189851A80-0x0000000189851AA0
	public static ConfigLoadRequest Get() => default; // 0x00000001836DBCF0-0x00000001836DBDD0
	// [XID] // 0x0000000189929220-0x0000000189929240
	public static void Release(ConfigLoadRequest request) {} // 0x00000001836DBDD0-0x00000001836DBEC0
	// [XID] // 0x000000018993F7B0-0x000000018993F7D0
	public bool CheckVoucher(object voucher) => default; // 0x00000001836DB940-0x00000001836DBA30
	// [XID] // 0x0000000189946E00-0x0000000189946E20
	public void UpdateLoadState(LoadState st, object obj = null) {} // 0x00000001836DBB00-0x00000001836DBC50
	// [XID] // 0x000000018994E410-0x000000018994E430
	public void ResetObject() {} // 0x00000001836DBF60-0x00000001836DC030
	// [XID] // 0x0000000189955AC0-0x0000000189955AE0
	public void Dismiss(object voucher) {} // 0x00000001836DBA30-0x00000001836DBB00
}

