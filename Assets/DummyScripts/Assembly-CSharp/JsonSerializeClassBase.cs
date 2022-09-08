/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class JsonSerializeClassBase // TypeDefIndex: 27860
{
	// Constructors
	protected JsonSerializeClassBase() {} // 0x0000000182B69E10-0x0000000182B69E70

	// Methods
	public static ST FromJson<ST>(string inJsonStr)
		where ST : JsonSerializeClassBase => default;
	// [XID] // 0x00000001898D5E90-0x00000001898D5EB0
	public string ToJson() => default; // 0x0000000182B69D60-0x0000000182B69E10
	public abstract void FillDataList(List<object> inData);
	public abstract void PostLoad();
}

