/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace XLua
{
	public class SignatureLoader // TypeDefIndex: 32440
	{
		// Fields
		private LuaEnv.CustomLoader userLoader; // 0x10
		private RSACryptoServiceProvider rsa; // 0x18
		private SHA1 sha; // 0x20
	
		// Constructors
		public SignatureLoader() {} // Dummy constructor
		public SignatureLoader(string publicKey, LuaEnv.CustomLoader loader) {} // 0x00000001866B56D0-0x00000001866B57D0
	
		// Methods
		private byte[] load_and_verify(ref string filepath, out bool recycleBytes) {
			recycleBytes = default;
			return default;
		} // 0x00000001866B57D0-0x00000001866B5A20
		public static implicit operator LuaEnv.CustomLoader(SignatureLoader signatureLoader) => default; // 0x00000001866B5A20-0x00000001866B5AC0
	}
}
