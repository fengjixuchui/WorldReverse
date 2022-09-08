/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class ParamVerify // TypeDefIndex: 8632
	{
		// Fields
		private IVerify verify; // 0x10
		private static ParamVerify _instance; // 0x00
	
		// Nested types
		public class RoleInfo // TypeDefIndex: 8633
		{
			// Fields
			public string server_id; // 0x10
			public string role_id; // 0x18
	
			// Constructors
			public RoleInfo() {} // 0x0000000185A8A4D0-0x0000000185A8A530
		}
	
		public class PayInfo // TypeDefIndex: 8634
		{
			// Fields
			public int amount; // 0x10
			public string order_id; // 0x18
			public string product_name; // 0x20
			public string product_id; // 0x28
			public string product_desc; // 0x30
			public string currency; // 0x38
			public string expend; // 0x40
	
			// Constructors
			public PayInfo() {} // 0x0000000185A89440-0x0000000185A894A0
		}
	
		// Constructors
		public ParamVerify() {} // 0x0000000185A893E0-0x0000000185A89440
		static ParamVerify() {} // 0x0000000185A89320-0x0000000185A893E0
	
		// Methods
		// [XID] // 0x0000000189832C80-0x0000000189832CA0
		public static ParamVerify Instance() => default; // 0x0000000185A88BC0-0x0000000185A88C90
		// [XID] // 0x0000000189A36300-0x0000000189A36320
		public void Init() {} // 0x0000000185A88AC0-0x0000000185A88BC0
		// [XID] // 0x0000000189841720-0x0000000189841740
		public void InvokeReturn(string funcName, string args = null, bool debug = false /* Metadata: 0x00AE1805 */) {} // 0x0000000185A88C90-0x0000000185A88E60
		// [XID] // 0x0000000189848B80-0x0000000189848BA0
		public void Invoke(string funcName, string args = null, Action<string> callback = null, bool debug = false /* Metadata: 0x00AE1806 */) {} // 0x0000000185A88E60-0x0000000185A89320
		// [XID] // 0x0000000189A0E4A0-0x0000000189A0E4C0
		private bool CheckNull(string str) => default; // 0x0000000185A889E0-0x0000000185A88AC0
	}
}
