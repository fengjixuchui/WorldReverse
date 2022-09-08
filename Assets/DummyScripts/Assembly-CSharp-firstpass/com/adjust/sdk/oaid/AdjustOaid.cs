/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace com.adjust.sdk.oaid
{
	public class AdjustOaid : MonoBehaviour // TypeDefIndex: 6737
	{
		// Fields
		private const string errorMsgEditor = "[AdjustOaid]: Adjust OAID plugin can not be used in Editor."; // Metadata: 0x00ADDD41
		private const string errorMsgPlatform = "[AdjustOaid]: Adjust OAID plugin can only be used in Android apps."; // Metadata: 0x00ADDD80
		public bool startManually; // 0x18
		public bool readOaid; // 0x19
	
		// Constructors
		public AdjustOaid() {} // 0x000000018775EAF0-0x000000018775EBE0
	
		// Methods
		// [XID] // 0x0000000189A2C960-0x0000000189A2C980
		private void Awake() {} // 0x000000018775E790-0x000000018775E8B0
		// [XID] // 0x0000000189B18AD0-0x0000000189B18AF0
		public static void ReadOaid() {} // 0x000000018775EA20-0x000000018775EAF0
		// [XID] // 0x000000018960C400-0x000000018960C420
		public static void DoNotReadOaid() {} // 0x000000018775E8B0-0x000000018775E980
		// [XID] // 0x000000018995E330-0x000000018995E350
		private static bool IsEditor() => default; // 0x000000018775E980-0x000000018775EA20
	}
}
