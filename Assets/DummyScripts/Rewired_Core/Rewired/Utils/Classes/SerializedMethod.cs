/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Classes.Data;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Utils.Classes
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001899D6C00-0x00000001899D6C30
	public abstract class SerializedMethod : ScriptableObject // TypeDefIndex: 3762
	{
		// Fields
		private const int boVdwwZoVKHxZrRnNKGatSWthKO = 3; // Metadata: 0x00AC421D
		[NonSerialized]
		private bool YUDatIsYdexhrFOLCBZeHQTCxEC; // 0x18
		[NonSerialized]
		internal List<TypeWrapper> _data; // 0x20
		[NonSerialized]
		internal TypeWrapper _result; // 0x28
		[NonSerialized]
		internal bool _resultIsValid; // 0x48
	
		// Properties
		internal abstract TypeWrapper.DataType ResultType { get; }
		internal int DataCount { get; } // 0x00000001862F6610-0x00000001862F6690 
		internal TypeWrapper Result { get; } // 0x00000001862F66F0-0x00000001862F6760 
		internal bool ResultIsValid { get; } // 0x00000001862F6690-0x00000001862F66F0 
	
		// Constructors
		protected SerializedMethod() {} // 0x00000001862F65B0-0x00000001862F6610
	
		// Methods
		internal TypeWrapper GetData(int index) => default; // 0x00000001862F6400-0x00000001862F64F0
		internal void AddData(byte item) {} // 0x00000001862F56D0-0x00000001862F57F0
		internal void AddData(sbyte item) {} // 0x00000001862F5BB0-0x00000001862F5CF0
		internal void AddData(char item) {} // 0x00000001862F5A70-0x00000001862F5BB0
		internal void AddData(int item) {} // 0x00000001862F57F0-0x00000001862F5930
		internal void AddData(uint item) {} // 0x00000001862F5440-0x00000001862F5580
		internal void AddData(long item) {} // 0x00000001862F5E20-0x00000001862F5F60
		internal void AddData(ulong item) {} // 0x00000001862F52F0-0x00000001862F5440
		internal void AddData(float item) {} // 0x00000001862F5CF0-0x00000001862F5E20
		internal void AddData(double item) {} // 0x00000001862F5580-0x00000001862F56D0
		internal void AddData(bool item) {} // 0x00000001862F5930-0x00000001862F5A70
		internal void AddData(string item) {} // 0x00000001862F6090-0x00000001862F61C0
		internal void AddData(object item) {} // 0x00000001862F5F60-0x00000001862F6090
		internal void AddData(TypeWrapper item) {} // 0x00000001862F5220-0x00000001862F52F0
		internal void ClearData() {} // 0x00000001862F61C0-0x00000001862F6240
		internal void ClearResult() {} // 0x00000001862F6240-0x00000001862F6400
		internal abstract bool Process();
		private void PIdggUKFqWQBhZnCDHiPmKlFcDl() {} // 0x00000001862F64F0-0x00000001862F65B0
	}
}
