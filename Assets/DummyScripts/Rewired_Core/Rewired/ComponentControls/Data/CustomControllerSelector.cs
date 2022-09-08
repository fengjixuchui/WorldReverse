/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Attributes;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001899D6C00-0x00000001899D6C30
	public sealed class CustomControllerSelector // TypeDefIndex: 3542
	{
		// Fields
		[CustomObfuscation] // 0x0000000189A53AF0-0x0000000189A53B50
		[SerializeField] // 0x0000000189A53AF0-0x0000000189A53B50
		// [Tooltip] // 0x0000000189A53AF0-0x0000000189A53B50
		private bool _findUsingSourceId; // 0x10
		[CustomObfuscation] // 0x0000000189A62A60-0x0000000189A62AE0
		// [FieldRange] // 0x0000000189A62A60-0x0000000189A62AE0
		[SerializeField] // 0x0000000189A62A60-0x0000000189A62AE0
		// [Tooltip] // 0x0000000189A62A60-0x0000000189A62AE0
		private int _sourceId; // 0x14
		[CustomObfuscation] // 0x0000000189A74B80-0x0000000189A74BE0
		[SerializeField] // 0x0000000189A74B80-0x0000000189A74BE0
		// [Tooltip] // 0x0000000189A74B80-0x0000000189A74BE0
		private bool _findUsingTag; // 0x18
		[CustomObfuscation] // 0x0000000189A84060-0x0000000189A840C0
		[SerializeField] // 0x0000000189A84060-0x0000000189A840C0
		// [Tooltip] // 0x0000000189A84060-0x0000000189A840C0
		private string _tag; // 0x20
		[CustomObfuscation] // 0x0000000189A92F50-0x0000000189A92FB0
		[SerializeField] // 0x0000000189A92F50-0x0000000189A92FB0
		// [Tooltip] // 0x0000000189A92F50-0x0000000189A92FB0
		private bool _findInPlayer; // 0x28
		[CustomObfuscation] // 0x0000000189AA1AE0-0x0000000189AA1B40
		[SerializeField] // 0x0000000189AA1AE0-0x0000000189AA1B40
		// [Tooltip] // 0x0000000189AA1AE0-0x0000000189AA1B40
		private int _playerId; // 0x2C
	
		// Properties
		public bool findUsingSourceId { get => default; } // 0x0000000185AA2820-0x0000000185AA2880 
		public int sourceId { get => default; } // 0x0000000185AA2940-0x0000000185AA29A0 
		public bool findUsingTag { get => default; } // 0x0000000185AA2880-0x0000000185AA28E0 
		public string tag { get => default; } // 0x0000000185AA29A0-0x0000000185AA2A00 
		public bool findInPlayer { get => default; } // 0x0000000185AA27C0-0x0000000185AA2820 
		public int playerId { get => default; } // 0x0000000185AA28E0-0x0000000185AA2940 
	
		// Constructors
		public CustomControllerSelector() {} // 0x0000000185AA2750-0x0000000185AA27C0
	
		// Methods
		internal CustomController GetCustomController() => default; // 0x0000000185AA22A0-0x0000000185AA2750
	}
}
