/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct EncryptedString : IEquatable<EncryptedString> // TypeDefIndex: 14605
{
	// Fields
	private SimpleSafeInt32 _safeKey; // 0x00
	private string _orgStr; // 0x08
	private static int _toAbilityStringCallCnt; // 0x00
	private static int _convertFromStrCallCnt; // 0x04
	private static int _convertToStrCallCnt; // 0x08
	private static int _toAbilityStringCallCntLastFrame; // 0x0C
	private static int _convertFromStrCallCntLastFrame; // 0x10
	private static int _convertToStrCallCntLastFrame; // 0x14

	// Constructors
	public EncryptedString(string strIn) {
		_safeKey = default;
		_orgStr = default;
	} // 0x00000001822C6B70-0x00000001822C6C70
	public EncryptedString(int hash) {
		_safeKey = default;
		_orgStr = default;
	} // 0x00000001822C6C70-0x00000001822C6C80
	static EncryptedString() {
		_toAbilityStringCallCnt = default;
		_convertFromStrCallCnt = default;
		_convertToStrCallCnt = default;
		_toAbilityStringCallCntLastFrame = default;
		_convertFromStrCallCntLastFrame = default;
		_convertToStrCallCntLastFrame = default;
	} // 0x00000001822C6A10-0x00000001822C6B70

	// Methods
	// [XID] // 0x0000000189848820-0x0000000189848840
	public static void doBenchmark() {} // 0x00000001822C6780-0x00000001822C6A00
	// [IDTag] // 0x00000001898500A0-0x00000001898500E0
	// [XID] // 0x00000001898500A0-0x00000001898500E0
	public static implicit operator string(EncryptedString es) => default; // 0x00000001822C6100-0x00000001822C6270
	// [IDTag] // 0x000000018985A640-0x000000018985A680
	// [XID] // 0x000000018985A640-0x000000018985A680
	public static implicit operator EncryptedString(string str) => default; // 0x00000001822C5F10-0x00000001822C6020
	// [IDTag] // 0x0000000189864950-0x0000000189864990
	// [XID] // 0x0000000189864950-0x0000000189864990
	public static implicit operator EncryptedString(int hash) => default; // 0x00000001822C6020-0x00000001822C6100
	// [XID] // 0x000000018986EE20-0x000000018986EE40
	public static explicit operator uint(EncryptedString es) => default; // 0x00000001822C6280-0x00000001822C6410
	// [XID] // 0x0000000189876350-0x0000000189876370
	public override string ToString() => default; // 0x00000001822C6A00-0x00000001822C6A10
	// [XID] // 0x000000018987DF10-0x000000018987DF30
	public override int GetHashCode() => default; // 0x00000001822C66C0-0x00000001822C6770
	// [IDTag] // 0x0000000189884F80-0x0000000189884FC0
	// [XID] // 0x0000000189884F80-0x0000000189884FC0
	public override bool Equals(object obj) => default; // 0x00000001822C6600-0x00000001822C66C0
	// [IDTag] // 0x000000018988F440-0x000000018988F480
	// [XID] // 0x000000018988F440-0x000000018988F480
	public bool Equals(EncryptedString es) => default; // 0x00000001822C64E0-0x00000001822C6600
}

